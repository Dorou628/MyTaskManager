using System.Media;
using TomatoClock;

namespace MyTaskManager
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();//任务管理器
        private DateTime selectedDate = DateTime.Today;//所选的日期，初始化为今天
        private System.Windows.Forms.Timer reminderTimer = new System.Windows.Forms.Timer();
        private Tomato _tomatoForm;
        private readonly ITomatoService _tomatoService;

        public Form1()
        {
            _tomatoService = new TomatoClockService();
            InitializeComponent();
            taskManager.ListInitialize();
            RefreshTaskListUI();
            InitReminderTimer();
        }

        private void RefreshTaskListUI()//根据所选日期刷新任务列表和date标签
        {
            ShowSelectDate.Value = selectedDate;
            date.Text = selectedDate.ToString("yyyy-MM-dd");//没用了（被ShowSelectDate覆盖）
            TaskListBox.Items.Clear();
            foreach (var task in taskManager.GetTasksByDate(selectedDate))
            {
                TaskListBox.Items.Add(task, task.IsCompleted);
            }
        }



        //按钮-后一天
        private void dayafter_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(+1);
            RefreshTaskListUI();
        }
        //按钮-前一天
        private void daybefore_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(-1);
            RefreshTaskListUI();
        }
        //按钮-去今天
        private void today_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            RefreshTaskListUI();
        }

        private void addtask_Click(object sender, EventArgs e)
        {
            FormAddTask addForm = new FormAddTask();
            addForm.SelectDate = selectedDate; // 传入所选日期
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                MyTask newTask = addForm.NewTask;
                if (newTask != null)
                {
                    taskManager.AddTask(newTask);
                    RefreshTaskListUI(); // 刷新任务列表
                }
            }
        }

        private void TaskListBox_DoubleClick(object sender, EventArgs e)
        {

        }

        private void TaskListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (TaskListBox.SelectedItem is MyTask taskToEdit)
                {
                    FormEditTask editForm = new FormEditTask();
                    editForm.ChosenTask = taskToEdit;
                    editForm.Selectdate = selectedDate; // 传入所选日期
                    editForm.InitEditWin();

                    var dialogResult = editForm.ShowDialog();

                    if (editForm.IsRemove)
                    {
                        taskManager.RemoveTask(taskToEdit);
                        RefreshTaskListUI(); // 更新界面
                    }
                    else if (dialogResult == DialogResult.OK)
                    {
                        RefreshTaskListUI(); // 用户修改了任务
                    }
                }
            }
        }

        private void TaskListBox_ItemCheck(object sender, ItemCheckEventArgs e)// / 任务列表复选框打勾
        {
            var task = (MyTask)TaskListBox.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                SystemSounds.Exclamation.Play(); // 播放提示音
                task.IsCompleted = true;
            }
            else
            {
                task.IsCompleted = false;
            }
        }

        private void InitReminderTimer()
        {
            reminderTimer.Interval = 1000; // 每秒检测一次
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private async void ReminderTimer_Tick(object sender, EventArgs e)
        {
            foreach (var task in taskManager.GetAllTasks())
            {
                if (task.ReminderTime.HasValue && task.ReminderTime.Value <= DateTime.Now)
                {
                    // 先将提醒时间置空，防止重复触发
                    task.ReminderTime = null;

                    // 异步显示消息框
                    await Task.Run(() =>
                    {
                        MessageBox.Show($"任务提醒：{task.Name}", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });

                    RefreshTaskListUI(); // 刷新 UI
                }
            }
        }

        private void ShowSelectDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = ShowSelectDate.Value;
            RefreshTaskListUI();
        }


        private void TaskListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // 任务项
            var task = TaskListBox.Items[e.Index] as MyTask;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            bool isCompleted = TaskListBox.GetItemChecked(e.Index);

            // 背景色
            e.Graphics.FillRectangle(
                new SolidBrush(isSelected ? Color.LightSkyBlue : Color.White),
                e.Bounds
            );

            // 文字样式
            string displayText = $"{task.Name} - {(task.Priority ?? PriorityLevel.Low)}";
            Font font = isCompleted ? new Font(e.Font, FontStyle.Strikeout) : e.Font;
            Color textColor = isCompleted ? Color.Gray : Color.Black;

            TextRenderer.DrawText(
                e.Graphics,
                displayText,
                font,
                e.Bounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            e.DrawFocusRectangle();
        }

        private void voice_Click(object sender, EventArgs e)
        {
            Speech speechForm = new Speech(this);//语音识别窗口
            speechForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            taskManager.SaveTasks(); // 保存所有任务到数据库
        }

        private void timer_Click(object sender, EventArgs e)
        {
            _tomatoService.ShowTomatoClock();
        }

        public void AddTaskFromSpeech(MyTask newTask)
        {
            taskManager.AddTask(newTask); // 将任务添加到 TaskManager
            RefreshTaskListUI(); // 刷新任务列表 UI
        }

        private void stats_Click(object sender, EventArgs e)
        {
            // 获取任务列表
            var tasks = taskManager.GetAllTasks();

            // 将任务列表传入 StatisticsForm
            var statsForm = new StatisticsForm(tasks);
            statsForm.Show();
        }
    }
}
