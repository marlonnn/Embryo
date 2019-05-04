using DevComponents.DotNetBar;
using EmbryoExpress.Instrument;
using EmbryoExpress.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmbryoExpress.UI
{
    public partial class EditTaskForm : ChildForm
    {
        private Task task;
        public EditTaskForm()
        {
            InitializeComponent();
        }

        public EditTaskForm(Task task) : this()
        {
            this.task = task;
            Initialize();
        }

        private void Initialize()
        {
            this.cmbOwner.Items.Add("管理员");
            this.cmbOwner.SelectedIndex = 0;

            InitializePriority();
            InitializeAssignedTo();
            InitializeStatus();

            this.dateTimeInputDue.Value = task.EndTime;
            this.txtSubject.Text = task.Subject;
            this.progressBarComplete.Value = task.Complete;
        }

        private void InitializeStatus()
        {
            this.cmbStatus.Items.Add(Status.NotStarted.ToDescription());
            this.cmbStatus.Items.Add(Status.Completed.ToDescription());
            this.cmbStatus.Items.Add(Status.InProgress.ToDescription());
            this.cmbStatus.Items.Add(Status.Deferred.ToDescription());
            this.cmbStatus.SelectedIndex = GetStatusSelectIndex();
        }

        private int GetStatusSelectIndex()
        {
            int index = 0;
            if (task.Complete == 100)
            {
                index = 1;
            }
            else if (task.Complete == 0)
            {
                index = 0;
            }
            else
            {
                index = 2;
            }
            return index;
        }

        private void InitializeAssignedTo()
        {
            this.cmbAssignTo.Items.AddRange(TaskManager.AssignTo);
            this.cmbAssignTo.SelectedItem = task.AssignTo;
        }

        private void InitializePriority()
        {
            this.cmbPriority.Items.Add(Priority.Low.ToDescription());
            this.cmbPriority.Items.Add(Priority.Normal.ToDescription());
            this.cmbPriority.Items.Add(Priority.High.ToDescription());
            this.cmbPriority.Items.Add(Priority.Urgent.ToDescription());
            this.cmbPriority.SelectedItem = task.Priority.ToDescription();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
