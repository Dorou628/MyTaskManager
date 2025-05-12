using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyTaskManager;

namespace MyTaskManager
{
    public partial class StatisticsForm : Form
    {
        private List<MyTask> _tasks;

        public StatisticsForm(List<MyTask> tasks)
        {
            InitializeComponent();
            _tasks = tasks;

            cmbStatType.Items.AddRange(new[] { "Week", "Month" });
            cmbStatType.SelectedIndex = 0;
            dtpSelectDate.Value = DateTime.Today;
            btnLoadStats.Click += (s, e) => LoadChart();
            LoadChart();
        }

        // 定义 btnLoadStats_Click 事件处理程序
        private void btnLoadStats_Click(object sender, EventArgs e)
        {
            LoadChart(); // 调用 LoadChart 方法加载图表
        }


        // 加载图表
        private void LoadChart()
        {
            chartStats.Series.Clear();
            chartStats.ChartAreas.Clear();
            chartStats.Titles.Clear();

            var chartArea = new ChartArea("MainArea");
            chartStats.ChartAreas.Add(chartArea);

            Series seriesTotal = new Series("Total Tasks")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Int32
            };

            Series seriesCompleted = new Series("Completion Rate (%)")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Double,
                YAxisType = AxisType.Secondary
            };

            List<DailyStat> stats;
            if (cmbStatType.SelectedItem.ToString() == "Week")
            {
                stats = GetStatsByWeek(dtpSelectDate.Value);
                chartStats.Titles.Add("Weekly Task Statistics");
            }
            else
            {
                stats = GetStatsByMonth(dtpSelectDate.Value.Year, dtpSelectDate.Value.Month);
                chartStats.Titles.Add("Monthly Task Statistics");
            }

            foreach (var stat in stats)
            {
                seriesTotal.Points.AddXY(stat.Date, stat.TotalTasks);
                seriesCompleted.Points.AddXY(stat.Date, stat.CompletionRate);
            }

            chartStats.Series.Add(seriesTotal);
            chartStats.Series.Add(seriesCompleted);
        }

        // 按周获取统计数据
        private List<DailyStat> GetStatsByWeek(DateTime referenceDate)
        {
            var weekStart = referenceDate.AddDays(-(int)referenceDate.DayOfWeek);
            var weekEnd = weekStart.AddDays(6);

            return _tasks
                .Where(t => t.CreateDate.Date >= weekStart && t.CreateDate.Date <= weekEnd)
                .GroupBy(t => t.CreateDate.Date)
                .OrderBy(g => g.Key)
                .Select(g => new DailyStat
                {
                    Date = g.Key,
                    TotalTasks = g.Count(),
                    CompletionRate = g.Count(t => t.IsCompleted) * 100.0 / g.Count()
                })
                .ToList();
        }

        // 按月获取统计数据
        private List<DailyStat> GetStatsByMonth(int year, int month)
        {
            return _tasks
                .Where(t => t.CreateDate.Year == year && t.CreateDate.Month == month)
                .GroupBy(t => t.CreateDate.Date)
                .OrderBy(g => g.Key)
                .Select(g => new DailyStat
                {
                    Date = g.Key,
                    TotalTasks = g.Count(),
                    CompletionRate = g.Count(t => t.IsCompleted) * 100.0 / g.Count()
                })
                .ToList();
        }

        // 统计数据的日统计类
        public class DailyStat
        {
            public DateTime Date { get; set; }
            public int TotalTasks { get; set; }
            public double CompletionRate { get; set; }
        }
    }
}
