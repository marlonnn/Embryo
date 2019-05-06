using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress.UI.Report
{
    public partial class EnvironmentControl : UserControl
    {
        public EnvironmentControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbEnvironmentItem.Items.Add("Temperature");
            this.cmbEnvironmentItem.Items.Add("Humidity");
            this.cmbEnvironmentItem.Items.Add("Tvoc");
            this.cmbEnvironmentItem.SelectedIndex = 0;
            this.cmbEnvironmentItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
