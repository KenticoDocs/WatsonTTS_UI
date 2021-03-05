using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Cloud.SDK.Core.Http;
using IBM.Cloud.SDK.Core.Http.Exceptions;
using IBM.Watson.TextToSpeech.v1;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WatsonTTS_UI
{
    public partial class Home : Form
    {
        public string PresetPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + @"\watson_tts_ui_presets.config";
            }
        }

        public Home()
        {
            InitializeComponent();
            if (File.Exists(PresetPath))
            {
                string[] presets = File.ReadAllLines(PresetPath);
                if (presets.Length == 4)
                {
                    try
                    {
                        authkey.Text = presets[0];
                        watsonurl.Text = presets[1];
                        inputfile.Text = presets[2];
                        outputfile.Text = presets[3];
                        OutToLog($"Presets were loaded.", true);
                    }
                    catch (Exception ex)
                    {
                        OutToLog(@"Error: Presets couldn't be loaded.");
                        OutToLog($"Error description: {ex.Message}", true);
                    }
                }
                else
                {
                    OutToLog(@"Error: Presets file was in an incompatible format.", true);
                }
            }
        }

        private void savepresets_Click(object sender, EventArgs e)
        {
            SavePresets();
        }

        private void SavePresets()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(PresetPath, false))
                {
                    sw.WriteLine(authkey.Text);
                    sw.WriteLine(watsonurl.Text);
                    sw.WriteLine(inputfile.Text);
                    sw.WriteLine(outputfile.Text);
                    sw.Close();
                }

                OutToLog($"Presets were saved to {PresetPath}.", true);
            }
            catch (Exception ex)
            {
                OutToLog(@"Error: Presets couldn't be created.");
                OutToLog($"Error description: {ex.Message}", true);
            }
        }

        private void OutToLog(string output, bool space = false)
        {
            string additionalSpace = "";
            if (space)
            {
                additionalSpace = "\r\n";
            }

            if (!string.IsNullOrWhiteSpace(log.Text))
            {
                log.AppendText("\r\n" + output + additionalSpace);
            }
            else
            {
                log.AppendText(output + additionalSpace);
            }
            log.ScrollToCaret();
        }

        private void launchtts_Click(object sender, EventArgs e)
        {
            SavePresets();
            LockUI(true);

            // Content preparation
            string inputPath = inputfile.Text;
            if (!File.Exists(inputPath))
            {
                inputPath = Directory.GetCurrentDirectory() + @"\" + inputPath;

                if (!File.Exists(inputPath))
                {
                    inputPath = Directory.GetCurrentDirectory() + inputPath;

                    if (!File.Exists(inputPath))
                    {
                        OutToLog("Error: The input path is invalid.", true);
                        LockUI(false);
                        return;
                    }
                }
            }
            OutToLog($"The input path is: {inputPath}");
            OutToLog($"The UI will freeze now until synthetization is completed.", true);

            string content = "<speak version=\"1.0\"><prosody pitch=\"-1st\" rate=\"-10%\">" +
                String.Join(Environment.NewLine, File.ReadAllLines(inputPath)) +
                "</prosody></speak>";

            // Sign in to Watson and synthesize
            DateTime start = DateTime.Now;
            DetailedResponse<MemoryStream> synthResult;
            try
            {
                IamAuthenticator authenticator = new IamAuthenticator(
                    apikey: authkey.Text
                );
                TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
                textToSpeech.SetServiceUrl(watsonurl.Text);

                synthResult = textToSpeech.Synthesize(
                    text: content,
                    accept: "audio/wav;rate=48000",
                    voice: "en-US_MichaelV3Voice"
                );
            }
            catch (ServiceResponseException ex)
            {
                OutToLog("Service response exception occured during synthetization.", true);
                OutToLog(ex.Message);
                OutToLog(ex.Response.ToString());
                OutToLog($"{ex.ResponseMessage.StatusCode}: {ex.ResponseMessage.RequestMessage.Content}");
                OutToLog(ex.InnerException.Message);
                LockUI(false);
                return;
            }
            catch (Exception ex)
            {
                OutToLog(@"General exception occured during synthetization.", true);
                OutToLog($"Error description: {ex.Message}");
                OutToLog(ex.InnerException.Message);
                LockUI(false);
                return;
            }
            DateTime end = DateTime.Now;
            OutToLog($"Synthentization done in {(end - start).TotalSeconds} seconds.", true);

            // Create audiofile
            try
            {
                string outputFilePath = Directory.GetCurrentDirectory() + @"\" + (outputfile.Text.Length > 0 ? outputfile.Text + ".wav" : "audio.wav");
                using (FileStream fs = File.Create(outputFilePath))
                {
                    synthResult.Result.WriteTo(fs);
                    fs.Close();
                    synthResult.Result.Close();
                    OutToLog($"Synthetization was successful. The file is located at: {outputFilePath}");
                    OutToLog("========================================", true);
                    LockUI(false);
                }
            }
            catch (Exception ex)
            {
                OutToLog(@"Error: Output file creation failed.");
                OutToLog($"Error description: {ex.Message}", true);
                LockUI(false);
                return;
            }
        }

        private void LockUI(bool lockUI)
        {
            authkey.Enabled = !lockUI;
            watsonurl.Enabled = !lockUI;
            inputfile.Enabled = !lockUI;
            outputfile.Enabled = !lockUI;
        }

        private void watsonconfig_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cloud.ibm.com/services/text-to-speech/crn%3Av1%3Abluemix%3Apublic%3Atext-to-speech%3Aeu-de%3Aa%2Faaa049bd7fc048f993d071ec5e2dfd24%3Ac7be80fe-a6be-493c-83d6-fa1866e63c41%3A%3A?paneId=manage");
        }
    }
}
