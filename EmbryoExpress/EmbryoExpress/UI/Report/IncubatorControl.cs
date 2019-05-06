using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmbryoExpress.Tasks;
using EmbryoExpress.Instrument;
using DevExpress.XtraCharts;

namespace EmbryoExpress.UI.Report
{
    public partial class IncubatorControl : UserControl
    {
        private List<Instruments> instrumentsList;
        private BindingSource bindingSource;
        public IncubatorControl()
        {
            bindingSource = new BindingSource();

            InitializeComponent();

            InitializeSelectItemsComboBox();

            instrumentsList = SysData.GetSysData().InstrumentsList;
        }

        private void InitializeSelectItemsComboBox()
        {
            this.cmbIncubatorItem.Items.Add("CO2 Concentration");
            this.cmbIncubatorItem.Items.Add("Temperature");
            this.cmbIncubatorItem.SelectedIndex = 0;
            this.cmbIncubatorItem.SelectedIndexChanged += CmbIncubatorItem_SelectedIndexChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetDataSource();

            InitializeTitles();
            InitializeChartControl();
            FillChartControl();
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

        private void InitializeTitles()
        {
            this.chartControl1.Titles[0].Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Titles[0].TextColor = Color.Black;
        }

        private void InitializeChartControl()
        {
            chartControl1.CrosshairOptions.ShowGroupHeaders = false;
        }

        private void FillChartControl()
        {
            this.chartControl1.Titles[0].Text = this.cmbIncubatorItem.SelectedItem.ToString();
            XYDiagram xyDiagram1 = (XYDiagram)chartControl1.Diagram;

            xyDiagram1.AxisX.Title.Text = "DateTime";
            xyDiagram1.AxisY.Title.Text = this.cmbIncubatorItem.SelectedItem.ToString();

            List<DateTime> xs; List<int> ys;
            GetStandardPoints(out xs, out ys);

            FillSeries(series1, xs, ys);

            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0;
            DateTime min = (DateTime)xyDiagram1.AxisX.WholeRange.MinValue;
            DateTime max = (DateTime)xyDiagram1.AxisX.WholeRange.MaxValue;
            var margin = max - min;

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

            for (int i=instrumentsList.Count - 1; i>=0; i--)
            {
                xs.Add(instrumentsList[i].DateTime);
                if (this.cmbIncubatorItem.SelectedIndex == 0)
                    ys.Add(instrumentsList[i].Incubator.Co2Concentration);
                else
                    ys.Add(instrumentsList[i].Incubator.Temperature);
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
