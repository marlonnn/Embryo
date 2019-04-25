namespace EmbryoExpress.UI
{
    partial class ProblemReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemReportForm));
            this.wizard = new DevComponents.DotNetBar.Wizard();
            this.pageWelcome = new DevComponents.DotNetBar.WizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageInputDescription = new DevComponents.DotNetBar.WizardPage();
            this.labelDescription = new DevComponents.DotNetBar.LabelX();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pageSelectFiles = new DevComponents.DotNetBar.WizardPage();
            this.buttonRemove = new DevComponents.DotNetBar.ButtonX();
            this.buttonAdd = new DevComponents.DotNetBar.ButtonX();
            this.labelAttachFile = new DevComponents.DotNetBar.LabelX();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.pageCreating = new DevComponents.DotNetBar.WizardPage();
            this.labelCreating = new DevComponents.DotNetBar.LabelX();
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.pageFinish = new DevComponents.DotNetBar.WizardPage();
            this.labelSuccess = new DevComponents.DotNetBar.LabelX();
            this.checkBoxOpenContainer = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.wizard.SuspendLayout();
            this.pageWelcome.SuspendLayout();
            this.pageInputDescription.SuspendLayout();
            this.pageSelectFiles.SuspendLayout();
            this.pageCreating.SuspendLayout();
            this.pageFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            resources.ApplyResources(this.wizard, "wizard");
            this.wizard.ButtonStyle = DevComponents.DotNetBar.eWizardStyle.Office2007;
            this.wizard.Cursor = System.Windows.Forms.Cursors.Default;
            this.wizard.FinishButtonTabIndex = 3;
            // 
            // 
            // 
            this.wizard.FooterStyle.BackColor = System.Drawing.Color.Transparent;
            this.wizard.FooterStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.wizard.HeaderCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizard.HeaderDescriptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizard.HeaderDescriptionIndent = 62;
            this.wizard.HeaderDescriptionVisible = false;
            this.wizard.HeaderHeight = 70;
            this.wizard.HeaderImage = global::EmbryoExpress.Properties.Resources.problem_report;
            this.wizard.HeaderImageAlignment = DevComponents.DotNetBar.eWizardTitleImageAlignment.Left;
            // 
            // 
            // 
            this.wizard.HeaderStyle.BackColor = System.Drawing.Color.Transparent;
            this.wizard.HeaderStyle.BackColorGradientAngle = 90;
            this.wizard.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.wizard.HeaderStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(157)))), ((int)(((byte)(182)))));
            this.wizard.HeaderStyle.BorderBottomWidth = 1;
            this.wizard.HeaderStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.wizard.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.wizard.HeaderTitleIndent = 62;
            this.wizard.HelpButtonVisible = false;
            this.wizard.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.wizard.Name = "wizard";
            this.wizard.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.pageWelcome,
            this.pageInputDescription,
            this.pageSelectFiles,
            this.pageCreating,
            this.pageFinish});
            this.wizard.WizardPageChanged += new DevComponents.DotNetBar.WizardPageChangeEventHandler(this.wizard_WizardPageChanged);
            // 
            // pageWelcome
            // 
            resources.ApplyResources(this.pageWelcome, "pageWelcome");
            this.pageWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pageWelcome.Controls.Add(this.label1);
            this.pageWelcome.Controls.Add(this.label2);
            this.pageWelcome.Controls.Add(this.label3);
            this.pageWelcome.InteriorPage = false;
            this.pageWelcome.Name = "pageWelcome";
            // 
            // 
            // 
            this.pageWelcome.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageWelcome.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageWelcome.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // pageInputDescription
            // 
            resources.ApplyResources(this.pageInputDescription, "pageInputDescription");
            this.pageInputDescription.AntiAlias = false;
            this.pageInputDescription.BackColor = System.Drawing.Color.Transparent;
            this.pageInputDescription.Controls.Add(this.labelDescription);
            this.pageInputDescription.Controls.Add(this.textBoxDescription);
            this.pageInputDescription.Name = "pageInputDescription";
            // 
            // 
            // 
            this.pageInputDescription.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageInputDescription.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageInputDescription.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelDescription
            // 
            // 
            // 
            // 
            this.labelDescription.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            // 
            // pageSelectFiles
            // 
            resources.ApplyResources(this.pageSelectFiles, "pageSelectFiles");
            this.pageSelectFiles.AntiAlias = false;
            this.pageSelectFiles.BackColor = System.Drawing.Color.Transparent;
            this.pageSelectFiles.Controls.Add(this.buttonRemove);
            this.pageSelectFiles.Controls.Add(this.buttonAdd);
            this.pageSelectFiles.Controls.Add(this.labelAttachFile);
            this.pageSelectFiles.Controls.Add(this.listViewFiles);
            this.pageSelectFiles.Name = "pageSelectFiles";
            // 
            // 
            // 
            this.pageSelectFiles.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageSelectFiles.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageSelectFiles.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonRemove
            // 
            this.buttonRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelAttachFile
            // 
            // 
            // 
            // 
            this.labelAttachFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelAttachFile, "labelAttachFile");
            this.labelAttachFile.Name = "labelAttachFile";
            this.labelAttachFile.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelAttachFile.WordWrap = true;
            // 
            // listViewFiles
            // 
            resources.ApplyResources(this.listViewFiles, "listViewFiles");
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.Scrollable = true;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            // 
            // pageCreating
            // 
            resources.ApplyResources(this.pageCreating, "pageCreating");
            this.pageCreating.AntiAlias = false;
            this.pageCreating.BackColor = System.Drawing.Color.Transparent;
            this.pageCreating.Controls.Add(this.labelCreating);
            this.pageCreating.Controls.Add(this.progressBar);
            this.pageCreating.Name = "pageCreating";
            this.pageCreating.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            // 
            // 
            // 
            this.pageCreating.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageCreating.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageCreating.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelCreating
            // 
            // 
            // 
            // 
            this.labelCreating.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelCreating, "labelCreating");
            this.labelCreating.Name = "labelCreating";
            this.labelCreating.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelCreating.WordWrap = true;
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // pageFinish
            // 
            resources.ApplyResources(this.pageFinish, "pageFinish");
            this.pageFinish.AntiAlias = false;
            this.pageFinish.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            this.pageFinish.BackColor = System.Drawing.Color.Transparent;
            this.pageFinish.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            this.pageFinish.Controls.Add(this.labelSuccess);
            this.pageFinish.Controls.Add(this.checkBoxOpenContainer);
            this.pageFinish.Name = "pageFinish";
            // 
            // 
            // 
            this.pageFinish.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageFinish.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pageFinish.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelSuccess
            // 
            // 
            // 
            // 
            this.labelSuccess.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelSuccess, "labelSuccess");
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelSuccess.WordWrap = true;
            // 
            // checkBoxOpenContainer
            // 
            // 
            // 
            // 
            this.checkBoxOpenContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxOpenContainer.Checked = true;
            this.checkBoxOpenContainer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOpenContainer.CheckValue = "Y";
            resources.ApplyResources(this.checkBoxOpenContainer, "checkBoxOpenContainer");
            this.checkBoxOpenContainer.Name = "checkBoxOpenContainer";
            this.checkBoxOpenContainer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ProblemReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wizard);
            this.Name = "ProblemReportForm";
            this.Load += new System.EventHandler(this.ProblemReportForm_Load);
            this.wizard.ResumeLayout(false);
            this.pageWelcome.ResumeLayout(false);
            this.pageInputDescription.ResumeLayout(false);
            this.pageInputDescription.PerformLayout();
            this.pageSelectFiles.ResumeLayout(false);
            this.pageCreating.ResumeLayout(false);
            this.pageFinish.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Wizard wizard;
        private DevComponents.DotNetBar.WizardPage pageWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.WizardPage pageSelectFiles;
        private DevComponents.DotNetBar.WizardPage pageInputDescription;
        private DevComponents.DotNetBar.WizardPage pageCreating;
        private DevComponents.DotNetBar.WizardPage pageFinish;
        private System.Windows.Forms.TextBox textBoxDescription;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
        private DevComponents.DotNetBar.LabelX labelSuccess;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxOpenContainer;
        private DevComponents.DotNetBar.LabelX labelAttachFile;
        private System.Windows.Forms.ListView listViewFiles;
        private DevComponents.DotNetBar.ButtonX buttonRemove;
        private DevComponents.DotNetBar.ButtonX buttonAdd;
        private DevComponents.DotNetBar.LabelX labelDescription;
        private DevComponents.DotNetBar.LabelX labelCreating;

    }
}
