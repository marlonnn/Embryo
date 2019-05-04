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
        public List<Tasks.Task> TaskList
        {
            set
            {
                this.taskList = value;
                SetDataSource();
            }
        }
        private BindingSource bindingSource;
        public TasksControl()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
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
            TaskList = taskManager.AllTasks;
        }

        private void SetDataSource()
        {
            bindingSource.DataSource = taskList;
            gridControl.DataSource = bindingSource;
        }

        private void btnAllTasks_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks;
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Complete != 100).ToList();
        }

        private void btnNotStarted_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Complete == 0).ToList();
        }

        private void btnDeferred_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Complete != 100).ToList();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Complete == 100).ToList();
        }

        private void btnHighPriority_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Priority == Tasks.Priority.High).ToList();
        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {
            TaskList = taskManager.AllTasks.Where(t => t.Priority == Tasks.Priority.Urgent).ToList();
        }
    }
}
