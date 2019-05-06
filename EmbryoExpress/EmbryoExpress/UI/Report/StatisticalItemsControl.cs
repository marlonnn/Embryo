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
    public partial class StatisticalItemsControl : UserControl
    {
        public StatisticalItemsControl()
        {
            InitializeComponent();

            InitializeSelectItemsComboBox();
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbStatisticalItem.Items.Add("Excellent Embryo Rate");
            this.cmbStatisticalItem.Items.Add("Blastocyst Formation Rate");
            this.cmbStatisticalItem.Items.Add("Pregnancy Rate");
            this.cmbStatisticalItem.Items.Add("Fertilization Rate");
            this.cmbStatisticalItem.Items.Add("Implantation Rate");
            this.cmbStatisticalItem.SelectedIndex = 0;
            this.cmbStatisticalItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
