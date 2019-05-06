namespace EmbryoExpress.UI
{
    partial class ReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.btnFridge = new System.Windows.Forms.Button();
            this.panelStep = new DevExpress.XtraEditors.PanelControl();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEnvironment = new System.Windows.Forms.Button();
            this.btnStatisticalItems = new System.Windows.Forms.Button();
            this.btnHotStage = new System.Windows.Forms.Button();
            this.btnTemperatureLowering = new System.Windows.Forms.Button();
            this.btnIncubator = new System.Windows.Forms.Button();
            this.btnAirConditioner = new System.Windows.Forms.Button();
            this.panelIncubator = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelHotStage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelTemperatureLowering = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelAirConditioner = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelStatisticalItems = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelFridge = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelEnvironment = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tabControl1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.panelReport = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelStep)).BeginInit();
            this.panelStep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFridge
            // 
            resources.ApplyResources(this.btnFridge, "btnFridge");
            this.btnFridge.BackColor = System.Drawing.Color.Transparent;
            this.btnFridge.FlatAppearance.BorderSize = 0;
            this.btnFridge.Name = "btnFridge";
            this.btnFridge.UseVisualStyleBackColor = false;
            this.btnFridge.Click += new System.EventHandler(this.btnFridge_Click);
            // 
            // panelStep
            // 
            this.panelStep.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelStep.Appearance.BackColor")));
            this.panelStep.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("panelStep.Appearance.BackColor2")));
            this.panelStep.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("panelStep.Appearance.Font")));
            this.panelStep.Appearance.Options.UseBackColor = true;
            this.panelStep.Appearance.Options.UseFont = true;
            this.panelStep.Controls.Add(this.btnReport);
            this.panelStep.Controls.Add(this.btnEnvironment);
            this.panelStep.Controls.Add(this.btnFridge);
            this.panelStep.Controls.Add(this.btnStatisticalItems);
            this.panelStep.Controls.Add(this.btnHotStage);
            this.panelStep.Controls.Add(this.btnTemperatureLowering);
            this.panelStep.Controls.Add(this.btnIncubator);
            this.panelStep.Controls.Add(this.btnAirConditioner);
            resources.ApplyResources(this.panelStep, "panelStep");
            this.panelStep.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panelStep.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panelStep.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelStep.Name = "panelStep";
            // 
            // btnReport
            // 
            resources.ApplyResources(this.btnReport, "btnReport");
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.Name = "btnReport";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEnvironment
            // 
            resources.ApplyResources(this.btnEnvironment, "btnEnvironment");
            this.btnEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvironment.FlatAppearance.BorderSize = 0;
            this.btnEnvironment.Name = "btnEnvironment";
            this.btnEnvironment.UseVisualStyleBackColor = false;
            this.btnEnvironment.Click += new System.EventHandler(this.btnEnvironment_Click);
            // 
            // btnStatisticalItems
            // 
            resources.ApplyResources(this.btnStatisticalItems, "btnStatisticalItems");
            this.btnStatisticalItems.BackColor = System.Drawing.Color.Transparent;
            this.btnStatisticalItems.FlatAppearance.BorderSize = 0;
            this.btnStatisticalItems.Name = "btnStatisticalItems";
            this.btnStatisticalItems.UseVisualStyleBackColor = false;
            this.btnStatisticalItems.Click += new System.EventHandler(this.btnStatisticalItems_Click);
            // 
            // btnHotStage
            // 
            resources.ApplyResources(this.btnHotStage, "btnHotStage");
            this.btnHotStage.BackColor = System.Drawing.Color.Transparent;
            this.btnHotStage.FlatAppearance.BorderSize = 0;
            this.btnHotStage.Name = "btnHotStage";
            this.btnHotStage.UseVisualStyleBackColor = false;
            this.btnHotStage.Click += new System.EventHandler(this.btnHotStage_Click);
            // 
            // btnTemperatureLowering
            // 
            resources.ApplyResources(this.btnTemperatureLowering, "btnTemperatureLowering");
            this.btnTemperatureLowering.BackColor = System.Drawing.Color.Transparent;
            this.btnTemperatureLowering.FlatAppearance.BorderSize = 0;
            this.btnTemperatureLowering.Name = "btnTemperatureLowering";
            this.btnTemperatureLowering.UseVisualStyleBackColor = false;
            this.btnTemperatureLowering.Click += new System.EventHandler(this.btnTemperatureLowering_Click);
            // 
            // btnIncubator
            // 
            resources.ApplyResources(this.btnIncubator, "btnIncubator");
            this.btnIncubator.BackColor = System.Drawing.Color.Transparent;
            this.btnIncubator.FlatAppearance.BorderSize = 0;
            this.btnIncubator.Name = "btnIncubator";
            this.btnIncubator.UseVisualStyleBackColor = false;
            this.btnIncubator.Click += new System.EventHandler(this.btnIncubator_Click);
            // 
            // btnAirConditioner
            // 
            resources.ApplyResources(this.btnAirConditioner, "btnAirConditioner");
            this.btnAirConditioner.BackColor = System.Drawing.Color.Transparent;
            this.btnAirConditioner.FlatAppearance.BorderSize = 0;
            this.btnAirConditioner.Name = "btnAirConditioner";
            this.btnAirConditioner.UseVisualStyleBackColor = false;
            this.btnAirConditioner.Click += new System.EventHandler(this.btnAirConditioner_Click);
            // 
            // panelIncubator
            // 
            resources.ApplyResources(this.panelIncubator, "panelIncubator");
            this.panelIncubator.Name = "panelIncubator";
            // 
            // panelHotStage
            // 
            resources.ApplyResources(this.panelHotStage, "panelHotStage");
            this.panelHotStage.Name = "panelHotStage";
            // 
            // panelTemperatureLowering
            // 
            resources.ApplyResources(this.panelTemperatureLowering, "panelTemperatureLowering");
            this.panelTemperatureLowering.Name = "panelTemperatureLowering";
            // 
            // panelAirConditioner
            // 
            resources.ApplyResources(this.panelAirConditioner, "panelAirConditioner");
            this.panelAirConditioner.Name = "panelAirConditioner";
            // 
            // panelStatisticalItems
            // 
            resources.ApplyResources(this.panelStatisticalItems, "panelStatisticalItems");
            this.panelStatisticalItems.Name = "panelStatisticalItems";
            // 
            // panelFridge
            // 
            resources.ApplyResources(this.panelFridge, "panelFridge");
            this.panelFridge.Name = "panelFridge";
            // 
            // panelEnvironment
            // 
            resources.ApplyResources(this.panelEnvironment, "panelEnvironment");
            this.panelEnvironment.Name = "panelEnvironment";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.panelIncubator);
            this.tabControl1.Controls.Add(this.panelHotStage);
            this.tabControl1.Controls.Add(this.panelTemperatureLowering);
            this.tabControl1.Controls.Add(this.panelAirConditioner);
            this.tabControl1.Controls.Add(this.panelStatisticalItems);
            this.tabControl1.Controls.Add(this.panelFridge);
            this.tabControl1.Controls.Add(this.panelEnvironment);
            this.tabControl1.Controls.Add(this.panelReport);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.panelIncubator,
            this.panelHotStage,
            this.panelTemperatureLowering,
            this.panelFridge,
            this.panelAirConditioner,
            this.panelEnvironment,
            this.panelStatisticalItems,
            this.panelReport});
            this.tabControl1.SelectedPage = this.panelHotStage;
            // 
            // panelReport
            // 
            resources.ApplyResources(this.panelReport, "panelReport");
            this.panelReport.Name = "panelReport";
            // 
            // panel1
            // 
            this.panel1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panel1.Appearance.BackColor")));
            this.panel1.Appearance.BackColor2 = ((System.Drawing.Color)(resources.GetObject("panel1.Appearance.BackColor2")));
            this.panel1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Appearance.Font")));
            this.panel1.Appearance.Options.UseBackColor = true;
            this.panel1.Appearance.Options.UseFont = true;
            this.panel1.Controls.Add(this.panelStep);
            this.panel1.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panel1.Name = "panel1";
            // 
            // ReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelStep)).EndInit();
            this.panelStep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFridge;
        private DevExpress.XtraEditors.PanelControl panelStep;
        private System.Windows.Forms.Button btnEnvironment;
        private System.Windows.Forms.Button btnStatisticalItems;
        private System.Windows.Forms.Button btnHotStage;
        private System.Windows.Forms.Button btnTemperatureLowering;
        private System.Windows.Forms.Button btnIncubator;
        private System.Windows.Forms.Button btnAirConditioner;
        private DevExpress.XtraBars.Navigation.NavigationPage panelIncubator;
        private DevExpress.XtraBars.Navigation.NavigationPage panelHotStage;
        private DevExpress.XtraBars.Navigation.NavigationPage panelTemperatureLowering;
        private DevExpress.XtraBars.Navigation.NavigationPage panelAirConditioner;
        private DevExpress.XtraBars.Navigation.NavigationPage panelStatisticalItems;
        private DevExpress.XtraBars.Navigation.NavigationPage panelFridge;
        private DevExpress.XtraBars.Navigation.NavigationPage panelEnvironment;
        private DevExpress.XtraBars.Navigation.NavigationFrame tabControl1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private System.Windows.Forms.Button btnReport;
        private DevExpress.XtraBars.Navigation.NavigationPage panelReport;
    }
}