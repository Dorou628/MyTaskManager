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
    public partial class FormEditTask : Form
    {
        public MyTask ChosenTask;//所选任务
        public DateTime Selectdate { get; set; }//所选日期
        public bool IsRemove = false;//是否删除任务

        public FormEditTask()
        {
            InitializeComponent();
        }

        public void InitEditWin()
        {
            if (ChosenTask == null) return;

            ChosenTaskReminder.Enabled = ReminderSet.Checked;//根据是否选中设置提醒时间选择框的可用性
            ChosenTaskName.Text = ChosenTask.Name ?? string.Empty;
            ChosenTaskDesc.Text = ChosenTask.Description ?? string.Empty;

            // 确保优先级在合法范围
            if ((int)ChosenTask.Priority >= 0 && (int)ChosenTask.Priority <= 2)
                ChosenTaskPriority.SelectedIndex = (int)ChosenTask.Priority;
            else
                ChosenTaskPriority.SelectedIndex = 0;

            ReminderSet.Checked = ChosenTask.ReminderTime != null;
            ChosenTaskReminder.Value = ChosenTask.ReminderTime ?? DateTime.Now;
        }
        private void SaveEdit_Click(object sender, EventArgs e)
        {
            DateTime? NewReminderTime = null;
            if (string.IsNullOrEmpty(ChosenTaskName.Text))
            {
                MessageBox.Show("任务名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChosenTask.Name = ChosenTaskName.Text;
            ChosenTask.Description = ChosenTaskDesc.Text;
            ChosenTask.Priority = (PriorityLevel)ChosenTaskPriority.SelectedIndex;

            if (ReminderSet.Checked)
            {
                NewReminderTime = Selectdate.Date + ChosenTaskReminder.Value.TimeOfDay;
                if (NewReminderTime <= DateTime.Now)
                {
                    MessageBox.Show("提醒时间必须晚于当前时间", "提醒设置无效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ChosenTask.ReminderTime = NewReminderTime;
            }
            else
            {
                ChosenTask.ReminderTime = null; // 取消勾选则清除提醒时间
            }

            this.DialogResult = DialogResult.OK; // 通知主窗体
            this.Close();
        }

        private void ReminderSet_CheckedChanged(object sender, EventArgs e)
        {
            ChosenTaskReminder.Enabled = ReminderSet.Checked;
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            $"确定要删除任务 \"{ChosenTask.Name}\" 吗？",
             "确认删除",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                IsRemove = true;
            }

            this.DialogResult = DialogResult.OK; // 通知主窗体
            this.Close();
        }
    }
}
