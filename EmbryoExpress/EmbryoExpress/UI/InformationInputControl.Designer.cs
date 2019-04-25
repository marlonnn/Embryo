namespace EmbryoExpress.UI
{
    partial class InformationInputControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationInputControl));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageIncubator = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageMicroscope = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageCylinder = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageHotStage = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageLiquidNitrogen = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageFridge = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageAirConditioner = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageThermometer = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageTimer = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageCO2Measurment = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            resources.ApplyResources(this.xtraTabControl1, "xtraTabControl1");
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageIncubator;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageIncubator,
            this.xtraTabPageMicroscope,
            this.xtraTabPageCylinder,
            this.xtraTabPageHotStage,
            this.xtraTabPageLiquidNitrogen,
            this.xtraTabPageFridge,
            this.xtraTabPageAirConditioner,
            this.xtraTabPageThermometer,
            this.xtraTabPageTimer,
            this.xtraTabPageCO2Measurment});
            // 
            // xtraTabPageIncubator
            // 
            this.xtraTabPageIncubator.Name = "xtraTabPageIncubator";
            resources.ApplyResources(this.xtraTabPageIncubator, "xtraTabPageIncubator");
            // 
            // xtraTabPageMicroscope
            // 
            this.xtraTabPageMicroscope.Name = "xtraTabPageMicroscope";
            resources.ApplyResources(this.xtraTabPageMicroscope, "xtraTabPageMicroscope");
            // 
            // xtraTabPageCylinder
            // 
            this.xtraTabPageCylinder.Name = "xtraTabPageCylinder";
            resources.ApplyResources(this.xtraTabPageCylinder, "xtraTabPageCylinder");
            // 
            // xtraTabPageHotStage
            // 
            this.xtraTabPageHotStage.Name = "xtraTabPageHotStage";
            resources.ApplyResources(this.xtraTabPageHotStage, "xtraTabPageHotStage");
            // 
            // xtraTabPageLiquidNitrogen
            // 
            this.xtraTabPageLiquidNitrogen.Name = "xtraTabPageLiquidNitrogen";
            resources.ApplyResources(this.xtraTabPageLiquidNitrogen, "xtraTabPageLiquidNitrogen");
            // 
            // xtraTabPageFridge
            // 
            this.xtraTabPageFridge.Name = "xtraTabPageFridge";
            resources.ApplyResources(this.xtraTabPageFridge, "xtraTabPageFridge");
            // 
            // xtraTabPageAirConditioner
            // 
            this.xtraTabPageAirConditioner.Name = "xtraTabPageAirConditioner";
            resources.ApplyResources(this.xtraTabPageAirConditioner, "xtraTabPageAirConditioner");
            // 
            // xtraTabPageThermometer
            // 
            this.xtraTabPageThermometer.Name = "xtraTabPageThermometer";
            resources.ApplyResources(this.xtraTabPageThermometer, "xtraTabPageThermometer");
            // 
            // xtraTabPageTimer
            // 
            this.xtraTabPageTimer.Name = "xtraTabPageTimer";
            resources.ApplyResources(this.xtraTabPageTimer, "xtraTabPageTimer");
            // 
            // xtraTabPageCO2Measurment
            // 
            this.xtraTabPageCO2Measurment.Name = "xtraTabPageCO2Measurment";
            resources.ApplyResources(this.xtraTabPageCO2Measurment, "xtraTabPageCO2Measurment");
            // 
            // InformationInputControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "InformationInputControl";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageIncubator;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMicroscope;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCylinder;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageHotStage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageLiquidNitrogen;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFridge;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAirConditioner;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageThermometer;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTimer;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageCO2Measurment;
    }
}
