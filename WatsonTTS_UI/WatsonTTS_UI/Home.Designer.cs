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
            this.authkey = new System.Windows.Forms.TextBox();
            this.authkey_label = new System.Windows.Forms.Label();
            this.inputfile_label = new System.Windows.Forms.Label();
            this.outputfile_label = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // authkey
            // 
            this.authkey.Location = new System.Drawing.Point(158, 42);
            this.authkey.Name = "authkey";
            this.authkey.Size = new System.Drawing.Size(432, 22);
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
            // outputfile_label
            // 
            this.outputfile_label.AutoSize = true;
            this.outputfile_label.Location = new System.Drawing.Point(12, 221);
            this.outputfile_label.Name = "outputfile_label";
            this.outputfile_label.Size = new System.Drawing.Size(112, 17);
            this.outputfile_label.TabIndex = 3;
            this.outputfile_label.Text = "Output filename:";
            // 
            // inputfile
            // 
            this.inputfile.Location = new System.Drawing.Point(158, 166);
            this.inputfile.Name = "inputfile";
            this.inputfile.Size = new System.Drawing.Size(432, 22);
            this.inputfile.TabIndex = 4;
            // 
            // outputfile
            // 
            this.outputfile.Location = new System.Drawing.Point(158, 221);
            this.outputfile.Name = "outputfile";
            this.outputfile.Size = new System.Drawing.Size(432, 22);
            this.outputfile.TabIndex = 5;
            // 
            // savepresets
            // 
            this.savepresets.Location = new System.Drawing.Point(344, 282);
            this.savepresets.Name = "savepresets";
            this.savepresets.Size = new System.Drawing.Size(117, 36);
            this.savepresets.TabIndex = 6;
            this.savepresets.Text = "Save presets";
            this.savepresets.UseVisualStyleBackColor = true;
            this.savepresets.Click += new System.EventHandler(this.savepresets_Click);
            // 
            // launchtts
            // 
            this.launchtts.Location = new System.Drawing.Point(473, 282);
            this.launchtts.Name = "launchtts";
            this.launchtts.Size = new System.Drawing.Size(117, 36);
            this.launchtts.TabIndex = 7;
            this.launchtts.Text = "Launch";
            this.launchtts.UseVisualStyleBackColor = true;
            this.launchtts.Click += new System.EventHandler(this.launchtts_Click);
            // 
            // log
            // 
            this.log.Enabled = false;
            this.log.Location = new System.Drawing.Point(15, 338);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(575, 246);
            this.log.TabIndex = 8;
            this.log.Text = "";
            // 
            // watsonurl
            // 
            this.watsonurl.Location = new System.Drawing.Point(158, 83);
            this.watsonurl.Name = "watsonurl";
            this.watsonurl.Size = new System.Drawing.Size(432, 22);
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
            this.inputfile_tooltip.Size = new System.Drawing.Size(410, 17);
            this.inputfile_tooltip.TabIndex = 13;
            this.inputfile_tooltip.Text = "Full or relative path. Speak, pitch, and rate added automatically.";
            // 
            // outputfile_tooltip
            // 
            this.outputfile_tooltip.AutoSize = true;
            this.outputfile_tooltip.Location = new System.Drawing.Point(158, 246);
            this.outputfile_tooltip.Name = "outputfile_tooltip";
            this.outputfile_tooltip.Size = new System.Drawing.Size(195, 17);
            this.outputfile_tooltip.TabIndex = 14;
            this.outputfile_tooltip.Text = "File name only without format.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 598);
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
            this.Controls.Add(this.outputfile_label);
            this.Controls.Add(this.inputfile_label);
            this.Controls.Add(this.authkey_label);
            this.Controls.Add(this.authkey);
            this.Name = "Home";
            this.Text = "Watson TTS UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authkey;
        private System.Windows.Forms.Label authkey_label;
        private System.Windows.Forms.Label inputfile_label;
        private System.Windows.Forms.Label outputfile_label;
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
    }
}

