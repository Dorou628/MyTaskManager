using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTaskManager
{
    public partial class FormAddTask : Form
    {
        public DateTime SelectDate { get; set; }//所选日期
        string taskName;
        string? taskDescription;
        DateTime? reminderTime;
        PriorityLevel priority = PriorityLevel.Low;

        public MyTask? NewTask { get; set; }//新建任务
        public FormAddTask(MyTask task = null)
        {
            InitializeComponent();
            if (task != null)
            {
                AddTaskName.Text = task.Name;
                AddTaskDesc.Text = task.Description ?? "";
                cmbPriority.SelectedIndex = (int)task.Priority;
                if (task.ReminderTime.HasValue)
                {
                    ReminderSet.Checked = true;
                    dtpReminder.Value = task.ReminderTime.Value;
                }
                else
                {
                    ReminderSet.Checked = false;
                }
                SelectDate = task.CreateDate;
            }
            else
            {
                InitAddWin(); // 原有初始化逻辑
            }
        }
        public void InitAddWin()//初始化添加窗口
        {
            cmbPriority.SelectedIndex = 0; // 可选，默认选中第一个
            reminderTime = null;//初始化提醒时间
            dtpReminder.Value = DateTime.Now;//初始化提醒时间
            dtpReminder.Enabled = false;//禁用提醒时间选择框
        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            taskName = AddTaskName.Text;
            taskDescription = AddTaskDesc.Text;
            DateTime? reminderTime = null;

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("任务名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ReminderSet.Checked)
            {
                reminderTime = SelectDate.Date + dtpReminder.Value.TimeOfDay;
                if (reminderTime <= DateTime.Now)
                {
                    MessageBox.Show("提醒时间必须晚于当前时间", "提醒设置无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 创建任务（可以在这里传给主窗口）
            NewTask = new MyTask(
                taskName,
                SelectDate,  // 创建时间为选择日期
                taskDescription,
                (PriorityLevel)cmbPriority.SelectedIndex,
                reminderTime
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ReminderSet_CheckedChanged(object sender, EventArgs e)
        {
            dtpReminder.Enabled = ReminderSet.Checked;
        }
    }
}
