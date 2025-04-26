using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//由于窗口的初始化只能在Form1.cs中执行，目前用不上
namespace MyTaskManager
{
    internal class Init
    {
        public static void Initialize(TaskManager taskManager, ListBox taskListBox, DateTime selectedDate)
        {
            taskManager.ListInitialize();  // 数据库初始化

            List<MyTask> tasks = taskManager.GetTasksByDate(selectedDate);

            // 绑定任务到 ListBox
            taskListBox.DataSource = null;
            taskListBox.DataSource = tasks;
            taskListBox.DisplayMember = "ToString"; // 用 MyTask 的 ToString() 方法显示文本
        }
    }
}
