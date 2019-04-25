using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Ionic.Zip;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EmbryoExpress.UI
{
    public partial class ProblemReportForm : EmbryoExpress.UI.ChildForm
    {
        private HashSet<String> _tag;

        private Image _screenShot;

        private String _feedback;

        private String _directory;

        private String _screenShotPath;

        private String _contentPath;

        private string _cytometerInfoPath;

        private string _systemInfo;

        private string _installedProgramsX64;

        private string _installedProgramsX32;

        private string _eventsRecordPath;

        private string _dataFlashPath;

        private List<ZFile> _zipfiles;

        private string _zipFullname;

        private bool _canZip;

        private bool _cancel;

        private BackgroundWorker _loadFileTask;

        private double _requireSpace;

        private int _readBytes = 0;
        private int _currentBytes = 0;

        private Process _process;

        public ProblemReportForm()
        {
            _process = new Process();

            _directory = Path.Combine(Program.SysConfig.LoginUser.DefaultDataFolder + @"\Technical Support Request");
            CheckSupportDirectory();

            _systemInfo = _directory + @"\Systeminfo.txt";
            //GetSysytemInfoFile();//在FormLoad事件中调用

            _screenShot = ScreenCapture.CaptureDesktop();

            InitializeComponent();

            _tag = new HashSet<string>();

            _contentPath = _directory + @"\Problem Description.txt";
            _screenShotPath = _directory + @"\Current Screenshot.png";

            _installedProgramsX64 = _directory + @"\InstalledPrograms-x64.csv";
            _installedProgramsX32 = _directory + @"\InstalledPrograms-x32.csv";

            _cytometerInfoPath = _directory + @"\Cytometer Info.txt";
            _eventsRecordPath = _directory + @"\Events Record.csv";

            initView();

            _cancel = false;

            _loadFileTask = new BackgroundWorker();
            _loadFileTask.WorkerReportsProgress = true;
            _loadFileTask.WorkerSupportsCancellation = true;
            _loadFileTask.DoWork += LoadFileTask_DoWork;
            _loadFileTask.ProgressChanged += LoadFileTask_ProgressChanged;
            _loadFileTask.RunWorkerCompleted += LoadFileTask_RunWorkerCompleted;

            wizard.HeaderImageSize = new Size(48, 48);  // fix image size to 48 for different dpi
            wizard.ButtonHeight = (int)Math.Round(22 * Program.DpiFactor);  // change button height according to dpi setting
            if (BaseFunction.ChineseEdition)
            {
                label2.Text = Properties.Resources.ProblemReportLabelCyte2ChineseEdition;
            }
        }

        private void CheckSupportDirectory()
        {
            if (!Directory.Exists(this._directory))
                Directory.CreateDirectory(this._directory);
        }

        public void StartGetFilesTask()
        {
            if (!_loadFileTask.IsBusy)
            {
                _cancel = false;
                labelCreating.Text = Properties.Resources.StrCollecting;
            }
        }

        private void GetFiles()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => GetFiles()));
            }
            else
            {
                _cancel = false;
                FileInfo[] fileInfos;

                WriteToFile();
                _zipfiles.Add(new ZFile(_contentPath, null, GetFileLength(_contentPath)));
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string[] extension = new string[] { "SystemLog", "FConfig", "FCPlates", "SensorData", "log-file", "log-file.1" };
                fileInfos = GetFileInfo(baseDirectory, "", extension, true);
                if (fileInfos != null)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        _zipfiles.Add(new ZFile(fileInfo.FullName, null, fileInfo.Length));
                    }
                }

                fileInfos = GetFileInfo(baseDirectory, @"\Calibration Results");
                // Calibration Results
                if (fileInfos != null)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        if (fileInfo != null)
                        {
                            _zipfiles.Add(new ZFile(fileInfo.FullName, "Calibration Results", fileInfo.Length));
                        }
                    }
                }

                extension = new string[] { "PerformanceReport" };
                fileInfos = GetFileInfo(baseDirectory, @"\QC\", extension, true);
                if (fileInfos != null)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        _zipfiles.Add(new ZFile(fileInfo.FullName, "QC", fileInfo.Length));
                    }
                }


                extension = new string[] { ".txt" };
                fileInfos = GetFileInfo(baseDirectory, @"\Dumps\", extension, false);
                if (fileInfos != null)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        _zipfiles.Add(new ZFile(fileInfo.FullName, "Dumps", fileInfo.Length));
                    }
                }

                foreach (ListViewItem item in this.listViewFiles.Items)
                {
                    string fileFullName = item.Tag as string;
                    if (fileFullName != null)
                    {
                        _zipfiles.Add(new ZFile(fileFullName, null, GetFileLength(fileFullName)));
                    }
                }
            }
        }

        private void LoadFileTask_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                GetFiles();
                _requireSpace = CalculateTotalFileLength() / (1024 * 1024.0);
                if (IsDiskFreeSpaceOK(_directory, _requireSpace))
                {
                    _canZip = true;
                    using (ZipFile zip = new ZipFile(System.Text.Encoding.Default))
                    {
                        zip.SaveProgress += Zip_SaveProgress;
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;
                        zip.UseZip64WhenSaving = Zip64Option.AsNecessary;
                        zip.ParallelDeflateThreshold = -1;
                        zip.ZipError += Zip_ZipError;
                        for (int i = 0; i < _zipfiles.Count; i++)
                        {
                            if (_loadFileTask.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                            zip.AddFile(_zipfiles[i].FileFullName, _zipfiles[i].Folder == null ? "" : _zipfiles[i].Folder);
                        }

                        //故障诊断不加电脑系统信息，因为获取电脑系统信息耗时太长
                        if (!_forErrorDiagnosis) AddSystemFileToZip(zip);

                        _zipFullname = string.Format(_forErrorDiagnosis ? "{0}\\Error Diagnosis Report {1}.{2}" :
                            "{0}\\Technical Support Request {1}.{2}", _directory, DateTime.Now.ToString("yyMMdd_HHmm"), "zip");
                        zip.Save(_zipFullname);
                    }
                }
                else
                {
                    e.Cancel = true;
                    _canZip = false;
                    ShowZipFailed();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// add system info text and installed programs csv files to zip file
        /// </summary>
        /// <param name="zip"></param>
        private void AddSystemFileToZip(ZipFile zip)
        {
            zip.AddFile(_installedProgramsX64, "SysInfo");
            zip.AddFile(_installedProgramsX32, "SysInfo");
            if (File.Exists(_systemInfo))
            {
                int count = 0;
                while (!this._process.HasExited && count++ < 300) // wait max 30 seconds
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            zip.AddFile(_systemInfo, "SysInfo");
        }

        private void Zip_ZipError(object sender, ZipErrorEventArgs e)
        {
            try
            {
                if (e != null)
                {
                    e.Cancel = true;
                    _canZip = false;
                    if (e.Exception.Message.Contains("There is not enough space on the disk."))
                    {
                        ShowZipFailed();
                    }
                    else
                    {
                        ShowZipException(e.Exception.Message);
                    }
                }
            } 
            catch (Exception)
            {
                throw;
            }
        }

        private void ShowZipException(string exception)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowZipException), new Object[] { exception });
            }
            else
            {
                CancelToDelete();
                //show zip failed page
                this.wizard.SelectedPage = this.pageFinish;
                this.labelSuccess.Text = exception;
                this.checkBoxOpenContainer.Visible = false;
                this.pageFinish.PageTitle = string.Format(Properties.Resources.strCreateFailedTitle,
                    _forErrorDiagnosis ? Properties.Resources.ErrorDiagnosisReport : Properties.Resources.TechnicalSupportRequest); 
            }
        }

        private void ShowZipFailed()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ShowZipFailed));
            }
            else
            {
                CancelToDelete();
                //show zip failed page
                this.wizard.SelectedPage = this.pageFinish;
                this.labelSuccess.Text = string.Format(Properties.Resources.strCreateReportFailed,
                    _forErrorDiagnosis ? Properties.Resources.ErrorDiagnosisReport : Properties.Resources.TechnicalSupportRequest); 
                this.checkBoxOpenContainer.Visible = false;
                this.pageFinish.PageTitle = string.Format(Properties.Resources.strCreateFailedTitle,
                    _forErrorDiagnosis ? Properties.Resources.ErrorDiagnosisReport : Properties.Resources.TechnicalSupportRequest); 
            }
        }

        private void GetFileTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void GetFileTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.progressBar.Value = 100;
            if (!_cancel)
            {
                StartZipTask();
            }
            else
            {
                DeleteFile(_eventsRecordPath);
                DeleteFile(_dataFlashPath);
            }
        }

        private void LoadFileTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void LoadFileTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void initView()
        {
            this.textBoxDescription.TextChanged += TextBoxDescription_TextChanged;

            this.pageInputDescription.NextButtonClick += PageInputDescription_NextButtonClick;

            this.pageSelectFiles.NextButtonClick += PageSelectFiles_NextButtonClick;

            this.pageSelectFiles.BackButtonClick += PageSelectFiles_BackButtonClick;

            this.pageSelectFiles.CancelButtonClick += PageSelectFiles_BackButtonClick;

            this.pageCreating.AfterPageDisplayed += PageCreating_AfterPageDisplayed;

            this.pageCreating.NextButtonClick += PageCreating_NextButtonClick;

            this.pageCreating.CancelButtonClick += PageCreating_CancelButtonClick;

            this.pageCreating.BackButtonClick += PageCreating_CancelButtonClick;

            this.buttonAdd.Click += ButtonAdd_Click;

            this.buttonRemove.Click += ButtonRemove_Click;

            this.pageFinish.FinishButtonClick += PageFinish_FinishButtonClick;

            this.pageFinish.BackButtonVisible = DevComponents.DotNetBar.eWizardButtonState.False;

            this.pageFinish.CancelButtonVisible = DevComponents.DotNetBar.eWizardButtonState.False;

            this.pageFinish.AfterPageDisplayed += PageFinish_AfterPageDisplayed;

            this.listViewFiles.ItemSelectionChanged += ListViewFiles_ItemSelectionChanged;

            this.listViewFiles.Columns.Add("Files", 200, HorizontalAlignment.Left);

            CheckTextBox();
        }

        private void PageSelectFiles_BackButtonClick(object sender, CancelEventArgs e)
        {
            _loadFileTask.CancelAsync();
        }

        private void ListViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.buttonRemove.Enabled = this.listViewFiles.SelectedItems.Count > 0;
        }

        private void PageCreating_CancelButtonClick(object sender, CancelEventArgs e)
        {
            _cancel = true;
            _loadFileTask.CancelAsync();

        }

        private void PageFinish_FinishButtonClick(object sender, CancelEventArgs e)
        {
            if (_canZip && this.checkBoxOpenContainer.Checked)
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select," + _zipFullname);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void PageCreating_NextButtonClick(object sender, CancelEventArgs e)
        {
            this.labelSuccess.Text = labelSuccess.Text.Replace(@"{0}", _zipFullname);
        }

        private void PageCreating_AfterPageDisplayed(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
        {
            CheckSupportDirectory();
            _zipfiles = new List<ZFile>();
            StartZipTask();
        }
        
        public void StartZipTask()
        {
            if (!_loadFileTask.IsBusy)
            {
                labelCreating.Text = string.Format(Properties.Resources.StrCreating,
                    _forErrorDiagnosis ? Properties.Resources.ErrorDiagnosisReport : Properties.Resources.TechnicalSupportRequest); 
                _loadFileTask.RunWorkerAsync();
            }
        }

        private void Zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Object, SaveProgressEventArgs>(Zip_SaveProgress), new Object[] { sender, e });
            }
            else
            {
                if (e.EventType == ZipProgressEventType.Saving_Started)
                {
                    this.progressBar.Maximum = (int)_requireSpace * 1024;
                    this.progressBar.Value = 0;
                    this.progressBar.Minimum = 0;
                    //this.progressBar.Step = 1;
                }
                else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
                {
                    //this.progressBar.Maximum = e.EntriesTotal;
                    //this.progressBar.Value = (int)e.EntriesSaved + 1;
                }
                else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
                {
                    if (e.BytesTransferred != e.TotalBytesToTransfer)
                    {
                        _currentBytes = (int)(e.BytesTransferred / 1024.0);
                        progressBar.Value = _readBytes + _currentBytes;
                    }
                    else
                    {
                        _readBytes += (int)(e.TotalBytesToTransfer / 1024.0);
                        progressBar.Value = _readBytes;
                    }
                }
                else if (e.EventType == ZipProgressEventType.Saving_Completed)
                {
                    if (!_cancel)
                    {
                        labelCreating.Text = string.Format(Properties.Resources.StrProblemReportCreateFinish, 
                            _forErrorDiagnosis ? Properties.Resources.ErrorDiagnosisReport : Properties.Resources.TechnicalSupportRequest);
                        this.pageCreating.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
                        CancelToDelete();
                        this.wizard.NavigateNext();
                    }
                    else
                    {
                        DeleteFile(_zipFullname);
                    }
                }
                this.Update();
                Application.DoEvents();
            }

        }

        private void PageSelectFiles_NextButtonClick(object sender, CancelEventArgs e)
        {
        }

        /// <summary>
        /// //Check if the disk free space is more than require space (M) 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="requireSpace"></param>
        /// <returns></returns>
        private bool IsDiskFreeSpaceOK(string path, double requireSpace)
        {
            double freeSpace = -1;
            string root = Path.GetPathRoot(path);
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (string.Equals(root, drive.Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    freeSpace = drive.TotalFreeSpace / (1024 * 1024.0);
                }
            }
            return freeSpace > requireSpace;
        }

        private long GetFileLength(string fileFullName)
        {
            return new System.IO.FileInfo(fileFullName).Length;
        }

        private long CalculateTotalFileLength()
        {
            long totalFileSize = 0;
            if (_zipfiles != null)
            {
                foreach (var file in _zipfiles)
                {
                    totalFileSize += file.FileLength;
                }
            }
            return totalFileSize;
        }

        /// <summary>
        /// get select file info
        /// </summary>
        /// <param name="baseDirectory"></param>
        /// <param name="fileFolder"></param>
        /// <param name="filter"></param>
        /// <param name="isNamefilter"></param>
        /// <returns></returns>
        private FileInfo[] GetFileInfo(string baseDirectory, string fileFolder, string[] filter, bool isNamefilter)
        {
            DirectoryInfo folder = new DirectoryInfo(baseDirectory + fileFolder);
            try
            {
                FileInfo[] files;
                if (isNamefilter)
                {
                    files = folder.GetFiles().Where(f => filter.Contains(f.Name)).ToArray();
                }
                else
                {
                    files = folder.GetFiles().Where(f => filter.Contains(f.Extension.ToLower())).ToArray();
                }

                return files;
            }
            catch (Exception e)
            {

                return null;
            }
        }

        private FileInfo[] GetFileInfo(string baseDirectory, string fileFolder)
        {
            DirectoryInfo folder = new DirectoryInfo(baseDirectory + fileFolder);
            try
            {
                FileInfo[] files = folder.GetFiles();
                return files;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// get the last ncf files
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private IEnumerable<FileInfo> GetFileInfo(string path)
        {
            if (path != null)
            {
                IEnumerable<FileInfo> fileInfos;
                try
                {
                    DirectoryInfo folder = new DirectoryInfo(path);
                    fileInfos = (from f in folder.GetFiles("*.ncf")
                             orderby f.LastWriteTime descending
                             select f).Take(5);
                }
                catch (Exception e)
                {
                    return null;
                }

                return fileInfos;
            }
            else
            {
                return null;
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem  lvi in this.listViewFiles.SelectedItems)
            {
                if (lvi != null)
                {
                    if (_tag.Remove((string)lvi.Tag))
                    {
                        this.listViewFiles.Items.Remove(lvi);
                    }
                }
            }
            if (this.listViewFiles.Items != null && this.listViewFiles.Items.Count == 0)
            {
                this.buttonRemove.Enabled = false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ShowOpenFileDialog();
        }

        public void ShowOpenFileDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //ofd.InitialDirectory = Program.SysConfig.LoginUser.NcfFilePath;
                ofd.Multiselect = true;
                ofd.Filter = "All Files|*.*|NovoCyte Files|*.ncf";
                if (ofd.ShowDialog(Program.MainForm) == DialogResult.OK)
                {
                    foreach (string fileName in ofd.FileNames)
                    {
                        try
                        {
                            AppendItem(Path.GetFileName(fileName), fileName);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }

            this.buttonRemove.Enabled = this.listViewFiles.SelectedItems.Count > 0;
        }

        private void PageInputDescription_NextButtonClick(object sender, CancelEventArgs e)
        {
            //WriteToFile();
            initListView();
        }

        private void CheckTextBox()
        {
            if (String.IsNullOrEmpty(this.textBoxDescription.Text))
            {
                this.pageInputDescription.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            }
            else
            {
                this.pageInputDescription.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
            }
        }

        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            CheckTextBox();

            _feedback = this.textBoxDescription.Text.ToString();
        }

        /// <summary>
        /// cancel to delete files
        /// </summary>
        private void CancelToDelete()
        {
            DeleteFile(_contentPath);
            DeleteFile(_cytometerInfoPath);
            DeleteFile(_systemInfo);
            DeleteFile(_installedProgramsX64);
            DeleteFile(_installedProgramsX32);
            DeleteFile(_screenShotPath);
            DeleteFile(_eventsRecordPath);
            DeleteFile(_dataFlashPath);
            DeleteFile(_diagnosisResultPath);
        }

        private void WriteToFile()
        {
            try
            {

                string productInfo = Application.ProductName + " " + Program.MajorVersion;
                string buildDate = Properties.Resources.StrBuiltDate +
                                           System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location).ToCSTTime().ToString();
                string content = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}", productInfo, buildDate, Application.StartupPath, _feedback);
                CheckSupportDirectory();
                File.WriteAllText(_contentPath, content);
                //File.WriteAllText(_cytometerInfoPath, Program.SysConfig.CytometerInfo.ToString());
                _zipfiles.Add(new ZFile(_cytometerInfoPath, null, GetFileLength(_cytometerInfoPath)));
                _screenShot.Save(_screenShotPath);
                GetInstalledPrograms();

                if (_forErrorDiagnosis)
                {                   
                    File.WriteAllText(_diagnosisResultPath, _diagnosisResultInfo);
                    _zipfiles.Add(new ZFile(_diagnosisResultPath, null, GetFileLength(_diagnosisResultPath)));
                }
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        /// <summary>
        /// get system info to local text file
        /// </summary>
        private void GetSysytemInfoFile()
        {
            string arguments = string.Format("{0} > \"{1}\"", "systeminfo", _systemInfo);
            ExecuteCommand(arguments, false, _process);
        }

        /// <summary>
        /// get system installed programs to local csc files
        /// </summary>
        private void GetInstalledPrograms()
        {
            string argsX32 = string.Format("{0} \"{1} '{2}'\"", "powershell",
                @"Get-ItemProperty HKLM:\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\* | Select-Object DisplayName, DisplayVersion, Publisher, InstallDate | export-csv -Encoding UTF8",
                _installedProgramsX32).Replace("\\", @"\");
            string argsX64 = string.Format("{0} \"{1} '{2}'\"", "powershell",
                @"Get-ItemProperty HKLM:\Software\Microsoft\Windows\CurrentVersion\Uninstall\* | Select-Object DisplayName, DisplayVersion, Publisher, InstallDate | export-csv -Encoding UTF8",
                _installedProgramsX64).Replace("\\", @"\");
            ExecuteCommand(argsX64, true, new Process());
            ExecuteCommand(argsX32, true, new Process());
        }

        /// <summary>
        /// execute sync/async cmd 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="sync"></param>
        private void ExecuteCommand(string command, bool sync, Process process)
        {
            //Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = string.Format("/c {0}", command);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            if (sync)
            {
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }

        private void DeleteFile(string fileFullName)
        {
            try
            {
                if (File.Exists(fileFullName))
                {
                    File.Delete(fileFullName);
                }
            }
            catch
            {

            }
            
        }

        private void initListView()
        {
            InitScreenshotItem();
            //InitNcfFileItem();
        }

        private void InitScreenshotItem()
        {
            AppendItem("Current Screenshot.png", _screenShotPath);
        }

        //private void InitNcfFileItem()
        //{
        //    string currentFile = Program.ExpDoc.PathName;
        //    if (!String.IsNullOrEmpty(currentFile))
        //    {
        //        AppendItem(Path.GetFileName(currentFile), currentFile);
        //    }
        //}

        private void AppendItem(string name, string fullname)
        {
            ListViewItem lvi = new ListViewItem(name);
            lvi.Text = name;
            lvi.Tag = fullname;
            if (_tag.Add(fullname))
            {
                this.listViewFiles.Items.Add(lvi);
            }
        }

        private void wizard_WizardPageChanged(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
        {
            wizard.NextButtonText = e.NewPage == pageSelectFiles ? Properties.Resources.WizardCreateButtonText : Properties.Resources.WizardNextButtonText;
        }

        private bool _forErrorDiagnosis = false;
        private string _diagnosisResultPath;
        private string _diagnosisResultInfo;
        private bool _needAutoClose = false;
        public bool NeedAutoClose
        {
            get { return _needAutoClose; }
            set { _needAutoClose = value; }
        }

        public void SetForErrorDiagnosisForm(string diagnosisResult)
        {
            _forErrorDiagnosis = true;
            _diagnosisResultInfo = diagnosisResult;            
        }

        private void ProblemReportForm_Load(object sender, EventArgs e)
        {
            if (_forErrorDiagnosis)
            { 
                this.pageCreating.BackButtonVisible = DevComponents.DotNetBar.eWizardButtonState.False;
                this.Text = Res.ProblemReportForm.ProblemReportFormTitle;
                labelCreating.Text = Res.ProblemReportForm.CreatingErrorDiagnososReport;
                pageCreating.PageTitle = Res.ProblemReportForm.ProblemReportFormTitle;
                labelSuccess.Text = Res.ProblemReportForm.CreateErrorDiagnososReportOK;
                checkBoxOpenContainer.Text = Res.ProblemReportForm.OpenReportFolder;

                _directory = Path.Combine(Program.SysConfig.LoginUser.DefaultDataFolder + @"\Error Diagnosis Report");
                CheckSupportDirectory();

                _systemInfo = _directory + @"\Systeminfo.txt";
                GetSysytemInfoFile();

                _contentPath = _directory + @"\Problem Description.txt";
                _screenShotPath = _directory + @"\Current Screenshot.png";

                _installedProgramsX64 = _directory + @"\InstalledPrograms-x64.csv";
                _installedProgramsX32 = _directory + @"\InstalledPrograms-x32.csv";

                _cytometerInfoPath = _directory + @"\Cytometer Info.txt";
                _eventsRecordPath = _directory + @"\Events Record.csv";
                _dataFlashPath = _directory + @"\Data Flash.bin";
                _diagnosisResultPath = _directory + @"\Error Diagnosis Details.txt";
                this.wizard.SelectedPage = this.pageCreating;
            }
            else
            {
                GetSysytemInfoFile();
            }
        }

        private void PageFinish_AfterPageDisplayed(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
        {
            // 在运行孔板时，压力超限故障诊断清除错误后自动关闭窗口
            if (_forErrorDiagnosis && NeedAutoClose)
            {
                //if (Program.Instrument.LastErrorSample != null) Program.Instrument.LastErrorSample.DiagnosisReportPath = _zipFullname;
                this.Close();
            }
        }
    }

    public class ZFile
    {
        private string _fileFullName;

        private string _folder;

        private long _fileLength;
        public ZFile(string fileFullName, string folder, long fileLength)
        {
            this._fileFullName = fileFullName;
            this._folder = folder;
            this._fileLength = fileLength;
        }

        public string FileFullName
        {
            get
            {
                return this._fileFullName;
            }
            set
            {
                this._fileFullName = value;
            }
        }

        public string Folder
        {
            get
            {
                return this._folder;
            }
            set
            {
                this._folder = value;
            }
        }

        public long FileLength
        {
            get
            {
                return this._fileLength;
            }
            set
            {
                this._fileLength = value;
            }
        }
    }

    public class ScreenCapture
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();

        public static Image CaptureDesktop()
        {
            return CaptureWindow(GetDesktopWindow());
        }

        public static Bitmap CaptureActiveWindow()
        {
            return CaptureWindow(GetForegroundWindow());
        }

        public static Bitmap CaptureWindow(IntPtr handle)
        {
            Rect rect = new Rect();
            GetWindowRect(handle, ref rect);
            Rectangle bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
            Bitmap result = new Bitmap(bounds.Width, bounds.Height);

            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return result;
        }
    }
}
