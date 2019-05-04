namespace EmbryoExpress.UI
{
    partial class EditTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.lblOwner = new DevComponents.DotNetBar.LabelX();
            this.lblAssignTo = new DevComponents.DotNetBar.LabelX();
            this.cmbAssignTo = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInputStart = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dateTimeInputDue = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDueDate = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPriority = new DevComponents.DotNetBar.LabelX();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblSubject = new DevComponents.DotNetBar.LabelX();
            this.txtSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dateTimeInputReminder = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chbReminder = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.progressBarComplete = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputReminder)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOwner
            // 
            this.cmbOwner.FormattingEnabled = true;
            resources.ApplyResources(this.cmbOwner, "cmbOwner");
            this.cmbOwner.Name = "cmbOwner";
            // 
            // lblOwner
            // 
            // 
            // 
            // 
            this.lblOwner.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblOwner, "lblOwner");
            this.lblOwner.Name = "lblOwner";
            // 
            // lblAssignTo
            // 
            // 
            // 
            // 
            this.lblAssignTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblAssignTo, "lblAssignTo");
            this.lblAssignTo.Name = "lblAssignTo";
            // 
            // cmbAssignTo
            // 
            this.cmbAssignTo.FormattingEnabled = true;
            resources.ApplyResources(this.cmbAssignTo, "cmbAssignTo");
            this.cmbAssignTo.Name = "cmbAssignTo";
            // 
            // lblStartDate
            // 
            // 
            // 
            // 
            this.lblStartDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblStartDate, "lblStartDate");
            this.lblStartDate.Name = "lblStartDate";
            // 
            // dateTimeInputStart
            // 
            // 
            // 
            // 
            this.dateTimeInputStart.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputStart.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputStart.ButtonDropDown.Visible = true;
            this.dateTimeInputStart.IsPopupCalendarOpen = false;
            resources.ApplyResources(this.dateTimeInputStart, "dateTimeInputStart");
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputStart.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputStart.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputStart.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dateTimeInputStart.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputStart.MonthCalendar.MarkedDates")));
            this.dateTimeInputStart.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputStart.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputStart.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputStart.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputStart.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("dateTimeInputStart.MonthCalendar.WeeklyMarkedDays")));
            this.dateTimeInputStart.Name = "dateTimeInputStart";
            this.dateTimeInputStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // dateTimeInputDue
            // 
            // 
            // 
            // 
            this.dateTimeInputDue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputDue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputDue.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputDue.ButtonDropDown.Visible = true;
            this.dateTimeInputDue.IsPopupCalendarOpen = false;
            resources.ApplyResources(this.dateTimeInputDue, "dateTimeInputDue");
            // 
            // 
            // 
            this.dateTimeInputDue.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputDue.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputDue.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputDue.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputDue.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputDue.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputDue.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dateTimeInputDue.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputDue.MonthCalendar.MarkedDates")));
            this.dateTimeInputDue.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputDue.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputDue.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputDue.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputDue.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputDue.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputDue.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputDue.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("dateTimeInputDue.MonthCalendar.WeeklyMarkedDays")));
            this.dateTimeInputDue.Name = "dateTimeInputDue";
            this.dateTimeInputDue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // lblDueDate
            // 
            // 
            // 
            // 
            this.lblDueDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblDueDate, "lblDueDate");
            this.lblDueDate.Name = "lblDueDate";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cmbStatus, "cmbStatus");
            this.cmbStatus.Name = "cmbStatus";
            // 
            // lblPriority
            // 
            // 
            // 
            // 
            this.lblPriority.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblPriority, "lblPriority");
            this.lblPriority.Name = "lblPriority";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPriority, "cmbPriority");
            this.cmbPriority.Name = "cmbPriority";
            // 
            // lblSubject
            // 
            // 
            // 
            // 
            this.lblSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.Name = "lblSubject";
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.Border.Class = "TextBoxBorder";
            this.txtSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.txtSubject, "txtSubject");
            this.txtSubject.Name = "txtSubject";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            // 
            // dateTimeInputReminder
            // 
            // 
            // 
            // 
            this.dateTimeInputReminder.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInputReminder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputReminder.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInputReminder.ButtonDropDown.Visible = true;
            this.dateTimeInputReminder.IsPopupCalendarOpen = false;
            resources.ApplyResources(this.dateTimeInputReminder, "dateTimeInputReminder");
            // 
            // 
            // 
            this.dateTimeInputReminder.MonthCalendar.AnnuallyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputReminder.MonthCalendar.AnnuallyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputReminder.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputReminder.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimeInputReminder.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInputReminder.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputReminder.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dateTimeInputReminder.MonthCalendar.MarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputReminder.MonthCalendar.MarkedDates")));
            this.dateTimeInputReminder.MonthCalendar.MonthlyMarkedDates = ((System.DateTime[])(resources.GetObject("dateTimeInputReminder.MonthCalendar.MonthlyMarkedDates")));
            // 
            // 
            // 
            this.dateTimeInputReminder.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInputReminder.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInputReminder.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInputReminder.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimeInputReminder.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInputReminder.MonthCalendar.WeeklyMarkedDays = ((System.DayOfWeek[])(resources.GetObject("dateTimeInputReminder.MonthCalendar.WeeklyMarkedDays")));
            this.dateTimeInputReminder.Name = "dateTimeInputReminder";
            this.dateTimeInputReminder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.Name = "labelX3";
            // 
            // chbReminder
            // 
            // 
            // 
            // 
            this.chbReminder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.chbReminder, "chbReminder");
            this.chbReminder.Name = "chbReminder";
            this.chbReminder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX4, "labelX4");
            this.labelX4.Name = "labelX4";
            // 
            // progressBarComplete
            // 
            // 
            // 
            // 
            this.progressBarComplete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.progressBarComplete, "progressBarComplete");
            this.progressBarComplete.Name = "progressBarComplete";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // EditTaskForm
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.progressBarComplete);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.chbReminder);
            this.Controls.Add(this.dateTimeInputReminder);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dateTimeInputDue);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dateTimeInputStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.cmbAssignTo);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.cmbOwner);
            this.Name = "EditTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInputReminder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOwner;
        private DevComponents.DotNetBar.LabelX lblOwner;
        private DevComponents.DotNetBar.LabelX lblAssignTo;
        private System.Windows.Forms.ComboBox cmbAssignTo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblStartDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputStart;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputDue;
        private DevComponents.DotNetBar.LabelX lblDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private DevComponents.DotNetBar.LabelX lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private DevComponents.DotNetBar.LabelX lblSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSubject;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInputReminder;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbReminder;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarComplete;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
    }
}