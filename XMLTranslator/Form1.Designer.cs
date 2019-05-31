namespace XMLTranslator
{
    partial class FormTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTranslator));
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.buttonTranslateNow = new System.Windows.Forms.Button();
            this.textBoxSaveFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBoxFrom = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTo = new System.Windows.Forms.RichTextBox();
            this.comboBoxFromLanguage = new System.Windows.Forms.ComboBox();
            this.comboBoxToLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSubKey = new System.Windows.Forms.Label();
            this.textBoxSubKey = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(187, 8);
            this.textBoxOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(676, 22);
            this.textBoxOpenFile.TabIndex = 0;
            // 
            // buttonTranslateNow
            // 
            this.buttonTranslateNow.Location = new System.Drawing.Point(16, 125);
            this.buttonTranslateNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTranslateNow.Name = "buttonTranslateNow";
            this.buttonTranslateNow.Size = new System.Drawing.Size(178, 23);
            this.buttonTranslateNow.TabIndex = 1;
            this.buttonTranslateNow.Text = "Translate Now";
            this.buttonTranslateNow.UseVisualStyleBackColor = true;
            this.buttonTranslateNow.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSaveFile
            // 
            this.textBoxSaveFile.Location = new System.Drawing.Point(187, 38);
            this.textBoxSaveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSaveFile.Name = "textBoxSaveFile";
            this.textBoxSaveFile.Size = new System.Drawing.Size(676, 22);
            this.textBoxSaveFile.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 8);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(178, 23);
            this.buttonOpenFile.TabIndex = 4;
            this.buttonOpenFile.Text = "Select Source File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(200, 125);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(663, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(3, 37);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(178, 23);
            this.buttonSaveFile.TabIndex = 6;
            this.buttonSaveFile.Text = "Select Destination File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBoxFrom
            // 
            this.richTextBoxFrom.Location = new System.Drawing.Point(3, 154);
            this.richTextBoxFrom.Name = "richTextBoxFrom";
            this.richTextBoxFrom.Size = new System.Drawing.Size(862, 184);
            this.richTextBoxFrom.TabIndex = 8;
            this.richTextBoxFrom.Text = "";
            // 
            // richTextBoxTo
            // 
            this.richTextBoxTo.Location = new System.Drawing.Point(5, 344);
            this.richTextBoxTo.Name = "richTextBoxTo";
            this.richTextBoxTo.Size = new System.Drawing.Size(860, 184);
            this.richTextBoxTo.TabIndex = 9;
            this.richTextBoxTo.Text = "";
            // 
            // comboBoxFromLanguage
            // 
            this.comboBoxFromLanguage.FormattingEnabled = true;
            this.comboBoxFromLanguage.Items.AddRange(new object[] {
            "Afrikaans af",
            "Arabic ar",
            "Bangla bn",
            "Bosnian (Latin) bs",
            "Bulgarian bg",
            "Cantonese (Traditional) yue",
            "Catalan ca",
            "Chinese Simplified zh-Hans",
            "Chinese Traditional zh-Hant",
            "Croatian hr",
            "Czech cs",
            "Danish da",
            "Dutch nl",
            "English en",
            "Estonian et",
            "Fijian fj",
            "Filipino fil",
            "Finnish fi",
            "French fr",
            "German de",
            "Greek el",
            "Haitian Creole ht",
            "Hebrew he",
            "Hindi hi",
            "Hmong Daw mww",
            "Hungarian hu",
            "Icelandic is",
            "Indonesian id",
            "Italian it",
            "Japanese ja",
            "Kiswahili sw",
            "Klingon tlh",
            "Klingon (plqaD) tlh-Qaak",
            "Korean ko",
            "Latvian lv",
            "Lithuanian lt",
            "Malagasy mg",
            "Malay ms",
            "Maltese mt",
            "Norwegian nb",
            "Persian fa",
            "Polish pl",
            "Portuguese pt",
            "Queretaro Otomi otq",
            "Romanian ro",
            "Russian ru",
            "Samoan sm",
            "Serbian (Cyrillic) sr-Cyrl",
            "Serbian (Latin) sr-Latn",
            "Slovak sk",
            "Slovenian sl",
            "Spanish es",
            "Swedish sv",
            "Tahitian ty",
            "Tamil ta",
            "Telugu te",
            "Thai th",
            "Tongan to",
            "Turkish tr",
            "Ukrainian uk",
            "Urdu ur",
            "Vietnamese vi",
            "Welsh cy",
            "Yucatec Maya yua"});
            this.comboBoxFromLanguage.Location = new System.Drawing.Point(58, 95);
            this.comboBoxFromLanguage.Name = "comboBoxFromLanguage";
            this.comboBoxFromLanguage.Size = new System.Drawing.Size(350, 24);
            this.comboBoxFromLanguage.TabIndex = 10;
            this.comboBoxFromLanguage.Text = "English en";
            this.comboBoxFromLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromLanguage_SelectedIndexChanged);
            // 
            // comboBoxToLanguage
            // 
            this.comboBoxToLanguage.FormattingEnabled = true;
            this.comboBoxToLanguage.Items.AddRange(new object[] {
            "Afrikaans af",
            "Arabic ar",
            "Bangla bn",
            "Bosnian (Latin) bs",
            "Bulgarian bg",
            "Cantonese (Traditional) yue",
            "Catalan ca",
            "Chinese Simplified zh-Hans",
            "Chinese Traditional zh-Hant",
            "Croatian hr",
            "Czech cs",
            "Danish da",
            "Dutch nl",
            "English en",
            "Estonian et",
            "Fijian fj",
            "Filipino fil",
            "Finnish fi",
            "French fr",
            "German de",
            "Greek el",
            "Haitian Creole ht",
            "Hebrew he",
            "Hindi hi",
            "Hmong Daw mww",
            "Hungarian hu",
            "Icelandic is",
            "Indonesian id",
            "Italian it",
            "Japanese ja",
            "Kiswahili sw",
            "Klingon tlh",
            "Klingon (plqaD) tlh-Qaak",
            "Korean ko",
            "Latvian lv",
            "Lithuanian lt",
            "Malagasy mg",
            "Malay ms",
            "Maltese mt",
            "Norwegian nb",
            "Persian fa",
            "Polish pl",
            "Portuguese pt",
            "Queretaro Otomi otq",
            "Romanian ro",
            "Russian ru",
            "Samoan sm",
            "Serbian (Cyrillic) sr-Cyrl",
            "Serbian (Latin) sr-Latn",
            "Slovak sk",
            "Slovenian sl",
            "Spanish es",
            "Swedish sv",
            "Tahitian ty",
            "Tamil ta",
            "Telugu te",
            "Thai th",
            "Tongan to",
            "Turkish tr",
            "Ukrainian uk",
            "Urdu ur",
            "Vietnamese vi",
            "Welsh cy",
            "Yucatec Maya yua"});
            this.comboBoxToLanguage.Location = new System.Drawing.Point(513, 95);
            this.comboBoxToLanguage.Name = "comboBoxToLanguage";
            this.comboBoxToLanguage.Size = new System.Drawing.Size(350, 24);
            this.comboBoxToLanguage.TabIndex = 11;
            this.comboBoxToLanguage.Text = "Chinese Traditional zh-Hant";
            this.comboBoxToLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxToLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "To";
            // 
            // labelSubKey
            // 
            this.labelSubKey.AutoSize = true;
            this.labelSubKey.Location = new System.Drawing.Point(55, 69);
            this.labelSubKey.Name = "labelSubKey";
            this.labelSubKey.Size = new System.Drawing.Size(114, 17);
            this.labelSubKey.TabIndex = 14;
            this.labelSubKey.Text = "Subscription Key";
            // 
            // textBoxSubKey
            // 
            this.textBoxSubKey.Location = new System.Drawing.Point(187, 66);
            this.textBoxSubKey.Name = "textBoxSubKey";
            this.textBoxSubKey.Size = new System.Drawing.Size(674, 22);
            this.textBoxSubKey.TabIndex = 15;
            // 
            // FormTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 557);
            this.Controls.Add(this.textBoxSubKey);
            this.Controls.Add(this.labelSubKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxToLanguage);
            this.Controls.Add(this.comboBoxFromLanguage);
            this.Controls.Add(this.richTextBoxTo);
            this.Controls.Add(this.richTextBoxFrom);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxSaveFile);
            this.Controls.Add(this.buttonTranslateNow);
            this.Controls.Add(this.textBoxOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTranslator";
            this.Text = "Book Translator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button buttonTranslateNow;
        private System.Windows.Forms.TextBox textBoxSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox richTextBoxFrom;
        private System.Windows.Forms.RichTextBox richTextBoxTo;
        private System.Windows.Forms.ComboBox comboBoxFromLanguage;
        private System.Windows.Forms.ComboBox comboBoxToLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSubKey;
        private System.Windows.Forms.TextBox textBoxSubKey;
    }
}

