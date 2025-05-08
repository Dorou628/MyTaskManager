using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager
{
    public enum PriorityLevel
    {
        Low = 0,
        Medium,
        High
    }

    public class MyTask
    {
        public int ID { get; set; } // 唯一标识符
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime? ReminderTime { get; set; }// 提醒时间
        public string? Description { get; set; }
        public PriorityLevel? Priority { get; set; }

        public MyTask() { }//无参构造函数,数据库使用

        public MyTask(string name,DateTime createdate,//必须传入任务名和创建时间
                      string? description = null,
                      PriorityLevel? priority = null,
                      DateTime? reminderTime = null)
        {
            Name = name;
            CreateDate = createdate;
            Description = description;
            Priority = priority;
            ReminderTime = reminderTime;
        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
        public override string ToString()
        {
            return $"{Name} - 优先级: ({Priority.ToString()}) - {(IsCompleted ? "已完成" : "未完成")}";
        }
    }
}
