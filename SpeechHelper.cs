using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace MyTaskManager
{
    internal class SpeechHelper
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;

        public void RecordAudio(string outputFilePath)
        {
            waveIn = new WaveInEvent();
            waveIn.WaveFormat = new WaveFormat(16000, 16, 1); // 16kHz, 16bit, Mono
            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);

            waveIn.DataAvailable += (s, a) =>
            {
                writer.Write(a.Buffer, 0, a.BytesRecorded);
            };

            waveIn.RecordingStopped += (s, a) =>
            {
                writer?.Dispose();
                waveIn?.Dispose();
            };

            waveIn.StartRecording();
        }


        public async Task<string> GetAccessTokenAsync(string apiKey, string secretKey)
        {
            using (var client = new HttpClient())
            {
                var url = $"https://aip.baidubce.com/oauth/2.0/token?grant_type=client_credentials&client_id={apiKey}&client_secret={secretKey}";
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);
                return json["access_token"].ToString();
            }
        }

        public void StopRecording()
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
            }
        }


        public async Task<string> RecognizeSpeechAsync(string audioFilePath, string accessToken)
        {
            byte[] audioData = File.ReadAllBytes(audioFilePath);
            string base64Audio = Convert.ToBase64String(audioData);

            var requestJson = new JObject
    {
        { "format", "pcm" },
        { "rate", 16000 },
        { "channel", 1 },
        { "token", accessToken },
        { "cuid", "YourUniqueUserID" },
        { "len", audioData.Length },
        { "speech", base64Audio }
    };

            using (var client = new HttpClient())
            {
                var content = new StringContent(requestJson.ToString(), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://vop.baidu.com/server_api", content);
                var responseString = await response.Content.ReadAsStringAsync();
                var resultJson = JObject.Parse(responseString);

                if (resultJson["err_no"].ToString() == "0")
                {
                    return resultJson["result"][0].ToString();
                }
                else
                {
                    throw new Exception($"识别失败，错误码：{resultJson["err_no"]}");
                }
            }
        }
    }
}
