using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DaraniaPlayer.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DaraniaPlayer
{
    public partial class ImportTrack_Form : Form
    {
        string originalFileName = "";
        string originalJsonName = "";
        Main_Form mainForm;
        bool editing = false;
        int trackIndex = 0;

        public ImportTrack_Form(Main_Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeForm();
        }

        public ImportTrack_Form(Main_Form mainForm, int trackIndex)
        {
            this.mainForm = mainForm;
            InitializeForm();

            editing = true;
            fileName_textBox.Enabled = true;
            fileExtension_comboBox.Enabled = true;
            this.Text = "Edit Track";
            importTrack_button.Text = "Update";

            this.trackIndex = trackIndex;
            LoadTrack(mainForm.GetTrack(trackIndex));
        }

        private void InitializeForm()
        {
            InitializeComponent();

            StopPlayer(mainForm.mediaPlayer);

            enviroment_comboBox.DataSource = Enum.GetValues(typeof(ENVIROMENT));
            vibe_comboBox.DataSource = Enum.GetValues(typeof(VIBE));
            situation_comboBox.DataSource = Enum.GetValues(typeof(SITUATION));
        }

        private void LoadTrack(Track track)
        {
            // Split the file name parts
            string[] fileNameParts = (track.trackInfo.fileName).Split(".");

            // Load fields
            fileName_textBox.Text = fileNameParts[0].Replace(tracksFolder, "");
            fileExtension_comboBox.SelectedIndex = fileExtension_comboBox.FindStringExact("." + fileNameParts[1]);
            sourceName_text.Text = track.trackInfo.sourceName;
            trackName_text.Text = track.trackInfo.trackName;
            volume_upDown.Value = (decimal)track.trackInfo.volume * 100;
            enviroment_comboBox.SelectedIndex = (int)track.trackInfo.enviroment;
            vibe_comboBox.SelectedIndex = (int)track.trackInfo.vibe;
            situation_comboBox.SelectedIndex = (int)track.trackInfo.situation;

            originalJsonName = track.trackInfo.jsonFileName;

            // Load song
            originalFileName = @tracksFolder + track.trackInfo.fileName;
            previewPlayer.URL = originalFileName;
        }

        private void loadAudio_button_click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.Filter = "audio files (*.mp3, *.wav)|*.mp3;*wav|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LoadAudio(openFile.FileName);
            }
        }

        private void LoadAudio(string loadedFile)
        {
            // Parse input
            originalFileName = loadedFile;
            string extension = Path.GetExtension(originalFileName);
            string fileName = Path.GetFileNameWithoutExtension(originalFileName);
            fileName = FormatFileName(fileName);

            // Display to the form
            fileName_textBox.Text = fileName;
            fileName_textBox.Enabled = true;
            fileExtension_comboBox.SelectedIndex = fileExtension_comboBox.FindString(extension);
            previewPlayer.URL = loadedFile;
        }

        // Whitespace and punctuation besides underscore/dash
        private static readonly Regex charRegex = new Regex(@"[^\w-[_-]]");
        private string FormatFileName(string fileName)
        {
            string newFileName = fileName;

            newFileName = charRegex.Replace(newFileName, "");

            return newFileName;
        }

        private void setFileName_button_Click(object sender, EventArgs e)
        {
            string sourceName = FormatFileName(sourceName_text.Text);
            string trackName = FormatFileName(trackName_text.Text);
            fileName_textBox.Text = sourceName + "_" + trackName;
        }

        private void fileName_textBox_Validated(object sender, EventArgs e)
        {
            fileName_textBox.Text = FormatFileName(fileName_textBox.Text);
        }

        private void importTrack_button_Click(object sender, EventArgs e)
        {
            if (fileName_textBox.Text == "" || originalFileName == "")
            {
                MessageBox.Show("File name cannot be empty. Load a file.");
                return;
            }

            StopPlayer(mainForm.mediaPlayer);
            StopPlayer(previewPlayer);

            // Save fields
            Track newTrack = new Track();

            string trackFileName = fileName_textBox.Text + fileExtension_comboBox.Text;
            string jsonFileName = fileName_textBox.Text + ".json";

            newTrack.trackInfo.fileName = trackFileName;
            newTrack.trackInfo.sourceName = sourceName_text.Text;
            newTrack.trackInfo.trackName = trackName_text.Text;
            newTrack.trackInfo.volume = (double)volume_upDown.Value / 100;
            newTrack.trackInfo.enviroment = (ENVIROMENT)enviroment_comboBox.SelectedIndex;
            newTrack.trackInfo.vibe = (VIBE)vibe_comboBox.SelectedIndex;
            newTrack.trackInfo.situation = (SITUATION)situation_comboBox.SelectedIndex;
            newTrack.trackInfo.jsonFileName = jsonFileName;

            newTrack.Save();

            if (!editing)
            {
                // Assume the track audio isn't already in the folder
                File.Copy(originalFileName, @tracksFolder + trackFileName, true);
                mainForm.AddTrack(newTrack);
            }
            else
            {
                System.Diagnostics.Debug.Print("trackFileName " + trackFileName);
                System.Diagnostics.Debug.Print("originalFileName " + trackFileName);
                System.Diagnostics.Debug.Print("@tracksFolder + originalFileName " + (@tracksFolder + originalFileName));
                System.Diagnostics.Debug.Print("trackFileName != originalFileName " + (trackFileName != originalFileName));
                System.Diagnostics.Debug.Print("@tracksFolder + trackFileName != originalFileName " + (@tracksFolder + trackFileName != originalFileName));
                System.Diagnostics.Debug.Print("originalFileName.Contains(@tracksFolder) " + (originalFileName.Contains(@tracksFolder)));
                if ((trackFileName != originalFileName && @tracksFolder + trackFileName != originalFileName) && originalFileName.Contains(@tracksFolder))
                {
                    
                    File.Copy(originalFileName, @tracksFolder + trackFileName, true);
                    File.Delete(originalFileName);
                }
                if (jsonFileName != originalJsonName && originalJsonName.Contains(@tracksFolder))
                {
                    File.Delete(originalJsonName);
                }
                mainForm.SetTrack(trackIndex, newTrack);
            }

            // Update filter
            mainForm.FilterTracks();
        }

        private void ImportTrack_Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void ImportTrack_Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                LoadAudio(file);
            }
        }
    }
}
