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
                    foreach (string preset in presets)
                    {
                        string[] words = preset.Split('#');
                        if (this.Controls.ContainsKey(words[0]))
                        {
                            if (this.Controls[words[0]] is TextBox)
                            {
                                this.Controls[words[0]].Text = words[1];
                            }
                            else if (this.Controls[words[0]] is CheckBox)
                            {
                                (this.Controls[words[0]] as CheckBox).Checked = words[1].ToLower() == "true" ? true : false;
                            }
                        }
                    }
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
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox)
                        {
                            sw.WriteLine($"{control.Name}#{control.Text}");
                        }
                        else if (control is CheckBox)
                        {
                            sw.WriteLine(control.Name + "#" + (control as CheckBox).Checked.ToString());
                        }
                    }
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

            string textToWrite = DateTime.Now.ToLongTimeString() + ": " + output + additionalSpace;

            if (!string.IsNullOrWhiteSpace(log.Text))
            {
                textToWrite = "\r\n" + textToWrite;
            }

            log.AppendText(textToWrite);
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
                string outputDirectoryPath = outputfiledirectory.Text;
                if (!Directory.Exists(outputDirectoryPath))
                {
                    outputDirectoryPath = Directory.GetCurrentDirectory() + @"\" + outputDirectoryPath;

                    if (!Directory.Exists(outputDirectoryPath))
                    {
                        outputDirectoryPath = Directory.GetCurrentDirectory() + outputDirectoryPath;

                        if (!File.Exists(outputDirectoryPath))
                        {
                            outputDirectoryPath = Directory.GetCurrentDirectory();
                        }
                    }
                }

                if (!outputDirectoryPath.EndsWith(@"\"))
                {
                    outputDirectoryPath = outputDirectoryPath + @"\";
                }

                string outputFilePath = outputDirectoryPath + (outputfile.Text.Length > 0 ? outputfile.Text : "watson_audio") + (outputfile_versioning.Checked ? "-" + DateTime.Now.ToString("yyyyMMddHHmmss") : "") + ".wav";
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
            foreach (Control control in this.Controls)
            {
                control.Enabled = !lockUI;
            }
        }

        private void watsonconfig_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://cloud.ibm.com/services/text-to-speech/crn%3Av1%3Abluemix%3Apublic%3Atext-to-speech%3Aeu-de%3Aa%2Faaa049bd7fc048f993d071ec5e2dfd24%3Ac7be80fe-a6be-493c-83d6-fa1866e63c41%3A%3A?paneId=manage");
        }

        private void Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressKey(e.KeyChar);
        }

        private void clearlog_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void log_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressKey(e.KeyChar);
        }

        private void PressKey(char pressedKey)
        {
            switch (pressedKey)
            {
                case 'p':
                    savepresets.PerformClick();
                    break;
                case 'l':
                    launchtts.PerformClick();
                    break;
                case 'c':
                    clearlog.PerformClick();
                    break;
            }
        }

        private void browseinput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                RestoreDirectory = true,
                Title = "Choose the input file",
                DefaultExt = "xml",
                Filter = "XML files (*.xml)|*.xml|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                CheckFileExists = true,
                CheckPathExists = true,
                AddExtension = true,
                FilterIndex = 0,
                Multiselect = false
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputfile.Text = openFileDialog1.FileName;
            }
        }

        private void outputfile_versioning_CheckedChanged(object sender, EventArgs e)
        {
            if (outputfile_versioning.Checked)
            {
                outputfile_tooltip.Text = "-yyyymmddhhmmss.wav";
            }
            else
            {
                outputfile_tooltip.Text = ".wav";
            }
        }

        private void browseoutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputfiledirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
