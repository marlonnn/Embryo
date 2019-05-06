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
    public partial class FridgeControl : UserControl
    {
        public FridgeControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbFridgeItem.Items.Add("Temperature");
            this.cmbFridgeItem.Items.Add("Cold Storage");
            this.cmbFridgeItem.SelectedIndex = 0;
            this.cmbFridgeItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
