namespace EmbryoExpress.UI
{
    partial class TasksControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUrgent = new DevComponents.DotNetBar.ButtonX();
            this.btnHighPriority = new DevComponents.DotNetBar.ButtonX();
            this.btnCompleted = new DevComponents.DotNetBar.ButtonX();
            this.btnDeferred = new DevComponents.DotNetBar.ButtonX();
            this.btnNotStarted = new DevComponents.DotNetBar.ButtonX();
            this.btnInProgress = new DevComponents.DotNetBar.ButtonX();
            this.btnAllTasks = new DevComponents.DotNetBar.ButtonX();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AssignTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Priority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Completion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUrgent);
            this.panel1.Controls.Add(this.btnHighPriority);
            this.panel1.Controls.Add(this.btnCompleted);
            this.panel1.Controls.Add(this.btnDeferred);
            this.panel1.Controls.Add(this.btnNotStarted);
            this.panel1.Controls.Add(this.btnInProgress);
            this.panel1.Controls.Add(this.btnAllTasks);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnUrgent
            // 
            this.btnUrgent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUrgent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnUrgent, "btnUrgent");
            this.btnUrgent.Name = "btnUrgent";
            this.btnUrgent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnHighPriority
            // 
            this.btnHighPriority.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHighPriority.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnHighPriority, "btnHighPriority");
            this.btnHighPriority.Name = "btnHighPriority";
            this.btnHighPriority.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnCompleted
            // 
            this.btnCompleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnCompleted, "btnCompleted");
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnDeferred
            // 
            this.btnDeferred.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeferred.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnDeferred, "btnDeferred");
            this.btnDeferred.Name = "btnDeferred";
            this.btnDeferred.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnNotStarted
            // 
            this.btnNotStarted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNotStarted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnNotStarted, "btnNotStarted");
            this.btnNotStarted.Name = "btnNotStarted";
            this.btnNotStarted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnInProgress
            // 
            this.btnInProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInProgress.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnInProgress, "btnInProgress");
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllTasks.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnAllTasks, "btnAllTasks");
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // gridControl
            // 
            resources.ApplyResources(this.gridControl, "gridControl");
            this.gridControl.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.gridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AssignTo,
            this.OwnedBy,
            this.Subject,
            this.Priority,
            this.DueDate,
            this.Completion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.FooterPanelHeight = 60;
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 10;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DueDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // AssignTo
            // 
            resources.ApplyResources(this.AssignTo, "AssignTo");
            this.AssignTo.Name = "AssignTo";
            // 
            // OwnedBy
            // 
            resources.ApplyResources(this.OwnedBy, "OwnedBy");
            this.OwnedBy.Name = "OwnedBy";
            // 
            // Subject
            // 
            resources.ApplyResources(this.Subject, "Subject");
            this.Subject.Name = "Subject";
            // 
            // Priority
            // 
            resources.ApplyResources(this.Priority, "Priority");
            this.Priority.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("Priority.ImageOptions.Alignment")));
            this.Priority.Name = "Priority";
            // 
            // DueDate
            // 
            resources.ApplyResources(this.DueDate, "DueDate");
            this.DueDate.Name = "DueDate";
            // 
            // Completion
            // 
            resources.ApplyResources(this.Completion, "Completion");
            this.Completion.Name = "Completion";
            this.Completion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("Completion.Summary"))), resources.GetString("Completion.Summary1"), resources.GetString("Completion.Summary2"))});
            // 
            // TasksControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.Name = "TasksControl";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnAllTasks;
        private DevComponents.DotNetBar.ButtonX btnInProgress;
        private DevComponents.DotNetBar.ButtonX btnNotStarted;
        private DevComponents.DotNetBar.ButtonX btnDeferred;
        private DevComponents.DotNetBar.ButtonX btnCompleted;
        private DevComponents.DotNetBar.ButtonX btnUrgent;
        private DevComponents.DotNetBar.ButtonX btnHighPriority;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn AssignTo;
        private DevExpress.XtraGrid.Columns.GridColumn OwnedBy;
        private DevExpress.XtraGrid.Columns.GridColumn Subject;
        private DevExpress.XtraGrid.Columns.GridColumn Priority;
        private DevExpress.XtraGrid.Columns.GridColumn DueDate;
        private DevExpress.XtraGrid.Columns.GridColumn Completion;
    }
}
