namespace MyTaskManager
{
    partial class FormAddTask
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TaskName = new Label();
            TaskDiscription = new Label();
            label3 = new Label();
            AddTaskName = new TextBox();
            AddTaskDesc = new TextBox();
            cmbPriority = new ComboBox();
            dtpReminder = new DateTimePicker();
            label1 = new Label();
            ReminderSet = new CheckBox();
            ConfirmAdd = new Guna.UI2.WinForms.Guna2Button();
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
            // AddTaskName
            // 
            AddTaskName.Location = new Point(100, 18);
            AddTaskName.Multiline = true;
            AddTaskName.Name = "AddTaskName";
            AddTaskName.Size = new Size(369, 27);
            AddTaskName.TabIndex = 4;
            // 
            // AddTaskDesc
            // 
            AddTaskDesc.Location = new Point(100, 64);
            AddTaskDesc.Multiline = true;
            AddTaskDesc.Name = "AddTaskDesc";
            AddTaskDesc.ScrollBars = ScrollBars.Vertical;
            AddTaskDesc.Size = new Size(369, 86);
            AddTaskDesc.TabIndex = 5;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(100, 156);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 6;
            // 
            // dtpReminder
            // 
            dtpReminder.CustomFormat = "HH:mm:ss";
            dtpReminder.Format = DateTimePickerFormat.Custom;
            dtpReminder.Location = new Point(106, 240);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.ShowUpDown = true;
            dtpReminder.Size = new Size(149, 27);
            dtpReminder.TabIndex = 7;
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
            // ConfirmAdd
            // 
            ConfirmAdd.BorderRadius = 10;
            ConfirmAdd.CustomizableEdges = customizableEdges1;
            ConfirmAdd.DisabledState.BorderColor = Color.DarkGray;
            ConfirmAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            ConfirmAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConfirmAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConfirmAdd.Font = new Font("Segoe UI", 9F);
            ConfirmAdd.ForeColor = Color.White;
            ConfirmAdd.Location = new Point(318, 240);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ConfirmAdd.Size = new Size(151, 43);
            ConfirmAdd.TabIndex = 10;
            ConfirmAdd.Text = "添加任务";
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // FormAddTask
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(505, 299);
            Controls.Add(ConfirmAdd);
            Controls.Add(ReminderSet);
            Controls.Add(label1);
            Controls.Add(dtpReminder);
            Controls.Add(cmbPriority);
            Controls.Add(AddTaskDesc);
            Controls.Add(AddTaskName);
            Controls.Add(label3);
            Controls.Add(TaskDiscription);
            Controls.Add(TaskName);
            Name = "FormAddTask";
            Text = "任务添加";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TaskName;
        private Label TaskDiscription;
        private Label label3;
        private TextBox AddTaskName;
        private TextBox AddTaskDesc;
        private ComboBox cmbPriority;
        private DateTimePicker dtpReminder;
        private Label label1;
        private CheckBox ReminderSet;
        private Guna.UI2.WinForms.Guna2Button ConfirmAdd;
    }
}