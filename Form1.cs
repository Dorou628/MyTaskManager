using System.Media;
using TomatoClock;

namespace MyTaskManager
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();//���������
        private DateTime selectedDate = DateTime.Today;//��ѡ�����ڣ���ʼ��Ϊ����
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

        private void RefreshTaskListUI()//������ѡ����ˢ�������б��date��ǩ
        {
            ShowSelectDate.Value = selectedDate;
            date.Text = selectedDate.ToString("yyyy-MM-dd");//û���ˣ���ShowSelectDate���ǣ�
            TaskListBox.Items.Clear();
            foreach (var task in taskManager.GetTasksByDate(selectedDate))
            {
                TaskListBox.Items.Add(task, task.IsCompleted);
            }
        }



        //��ť-��һ��
        private void dayafter_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(+1);
            RefreshTaskListUI();
        }
        //��ť-ǰһ��
        private void daybefore_Click(object sender, EventArgs e)
        {
            selectedDate = selectedDate.AddDays(-1);
            RefreshTaskListUI();
        }
        //��ť-ȥ����
        private void today_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            RefreshTaskListUI();
        }

        private void addtask_Click(object sender, EventArgs e)
        {
            FormAddTask addForm = new FormAddTask();
            addForm.SelectDate = selectedDate; // ������ѡ����
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                MyTask newTask = addForm.NewTask;
                if (newTask != null)
                {
                    taskManager.AddTask(newTask);
                    RefreshTaskListUI(); // ˢ�������б�
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
                    editForm.Selectdate = selectedDate; // ������ѡ����
                    editForm.InitEditWin();

                    var dialogResult = editForm.ShowDialog();

                    if (editForm.IsRemove)
                    {
                        taskManager.RemoveTask(taskToEdit);
                        RefreshTaskListUI(); // ���½���
                    }
                    else if (dialogResult == DialogResult.OK)
                    {
                        RefreshTaskListUI(); // �û��޸�������
                    }
                }
            }
        }

        private void TaskListBox_ItemCheck(object sender, ItemCheckEventArgs e)// / �����б�ѡ���
        {
            var task = (MyTask)TaskListBox.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                SystemSounds.Exclamation.Play(); // ������ʾ��
                task.IsCompleted = true;
            }
            else
            {
                task.IsCompleted = false;
            }
        }

        private void InitReminderTimer()
        {
            reminderTimer.Interval = 1000; // ÿ����һ��
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private async void ReminderTimer_Tick(object sender, EventArgs e)
        {
            foreach (var task in taskManager.GetAllTasks())
            {
                if (task.ReminderTime.HasValue && task.ReminderTime.Value <= DateTime.Now)
                {
                    // �Ƚ�����ʱ���ÿգ���ֹ�ظ�����
                    task.ReminderTime = null;

                    // �첽��ʾ��Ϣ��
                    await Task.Run(() =>
                    {
                        MessageBox.Show($"�������ѣ�{task.Name}", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });

                    RefreshTaskListUI(); // ˢ�� UI
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

            // ������
            var task = TaskListBox.Items[e.Index] as MyTask;
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            bool isCompleted = TaskListBox.GetItemChecked(e.Index);

            // ����ɫ
            e.Graphics.FillRectangle(
                new SolidBrush(isSelected ? Color.LightSkyBlue : Color.White),
                e.Bounds
            );

            // ������ʽ
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
            Speech speechForm = new Speech(this);//����ʶ�𴰿�
            speechForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            taskManager.SaveTasks(); // ���������������ݿ�
        }

        private void timer_Click(object sender, EventArgs e)
        {
            _tomatoService.ShowTomatoClock();
        }

        public void AddTaskFromSpeech(MyTask newTask)
        {
            taskManager.AddTask(newTask); // ��������ӵ� TaskManager
            RefreshTaskListUI(); // ˢ�������б� UI
        }

        private void stats_Click(object sender, EventArgs e)
        {
            // ��ȡ�����б�
            var tasks = taskManager.GetAllTasks();

            // �������б��� StatisticsForm
            var statsForm = new StatisticsForm(tasks);
            statsForm.Show();
        }
    }
}
