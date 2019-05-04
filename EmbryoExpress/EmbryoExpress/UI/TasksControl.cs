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

namespace EmbryoExpress.UI
{
    public partial class TasksControl : UserControl
    {
        private string[] captions;

        private string[] fildNames;
        private TaskManager taskManager;
        public TasksControl()
        {
            InitializeComponent();
            captions = new string[]
            {
                Properties.Resources.StrAssignTo,
                Properties.Resources.StrOwnedBy,
                Properties.Resources.StrSubject,
                Properties.Resources.StrPriority,
                Properties.Resources.StrEndTime,
                Properties.Resources.StrComplete
            };
            fildNames = new string[]
            {
                "AssignTo",
                "OwnedBy",
                "Subject",
                "Priority",
                "EndTime",
                "Complete"
            };
            taskManager = TaskManager.GetTaskManager();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            taskManager.SimulatorData();

            //InitializeGridControl();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = taskManager.AllTasks;

            gridControl.DataSource = bindingSource;
        }

        //private void InitializeGridControl()
        //{
        //    for (int i=0; i< captions.Length; i++)
        //    {
        //        var gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
        //        string caption = captions[i];
        //        gridColumn.FieldName = fildNames[i];
        //        gridColumn.Caption = caption;
        //        //gridColumn.DisplayFormat.FormatType = NovoplexResultPerAnalyteTable.GetColumnFormatType(fieldName);
        //        //gridColumn.DisplayFormat.FormatString = NovoplexResultPerAnalyteTable.GetColumnFormatString(fieldName);
        //        gridColumn.VisibleIndex = i;
        //        gridColumn.BestFit();
        //        gridColumn.MinWidth = 100;
        //        gridView1.Columns.Add(gridColumn);
        //    }

        //    gridView1.OptionsView.ColumnAutoWidth = false;
        //    var bindingSource = new BindingSource();
        //    bindingSource.DataSource = taskManager.AllTasks;

        //    gridControl1.DataSource = bindingSource;
        //}
    }
}
