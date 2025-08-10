namespace DaraniaPlayer
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            addTrack_button = new Button();
            tracks_listBox = new ListBox();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            loopMode_groupbox = new GroupBox();
            loopNext_radioButton = new RadioButton();
            noLoop_RadioButton = new RadioButton();
            loopShuffle_radioButton = new RadioButton();
            loopCurrent_radioButton = new RadioButton();
            groupBox1 = new GroupBox();
            enviroment_checkedListBox = new CheckedListBox();
            groupBox2 = new GroupBox();
            situation_checkedListBox = new CheckedListBox();
            groupBox3 = new GroupBox();
            vibe_checkedListBox = new CheckedListBox();
            filter_button = new Button();
            editTrack_button = new Button();
            random_button = new Button();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            loopMode_groupbox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // addTrack_button
            // 
            addTrack_button.Location = new Point(763, 412);
            addTrack_button.Name = "addTrack_button";
            addTrack_button.Size = new Size(75, 23);
            addTrack_button.TabIndex = 1;
            addTrack_button.Text = "Add Track";
            addTrack_button.UseVisualStyleBackColor = true;
            addTrack_button.Click += addTrack_button_Click;
            // 
            // tracks_listBox
            // 
            tracks_listBox.FormattingEnabled = true;
            tracks_listBox.ItemHeight = 15;
            tracks_listBox.Location = new Point(455, 12);
            tracks_listBox.Name = "tracks_listBox";
            tracks_listBox.Size = new Size(383, 394);
            tracks_listBox.TabIndex = 2;
            tracks_listBox.SelectedValueChanged += tracks_listBox_SelectedValueChanged;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(12, 12);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(437, 268);
            mediaPlayer.TabIndex = 3;
            // 
            // loopMode_groupbox
            // 
            loopMode_groupbox.Controls.Add(loopNext_radioButton);
            loopMode_groupbox.Controls.Add(noLoop_RadioButton);
            loopMode_groupbox.Controls.Add(loopShuffle_radioButton);
            loopMode_groupbox.Controls.Add(loopCurrent_radioButton);
            loopMode_groupbox.ForeColor = Color.White;
            loopMode_groupbox.Location = new Point(12, 285);
            loopMode_groupbox.Name = "loopMode_groupbox";
            loopMode_groupbox.Size = new Size(85, 121);
            loopMode_groupbox.TabIndex = 4;
            loopMode_groupbox.TabStop = false;
            loopMode_groupbox.Text = "Loop Mode";
            // 
            // loopNext_radioButton
            // 
            loopNext_radioButton.AutoSize = true;
            loopNext_radioButton.ForeColor = Color.White;
            loopNext_radioButton.Location = new Point(6, 66);
            loopNext_radioButton.Name = "loopNext_radioButton";
            loopNext_radioButton.Size = new Size(49, 19);
            loopNext_radioButton.TabIndex = 7;
            loopNext_radioButton.Text = "Next";
            loopNext_radioButton.UseVisualStyleBackColor = true;
            loopNext_radioButton.CheckedChanged += loopNext_radioButton_CheckedChanged;
            // 
            // noLoop_RadioButton
            // 
            noLoop_RadioButton.AutoSize = true;
            noLoop_RadioButton.Checked = true;
            noLoop_RadioButton.ForeColor = Color.White;
            noLoop_RadioButton.Location = new Point(6, 18);
            noLoop_RadioButton.Name = "noLoop_RadioButton";
            noLoop_RadioButton.Size = new Size(42, 19);
            noLoop_RadioButton.TabIndex = 8;
            noLoop_RadioButton.TabStop = true;
            noLoop_RadioButton.Text = "Off";
            noLoop_RadioButton.UseVisualStyleBackColor = true;
            noLoop_RadioButton.CheckedChanged += noLoop_RadioButton_CheckedChanged;
            // 
            // loopShuffle_radioButton
            // 
            loopShuffle_radioButton.AutoSize = true;
            loopShuffle_radioButton.ForeColor = Color.White;
            loopShuffle_radioButton.Location = new Point(6, 90);
            loopShuffle_radioButton.Name = "loopShuffle_radioButton";
            loopShuffle_radioButton.Size = new Size(62, 19);
            loopShuffle_radioButton.TabIndex = 5;
            loopShuffle_radioButton.Text = "Shuffle";
            loopShuffle_radioButton.UseVisualStyleBackColor = true;
            loopShuffle_radioButton.CheckedChanged += loopShuffle_radioButton_CheckedChanged;
            // 
            // loopCurrent_radioButton
            // 
            loopCurrent_radioButton.AutoSize = true;
            loopCurrent_radioButton.ForeColor = Color.White;
            loopCurrent_radioButton.Location = new Point(6, 42);
            loopCurrent_radioButton.Name = "loopCurrent_radioButton";
            loopCurrent_radioButton.Size = new Size(65, 19);
            loopCurrent_radioButton.TabIndex = 6;
            loopCurrent_radioButton.Text = "Current";
            loopCurrent_radioButton.UseVisualStyleBackColor = true;
            loopCurrent_radioButton.CheckedChanged += loopCurrent_radioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(enviroment_checkedListBox);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(103, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 120);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enviroment";
            // 
            // enviroment_checkedListBox
            // 
            enviroment_checkedListBox.BackColor = Color.Maroon;
            enviroment_checkedListBox.BorderStyle = BorderStyle.None;
            enviroment_checkedListBox.CheckOnClick = true;
            enviroment_checkedListBox.ForeColor = Color.White;
            enviroment_checkedListBox.FormattingEnabled = true;
            enviroment_checkedListBox.Location = new Point(6, 17);
            enviroment_checkedListBox.Name = "enviroment_checkedListBox";
            enviroment_checkedListBox.ScrollAlwaysVisible = true;
            enviroment_checkedListBox.Size = new Size(100, 90);
            enviroment_checkedListBox.TabIndex = 10;
            enviroment_checkedListBox.MouseDown += DeselectOnRightClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(situation_checkedListBox);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(345, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(104, 121);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Situation";
            // 
            // situation_checkedListBox
            // 
            situation_checkedListBox.BackColor = Color.Maroon;
            situation_checkedListBox.BorderStyle = BorderStyle.None;
            situation_checkedListBox.CheckOnClick = true;
            situation_checkedListBox.ForeColor = Color.White;
            situation_checkedListBox.FormattingEnabled = true;
            situation_checkedListBox.Location = new Point(6, 18);
            situation_checkedListBox.Name = "situation_checkedListBox";
            situation_checkedListBox.ScrollAlwaysVisible = true;
            situation_checkedListBox.Size = new Size(92, 90);
            situation_checkedListBox.TabIndex = 9;
            situation_checkedListBox.MouseDown += DeselectOnRightClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(vibe_checkedListBox);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(219, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(120, 120);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Vibe";
            // 
            // vibe_checkedListBox
            // 
            vibe_checkedListBox.BackColor = Color.Maroon;
            vibe_checkedListBox.BorderStyle = BorderStyle.None;
            vibe_checkedListBox.CheckOnClick = true;
            vibe_checkedListBox.ForeColor = Color.White;
            vibe_checkedListBox.FormattingEnabled = true;
            vibe_checkedListBox.Location = new Point(6, 17);
            vibe_checkedListBox.Name = "vibe_checkedListBox";
            vibe_checkedListBox.ScrollAlwaysVisible = true;
            vibe_checkedListBox.Size = new Size(110, 90);
            vibe_checkedListBox.TabIndex = 8;
            vibe_checkedListBox.MouseDown += DeselectOnRightClick;
            // 
            // filter_button
            // 
            filter_button.Location = new Point(103, 412);
            filter_button.Name = "filter_button";
            filter_button.Size = new Size(346, 23);
            filter_button.TabIndex = 8;
            filter_button.Text = "Filter Tracks";
            filter_button.UseVisualStyleBackColor = true;
            filter_button.Click += filter_button_Click;
            // 
            // editTrack_button
            // 
            editTrack_button.Location = new Point(682, 412);
            editTrack_button.Name = "editTrack_button";
            editTrack_button.Size = new Size(75, 23);
            editTrack_button.TabIndex = 9;
            editTrack_button.Text = "Edit Track";
            editTrack_button.UseVisualStyleBackColor = true;
            editTrack_button.Click += editTrack_button_Click;
            // 
            // random_button
            // 
            random_button.Location = new Point(12, 412);
            random_button.Name = "random_button";
            random_button.Size = new Size(85, 23);
            random_button.TabIndex = 10;
            random_button.Text = "Random";
            random_button.UseVisualStyleBackColor = true;
            random_button.Click += random_button_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(850, 443);
            Controls.Add(random_button);
            Controls.Add(editTrack_button);
            Controls.Add(filter_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(loopMode_groupbox);
            Controls.Add(mediaPlayer);
            Controls.Add(tracks_listBox);
            Controls.Add(addTrack_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main_Form";
            Text = "Darania Player";
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            loopMode_groupbox.ResumeLayout(false);
            loopMode_groupbox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button addTrack_button;
        private ListBox tracks_listBox;
        private GroupBox loopMode_groupbox;
        private RadioButton loopNext_radioButton;
        private RadioButton noLoop_RadioButton;
        private RadioButton loopShuffle_radioButton;
        private RadioButton loopCurrent_radioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckedListBox vibe_checkedListBox;
        private CheckedListBox enviroment_checkedListBox;
        private Button filter_button;
        private CheckedListBox situation_checkedListBox;
        private Button editTrack_button;
        internal AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private Button random_button;
    }
}
