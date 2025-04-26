namespace MyTaskManager
{
    partial class FormEditTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TaskName = new Label();
            TaskDiscription = new Label();
            label3 = new Label();
            ChosenTaskName = new TextBox();
            ChosenTaskDesc = new TextBox();
            ChosenTaskPriority = new ComboBox();
            ChosenTaskReminder = new DateTimePicker();
            label1 = new Label();
            ReminderSet = new CheckBox();
            SaveEdit = new Button();
            DeleteTask = new Button();
            SuspendLayout();
            // 
            // TaskName
            // 
            TaskName.AutoSize = true;
            TaskName.Location = new Point(31, 21);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(54, 20);
            TaskName.TabIndex = 1;
            TaskName.Text = "任务名";
            // 
            // TaskDiscription
            // 
            TaskDiscription.AutoSize = true;
            TaskDiscription.Location = new Point(25, 67);
            TaskDiscription.Name = "TaskDiscription";
            TaskDiscription.Size = new Size(69, 20);
            TaskDiscription.TabIndex = 2;
            TaskDiscription.Text = "任务描述";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 159);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 3;
            label3.Text = "优先级";
            // 
            // ChosenTaskName
            // 
            ChosenTaskName.Location = new Point(100, 18);
            ChosenTaskName.Multiline = true;
            ChosenTaskName.Name = "ChosenTaskName";
            ChosenTaskName.Size = new Size(369, 27);
            ChosenTaskName.TabIndex = 4;
            // 
            // ChosenTaskDesc
            // 
            ChosenTaskDesc.Location = new Point(100, 64);
            ChosenTaskDesc.Multiline = true;
            ChosenTaskDesc.Name = "ChosenTaskDesc";
            ChosenTaskDesc.ScrollBars = ScrollBars.Vertical;
            ChosenTaskDesc.Size = new Size(369, 86);
            ChosenTaskDesc.TabIndex = 5;
            // 
            // ChosenTaskPriority
            // 
            ChosenTaskPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            ChosenTaskPriority.FormattingEnabled = true;
            ChosenTaskPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            ChosenTaskPriority.Location = new Point(100, 156);
            ChosenTaskPriority.Name = "ChosenTaskPriority";
            ChosenTaskPriority.Size = new Size(151, 28);
            ChosenTaskPriority.TabIndex = 6;
            // 
            // ChosenTaskReminder
            // 
            ChosenTaskReminder.CustomFormat = "HH:mm:ss";
            ChosenTaskReminder.Format = DateTimePickerFormat.Custom;
            ChosenTaskReminder.Location = new Point(106, 240);
            ChosenTaskReminder.Name = "ChosenTaskReminder";
            ChosenTaskReminder.ShowUpDown = true;
            ChosenTaskReminder.Size = new Size(149, 27);
            ChosenTaskReminder.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 245);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "提醒时间";
            // 
            // ReminderSet
            // 
            ReminderSet.AutoSize = true;
            ReminderSet.Location = new Point(31, 203);
            ReminderSet.Name = "ReminderSet";
            ReminderSet.Size = new Size(91, 24);
            ReminderSet.TabIndex = 9;
            ReminderSet.Text = "定时提醒";
            ReminderSet.UseVisualStyleBackColor = true;
            ReminderSet.CheckedChanged += ReminderSet_CheckedChanged;
            // 
            // SaveEdit
            // 
            SaveEdit.Location = new Point(375, 238);
            SaveEdit.Name = "SaveEdit";
            SaveEdit.Size = new Size(94, 29);
            SaveEdit.TabIndex = 10;
            SaveEdit.Text = "保存";
            SaveEdit.UseVisualStyleBackColor = true;
            SaveEdit.Click += SaveEdit_Click;
            // 
            // DeleteTask
            // 
            DeleteTask.Location = new Point(272, 238);
            DeleteTask.Name = "DeleteTask";
            DeleteTask.Size = new Size(94, 29);
            DeleteTask.TabIndex = 11;
            DeleteTask.Text = "删除任务";
            DeleteTask.UseVisualStyleBackColor = true;
            DeleteTask.Click += DeleteTask_Click;
            // 
            // FormEditTask
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 299);
            Controls.Add(DeleteTask);
            Controls.Add(SaveEdit);
            Controls.Add(ReminderSet);
            Controls.Add(label1);
            Controls.Add(ChosenTaskReminder);
            Controls.Add(ChosenTaskPriority);
            Controls.Add(ChosenTaskDesc);
            Controls.Add(ChosenTaskName);
            Controls.Add(label3);
            Controls.Add(TaskDiscription);
            Controls.Add(TaskName);
            Name = "FormEditTask";
            Text = "FormEditTask";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label TaskName;
        private Label TaskDiscription;
        private Label label3;
        private TextBox ChosenTaskName;
        private TextBox ChosenTaskDesc;
        private ComboBox ChosenTaskPriority;
        private DateTimePicker ChosenTaskReminder;
        private Label label1;
        private CheckBox ReminderSet;
        private Button SaveEdit;
        private Button DeleteTask;
    }
}