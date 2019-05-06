namespace EmbryoExpress.UI.Report
{
    partial class TemperLoweringControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperLoweringControl));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.liquidNitrogen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seedTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endTemperature = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblSelectIncubatorItem = new System.Windows.Forms.ToolStripLabel();
            this.cmbLoweringItem = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveImage = new System.Windows.Forms.ToolStripButton();
            this.btnExportCSV = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            resources.ApplyResources(this.splitContainerControl1, "splitContainerControl1");
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel1, "splitContainerControl1.Panel1");
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl1);
            resources.ApplyResources(this.splitContainerControl1.Panel2, "splitContainerControl1.Panel2");
            this.splitContainerControl1.SplitterPosition = 317;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dateTime,
            this.liquidNitrogen,
            this.startTemperature,
            this.seedTemperature,
            this.endTemperature});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dateTime
            // 
            resources.ApplyResources(this.dateTime, "dateTime");
            this.dateTime.FieldName = "DateTime";
            this.dateTime.Name = "dateTime";
            // 
            // liquidNitrogen
            // 
            resources.ApplyResources(this.liquidNitrogen, "liquidNitrogen");
            this.liquidNitrogen.FieldName = "TemperLowering.LiquidNitrogen";
            this.liquidNitrogen.Name = "liquidNitrogen";
            // 
            // startTemperature
            // 
            resources.ApplyResources(this.startTemperature, "startTemperature");
            this.startTemperature.FieldName = "TemperLowering.StartTemperature";
            this.startTemperature.Name = "startTemperature";
            // 
            // seedTemperature
            // 
            resources.ApplyResources(this.seedTemperature, "seedTemperature");
            this.seedTemperature.FieldName = "TemperLowering.SeedingTemperature";
            this.seedTemperature.Name = "seedTemperature";
            // 
            // endTemperature
            // 
            resources.ApplyResources(this.endTemperature, "endTemperature");
            this.endTemperature.FieldName = "TemperLowering.EndTemperature";
            this.endTemperature.Name = "endTemperature";
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            resources.ApplyResources(this.chartControl1, "chartControl1");
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Name = "chartControl1";
            resources.ApplyResources(series1, "series1");
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectIncubatorItem,
            this.cmbLoweringItem,
            this.toolStripSeparator1,
            this.btnSaveImage,
            this.btnExportCSV});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // lblSelectIncubatorItem
            // 
            this.lblSelectIncubatorItem.Name = "lblSelectIncubatorItem";
            resources.ApplyResources(this.lblSelectIncubatorItem, "lblSelectIncubatorItem");
            // 
            // cmbLoweringItem
            // 
            this.cmbLoweringItem.Name = "cmbLoweringItem";
            resources.ApplyResources(this.cmbLoweringItem, "cmbLoweringItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveImage.Image = global::EmbryoExpress.Properties.Resources.Save_as_Picture;
            resources.ApplyResources(this.btnSaveImage, "btnSaveImage");
            this.btnSaveImage.Name = "btnSaveImage";
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportCSV.Image = global::EmbryoExpress.Properties.Resources.Export_Table;
            resources.ApplyResources(this.btnExportCSV, "btnExportCSV");
            this.btnExportCSV.Name = "btnExportCSV";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TemperLoweringControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TemperLoweringControl";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblSelectIncubatorItem;
        private System.Windows.Forms.ToolStripComboBox cmbLoweringItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSaveImage;
        private System.Windows.Forms.ToolStripButton btnExportCSV;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.Columns.GridColumn dateTime;
        private DevExpress.XtraGrid.Columns.GridColumn liquidNitrogen;
        private DevExpress.XtraGrid.Columns.GridColumn startTemperature;
        private DevExpress.XtraGrid.Columns.GridColumn seedTemperature;
        private DevExpress.XtraGrid.Columns.GridColumn endTemperature;
    }
}
