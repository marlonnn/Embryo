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
            string operationType = "";
            for (int i=0; i< 50; i++)
            {
                string assignTo = "";
                Priority priority = Priority.Low;
                int complete = 0;
                if (i < 5)
                {
                    assignTo = "钟文";
                    priority = Priority.Low;
                    complete = 100;
                    operationType = OperationType.Degranulation.ToDescription();
                }
                else if (i >= 5 && i < 10)
                {
                    assignTo = "郭荣";
                    priority = Priority.Normal;
                    complete = 20;
                    operationType = OperationType.FrozenEmbryo.ToDescription();
                }
                else if (i >= 10 && i < 15)
                {
                    assignTo = "谢波";
                    priority = Priority.High;
                    complete = 35;
                    operationType = OperationType.PickingEgg.ToDescription();
                }
                else if (i >= 15 && i < 20)
                {
                    assignTo = "袁松";
                    priority = Priority.Urgent;
                    complete = 55;
                    operationType = OperationType.SelectionEmbryo.ToDescription();
                }
                else if (i >= 20 && i < 25)
                {
                    assignTo = "李四";
                    priority = Priority.Low;
                    complete = 0;
                    operationType = OperationType.ThawedEmbryo.ToDescription();
                }
                else if (i >= 25 && i < 30)
                {
                    assignTo = "张三";
                    priority = Priority.Normal;
                    complete = 0;
                    operationType = OperationType.TransferEmbryo.ToDescription();
                }
                else if (i >= 30 && i < 35)
                {
                    assignTo = "宋江";
                    priority = Priority.Normal;
                    complete = 36;
                    operationType = OperationType.Degranulation.ToDescription();
                }
                else if (i >= 35 && i < 40)
                {
                    assignTo = "李俊";
                    priority = Priority.High;
                    complete = 78;
                    operationType = OperationType.FrozenEmbryo.ToDescription();
                }
                else if (i >= 40 && i < 45)
                {
                    assignTo = "李逵";
                    priority = Priority.High;
                    complete = 66;
                    operationType = OperationType.PickingEgg.ToDescription();
                }
                else if (i >= 45 && i < 50)
                {
                    assignTo = "武松";
                    priority = Priority.Urgent;
                    complete = 88;
                    operationType = OperationType.TransferEmbryo.ToDescription();
                }
                Task task = new Task(assignTo, "管理员", operationType, priority, dateTime, complete);
                taskList.Add(task);
            }
        }
    }
}
