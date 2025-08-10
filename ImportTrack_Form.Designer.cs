namespace DaraniaPlayer
{
    partial class ImportTrack_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportTrack_Form));
            loadAudio_button = new Button();
            label1 = new Label();
            sourceName_text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            trackName_text = new TextBox();
            volume_upDown = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            enviroment_comboBox = new ComboBox();
            vibe_comboBox = new ComboBox();
            label6 = new Label();
            situation_comboBox = new ComboBox();
            label7 = new Label();
            importTrack_button = new Button();
            fileName_textBox = new TextBox();
            fileExtension_comboBox = new ComboBox();
            setFileName_button = new Button();
            previewPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)volume_upDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previewPlayer).BeginInit();
            SuspendLayout();
            // 
            // loadAudio_button
            // 
            loadAudio_button.Location = new Point(436, 9);
            loadAudio_button.Name = "loadAudio_button";
            loadAudio_button.Size = new Size(126, 25);
            loadAudio_button.TabIndex = 0;
            loadAudio_button.Text = "Load Audio File";
            loadAudio_button.UseVisualStyleBackColor = true;
            loadAudio_button.Click += loadAudio_button_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "File Name:";
            // 
            // sourceName_text
            // 
            sourceName_text.BorderStyle = BorderStyle.FixedSingle;
            sourceName_text.Location = new Point(91, 40);
            sourceName_text.Name = "sourceName_text";
            sourceName_text.Size = new Size(339, 23);
            sourceName_text.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 43);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Source Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 6;
            label3.Text = "Track Name";
            // 
            // trackName_text
            // 
            trackName_text.BorderStyle = BorderStyle.FixedSingle;
            trackName_text.Location = new Point(91, 69);
            trackName_text.Name = "trackName_text";
            trackName_text.Size = new Size(339, 23);
            trackName_text.TabIndex = 5;
            // 
            // volume_upDown
            // 
            volume_upDown.Location = new Point(91, 98);
            volume_upDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            volume_upDown.Name = "volume_upDown";
            volume_upDown.Size = new Size(48, 23);
            volume_upDown.TabIndex = 7;
            volume_upDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 100);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 8;
            label4.Text = "Volume (%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 130);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 9;
            label5.Text = "Enviroment";
            // 
            // enviroment_comboBox
            // 
            enviroment_comboBox.FormattingEnabled = true;
            enviroment_comboBox.Location = new Point(90, 127);
            enviroment_comboBox.Name = "enviroment_comboBox";
            enviroment_comboBox.Size = new Size(121, 23);
            enviroment_comboBox.TabIndex = 10;
            // 
            // vibe_comboBox
            // 
            vibe_comboBox.FormattingEnabled = true;
            vibe_comboBox.Location = new Point(90, 156);
            vibe_comboBox.Name = "vibe_comboBox";
            vibe_comboBox.Size = new Size(121, 23);
            vibe_comboBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 159);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 11;
            label6.Text = "Vibe";
            // 
            // situation_comboBox
            // 
            situation_comboBox.FormattingEnabled = true;
            situation_comboBox.Location = new Point(90, 185);
            situation_comboBox.Name = "situation_comboBox";
            situation_comboBox.Size = new Size(121, 23);
            situation_comboBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 188);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 13;
            label7.Text = "Situation";
            // 
            // importTrack_button
            // 
            importTrack_button.Location = new Point(91, 217);
            importTrack_button.Name = "importTrack_button";
            importTrack_button.Size = new Size(75, 23);
            importTrack_button.TabIndex = 15;
            importTrack_button.Text = "Import";
            importTrack_button.UseVisualStyleBackColor = true;
            importTrack_button.Click += importTrack_button_Click;
            // 
            // fileName_textBox
            // 
            fileName_textBox.BorderStyle = BorderStyle.FixedSingle;
            fileName_textBox.Enabled = false;
            fileName_textBox.Location = new Point(91, 11);
            fileName_textBox.Name = "fileName_textBox";
            fileName_textBox.Size = new Size(222, 23);
            fileName_textBox.TabIndex = 16;
            fileName_textBox.Validated += fileName_textBox_Validated;
            // 
            // fileExtension_comboBox
            // 
            fileExtension_comboBox.Enabled = false;
            fileExtension_comboBox.FormattingEnabled = true;
            fileExtension_comboBox.Items.AddRange(new object[] { ".mp3", ".wav" });
            fileExtension_comboBox.Location = new Point(319, 11);
            fileExtension_comboBox.Name = "fileExtension_comboBox";
            fileExtension_comboBox.Size = new Size(111, 23);
            fileExtension_comboBox.TabIndex = 18;
            // 
            // setFileName_button
            // 
            setFileName_button.Location = new Point(436, 40);
            setFileName_button.Name = "setFileName_button";
            setFileName_button.Size = new Size(126, 52);
            setFileName_button.TabIndex = 19;
            setFileName_button.Text = "File Name From Source/Track names";
            setFileName_button.UseVisualStyleBackColor = true;
            setFileName_button.Click += setFileName_button_Click;
            // 
            // previewPlayer
            // 
            previewPlayer.Enabled = true;
            previewPlayer.Location = new Point(345, 100);
            previewPlayer.Name = "previewPlayer";
            previewPlayer.OcxState = (AxHost.State)resources.GetObject("previewPlayer.OcxState");
            previewPlayer.Size = new Size(217, 140);
            previewPlayer.TabIndex = 20;
            // 
            // ImportTrack_Form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(574, 252);
            Controls.Add(previewPlayer);
            Controls.Add(setFileName_button);
            Controls.Add(fileExtension_comboBox);
            Controls.Add(fileName_textBox);
            Controls.Add(importTrack_button);
            Controls.Add(situation_comboBox);
            Controls.Add(label7);
            Controls.Add(vibe_comboBox);
            Controls.Add(label6);
            Controls.Add(enviroment_comboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(volume_upDown);
            Controls.Add(label3);
            Controls.Add(trackName_text);
            Controls.Add(label2);
            Controls.Add(sourceName_text);
            Controls.Add(label1);
            Controls.Add(loadAudio_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ImportTrack_Form";
            Text = "Import Track";
            DragDrop += ImportTrack_Form_DragDrop;
            DragEnter += ImportTrack_Form_DragEnter;
            ((System.ComponentModel.ISupportInitialize)volume_upDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)previewPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAudio_button;
        private Label label1;
        private TextBox sourceName_text;
        private Label label2;
        private Label label3;
        private TextBox trackName_text;
        private NumericUpDown volume_upDown;
        private Label label4;
        private Label label5;
        private ComboBox enviroment_comboBox;
        private ComboBox vibe_comboBox;
        private Label label6;
        private ComboBox situation_comboBox;
        private Label label7;
        private Button importTrack_button;
        private TextBox fileName_textBox;
        private ComboBox fileExtension_comboBox;
        private Button setFileName_button;
        private AxWMPLib.AxWindowsMediaPlayer previewPlayer;
    }
}