using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using static DaraniaPlayer.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DaraniaPlayer
{
    public partial class Main_Form : Form
    {
        public List<Track> allTracks = new List<Track>();
        public List<Track> currentTracks = new List<Track>();
        int trackIndex = 0;
        LoopMode mode = LoopMode.NONE;
        bool filtering = false;

        public Main_Form()
        {
            InitializeComponent();
            LoadTracks();
            LoadLists();

            mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(MusicEnded);
        }

        private async void MusicEnded(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            PlayState state = (PlayState)e.newState;

            if (state == PlayState.MEDIAENDED)
            {
                // Wait until the previous song is done transitioning
                while ((PlayState)mediaPlayer.playState != PlayState.STOPPED)
                {
                    await Task.Delay(1);
                }

                // Play the next song
                PlayNext();
            }
        }

        public void LoadTracks()
        {
            if (!Directory.Exists(tracksFolder))
            {
                return;
            }
            string[] files = System.IO.Directory.GetFiles(tracksFolder, "*.json");
            foreach (string filePath in files)
            {
                Track? currentTrack = JsonConvert.DeserializeObject<Track>(File.ReadAllText(@filePath));

                if (currentTrack != null)
                {
                    currentTrack = ValidateTrack(currentTrack, filePath);

                    AddTrack(currentTrack);
                }
            }

            tracks_listBox.Sorted = true; // sort items

            if (allTracks.Count > 0)
            {
                tracks_listBox.SelectedIndex = 0;
            }
        }

        public Track ValidateTrack(Track t, string jsonFilePath)
        {
            Track validTrack = t;

            if (validTrack.trackInfo.jsonFileName == "")
            {
                validTrack.trackInfo.jsonFileName = jsonFilePath;
                validTrack.Save();
            }

            return validTrack;
        }

        public Track GetTrack(int index)
        {
            return allTracks[index];
        }

        public void SetTrack(int index, Track track)
        {
            allTracks[index] = track;
        }

        public void LoadLists()
        {
            LoadList(enviroment_checkedListBox, new ENVIROMENT());
            LoadList(vibe_checkedListBox, new VIBE());
            LoadList(situation_checkedListBox, new SITUATION());
        }

        public void LoadList(CheckedListBox listbox, Enum e)
        {
            string[] enumValues = Enum.GetNames(e.GetType());
            foreach (string val in enumValues)
            {
                listbox.Items.Add(Common.Capitalize(val), true); // Add checked
            }
        }

        public void AddTrack(Track newTrack)
        {
            allTracks.Add(newTrack);
            currentTracks.Add(newTrack);
            tracks_listBox.Items.Add(newTrack.trackInfo.sourceName + " - " + newTrack.trackInfo.trackName);
        }
        private void Play()
        {
            mediaPlayer.URL = tracksFolder + currentTracks[trackIndex].trackInfo.fileName;

            System.Diagnostics.Debug.Print(mediaPlayer.URL);
        }

        private void addTrack_button_Click(object sender, EventArgs e)
        {
            ImportTrack_Form importForm = new ImportTrack_Form(this);
            importForm.Show();
        }
        private int GetTrackIndex(bool useAllTracks = false)
        {
            int idx = -1;

            List<Track> trackList;

            if (useAllTracks)
            {
                trackList = allTracks;
            }
            else
            {
                trackList = currentTracks;
            }

            // Update selected index
            for (int i = 0; i < trackList.Count; i++)
            {
                Track currentTrack = trackList[i];

                if (tracks_listBox.Text == (currentTrack.trackInfo.sourceName + " - " + currentTrack.trackInfo.trackName))
                {
                    idx = i;
                    break;
                }
            }

            return idx;
        }
        private void tracks_listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            trackIndex = GetTrackIndex();

            if (!filtering)
            {
                Play();
            }
        }
        private void GetNextSong()
        {
            // Update index if necessary
            switch (mode)
            {
                case LoopMode.PLAYLIST:
                    tracks_listBox.SelectedIndex = (trackIndex + 1) % tracks_listBox.Items.Count;
                    break;
                case LoopMode.SHUFFLE:
                    Random rand = new Random();
                    tracks_listBox.SelectedIndex = rand.Next(0, tracks_listBox.Items.Count);
                    break;
            }

        }
        private void PlayNext()
        {
            if (tracks_listBox.Items.Count <= 0) { return; }

            GetNextSong();

            if (mode != LoopMode.NONE)
            {
                Play();
            }
        }

        private void noLoop_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = LoopMode.NONE;
        }

        private void loopCurrent_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = LoopMode.SINGLE;
        }

        private void loopNext_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = LoopMode.PLAYLIST;
        }

        private void loopShuffle_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            mode = LoopMode.SHUFFLE;
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            FilterTracks();
        }

        public void FilterTracks()
        {
            filtering = true;
            List<VIBE> selectedVibes = GetSelectedOptions<VIBE>(vibe_checkedListBox);
            List<ENVIROMENT> selectedEnviroments = GetSelectedOptions<ENVIROMENT>(enviroment_checkedListBox);
            List<SITUATION> selectedSituations = GetSelectedOptions<SITUATION>(situation_checkedListBox);

            tracks_listBox.Items.Clear();
            currentTracks = new List<Track>();

            foreach (Track track in allTracks)
            {
                // If selected
                if (
                    // IF (IN ENVIROMENT OR IN VIBE) AND (IN SITUATION)
                    // Take all if a list is empty
                    ((selectedEnviroments.Contains(track.trackInfo.enviroment) || selectedVibes.Contains(track.trackInfo.vibe)) || (selectedEnviroments.Count == 0 && selectedVibes.Count == 0)) // If in either enviroment/vibe or if they're empty
                    && ((selectedSituations.Contains(track.trackInfo.situation)) || selectedSituations.Count == 0) // If it matches a selected situation or if none selected
                    )
                {
                    currentTracks.Add(track);
                    tracks_listBox.Items.Add(track.trackInfo.sourceName + " - " + track.trackInfo.trackName);
                }
            }

            trackIndex = 0;

            if (currentTracks.Count > 0)
            {
                tracks_listBox.SelectedIndex = 0;
            }
            filtering = false;
        }

        private void DeselectOnRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DeselectAll((CheckedListBox)sender);
            }
        }

        private void DeselectAll(CheckedListBox listbox)
        {
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                listbox.SetItemChecked(i, false);
            }
        }

        private void editTrack_button_Click(object sender, EventArgs e)
        {
            ImportTrack_Form importForm = new ImportTrack_Form(this, GetTrackIndex(true)); // Get the selected track using the index for all tracks
            importForm.Show();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            tracks_listBox.SelectedIndex = rand.Next(0, tracks_listBox.Items.Count);
            Play();
        }

        private List<T> GetSelectedOptions<T>(CheckedListBox listBox) where T : System.Enum
        {
            List<T> selectedValues = new List<T>();

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (listBox.GetItemChecked(i))
                {
                    selectedValues.Add(Common.IntToEnum<T>(i));
                }
            }

            return selectedValues;
        }
    }
}
