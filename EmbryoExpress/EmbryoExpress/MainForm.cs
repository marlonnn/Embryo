using DevComponents.DotNetBar;
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
        private InputControl inputControl;
        public MainForm()
        {
            InitializeComponent();
            inputControl = new InputControl();
        }

        private void buttonItemInformationInput_Click(object sender, EventArgs e)
        {
            this.panelEx1.Controls.Clear();
            inputControl.Dock = DockStyle.Fill;
            this.panelEx1.Controls.Add(inputControl);
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
    }
}
