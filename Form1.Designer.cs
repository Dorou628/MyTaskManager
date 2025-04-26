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
            daybefore = new Button();
            dayafter = new Button();
            date = new Label();
            timer = new Button();
            stats = new Button();
            addtask = new Button();
            voice = new Button();
            TaskListBox = new CheckedListBox();
            today = new Button();
            SuspendLayout();
            // 
            // daybefore
            // 
            daybefore.Location = new Point(26, 27);
            daybefore.Margin = new Padding(4);
            daybefore.Name = "daybefore";
            daybefore.Size = new Size(129, 40);
            daybefore.TabIndex = 7;
            daybefore.Text = "前一天";
            daybefore.UseVisualStyleBackColor = true;
            daybefore.Click += daybefore_Click;
            // 
            // dayafter
            // 
            dayafter.Location = new Point(180, 27);
            dayafter.Margin = new Padding(4);
            dayafter.Name = "dayafter";
            dayafter.Size = new Size(129, 40);
            dayafter.TabIndex = 6;
            dayafter.Text = "后一天";
            dayafter.UseVisualStyleBackColor = true;
            dayafter.Click += dayafter_Click;
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
            // timer
            // 
            timer.Location = new Point(26, 93);
            timer.Margin = new Padding(4);
            timer.Name = "timer";
            timer.Size = new Size(129, 40);
            timer.TabIndex = 4;
            timer.Text = "番茄钟";
            timer.UseVisualStyleBackColor = true;
            // 
            // stats
            // 
            stats.Location = new Point(180, 93);
            stats.Margin = new Padding(4);
            stats.Name = "stats";
            stats.Size = new Size(129, 40);
            stats.TabIndex = 3;
            stats.Text = "统计";
            stats.UseVisualStyleBackColor = true;
            // 
            // addtask
            // 
            addtask.Location = new Point(334, 93);
            addtask.Margin = new Padding(4);
            addtask.Name = "addtask";
            addtask.Size = new Size(129, 40);
            addtask.TabIndex = 2;
            addtask.Text = "添加任务";
            addtask.UseVisualStyleBackColor = true;
            addtask.Click += addtask_Click;
            // 
            // voice
            // 
            voice.Location = new Point(489, 93);
            voice.Margin = new Padding(4);
            voice.Name = "voice";
            voice.Size = new Size(129, 40);
            voice.TabIndex = 1;
            voice.Text = "语音功能";
            voice.UseVisualStyleBackColor = true;
            // 
            // TaskListBox
            // 
            TaskListBox.FormattingEnabled = true;
            TaskListBox.Location = new Point(26, 160);
            TaskListBox.Margin = new Padding(4);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(590, 378);
            TaskListBox.TabIndex = 0;
            TaskListBox.ItemCheck += TaskListBox_ItemCheck;
            TaskListBox.DoubleClick += TaskListBox_DoubleClick;
            TaskListBox.MouseDown += TaskListBox_MouseDown;
            // 
            // today
            // 
            today.Location = new Point(489, 27);
            today.Name = "today";
            today.Size = new Size(127, 40);
            today.TabIndex = 8;
            today.Text = "去今天";
            today.UseVisualStyleBackColor = true;
            today.Click += today_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 600);
            Controls.Add(today);
            Controls.Add(TaskListBox);
            Controls.Add(voice);
            Controls.Add(addtask);
            Controls.Add(stats);
            Controls.Add(timer);
            Controls.Add(date);
            Controls.Add(dayafter);
            Controls.Add(daybefore);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "我的任务管理器";
            ResumeLayout(false);
            PerformLayout();
        }



        private Button daybefore;
        private Button dayafter;
        private Label date;
        private Button timer;
        private Button stats;
        private Button addtask;
        private Button voice;
        private CheckedListBox TaskListBox;
        private Button today;
    }
}
