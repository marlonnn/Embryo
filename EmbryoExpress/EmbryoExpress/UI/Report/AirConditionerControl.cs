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
    public partial class AirConditionerControl : UserControl
    {
        public AirConditionerControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbAirConditionerItem.Items.Add("Temperature");
            this.cmbAirConditionerItem.Items.Add("Humidity");
            this.cmbAirConditionerItem.SelectedIndex = 0;
            this.cmbAirConditionerItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
