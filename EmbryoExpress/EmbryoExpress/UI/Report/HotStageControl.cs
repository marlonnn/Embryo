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
    public partial class HotStageControl : UserControl
    {
        public HotStageControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbHotStageItem.Items.Add("Temperature");
            this.cmbHotStageItem.SelectedIndex = 0;
            this.cmbHotStageItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
