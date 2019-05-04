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
        private List<Tasks.Task> taskList;
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
            taskList = taskManager.AllTasks;
            var bindingSource = new BindingSource();
            bindingSource.DataSource = taskList;

            gridControl.DataSource = bindingSource;
        }

        private void btnAllTasks_Click(object sender, EventArgs e)
        {

        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {

        }

        private void btnNotStarted_Click(object sender, EventArgs e)
        {

        }

        private void btnDeferred_Click(object sender, EventArgs e)
        {

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {

        }

        private void btnHighPriority_Click(object sender, EventArgs e)
        {

        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {

        }
    }
}
