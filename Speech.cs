using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using NAudio.Wave;


namespace MyTaskManager
{
    public partial class Speech : Form
    {
        private WaveInEvent waveIn; // 加在类字段里，方便控制
        private SpeechHelper speechHelper = new SpeechHelper();
        private string audioFilePath = "output.wav"; // 临时音频文件路径
        bool isRecognizing = false; // 识别状态标志
        public Speech()
        {
            InitializeComponent();
            //InitRecognizer();
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
                string apiKey = "4U0drKRhd1JdywJ1wut41tU0";
                string secretKey = "E3yp9yuBd3S7jy4naSrubbakT0Z7C3HC";
                string accessToken = await speechHelper.GetAccessTokenAsync(apiKey, secretKey);

                try
                {
                    string result = await speechHelper.RecognizeSpeechAsync(audioFilePath, accessToken);
                    txtSpeechContent.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("识别失败：" + ex.Message);
                }
            }
        }
    }
}
