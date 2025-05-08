using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTaskManager
{
    internal class TaskManager
    {
        private List<MyTask> _tasks;

        public TaskManager()
        {
            _tasks = new List<MyTask>();
        }

        // 从数据库初始化任务列表
        public void ListInitialize()
        {
            TaskDatabaseHelper.InitializeDatabase();//初始化数据库
            _tasks = TaskDatabaseHelper.GetAllTasks();
            // 生成一些测试任务，仅用于测试
            /*
            _tasks = new List<MyTask>
            {
                new MyTask("写周报", DateTime.Today, "每周五要写", PriorityLevel.High, DateTime.Now.AddMinutes(10)),
                new MyTask("背单词", DateTime.Today, "英语四级词汇", PriorityLevel.Medium),
                new MyTask("锻炼身体", DateTime.Today, "30分钟跑步", PriorityLevel.Low),
                new MyTask("学习WPF", DateTime.Today, "继续完善任务管理系统", PriorityLevel.High),
                new MyTask("看电影", DateTime.Today.AddDays(-1), "放松一下", PriorityLevel.Low)
            };
            */
        }

        // 添加任务
        public bool AddTask(MyTask task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            _tasks.Add(task);

            //            // 调试输出，查看添加后的任务列表
            foreach (var Mytask in _tasks)
            {
                Console.WriteLine($"[调试] 添加后任务：{task.Name}, {task.CreateDate}, {task.IsCompleted}");
            }

            return true;
        }

        // 删除任务
        public bool RemoveTask(MyTask task)
        {
            if (task == null)
                return false;

            _tasks.Remove(task);
            return true;
        }

        // 更新任务
        public bool UpdateTask(MyTask TheTask)
        {


            // 更新任务属性


            return true;
        }

        //获取所有任务
        public List<MyTask> GetAllTasks()
        {
            return _tasks;
        }

        // 查询任务
        public List<MyTask> GetTasksByDate(DateTime date)//Linq语句
        {
            return _tasks
                .Where(t => t.CreateDate.Date == date.Date)
                .OrderByDescending(t => t.IsCompleted)
                .OrderByDescending(t => t.Priority) // 按优先级排序
                .ThenBy(t => t.Name)      // 名字排序
                .ToList();
        }

        //数据库保存
        public void SaveTasks()
        {
            TaskDatabaseHelper.SaveAllTasks(_tasks);
        }
    }
}
