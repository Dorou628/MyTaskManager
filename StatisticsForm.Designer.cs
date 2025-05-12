namespace MyTaskManager
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            cmbStatType = new ComboBox();
            dtpSelectDate = new DateTimePicker();
            btnLoadStats = new Button();
            chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart(); // 初始化 chartStats
            SuspendLayout();
            // 
            // cmbStatType
            // 
            cmbStatType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatType.FormattingEnabled = true;
            cmbStatType.Location = new Point(30, 30);
            cmbStatType.Name = "cmbStatType";
            cmbStatType.Size = new Size(121, 28);
            cmbStatType.TabIndex = 0;
            // 
            // dtpSelectDate
            // 
            dtpSelectDate.Location = new Point(170, 30);
            dtpSelectDate.Name = "dtpSelectDate";
            dtpSelectDate.Size = new Size(200, 27);
            dtpSelectDate.TabIndex = 1;
            // 
            // btnLoadStats
            // 
            btnLoadStats.Location = new Point(390, 28);
            btnLoadStats.Name = "btnLoadStats";
            btnLoadStats.Size = new Size(89, 30);
            btnLoadStats.TabIndex = 2;
            btnLoadStats.Text = "加载统计";
            btnLoadStats.UseVisualStyleBackColor = true;
            btnLoadStats.Click += btnLoadStats_Click;
            // 
            // chartStats
            // 
            chartStats.Location = new Point(30, 70); // 设置图表位置
            chartStats.Name = "chartStats";
            chartStats.Size = new Size(700, 400); // 设置图表大小
            chartStats.TabIndex = 3;
            // 
            // StatisticsForm
            // 
            ClientSize = new Size(764, 501);
            Controls.Add(btnLoadStats);
            Controls.Add(dtpSelectDate);
            Controls.Add(cmbStatType);
            Controls.Add(chartStats); // 将 chartStats 添加到窗体控件集合
            Name = "StatisticsForm";
            Text = "任务统计分析";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatType;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Button btnLoadStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
    }
}
