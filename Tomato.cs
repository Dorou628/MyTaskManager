using System;
using System.Windows.Forms;
using System.Timers;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TomatoClock
{
    public partial class Tomato : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool IsWindowVisible(IntPtr hWnd);
        private System.Timers.Timer timer;
        private int remainingSeconds;
        private bool isWorkTime = true;
        private int workDuration = 25 * 60;
        private int breakDuration = 5 * 60;
        private System.Timers.Timer processCheckTimer;
        private readonly List<string> whiteListProcesses = new List<string>
        {
            "ApplicationFrameHost",
            "explorer",
            "devenv",
            "SystemSettings",
            "TextInputHost",
            "TomatoClock",
            "MyTaskManager"
        };
        public void Start()
        {
            InitializeComponent();
            numericWork.Value = workDuration / 60;
            numericBreak.Value = breakDuration / 60;
            InitializeTimer();
            InitializeProcessCheckTimer();

        }
        private void InitializeProcessCheckTimer()
        {
            processCheckTimer = new System.Timers.Timer(30000);
            processCheckTimer.Elapsed += (s, e) => CheckAndCloseProcesses();
            processCheckTimer.AutoReset = true;
        }
        private void UpdateDisplay()
        {
            TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
            maskedTextBox1.Text = time.ToString(@"mm\:ss");
            WorR_Time.Text = isWorkTime ? "工作时间" : "休息时间";
            this.Text = "番茄钟";
        }
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimerElapsed;
            timer.AutoReset = true;
            remainingSeconds = workDuration;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                remainingSeconds--;
                this.Invoke((MethodInvoker)delegate
                {
                    UpdateDisplay();

                    if (remainingSeconds <= 0)
                    {
                        timer.Stop();
                        isWorkTime = !isWorkTime;
                        remainingSeconds = isWorkTime ? workDuration : breakDuration;
                        System.Media.SystemSounds.Beep.Play();
                        var result = MessageBox.Show(isWorkTime ? "工作时间开始" : "休息时间开始", "番茄钟", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            timer.Start();
                        }
                    }

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckAndCloseProcesses()
        {
            if (!isWorkTime) return;
            try
            {
                var processes = Process.GetProcesses()
                    .Where(p =>
                    {
                        try
                        {
                            return p.MainWindowHandle != IntPtr.Zero &&
                            IsWindowVisible(p.MainWindowHandle) &&
                            !whiteListProcesses.Contains(p.ProcessName);
                        }
                        catch
                        { return false; }

                    })
                    .ToList();
                foreach (var process in processes)
                {
                    try
                    {
                        if (!process.HasExited)
                        {
                            process.CloseMainWindow();
                            if (!process.WaitForExit(1000))
                            {
                                Debug.Write($"进程{process.ProcessName}未能关闭\n");
                                //process.Kill();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"关闭进程{process.ProcessName}失败：{ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"进程检查失败：{ex.Message}");
            }
        }
        private void LoadWindowProcesses()
        {
            checkedListProcesses.Items.Clear();
            var processes = Process.GetProcesses()
                   .Where(p =>
                   {
                       try
                       {
                           return p.MainWindowHandle != IntPtr.Zero &&
                           IsWindowVisible(p.MainWindowHandle) &&
                           !whiteListProcesses.Contains(p.ProcessName);
                       }
                       catch
                       { return false; }

                   })
                   .ToList();
            foreach (var process in processes)
            {
                checkedListProcesses.Items.Add($"{process.ProcessName}", false);
            }
        }
        private void LoadWhiteProcesses()
        {
            checkedListProcesses.Items.Clear();
            foreach (var process in whiteListProcesses)
            {
                checkedListProcesses.Items.Add(process);
            }
        }


        private void buttonMain_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelMain.Enabled = true;
            panelSettime.Visible = false;
            panelSettime.Enabled = false;
            panelAddWhite.Visible = false;
            panelAddWhite.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            workDuration = (int)numericWork.Value * 60;
            breakDuration = (int)numericBreak.Value * 60;
            if (isWorkTime)
            {
                remainingSeconds = workDuration;

            }
            else
            {
                remainingSeconds = breakDuration;
            }
            UpdateDisplay();
            MessageBox.Show("设置成功");


        }

        private void btnNok_Click(object sender, EventArgs e)
        {
            numericWork.Value = workDuration / 60;
            numericBreak.Value = breakDuration / 60;





        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelSettime.Visible = true;
            panelSettime.Enabled = true;
            panelMain.Visible = false;
            panelMain.Enabled = false;
            panelAddWhite.Visible = false;
            panelAddWhite.Enabled = false;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            processCheckTimer.Start();
            CheckAndCloseProcesses();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonReset.Enabled = true;
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            processCheckTimer.Stop();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            processCheckTimer.Stop();
            isWorkTime = true;
            remainingSeconds = workDuration;
            UpdateDisplay();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonReset.Enabled = false;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S)
            {
                buttonSettings_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            foreach (int index in checkedListProcesses.CheckedIndices)
            {
                string processName = checkedListProcesses.Items[index].ToString();
                whiteListProcesses.Add(processName);
            }
            MessageBox.Show("添加成功", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWindowProcesses();
        }

        private void buttonWatchWhite_Click(object sender, EventArgs e)
        {
            LoadWhiteProcesses();
            buttonAddOk.Enabled = false;
            buttonRvWhite.Enabled = true;
        }

        private void buttonRvWhite_Click(object sender, EventArgs e)
        {
            if (checkedListProcesses.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选中要删除的进程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedProcesses = checkedListProcesses.SelectedItems.Cast<string>().ToList();
            foreach (string processName in selectedProcesses)
            {
                whiteListProcesses.Remove(processName);
            }

            LoadWhiteProcesses();
        }

        private void buttonLoadProcess_Click(object sender, EventArgs e)
        {
            checkedListProcesses.Items.Clear();
            LoadWindowProcesses();
            buttonRvWhite.Enabled = false;
            buttonAddOk.Enabled = true;

        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {

            panelAddWhite.Visible = true;
            panelAddWhite.Enabled = true;
            panelMain.Visible = false;
            panelMain.Enabled = false;
            panelSettime.Visible = false;
            panelSettime.Enabled = false;
            buttonRvWhite.Enabled = false;
        }

        private void panelSettime_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
