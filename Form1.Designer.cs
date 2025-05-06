namespace MyTaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            date = new Label();
            TaskListBox = new CheckedListBox();
            daybefore = new Guna.UI2.WinForms.Guna2Button();
            dayafter = new Guna.UI2.WinForms.Guna2Button();
            ShowSelectDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            today = new Guna.UI2.WinForms.Guna2Button();
            timer = new Guna.UI2.WinForms.Guna2Button();
            stats = new Guna.UI2.WinForms.Guna2Button();
            addtask = new Guna.UI2.WinForms.Guna2Button();
            voice = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(334, 33);
            date.Margin = new Padding(4, 0, 4, 0);
            date.Name = "date";
            date.Size = new Size(39, 20);
            date.TabIndex = 5;
            date.Text = "日期";
            // 
            // TaskListBox
            // 
            TaskListBox.BorderStyle = BorderStyle.FixedSingle;
            TaskListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskListBox.ForeColor = Color.Black;
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ImeMode = ImeMode.NoControl;
            TaskListBox.IntegralHeight = false;
            TaskListBox.Location = new Point(26, 160);
            TaskListBox.Margin = new Padding(4);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(590, 378);
            TaskListBox.TabIndex = 0;
            TaskListBox.ItemCheck += TaskListBox_ItemCheck;
            TaskListBox.DrawItem += TaskListBox_DrawItem;
            TaskListBox.DoubleClick += TaskListBox_DoubleClick;
            TaskListBox.MouseDown += TaskListBox_MouseDown;
            // 
            // daybefore
            // 
            daybefore.BorderRadius = 10;
            daybefore.CustomizableEdges = customizableEdges1;
            daybefore.DisabledState.BorderColor = Color.DarkGray;
            daybefore.DisabledState.CustomBorderColor = Color.DarkGray;
            daybefore.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            daybefore.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            daybefore.Font = new Font("Segoe UI", 9F);
            daybefore.ForeColor = Color.White;
            daybefore.Location = new Point(26, 27);
            daybefore.Name = "daybefore";
            daybefore.ShadowDecoration.CustomizableEdges = customizableEdges2;
            daybefore.Size = new Size(129, 40);
            daybefore.TabIndex = 10;
            daybefore.Text = "前一天";
            daybefore.Click += daybefore_Click;
            // 
            // dayafter
            // 
            dayafter.BorderRadius = 10;
            dayafter.CustomizableEdges = customizableEdges3;
            dayafter.DisabledState.BorderColor = Color.DarkGray;
            dayafter.DisabledState.CustomBorderColor = Color.DarkGray;
            dayafter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dayafter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dayafter.Font = new Font("Segoe UI", 9F);
            dayafter.ForeColor = Color.White;
            dayafter.Location = new Point(180, 27);
            dayafter.Name = "dayafter";
            dayafter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dayafter.Size = new Size(129, 40);
            dayafter.TabIndex = 11;
            dayafter.Text = "后一天";
            dayafter.Click += dayafter_Click;
            // 
            // ShowSelectDate
            // 
            ShowSelectDate.BorderRadius = 10;
            ShowSelectDate.Checked = true;
            ShowSelectDate.CustomizableEdges = customizableEdges5;
            ShowSelectDate.Font = new Font("Segoe UI", 9F);
            ShowSelectDate.Format = DateTimePickerFormat.Long;
            ShowSelectDate.Location = new Point(324, 27);
            ShowSelectDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ShowSelectDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ShowSelectDate.Name = "ShowSelectDate";
            ShowSelectDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ShowSelectDate.Size = new Size(148, 40);
            ShowSelectDate.TabIndex = 12;
            ShowSelectDate.Value = new DateTime(2025, 5, 4, 10, 49, 32, 423);
            ShowSelectDate.ValueChanged += ShowSelectDate_ValueChanged;
            // 
            // today
            // 
            today.BorderRadius = 10;
            today.CustomizableEdges = customizableEdges7;
            today.DisabledState.BorderColor = Color.DarkGray;
            today.DisabledState.CustomBorderColor = Color.DarkGray;
            today.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            today.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            today.Font = new Font("Segoe UI", 9F);
            today.ForeColor = Color.White;
            today.Location = new Point(489, 27);
            today.Name = "today";
            today.ShadowDecoration.CustomizableEdges = customizableEdges8;
            today.Size = new Size(127, 40);
            today.TabIndex = 13;
            today.Text = "今天";
            today.Click += today_Click;
            // 
            // timer
            // 
            timer.BorderRadius = 10;
            timer.CustomizableEdges = customizableEdges9;
            timer.DisabledState.BorderColor = Color.DarkGray;
            timer.DisabledState.CustomBorderColor = Color.DarkGray;
            timer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            timer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            timer.Font = new Font("Segoe UI", 9F);
            timer.ForeColor = Color.White;
            timer.Location = new Point(26, 93);
            timer.Name = "timer";
            timer.ShadowDecoration.CustomizableEdges = customizableEdges10;
            timer.Size = new Size(129, 40);
            timer.TabIndex = 14;
            timer.Text = "番茄钟";
            // 
            // stats
            // 
            stats.BorderRadius = 10;
            stats.CustomizableEdges = customizableEdges11;
            stats.DisabledState.BorderColor = Color.DarkGray;
            stats.DisabledState.CustomBorderColor = Color.DarkGray;
            stats.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            stats.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            stats.Font = new Font("Segoe UI", 9F);
            stats.ForeColor = Color.White;
            stats.Location = new Point(180, 93);
            stats.Name = "stats";
            stats.ShadowDecoration.CustomizableEdges = customizableEdges12;
            stats.Size = new Size(129, 40);
            stats.TabIndex = 15;
            stats.Text = "统计";
            // 
            // addtask
            // 
            addtask.BorderRadius = 10;
            addtask.CustomizableEdges = customizableEdges13;
            addtask.DisabledState.BorderColor = Color.DarkGray;
            addtask.DisabledState.CustomBorderColor = Color.DarkGray;
            addtask.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addtask.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addtask.Font = new Font("Segoe UI", 9F);
            addtask.ForeColor = Color.White;
            addtask.Location = new Point(324, 93);
            addtask.Name = "addtask";
            addtask.ShadowDecoration.CustomizableEdges = customizableEdges14;
            addtask.Size = new Size(148, 40);
            addtask.TabIndex = 16;
            addtask.Text = "添加任务";
            addtask.Click += addtask_Click;
            // 
            // voice
            // 
            voice.BorderRadius = 10;
            voice.CustomizableEdges = customizableEdges15;
            voice.DisabledState.BorderColor = Color.DarkGray;
            voice.DisabledState.CustomBorderColor = Color.DarkGray;
            voice.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            voice.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            voice.Font = new Font("Segoe UI", 9F);
            voice.ForeColor = Color.White;
            voice.Location = new Point(489, 93);
            voice.Name = "voice";
            voice.ShadowDecoration.CustomizableEdges = customizableEdges16;
            voice.Size = new Size(127, 40);
            voice.TabIndex = 17;
            voice.Text = "语音添加";
            voice.Click += voice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(643, 600);
            Controls.Add(voice);
            Controls.Add(addtask);
            Controls.Add(stats);
            Controls.Add(timer);
            Controls.Add(today);
            Controls.Add(ShowSelectDate);
            Controls.Add(dayafter);
            Controls.Add(daybefore);
            Controls.Add(TaskListBox);
            Controls.Add(date);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "我的任务管理器";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label date;
        private CheckedListBox TaskListBox;
        private Guna.UI2.WinForms.Guna2Button daybefore;
        private Guna.UI2.WinForms.Guna2Button dayafter;
        private Guna.UI2.WinForms.Guna2DateTimePicker ShowSelectDate;
        private Guna.UI2.WinForms.Guna2Button today;
        private Guna.UI2.WinForms.Guna2Button timer;
        private Guna.UI2.WinForms.Guna2Button stats;
        private Guna.UI2.WinForms.Guna2Button addtask;
        private Guna.UI2.WinForms.Guna2Button voice;
    }
}
