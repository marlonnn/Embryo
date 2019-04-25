using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress
{
    public static class BaseFunction
    {
        /// <summary>
        /// if this is Chinese edition which need register process
        /// </summary>
        public static bool ChineseEdition
        {
            get { return _chineseEdition ?? (bool)(_chineseEdition = File.Exists(Application.StartupPath + "\\zh-CN\\EmbryoExpress.resources.dll")); }
        }

        private static bool? _chineseEdition;

        public static void RefreshUICulture(System.ComponentModel.ComponentResourceManager resources, Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                ////PlatePanel里面会调用RefreshUICulture，如果重复处理显示有问题
                //if (c is NovoCyte.UI.PlatePanel || c is NovoCyte.UI.PlatePanel_2)
                //{
                //    continue;
                //}

                //if (c is Novoplexs.UI.NovoplexBeadsInfoCtrl || c is Novoplexs.UI.NovoplexStandardsCtrl || c is Novoplexs.UI.NovoplexCurvesCtrl ||
                //    c is Novoplexs.UI.NovoplexResultsPerAnalyteCtrl || c is Novoplexs.UI.NovoplexResultsPerSampleCtrl || c is Novoplexs.UI.NovoplexResultsSummaryCtrl)
                //{
                //    continue;
                //}

                resources.ApplyResources(c, c.Name);
                RefreshUICulture(resources, c);

                if (c is RibbonBar)
                {
                    RefreshBaseItemsUICulture(resources, (c as RibbonBar).Items);
                }
                else if (c is RibbonControl)
                {
                    RefreshBaseItemsUICulture(resources, (c as RibbonControl).Items);
                }
                else if (c is Bar)
                {
                    RefreshBaseItemsUICulture(resources, (c as Bar).Items);
                }
                else if (c is ButtonX)
                {
                    RefreshBaseItemsUICulture(resources, (c as ButtonX).SubItems);
                }
                else if (c is ToolStrip)
                {
                    RefreshToolStripUICulture(resources, (c as ToolStrip).Items);
                }
            }
        }

        public static void RefreshToolStripUICulture(System.ComponentModel.ComponentResourceManager resources, ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                resources.ApplyResources(item, item.Name);
                if (item is ToolStripDropDownItem)
                    RefreshToolStripUICulture(resources, (item as ToolStripDropDownItem).DropDownItems);
            }
        }

        public static void RefreshBaseItemsUICulture(System.ComponentModel.ComponentResourceManager resources, SubItemsCollection items)
        {
            foreach (BaseItem item in items)
            {
                if (item is ColorPickerDropDown) continue;
                resources.ApplyResources(item, item.Name);
                RefreshBaseItemsUICulture(resources, item.SubItems);
            }
        }

        public static string ReplacePathInvalidChar(string path, string replaceWith = "_")
        {
            if (path == null) return null;

            // replace invalid file name chars to " "
            string invalid = new string(System.IO.Path.GetInvalidFileNameChars());
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(
                string.Format("[{0}]", System.Text.RegularExpressions.Regex.Escape(invalid)));

            path = r.Replace(path, replaceWith);

            return ReplacePathReservedName(path);
        }

        private static string[] reservedFileNames = new string[] { "CON", "PRN", "AUX", "CLOCK$", "NUL", "COM0", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT0", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };

        public static string ReplacePathReservedName(string path)
        {
            if (path == null) return null;

            //check reserve names, for example con, con.           
            foreach (string reserve in reservedFileNames)
            {
                if (string.Compare(path, reserve, true) == 0 || path.ToUpper().StartsWith(reserve + "."))
                {
                    path = path.Substring(0, reserve.Length) + "_" + path.Substring(reserve.Length);
                    break;
                }
            }

            return path;
        }

        public static string GetPublicPath()
        {
            var disk = DriveInfo.GetDrives().Where(drive => drive.Name == "D:\\" && drive.DriveType == DriveType.Fixed);
            if (disk.Count<DriveInfo>() == 0)
            {
                return @"C:";
            }
            else
            {
                return @"D:";
            }

            //Version ver = System.Environment.OSVersion.Version;
            //bool isVistaOrLater = ver.Major >= 6;
            //string path = Environment.GetEnvironmentVariable(isVistaOrLater ? "PUBLIC" : "ALLUSERSPROFILE");
            //return path;
        }
        /// <summary>
        /// this function get next available name for specified name
        /// </summary>
        /// <param name="targetName"></param>
        /// <param name="existsNames"></param>
        /// <returns></returns>
        public static string GeDuplicateName(string targetName, IEnumerable<string> existsNames)
        {
            return GeDuplicateName(targetName, existsNames, false);
        }

        /// <summary>
        /// this function get next available name for specified name 
        /// </summary>        
        /// <returns>name with pattern Name(2)</returns>
        public static string GeDuplicateName(string targetName, IEnumerable<string> existsNames, bool ignoreCase)
        {
            if (!ignoreCase && !existsNames.Contains(targetName)) return targetName;
            if (ignoreCase && !existsNames.Select(n => n.ToUpper()).Contains(targetName.ToUpper())) return targetName;

            //find parentheses, like Name(2)
            int left = -1;
            if (targetName.EndsWith(")"))
            {
                for (int i = targetName.Length - 2; i >= 0; i--)
                {
                    char c = targetName[i];
                    if (c == '(')
                    {
                        left = i;
                        break;
                    }
                    else if (c < '0' || c > '9')
                        break;
                }
            }

            //sampleName = rootName + parentheses
            string parentheses = (left < 0) ? "" : targetName.Substring(left, targetName.Length - left);
            string rootName = (left < 0) ? targetName : targetName.Substring(0, left);

            //find max index
            IEnumerable<string> dupNames = existsNames.Where(s => s.StartsWith(rootName, ignoreCase, null));
            int maxIndex = -1;
            foreach (string name in dupNames)
            {
                if (name.Length == rootName.Length)
                {
                    if (maxIndex < 0) maxIndex = 0;
                }
                else if (name[rootName.Length] == '(' && name.EndsWith(")"))
                {
                    bool bIndex = true;
                    for (int i = rootName.Length + 1; i < name.Length - 1; i++)
                    {
                        char c = name[i];
                        if (c < '0' || c > '9')
                        {
                            bIndex = false;
                            break;
                        }
                    }

                    if (!bIndex)
                        continue;

                    int index;
                    int.TryParse(name.Substring(rootName.Length + 1, name.Length - rootName.Length - 2), out index);
                    if (maxIndex < index)
                    {
                        maxIndex = index;
                    }
                }
            }

            if (maxIndex >= 0)
            {
                targetName = rootName + "(" + Convert.ToString(maxIndex + 1) + ")";
            }

            return targetName;
        }


        public static string GetMajorVersion(string version)
        {
            if (version != null && version.Length > 5) version = version.Substring(0, version.Length - 5);
            return version;
        }
        public static bool CreateDirectory(string directoryPath)
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
