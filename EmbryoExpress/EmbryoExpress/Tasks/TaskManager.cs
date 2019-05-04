using EmbryoExpress.Instrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Tasks
{
    public class TaskManager
    {
        private List<Task> taskList;
        public List<Task> AllTasks
        {
            get { return this.taskList; }
        }

        private static TaskManager instance;

        public static TaskManager GetTaskManager()
        {
            if (instance == null)
            {
                instance = new TaskManager();
            }
            return instance;
        }

        public TaskManager()
        {
            taskList = new List<Task>();
        }

        public List<Task> GetAllTasks()
        {
            return this.taskList;
        }

        private OperationType GetOperationType(int index)
        {
            OperationType operationType = OperationType.TransferEmbryo;
            switch (index)
            {
                case 0:
                    operationType = OperationType.PickingEgg;
                    break;
                case 1:
                    operationType = OperationType.SelectionEmbryo;
                    break;
                case 2:
                    operationType = OperationType.Degranulation;
                    break;
                case 3:
                    operationType = OperationType.FrozenEmbryo;
                    break;
                case 4:
                    operationType = OperationType.ThawedEmbryo;
                    break;
                case 5:
                    operationType = OperationType.TransferEmbryo;
                    break;
            }
            return operationType;
        }

        public void SimulatorData()
        {
            DateTime dateTime = DateTime.Now;
            for (int i=0; i< 30; i++)
            {
                string assignTo = "";
                Priority priority = Priority.Low;
                if (i < 5)
                {
                    assignTo = "钟文";
                    priority = Priority.High;
                }
                else if (i >= 5 && i < 10)
                {
                    assignTo = "郭荣";
                    priority = Priority.Low;
                }
                else if (i >= 10 && i < 15)
                {
                    assignTo = "谢波";
                    priority = Priority.Normal;
                }
                else if (i >= 15 && i < 20)
                {
                    assignTo = "袁松";
                    priority = Priority.Urgent;
                }
                else if (i >= 20 && i < 25)
                {
                    assignTo = "李四";
                    priority = Priority.Urgent;
                }
                else if (i >= 25 && i < 30)
                {
                    assignTo = "张三";
                    priority = Priority.Normal;
                }
                OperationType operationType = GetOperationType(i / 2);
                Task task = new Task(assignTo, "管理员", operationType.ToDescription(),
                    priority, dateTime.AddHours(i * 2)/*, dateTime.AddHours((i + 1) * 2)*/, (i / 3 * 10));
                taskList.Add(task);
            }
        }
    }
}
