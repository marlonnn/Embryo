using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using EmbryoExpress.Instrument;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace EmbryoExpress.UI.Report
{
    public partial class SubIncubatorReport : DevExpress.XtraReports.UI.XtraReport
    {
        private const int CHARTHEIGHT = 400;

        private List<Instruments> instrumentsList;
        private XRTable xrTable;
        private XRChart chart;
        public SubIncubatorReport()
        {

            instrumentsList = SysData.GetSysData().InstrumentsList;
            InitializeComponent();
        }

        private XRLabel CreateXRLabel(PointFloat pos, string message)
        {
            XRLabel xLblInfoTitle = new XRLabel();
            xLblInfoTitle.Font = new Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular);
            xLblInfoTitle.LocationFloat = pos;
            xLblInfoTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            xLblInfoTitle.SizeF = new System.Drawing.SizeF(400F, 23F);
            xLblInfoTitle.Text = message;
            return xLblInfoTitle;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel xLblInfoTitle = CreateXRLabel(new PointFloat(5F, 10), "培养箱图表");

            this.Detail.Controls.Add(xLblInfoTitle);
            CreateTable(xLblInfoTitle);

            CreateXRChartToReport(new PointFloat(xrTable.LocationF.X, xrTable.HeightF + xrTable.LocationF.Y + 10 + ReportManager.SpiltTableSpace));

            XRLabel xLblInfoTitle2 = CreateXRLabel(new PointFloat(5F, 10 + chart.LocationF.Y + chart.HeightF + ReportManager.SpiltTableSpace), "未完待续。。。");

            this.Detail.Controls.Add(xLblInfoTitle2);
        }

        private void CreateTable(XRLabel xLblInfoTitle)
        {
            xrTable = new XRTable();

            XRTableRow xrTableRowHeader = new XRTableRow();

            xrTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                | DevExpress.XtraPrinting.BorderSide.Right)
                | DevExpress.XtraPrinting.BorderSide.Bottom)));

            var tableHeight = ReportManager.TableRowHeight * (instrumentsList.Count + 1);

            var y = xLblInfoTitle.LocationF.Y + xLblInfoTitle.HeightF + 10 + ReportManager.SpiltTableSpace;
            xrTable.BoundsF = new RectangleF(5F, y, 580, tableHeight);
            xrTableRowHeader.Weight = 1D;
            xrTableRowHeader.BackColor = ReportManager.Instance().TableHeadBackColor;

            string[] captions = new string[] {"DateTime", "Co2 Concentration" , "Temperature" , "Maintenance", "Cleaning" , "Calibration" };
            float[] captionWidth = new float[] { 120, 120, 100, 80, 80, 80};
            for (int i = 0; i < captions.Length; i++)
            {
                XRTableCell xTableCell = new XRTableCell();
                xTableCell.Text = captions[i];
                xTableCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell.WidthF = captionWidth[i];
                xrTableRowHeader.Cells.Add(xTableCell);
            }
            xrTable.Rows.AddRange(new XRTableRow[] { xrTableRowHeader });

            for (int j = 0; j < instrumentsList.Count; j++)
            {
                XRTableRow xrTableRow = new XRTableRow();
                xrTableRow.Weight = 1D;

                XRTableCell xTableCell = new XRTableCell();
                xTableCell.Text = instrumentsList[j].DateTime.ToString("");
                xTableCell.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell.WidthF = 120;
                xrTableRow.Cells.Add(xTableCell);

                XRTableCell xTableCell1 = new XRTableCell();
                xTableCell1.Text = instrumentsList[j].Incubator.Co2Concentration.ToString();
                xTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell1.WidthF = 120;
                xrTableRow.Cells.Add(xTableCell1);

                XRTableCell xTableCell2 = new XRTableCell();
                xTableCell2.Text = instrumentsList[j].Incubator.Temperature.ToString();
                xTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell2.WidthF = 100;
                xrTableRow.Cells.Add(xTableCell2);

                XRTableCell xTableCell3 = new XRTableCell();
                xTableCell3.Text = instrumentsList[j].Incubator.Maintenance.ToDescription();
                xTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell3.WidthF = 80;
                xrTableRow.Cells.Add(xTableCell3);

                XRTableCell xTableCell4 = new XRTableCell();
                xTableCell4.Text = instrumentsList[j].Incubator.Cleaning.ToDescription();
                xTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell4.WidthF = 80;
                xrTableRow.Cells.Add(xTableCell4);

                XRTableCell xTableCell5 = new XRTableCell();
                xTableCell5.Text = instrumentsList[j].Incubator.Calibration.ToDescription();
                xTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
                xTableCell5.WidthF = 80;
                xrTableRow.Cells.Add(xTableCell5);

                xrTable.Rows.AddRange(new XRTableRow[] { xrTableRow });
            }

            this.Detail.Controls.AddRange(new XRControl[] { xrTable });
        }

        private void CreateXRChartToReport( PointFloat chartLocation)
        {
            chart = new XRChart();

            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Font = new Font("Arial Unicode MS", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            chartTitle.TextColor = Color.Black;
            chartTitle.Text = "培养箱图表";

            chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle });

            //DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            //xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            //xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            //chart.Diagram = xyDiagram1;

            //((XYDiagram)chart.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //((XYDiagram)chart.Diagram).AxisX.VisibleInPanesSerializable = "-1";
            //((XYDiagram)chart.Diagram).AxisX.WholeRange.AlwaysShowZeroLevel = true;

            //((XYDiagram)chart.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //((XYDiagram)chart.Diagram).AxisY.VisibleInPanesSerializable = "-1";
            //((XYDiagram)chart.Diagram).AxisY.WholeRange.AlwaysShowZeroLevel = true;

            //((XYDiagram)chart.Diagram).AxisX.Title.Text = "DateTime";
            //((XYDiagram)chart.Diagram).AxisX.Title.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular);
            //((XYDiagram)chart.Diagram).AxisY.Title.Text = "CO2 Concentration";
            //((XYDiagram)chart.Diagram).AxisY.Title.Font = new Font("Arial Unicode MS", 12F, FontStyle.Regular);

            List<DateTime> xs; List<int> ys;
            GetStandardPoints(out xs, out ys);

            if (xs != null && ys != null)
            {
                Series series2 = new Series("series2", ViewType.Bar);
                series2.LabelsVisibility = DefaultBoolean.False;
                ((BarSeriesView)series2.View).Color = Color.OrangeRed;
                //((BarSeriesView)series2.View).MarkerVisibility = DefaultBoolean.False;
                for (int i = 0; i < xs.Count; i++)
                {
                    series2.Points.Add(new SeriesPoint(xs[i], ys[i]));
                }
                chart.Series.Add(series2);
            }

            chart.Legend.Name = "Default Legend";
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            chart.LocationFloat = chartLocation;
            chart.SizeF = new SizeF(616F, CHARTHEIGHT);

            this.Detail.Controls.Add(chart);
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

        private void GetStandardPoints(out List<DateTime> xs, out List<int> ys, bool co2 = true)
        {
            xs = new List<DateTime>();
            ys = new List<int>();

            for (int i = instrumentsList.Count - 1; i >= 0; i--)
            {
                xs.Add(instrumentsList[i].DateTime);
                if (co2)
                    ys.Add(instrumentsList[i].Incubator.Co2Concentration);
                else
                    ys.Add(instrumentsList[i].Incubator.Temperature);
            }
        }
    }
}
