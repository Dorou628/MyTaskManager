using System;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyTaskManager
{
    public partial class Speech : Form
    {
        private WaveInEvent waveIn; // 加在类字段里，方便控制
        private SpeechHelper speechHelper = new SpeechHelper();
        private string audioFilePath = "output.wav"; // 临时音频文件路径
        private bool isRecognizing = false; // 识别状态标志
        private readonly HttpClient httpClient; // 用于 DeepSeek API 请求

        // DeepSeek API 配置
        private readonly string DeepSeekApiKey = "sk-56ff4d52c9f34b038e37d518e7293399"; // DeepSeek API 密钥
        private const string DeepSeekApiUrl = "https://api.deepseek.com/v1/chat/completions"; // DeepSeek API URL
        private const string DeepSeekModel = "deepseek-chat"; // DeepSeek 模型名称

        // 百度语音识别配置
        private const string BaiduApiKey = "4U0drKRhd1JdywJ1wut41tU0"; // 替换为实际百度 API Key
        private const string BaiduSecretKey = "E3yp9yuBd3S7jy4naSrubbakT0Z7C3HC"; // 替换为实际百度 Secret Key
        private Form1 parentForm; // 引用 Form1 实例

        public Speech(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent; // 保存 Form1 实例

            try
            {
                if (string.IsNullOrWhiteSpace(DeepSeekApiKey))
                {
                    throw new ArgumentException("DeepSeekApiKey 为空或无效，请确保正确设置密钥。");
                }

                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", DeepSeekApiKey.Trim());
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化 DeepSeek API 客户端失败：{ex.Message}\nInnerException: {ex.InnerException?.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSpeechContent_TextChanged(object sender, EventArgs e)
        {
            // 保留原始的事件处理（如果需要）
        }

        private async void StartSpeech_Click(object sender, EventArgs e)
        {
            if (!isRecognizing)
            {
                txtSpeechContent.Clear();

                speechHelper.RecordAudio(audioFilePath); // 开始录音
                StartSpeech.Text = "停止识别";
                isRecognizing = true;
            }
            else
            {
                speechHelper.StopRecording(); // 停止录音
                StartSpeech.Text = "开始识别";
                isRecognizing = false;

                // 获取 token
                string accessToken = await speechHelper.GetAccessTokenAsync(BaiduApiKey, BaiduSecretKey);

                try
                {
                    string result = await speechHelper.RecognizeSpeechAsync(audioFilePath, accessToken);
                    txtSpeechContent.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("识别失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnSendToDeepSeek_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpeechContent.Text))
            {
                MessageBox.Show("请先录音并获取转写文本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (httpClient == null)
            {
                MessageBox.Show("DeepSeek API 客户端未正确初始化，请检查密钥配置或网络环境。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string transcribedText = txtSpeechContent.Text.Trim();
                string conditions = txtConditions.Text.Trim();

                // 构造 DeepSeek API 请求，要求标准时间格式
                var requestBody = new
                {
                    model = DeepSeekModel,
                    messages = new[]
                    {
                        new { role = "system", content = "请将用户的语音转写内容解析为任务信息，并以 JSON 格式返回，例如 {'name': '任务名称', 'date': '2023-10-01', 'priority': 'High', 'reminder': '2023-10-01 17:30', 'description': '任务描述'}。确保 'reminder' 是标准日期时间格式（如 'YYYY-MM-DD HH:mm'）。" },
                        new { role = "user", content = $"请将以下语音转写内容解析为任务信息，并以 JSON 格式返回：{transcribedText}" }
                    },
                    stream = false
                };
                string jsonRequest = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                // 发送请求到 DeepSeek API
                var response = await httpClient.PostAsync(DeepSeekApiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    var responseObj = JObject.Parse(responseJson);
                    string deepSeekResult = responseObj["choices"]?[0]?["message"]?["content"]?.ToString();

                    if (!string.IsNullOrEmpty(deepSeekResult))
                    {
                        // 清理返回内容，去除 ```json 和 ```
                        string cleanedResult = deepSeekResult.Replace("```json", "").Replace("```", "").Trim();

                        try
                        {
                            if (cleanedResult.StartsWith("{") || cleanedResult.StartsWith("["))
                            {
                                var taskInfo = JObject.Parse(cleanedResult);
                                string name = taskInfo["name"]?.ToString() ?? "未命名任务";
                                string dateStr = taskInfo["date"]?.ToString();
                                string priorityStr = taskInfo["priority"]?.ToString();
                                string reminderStr = taskInfo["reminder"]?.ToString();
                                string description = taskInfo["description"]?.ToString();

                                // 解析日期
                                DateTime createDate = DateTime.Today;
                                if (!string.IsNullOrEmpty(dateStr) && DateTime.TryParse(dateStr, out DateTime parsedDate))
                                {
                                    createDate = parsedDate;
                                }

                                // 解析优先级
                                PriorityLevel priority = PriorityLevel.Medium;
                                if (!string.IsNullOrEmpty(priorityStr) && Enum.TryParse(priorityStr, true, out PriorityLevel parsedPriority))
                                {
                                    priority = parsedPriority;
                                }

                                // 解析提醒时间
                                DateTime? reminderTime = null;
                                if (!string.IsNullOrEmpty(reminderStr))
                                {
                                    if (DateTime.TryParse(reminderStr, out DateTime parsedReminder))
                                    {
                                        reminderTime = parsedReminder;
                                    }
                                    else
                                    {
                                        // 尝试解析非标准中文时间描述
                                        reminderTime = ParseChineseDateTime(reminderStr, createDate);
                                        if (!reminderTime.HasValue)
                                        {
                                            txtDeepSeekResult.Text = $"无法解析提醒时间：{reminderStr}";
                                            return;
                                        }
                                    }
                                }

                                MyTask newTask = new MyTask(name, createDate, description, priority, reminderTime);
                                FormAddTask addForm = new FormAddTask(newTask);
                                if (addForm.ShowDialog() == DialogResult.OK)
                                {
                                    MyTask finalTask = addForm.NewTask;
                                    parentForm.AddTaskFromSpeech(finalTask);
                                    txtDeepSeekResult.Text = "任务已创建并添加到任务管理器。";
                                }
                                else
                                {
                                    txtDeepSeekResult.Text = "用户取消了任务创建。";
                                }
                            }
                            else
                            {
                                txtDeepSeekResult.Text = $"清理后内容仍不是 JSON：{cleanedResult}";
                            }
                        }
                        catch (JsonException jsonEx)
                        {
                            txtDeepSeekResult.Text = $"JSON 解析失败：{jsonEx.Message}\n原始内容：{deepSeekResult}";
                        }
                    }
                    else
                    {
                        txtDeepSeekResult.Text = "DeepSeek 未返回有效结果。";
                    }
                }
                else
                {
                    txtDeepSeekResult.Text = $"DeepSeek API 错误：{response.StatusCode} - {await response.Content.ReadAsStringAsync()}";
                }
            }
            catch (Exception ex)
            {
                txtDeepSeekResult.Text = $"发送到 DeepSeek 失败：{ex.Message}";
            }
            this.Close();
        }

        // 解析中文时间描述
        private DateTime? ParseChineseDateTime(string timeStr, DateTime baseDate)
        {
            try
            {
                timeStr = timeStr.ToLower().Trim();
                DateTime result = baseDate;

                // 处理相对日期
                if (timeStr.Contains("明天"))
                {
                    result = baseDate.AddDays(1);
                }
                else if (timeStr.Contains("今天"))
                {
                    result = baseDate;
                }

                // 提取时间（支持“五点半”、“17:30”等格式）
                var timeMatch = Regex.Match(timeStr, @"(\d{1,2})点(半)?|(\d{1,2}):(\d{2})");
                if (timeMatch.Success)
                {
                    int hour, minute = 0;
                    if (timeMatch.Groups[3].Success) // 标准格式，如 "17:30"
                    {
                        hour = int.Parse(timeMatch.Groups[3].Value);
                        minute = int.Parse(timeMatch.Groups[4].Value);
                    }
                    else // 中文格式，如 "五点半"
                    {
                        hour = int.Parse(timeMatch.Groups[1].Value);
                        if (timeMatch.Groups[2].Success) // 包含“半”
                            minute = 30;
                    }

                    // 处理“下午”
                    if (timeStr.Contains("下午") && hour < 12)
                    {
                        hour += 12;
                    }

                    result = new DateTime(result.Year, result.Month, result.Day, hour, minute, 0);
                    return result;
                }

                return null; // 无法解析
            }
            catch
            {
                return null;
            }
        }

        private void txtConditions_TextChanged(object sender, EventArgs e)
        {

        }
    }
}