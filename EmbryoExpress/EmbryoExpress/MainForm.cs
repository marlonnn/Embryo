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

        private InputControl inputControl;
        private InformationControl informationControl;
        public MainForm()
        {
            ToRestart = false;
            InitializeComponent();
            inputControl = new InputControl();
            informationControl = new InformationControl();

            inputControl.Dock = DockStyle.Fill;
            informationControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(informationControl);
        }

        private void buttonItemInformationInput_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            inputControl.Dock = DockStyle.Fill;
            informationControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(informationControl);
        }

        private void comboBoxItemLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureSettings.SetAppUICulture(Program.SysConfig, ((ComboItem)comboBoxItemLanguage.SelectedItem).Value.ToString());
        }

        private void buttonItemQualityControlProcess_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemDailyManagerment_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemCentralMonitor_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemReportManagerment_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

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
