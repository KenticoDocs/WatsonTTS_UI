namespace WatsonTTS_UI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.authkey = new System.Windows.Forms.TextBox();
            this.authkey_label = new System.Windows.Forms.Label();
            this.inputfile_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.inputfile = new System.Windows.Forms.TextBox();
            this.outputfile = new System.Windows.Forms.TextBox();
            this.savepresets = new System.Windows.Forms.Button();
            this.launchtts = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.watsonurl = new System.Windows.Forms.TextBox();
            this.watsonurl_label = new System.Windows.Forms.Label();
            this.watsonconfig_label = new System.Windows.Forms.LinkLabel();
            this.filesconfig = new System.Windows.Forms.Label();
            this.inputfile_tooltip = new System.Windows.Forms.Label();
            this.outputfile_tooltip = new System.Windows.Forms.Label();
            this.clearlog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseinput = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.outputfiledirectory = new System.Windows.Forms.TextBox();
            this.outputfiledirectory_label = new System.Windows.Forms.Label();
            this.outputfiledirectory_tooltip = new System.Windows.Forms.Label();
            this.outputfile_label = new System.Windows.Forms.Label();
            this.outputfile_versioning = new System.Windows.Forms.CheckBox();
            this.browseoutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authkey
            // 
            this.authkey.Location = new System.Drawing.Point(158, 42);
            this.authkey.Name = "authkey";
            this.authkey.Size = new System.Drawing.Size(732, 22);
            this.authkey.TabIndex = 0;
            // 
            // authkey_label
            // 
            this.authkey_label.AutoSize = true;
            this.authkey_label.Location = new System.Drawing.Point(12, 47);
            this.authkey_label.Name = "authkey_label";
            this.authkey_label.Size = new System.Drawing.Size(59, 17);
            this.authkey_label.TabIndex = 1;
            this.authkey_label.Text = "API key:";
            // 
            // inputfile_label
            // 
            this.inputfile_label.AutoSize = true;
            this.inputfile_label.Location = new System.Drawing.Point(12, 166);
            this.inputfile_label.Name = "inputfile_label";
            this.inputfile_label.Size = new System.Drawing.Size(75, 17);
            this.inputfile_label.TabIndex = 2;
            this.inputfile_label.Text = "Input path:";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(12, 238);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(77, 17);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "Output file:";
            // 
            // inputfile
            // 
            this.inputfile.Location = new System.Drawing.Point(158, 166);
            this.inputfile.Name = "inputfile";
            this.inputfile.Size = new System.Drawing.Size(636, 22);
            this.inputfile.TabIndex = 4;
            // 
            // outputfile
            // 
            this.outputfile.Location = new System.Drawing.Point(235, 300);
            this.outputfile.Name = "outputfile";
            this.outputfile.Size = new System.Drawing.Size(432, 22);
            this.outputfile.TabIndex = 5;
            // 
            // savepresets
            // 
            this.savepresets.Location = new System.Drawing.Point(616, 379);
            this.savepresets.Name = "savepresets";
            this.savepresets.Size = new System.Drawing.Size(134, 36);
            this.savepresets.TabIndex = 6;
            this.savepresets.Text = "Save presets (p)";
            this.savepresets.UseVisualStyleBackColor = true;
            this.savepresets.Click += new System.EventHandler(this.savepresets_Click);
            // 
            // launchtts
            // 
            this.launchtts.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.launchtts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchtts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchtts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.launchtts.Location = new System.Drawing.Point(756, 379);
            this.launchtts.Name = "launchtts";
            this.launchtts.Size = new System.Drawing.Size(134, 36);
            this.launchtts.TabIndex = 7;
            this.launchtts.Text = "Launch (l)";
            this.launchtts.UseVisualStyleBackColor = false;
            this.launchtts.Click += new System.EventHandler(this.launchtts_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(15, 439);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(875, 313);
            this.log.TabIndex = 8;
            this.log.Text = resources.GetString("log.Text");
            this.log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.log_KeyPress);
            // 
            // watsonurl
            // 
            this.watsonurl.Location = new System.Drawing.Point(158, 83);
            this.watsonurl.Name = "watsonurl";
            this.watsonurl.Size = new System.Drawing.Size(732, 22);
            this.watsonurl.TabIndex = 10;
            // 
            // watsonurl_label
            // 
            this.watsonurl_label.AutoSize = true;
            this.watsonurl_label.Location = new System.Drawing.Point(12, 83);
            this.watsonurl_label.Name = "watsonurl_label";
            this.watsonurl_label.Size = new System.Drawing.Size(92, 17);
            this.watsonurl_label.TabIndex = 9;
            this.watsonurl_label.Text = "Watson URL:";
            // 
            // watsonconfig_label
            // 
            this.watsonconfig_label.AutoSize = true;
            this.watsonconfig_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watsonconfig_label.Location = new System.Drawing.Point(12, 9);
            this.watsonconfig_label.Name = "watsonconfig_label";
            this.watsonconfig_label.Size = new System.Drawing.Size(162, 17);
            this.watsonconfig_label.TabIndex = 11;
            this.watsonconfig_label.TabStop = true;
            this.watsonconfig_label.Text = "Watson configuration";
            this.watsonconfig_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.watsonconfig_label_LinkClicked);
            // 
            // filesconfig
            // 
            this.filesconfig.AutoSize = true;
            this.filesconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesconfig.Location = new System.Drawing.Point(12, 138);
            this.filesconfig.Name = "filesconfig";
            this.filesconfig.Size = new System.Drawing.Size(142, 17);
            this.filesconfig.TabIndex = 12;
            this.filesconfig.Text = "Files configuration";
            // 
            // inputfile_tooltip
            // 
            this.inputfile_tooltip.AutoSize = true;
            this.inputfile_tooltip.Location = new System.Drawing.Point(158, 191);
            this.inputfile_tooltip.Name = "inputfile_tooltip";
            this.inputfile_tooltip.Size = new System.Drawing.Size(448, 17);
            this.inputfile_tooltip.TabIndex = 13;
            this.inputfile_tooltip.Text = "Full or relative path. Enter a filename only to use the program\'s folder.";
            // 
            // outputfile_tooltip
            // 
            this.outputfile_tooltip.AutoSize = true;
            this.outputfile_tooltip.Location = new System.Drawing.Point(668, 305);
            this.outputfile_tooltip.Name = "outputfile_tooltip";
            this.outputfile_tooltip.Size = new System.Drawing.Size(36, 17);
            this.outputfile_tooltip.TabIndex = 14;
            this.outputfile_tooltip.Text = ".wav";
            // 
            // clearlog
            // 
            this.clearlog.Location = new System.Drawing.Point(476, 379);
            this.clearlog.Name = "clearlog";
            this.clearlog.Size = new System.Drawing.Size(134, 36);
            this.clearlog.TabIndex = 15;
            this.clearlog.Text = "Clear log (c)";
            this.clearlog.UseVisualStyleBackColor = true;
            this.clearlog.Click += new System.EventHandler(this.clearlog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseinput
            // 
            this.browseinput.AllowDrop = true;
            this.browseinput.Location = new System.Drawing.Point(800, 162);
            this.browseinput.Name = "browseinput";
            this.browseinput.Size = new System.Drawing.Size(90, 30);
            this.browseinput.TabIndex = 16;
            this.browseinput.Text = "Browse";
            this.browseinput.UseVisualStyleBackColor = true;
            this.browseinput.Click += new System.EventHandler(this.browseinput_Click);
            // 
            // outputfiledirectory
            // 
            this.outputfiledirectory.Location = new System.Drawing.Point(235, 235);
            this.outputfiledirectory.Name = "outputfiledirectory";
            this.outputfiledirectory.Size = new System.Drawing.Size(559, 22);
            this.outputfiledirectory.TabIndex = 17;
            // 
            // outputfiledirectory_label
            // 
            this.outputfiledirectory_label.AutoSize = true;
            this.outputfiledirectory_label.Location = new System.Drawing.Point(160, 238);
            this.outputfiledirectory_label.Name = "outputfiledirectory_label";
            this.outputfiledirectory_label.Size = new System.Drawing.Size(41, 17);
            this.outputfiledirectory_label.TabIndex = 18;
            this.outputfiledirectory_label.Text = "Path:";
            // 
            // outputfiledirectory_tooltip
            // 
            this.outputfiledirectory_tooltip.AutoSize = true;
            this.outputfiledirectory_tooltip.Location = new System.Drawing.Point(232, 260);
            this.outputfiledirectory_tooltip.Name = "outputfiledirectory_tooltip";
            this.outputfiledirectory_tooltip.Size = new System.Drawing.Size(267, 17);
            this.outputfiledirectory_tooltip.TabIndex = 19;
            this.outputfiledirectory_tooltip.Text = "Leave empty to use the program\'s folder.";
            // 
            // outputfile_label
            // 
            this.outputfile_label.AutoSize = true;
            this.outputfile_label.Location = new System.Drawing.Point(160, 303);
            this.outputfile_label.Name = "outputfile_label";
            this.outputfile_label.Size = new System.Drawing.Size(73, 17);
            this.outputfile_label.TabIndex = 20;
            this.outputfile_label.Text = "File name:";
            // 
            // outputfile_versioning
            // 
            this.outputfile_versioning.AutoSize = true;
            this.outputfile_versioning.Location = new System.Drawing.Point(235, 328);
            this.outputfile_versioning.Name = "outputfile_versioning";
            this.outputfile_versioning.Size = new System.Drawing.Size(168, 21);
            this.outputfile_versioning.TabIndex = 21;
            this.outputfile_versioning.Text = "Version the output file";
            this.outputfile_versioning.UseVisualStyleBackColor = true;
            this.outputfile_versioning.CheckedChanged += new System.EventHandler(this.outputfile_versioning_CheckedChanged);
            // 
            // browseoutput
            // 
            this.browseoutput.AllowDrop = true;
            this.browseoutput.Location = new System.Drawing.Point(800, 231);
            this.browseoutput.Name = "browseoutput";
            this.browseoutput.Size = new System.Drawing.Size(90, 30);
            this.browseoutput.TabIndex = 22;
            this.browseoutput.Text = "Browse";
            this.browseoutput.UseVisualStyleBackColor = true;
            this.browseoutput.Click += new System.EventHandler(this.browseoutput_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 764);
            this.Controls.Add(this.browseoutput);
            this.Controls.Add(this.outputfile_versioning);
            this.Controls.Add(this.outputfile_label);
            this.Controls.Add(this.outputfiledirectory_tooltip);
            this.Controls.Add(this.outputfiledirectory_label);
            this.Controls.Add(this.outputfiledirectory);
            this.Controls.Add(this.browseinput);
            this.Controls.Add(this.clearlog);
            this.Controls.Add(this.outputfile_tooltip);
            this.Controls.Add(this.inputfile_tooltip);
            this.Controls.Add(this.filesconfig);
            this.Controls.Add(this.watsonconfig_label);
            this.Controls.Add(this.watsonurl);
            this.Controls.Add(this.watsonurl_label);
            this.Controls.Add(this.log);
            this.Controls.Add(this.launchtts);
            this.Controls.Add(this.savepresets);
            this.Controls.Add(this.outputfile);
            this.Controls.Add(this.inputfile);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.inputfile_label);
            this.Controls.Add(this.authkey_label);
            this.Controls.Add(this.authkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Watson TTS UI";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Home_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authkey;
        private System.Windows.Forms.Label authkey_label;
        private System.Windows.Forms.Label inputfile_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.TextBox inputfile;
        private System.Windows.Forms.TextBox outputfile;
        private System.Windows.Forms.Button savepresets;
        private System.Windows.Forms.Button launchtts;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.TextBox watsonurl;
        private System.Windows.Forms.Label watsonurl_label;
        private System.Windows.Forms.LinkLabel watsonconfig_label;
        private System.Windows.Forms.Label filesconfig;
        private System.Windows.Forms.Label inputfile_tooltip;
        private System.Windows.Forms.Label outputfile_tooltip;
        private System.Windows.Forms.Button clearlog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseinput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox outputfiledirectory;
        private System.Windows.Forms.Label outputfiledirectory_label;
        private System.Windows.Forms.Label outputfiledirectory_tooltip;
        private System.Windows.Forms.Label outputfile_label;
        private System.Windows.Forms.CheckBox outputfile_versioning;
        private System.Windows.Forms.Button browseoutput;
    }
}

