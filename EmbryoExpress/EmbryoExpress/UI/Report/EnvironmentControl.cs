using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmbryoExpress.Instrument;
using DevExpress.XtraCharts;

namespace EmbryoExpress.UI.Report
{
    public partial class EnvironmentControl : UserControl
    {
        private List<Instruments> instrumentsList;
        private BindingSource bindingSource;
        public EnvironmentControl()
        {
            bindingSource = new BindingSource();

            InitializeComponent();

            InitializeSelectItemsComboBox();

            instrumentsList = SysData.GetSysData().InstrumentsList;
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbEnvironmentItem.Items.Add("Temperature");
            this.cmbEnvironmentItem.Items.Add("Humidity");
            this.cmbEnvironmentItem.Items.Add("Tvoc");
            this.cmbEnvironmentItem.SelectedIndex = 0;
            this.cmbEnvironmentItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetDataSource();

            InitializeTitles();
            FillChartControl();
        }

        private void InitializeTitles()
        {
            this.chartControl1.Titles[0].Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Titles[0].TextColor = Color.Black;
            chartControl1.CrosshairOptions.ShowGroupHeaders = false;
        }

        private void SetDataSource()
        {
            bindingSource.DataSource = instrumentsList;
            gridControl1.DataSource = bindingSource;
        }

        private void CmbIncubatorItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillChartControl();
        }

        private void FillChartControl()
        {
            this.chartControl1.Titles[0].Text = "Environment";
            XYDiagram xyDiagram1 = (XYDiagram)chartControl1.Diagram;

            xyDiagram1.AxisX.Title.Text = "DateTime";
            xyDiagram1.AxisY.Title.Text = this.cmbEnvironmentItem.SelectedItem.ToString();

            List<DateTime> xs; List<int> ys;
            GetStandardPoints(out xs, out ys);

            FillSeries(this.chartControl1.Series[0], xs, ys);

            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0;
            DateTime min = (DateTime)xyDiagram1.AxisX.WholeRange.MinValue;
            DateTime max = (DateTime)xyDiagram1.AxisX.WholeRange.MaxValue;

            xyDiagram1.AxisX.WholeRange.SetMinMaxValues(min, max);


            //xyDiagram1.AxisX.VisualRange.Auto = false;
            //xyDiagram1.AxisX.VisualRange.MinValue = xs[0];
            //xyDiagram1.AxisX.VisualRange.MaxValue = xs[xs.Count - 1];
            this.chartControl1.Update();
        }

        private void GetStandardPoints(out List<DateTime> xs, out List<int> ys)
        {
            xs = new List<DateTime>();
            ys = new List<int>();

            for (int i = instrumentsList.Count - 1; i >= 0; i--)
            {
                xs.Add(instrumentsList[i].DateTime);
                if (this.cmbEnvironmentItem.SelectedIndex == 0)
                    ys.Add(instrumentsList[i].Environment.Temperature);
                else if (this.cmbEnvironmentItem.SelectedIndex == 1)
                    ys.Add(instrumentsList[i].Environment.Humidity);
                else if (this.cmbEnvironmentItem.SelectedIndex == 2)
                    ys.Add(instrumentsList[i].Environment.Tvoc);
            }
        }

        private static void FillSeries(Series series, List<DateTime> xs, List<int> ys)
        {
            if (series == null) return;

            if (xs == null || ys == null)
            {
                series.Points.Clear();
            }
            else
            {
                series.Points.Clear();
                for (int i = 0; i < xs.Count; i++)
                {
                    series.Points.Add(new SeriesPoint(xs[i], ys[i]));
                }
            }
        }
    }
}
