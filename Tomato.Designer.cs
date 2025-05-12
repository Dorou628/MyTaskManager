namespace TomatoClock
{
    partial class Tomato
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainLabel = new Label();
            buttonStart = new Button();
            buttonReset = new Button();
            buttonStop = new Button();
            maskedTextBox1 = new MaskedTextBox();
            WorR_Time = new Label();
            buttonSettings = new Button();
            panelMain = new Panel();
            panelSettime = new Panel();
            btnNok = new Button();
            btnOk = new Button();
            BreakLable = new Label();
            WorkLable = new Label();
            numericBreak = new NumericUpDown();
            numericWork = new NumericUpDown();
            buttonMain = new Button();
            panelAddWhite = new Panel();
            buttonLoadProcess = new Button();
            buttonRvWhite = new Button();
            buttonWatchWhite = new Button();
            labelAddWhite = new Label();
            buttonAddOk = new Button();
            checkedListProcesses = new CheckedListBox();
            buttonWhite = new Button();
            panelMain.SuspendLayout();
            panelSettime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWork).BeginInit();
            panelAddWhite.SuspendLayout();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            MainLabel.Location = new Point(6, 39);
            MainLabel.Margin = new Padding(2, 0, 2, 0);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(95, 32);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "LeftTime";
            MainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(85, 143);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(68, 40);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "开始";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(168, 143);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(68, 40);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "重置";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(253, 143);
            buttonStop.Margin = new Padding(2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(68, 40);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "暂停";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludePromptAndLiterals;
            maskedTextBox1.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Regular, GraphicsUnit.Point, 134);
            maskedTextBox1.Location = new Point(110, 27);
            maskedTextBox1.Margin = new Padding(2);
            maskedTextBox1.Mask = "90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.ReadOnly = true;
            maskedTextBox1.Size = new Size(211, 79);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.Text = "2500";
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // WorR_Time
            // 
            WorR_Time.AutoSize = true;
            WorR_Time.Location = new Point(110, 4);
            WorR_Time.Margin = new Padding(2, 0, 2, 0);
            WorR_Time.Name = "WorR_Time";
            WorR_Time.Size = new Size(43, 17);
            WorR_Time.TabIndex = 5;
            WorR_Time.Text = "label1";
            WorR_Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(474, 149);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(82, 36);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "设置时间";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(buttonStop);
            panelMain.Controls.Add(MainLabel);
            panelMain.Controls.Add(WorR_Time);
            panelMain.Controls.Add(buttonStart);
            panelMain.Controls.Add(maskedTextBox1);
            panelMain.Controls.Add(buttonReset);
            panelMain.Location = new Point(32, 44);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(431, 221);
            panelMain.TabIndex = 7;
            // 
            // panelSettime
            // 
            panelSettime.Controls.Add(btnNok);
            panelSettime.Controls.Add(btnOk);
            panelSettime.Controls.Add(BreakLable);
            panelSettime.Controls.Add(WorkLable);
            panelSettime.Controls.Add(numericBreak);
            panelSettime.Controls.Add(numericWork);
            panelSettime.Enabled = false;
            panelSettime.Location = new Point(27, 0);
            panelSettime.Name = "panelSettime";
            panelSettime.Size = new Size(332, 207);
            panelSettime.TabIndex = 8;
            panelSettime.Visible = false;
            // 
            // btnNok
            // 
            btnNok.Location = new Point(222, 141);
            btnNok.Name = "btnNok";
            btnNok.Size = new Size(75, 23);
            btnNok.TabIndex = 11;
            btnNok.Text = "取消";
            btnNok.UseVisualStyleBackColor = true;
            btnNok.Click += btnNok_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(68, 141);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "确定";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // BreakLable
            // 
            BreakLable.AutoSize = true;
            BreakLable.Enabled = false;
            BreakLable.Location = new Point(38, 86);
            BreakLable.Name = "BreakLable";
            BreakLable.Size = new Size(56, 17);
            BreakLable.TabIndex = 9;
            BreakLable.Text = "休息时间";
            BreakLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WorkLable
            // 
            WorkLable.AutoSize = true;
            WorkLable.Enabled = false;
            WorkLable.Location = new Point(38, 51);
            WorkLable.Name = "WorkLable";
            WorkLable.Size = new Size(56, 17);
            WorkLable.TabIndex = 8;
            WorkLable.Text = "工作时间";
            WorkLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericBreak
            // 
            numericBreak.Location = new Point(105, 80);
            numericBreak.Name = "numericBreak";
            numericBreak.Size = new Size(192, 23);
            numericBreak.TabIndex = 7;
            numericBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericWork
            // 
            numericWork.Location = new Point(105, 51);
            numericWork.Name = "numericWork";
            numericWork.Size = new Size(192, 23);
            numericWork.TabIndex = 6;
            numericWork.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // buttonMain
            // 
            buttonMain.Location = new Point(474, 111);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(82, 36);
            buttonMain.TabIndex = 9;
            buttonMain.Text = "主页";
            buttonMain.UseVisualStyleBackColor = true;
            buttonMain.Click += buttonMain_Click;
            // 
            // panelAddWhite
            // 
            panelAddWhite.Controls.Add(buttonLoadProcess);
            panelAddWhite.Controls.Add(buttonRvWhite);
            panelAddWhite.Controls.Add(panelSettime);
            panelAddWhite.Controls.Add(buttonWatchWhite);
            panelAddWhite.Controls.Add(labelAddWhite);
            panelAddWhite.Controls.Add(buttonAddOk);
            panelAddWhite.Controls.Add(checkedListProcesses);
            panelAddWhite.Location = new Point(12, 12);
            panelAddWhite.Name = "panelAddWhite";
            panelAddWhite.Size = new Size(456, 303);
            panelAddWhite.TabIndex = 10;
            panelAddWhite.Visible = false;
            // 
            // buttonLoadProcess
            // 
            buttonLoadProcess.Location = new Point(289, 81);
            buttonLoadProcess.Name = "buttonLoadProcess";
            buttonLoadProcess.Size = new Size(94, 37);
            buttonLoadProcess.TabIndex = 6;
            buttonLoadProcess.Text = "查看进程";
            buttonLoadProcess.UseVisualStyleBackColor = true;
            buttonLoadProcess.Click += buttonLoadProcess_Click;
            // 
            // buttonRvWhite
            // 
            buttonRvWhite.Location = new Point(289, 185);
            buttonRvWhite.Name = "buttonRvWhite";
            buttonRvWhite.Size = new Size(94, 37);
            buttonRvWhite.TabIndex = 5;
            buttonRvWhite.Text = "清除";
            buttonRvWhite.UseVisualStyleBackColor = true;
            buttonRvWhite.Click += buttonRvWhite_Click;
            // 
            // buttonWatchWhite
            // 
            buttonWatchWhite.Location = new Point(289, 233);
            buttonWatchWhite.Name = "buttonWatchWhite";
            buttonWatchWhite.Size = new Size(94, 37);
            buttonWatchWhite.TabIndex = 4;
            buttonWatchWhite.Text = "查看白名单";
            buttonWatchWhite.UseVisualStyleBackColor = true;
            buttonWatchWhite.Click += buttonWatchWhite_Click;
            // 
            // labelAddWhite
            // 
            labelAddWhite.AutoSize = true;
            labelAddWhite.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddWhite.Location = new Point(170, 20);
            labelAddWhite.Name = "labelAddWhite";
            labelAddWhite.Size = new Size(117, 28);
            labelAddWhite.TabIndex = 3;
            labelAddWhite.Text = "白名单功能";
            // 
            // buttonAddOk
            // 
            buttonAddOk.Location = new Point(289, 136);
            buttonAddOk.Name = "buttonAddOk";
            buttonAddOk.Size = new Size(94, 37);
            buttonAddOk.TabIndex = 1;
            buttonAddOk.Text = "添加";
            buttonAddOk.UseVisualStyleBackColor = true;
            buttonAddOk.Click += buttonAddOk_Click;
            // 
            // checkedListProcesses
            // 
            checkedListProcesses.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkedListProcesses.FormattingEnabled = true;
            checkedListProcesses.Location = new Point(27, 63);
            checkedListProcesses.Name = "checkedListProcesses";
            checkedListProcesses.Size = new Size(237, 224);
            checkedListProcesses.TabIndex = 0;
            // 
            // buttonWhite
            // 
            buttonWhite.Location = new Point(474, 189);
            buttonWhite.Name = "buttonWhite";
            buttonWhite.Size = new Size(82, 36);
            buttonWhite.TabIndex = 11;
            buttonWhite.Text = "设置白名单";
            buttonWhite.UseVisualStyleBackColor = true;
            buttonWhite.Click += buttonWhite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 340);
            Controls.Add(buttonWhite);
            Controls.Add(panelAddWhite);
            Controls.Add(buttonMain);
            Controls.Add(panelMain);
            Controls.Add(buttonSettings);
            Controls.Add(panelSettime);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "TomatoClock";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelSettime.ResumeLayout(false);
            panelSettime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWork).EndInit();
            panelAddWhite.ResumeLayout(false);
            panelAddWhite.PerformLayout();
            ResumeLayout(false);
        }

        #endregion  

        private Label MainLabel;
        private Button buttonStart;
        private Button buttonReset;
        private Button buttonStop;
        private MaskedTextBox maskedTextBox1;
        private Label WorR_Time;
        private Button buttonSettings;
        private Panel panelMain;
        private Panel panelSettime;
        private Button btnNok;
        private Button btnOk;
        private Label BreakLable;
        private Label WorkLable;
        private NumericUpDown numericBreak;
        private NumericUpDown numericWork;
        private Button buttonMain;
        private Panel panelAddWhite;
        private Button buttonAddOk;
        private CheckedListBox checkedListProcesses;
        private Label labelAddWhite;
        private Button buttonWatchWhite;
        private Button buttonRvWhite;
        private Button buttonLoadProcess;
        private Button buttonWhite;
    }
}
