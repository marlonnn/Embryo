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
    public partial class TemperLoweringControl : UserControl
    {
        public TemperLoweringControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbLoweringItem.Items.Add("Liquid Nitrogen");
            this.cmbLoweringItem.Items.Add("Start Temperature");
            this.cmbLoweringItem.Items.Add("Seeding Temperature");
            this.cmbLoweringItem.Items.Add("End Temperature");
            this.cmbLoweringItem.SelectedIndex = 0;
            this.cmbLoweringItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
