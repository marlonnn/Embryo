using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmbryoExpress.ExtensionMethods;

namespace EmbryoExpress.Tasks
{
    [LocalizedResource(typeof(Res.Instrument))]
    public enum Priority
    {
        [LocalizedDescription("StrLow")]
        Low,
        [LocalizedDescription("StrNormal")]
        Normal,
        [LocalizedDescription("StrHigh")]
        High,
        [LocalizedDescription("StrUrgent")]
        Urgent
    }
    public class Task
    {
        private string assignTo;
        public string AssignTo
        {
            get { return this.assignTo; }
            set { this.assignTo = value; }
        }

        private string ownedBy;
        public string OwnedBy
        {
            get { return this.ownedBy; }
            set { this.ownedBy = value; }
        }

        private string subject;
        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        //private string description;
        //public string Description
        //{
        //    get { return this.description; }
        //    set { this.description = value; }
        //}

        private Priority priority;
        public Priority Priority
        {
            get { return this.priority; }
            set { this.priority = value; }
        }

        //private DateTime startTime;
        //public DateTime StartTime
        //{
        //    get { return this.startTime; }
        //    set { this.startTime = value; }
        //}

        private DateTime endTime;
        public DateTime EndTime
        {
            get { return this.endTime; }
            set { this.endTime = value; }
        }

        private int complete;
        public int Complete
        {
            get { return this.complete; }
            set { this.complete = value; }
        }

        public Task() { }
        public Task(string assignTo, string ownedBy, string subject, /*string description, */Priority priority,
            /*DateTime startTime, */DateTime endTime, int complete)
        {
            this.assignTo = assignTo;
            this.ownedBy = ownedBy;
            this.subject = subject;
            //this.description = description;
            this.priority = priority;
            //this.startTime = startTime;
            this.endTime = endTime;
            this.complete = complete;
        }
    }
}
