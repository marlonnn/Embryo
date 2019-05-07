using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace EmbryoExpress.UI.Report
{
    public partial class ReportControl : UserControl
    {
        private XtraReport report;
        public ReportControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            report = new XtraReport();
            InitReportSetupSetting(report);
            report.HorizontalContentSplitting = HorizontalContentSplitting.Smart;
            this.documentViewer1.DocumentSource = this.report;
            //SubscribePageSettingEvent();
            report.CreateDocument(false);

            SetCommandVisiable(this.report.PrintingSystem);
            InitReportLayout();
        }

        private void InitReportLayout()
        {
            this.barCheckItemHorizontal.Checked = ReportManager.Instance().Landscape;
            this.barCheckItemVertical.Checked = !ReportManager.Instance().Landscape;
        }

        private void InitReportSetupSetting(XtraReport report)
        {
            if (report != null)
            {
                report.Landscape = ReportManager.Instance().Landscape;
                report.PaperKind = ReportManager.Instance().PaperKind;
                report.Margins.Left = ReportManager.Instance().MarginLeft;
                report.Margins.Right = ReportManager.Instance().MarginLeft;
                report.Margins.Top = ReportManager.Instance().MarginTop;
                report.Margins.Bottom = ReportManager.Instance().MarginBottom;
                ReportManager.Instance().TableWidth = report.PageWidth;
            }
        }

        private void SetCommandVisiable(PrintingSystemBase printingSystem)
        {
            // Disable PageMargins. 
            printingSystem.SetCommandVisibility(new PrintingSystemCommand[] {
                PrintingSystemCommand.Save, PrintingSystemCommand.Open,
                PrintingSystemCommand.PrintDirect, PrintingSystemCommand.Magnifier,
                PrintingSystemCommand.PageSetup,
                PrintingSystemCommand.PageMargins, PrintingSystemCommand.ClosePreview ,
                PrintingSystemCommand.Background, PrintingSystemCommand.FillBackground,
                PrintingSystemCommand.Customize , PrintingSystemCommand.MultiplePages, PrintingSystemCommand.Scale},
                        CommandVisibility.None);
        }
    }
}
