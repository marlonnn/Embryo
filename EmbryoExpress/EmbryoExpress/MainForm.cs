using DevComponents.DotNetBar;
using DevComponents.Editors;
using EmbryoExpress.SysClass;
using EmbryoExpress.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress
{
    public partial class MainForm : Office2007RibbonForm
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

        public bool ToRestart { get; set; }

        private InformationControl informationControl;
        private TasksControl tasksControl;
        private MonitorControl monitorControl;
        private DailyManagerControl dailyManagerControl;

        public MainForm()
        {
            ToRestart = false;
            InitializeComponent();
            informationControl = new InformationControl();
            tasksControl = new TasksControl();
            monitorControl = new MonitorControl();
            dailyManagerControl = new DailyManagerControl();
            dailyManagerControl.Dock = DockStyle.Fill;
            informationControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(informationControl);

            Program.SysConfig.UserRoleChanged += new EventHandler(SysConfig_UserRoleChanged);

        }

        private void SysConfig_UserRoleChanged(object sender, EventArgs e)
        {
            if (!Program.SysConfig.UserConfig.IsAdminLogin())
            {
                //buttonUserManager.Enabled = false;
                buttonItemUserManager.Enabled = false;
            }
        }

        private void buttonItemInformationInput_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            informationControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(informationControl);
        }

        private void comboBoxItemLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureSettings.SetAppUICulture(Program.SysConfig, ((ComboItem)comboBoxItemLanguage.SelectedItem).Value.ToString());
        }

        private void buttonItemQualityControlProcess_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            tasksControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(tasksControl);
        }

        private void buttonItemDailyManagerment_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            dailyManagerControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(dailyManagerControl);
        }

        private void buttonItemCentralMonitor_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            monitorControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(monitorControl);
        }

        private void buttonItemReportManagerment_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            UserManagerForm userManagerForm = new UserManagerForm();
            userManagerForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.SysConfig.LoginUser != null)
                Program.SysConfig.LoginUser.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(SysConfig_PropertyChanged);
        }

        private void SysConfig_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == SysConfig.GetPropertyName(() => Program.SysConfig.LoginUser.UICulture))
            {

                UpdateComboLanguage();

                BaseFunction.RefreshUICulture(resources, this);

                // fix ribbon refresh problem
                var item = ribbonControl1.SelectedRibbonTabItem;
                ribbonControl1.SelectedRibbonTabItem = item == ribbonTabItemSetting ? this.ribbonTabItemSetting : this.ribbonTabItemHome;
                ribbonControl1.SelectedRibbonTabItem = item;

            }
        }

        private void UpdateComboLanguage()
        {
            foreach (ComboItem item in comboBoxItemLanguage.Items)
            {
                if (item.Value.ToString() == Program.SysConfig.LoginUser.UICulture)
                {
                    comboBoxItemLanguage.SelectedItem = item;
                    break;
                }
            }
            comboBoxItemLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemLanguage_SelectedIndexChanged);
        }
    }
}
