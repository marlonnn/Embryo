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
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AssignTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OwnedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Priority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.priorityImageCollection = new DevExpress.Utils.ImageCollection();
            this.DueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Completion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
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
            this.btnUrgent.Click += new System.EventHandler(this.btnUrgent_Click);
            // 
            // btnHighPriority
            // 
            this.btnHighPriority.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHighPriority.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnHighPriority, "btnHighPriority");
            this.btnHighPriority.Name = "btnHighPriority";
            this.btnHighPriority.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHighPriority.Click += new System.EventHandler(this.btnHighPriority_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCompleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnCompleted, "btnCompleted");
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnDeferred
            // 
            this.btnDeferred.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeferred.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnDeferred, "btnDeferred");
            this.btnDeferred.Name = "btnDeferred";
            this.btnDeferred.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeferred.Click += new System.EventHandler(this.btnDeferred_Click);
            // 
            // btnNotStarted
            // 
            this.btnNotStarted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNotStarted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnNotStarted, "btnNotStarted");
            this.btnNotStarted.Name = "btnNotStarted";
            this.btnNotStarted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNotStarted.Click += new System.EventHandler(this.btnNotStarted_Click);
            // 
            // btnInProgress
            // 
            this.btnInProgress.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInProgress.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnInProgress, "btnInProgress");
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAllTasks.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            resources.ApplyResources(this.btnAllTasks, "btnAllTasks");
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAllTasks.Click += new System.EventHandler(this.btnAllTasks_Click);
            // 
            // gridControl
            // 
            resources.ApplyResources(this.gridControl, "gridControl");
            this.gridControl.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridControl.EmbeddedNavigator.Margin")));
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemProgressBar1});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AssignTo,
            this.OwnedBy,
            this.Subject,
            this.Priority,
            this.DueDate,
            this.Completion});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView.FooterPanelHeight = 60;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsFind.AllowFindPanel = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowHeight = 10;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DueDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // AssignTo
            // 
            resources.ApplyResources(this.AssignTo, "AssignTo");
            this.AssignTo.FieldName = "AssignTo";
            this.AssignTo.Name = "AssignTo";
            // 
            // OwnedBy
            // 
            resources.ApplyResources(this.OwnedBy, "OwnedBy");
            this.OwnedBy.FieldName = "OwnedBy";
            this.OwnedBy.Name = "OwnedBy";
            // 
            // Subject
            // 
            this.Subject.FieldName = "Subject";
            this.Subject.Name = "Subject";
            resources.ApplyResources(this.Subject, "Subject");
            // 
            // Priority
            // 
            this.Priority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.Priority.FieldName = "Priority";
            this.Priority.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("Priority.ImageOptions.Alignment")));
            this.Priority.Name = "Priority";
            this.Priority.OptionsFilter.AllowAutoFilter = false;
            this.Priority.OptionsFilter.AllowFilter = false;
            this.Priority.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            resources.ApplyResources(this.Priority, "Priority");
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemImageComboBox1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", EmbryoExpress.Tasks.Priority.Low, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", EmbryoExpress.Tasks.Priority.Normal, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", EmbryoExpress.Tasks.Priority.High, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", EmbryoExpress.Tasks.Priority.Urgent, 3)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.PopupSizeable = true;
            this.repositoryItemImageComboBox1.SmallImages = this.priorityImageCollection;
            // 
            // priorityImageCollection
            // 
            this.priorityImageCollection.ImageSize = new System.Drawing.Size(24, 24);
            this.priorityImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("priorityImageCollection.ImageStream")));
            this.priorityImageCollection.Images.SetKeyName(0, "LowPriority.png");
            this.priorityImageCollection.Images.SetKeyName(1, "NormalPriority.png");
            this.priorityImageCollection.Images.SetKeyName(2, "MediumPriority.png");
            this.priorityImageCollection.Images.SetKeyName(3, "HighPriority.png");
            // 
            // DueDate
            // 
            this.DueDate.FieldName = "EndTime";
            this.DueDate.Name = "DueDate";
            resources.ApplyResources(this.DueDate, "DueDate");
            // 
            // Completion
            // 
            resources.ApplyResources(this.Completion, "Completion");
            this.Completion.ColumnEdit = this.repositoryItemProgressBar1;
            this.Completion.FieldName = "Complete";
            this.Completion.Name = "Completion";
            this.Completion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("Completion.Summary"))), resources.GetString("Completion.Summary1"), resources.GetString("Completion.Summary2"))});
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ProgressPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.repositoryItemProgressBar1.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.repositoryItemProgressBar1.ShowTitle = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn AssignTo;
        private DevExpress.XtraGrid.Columns.GridColumn OwnedBy;
        private DevExpress.XtraGrid.Columns.GridColumn Subject;
        private DevExpress.XtraGrid.Columns.GridColumn Priority;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection priorityImageCollection;
        private DevExpress.XtraGrid.Columns.GridColumn DueDate;
        private DevExpress.XtraGrid.Columns.GridColumn Completion;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}
