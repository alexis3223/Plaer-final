using NAudio.Wave;
using System.IO;
using System.Windows.Forms;
using Plaer.Properties;

namespace Plaer
{
    public partial class Form1 : Form
    {
        private string[] songs;
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        private bool isPaused;
        private int currentSongIndex;
        private bool isDraggingTrackBar;
        private string lastSelectedFolderPath;
        private List<string> playlistSongs;

        public Form1()
        {
            InitializeComponent();
            waveOutEvent = new WaveOutEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Folders == null)
            {
                Properties.Settings.Default.Folders = new System.Collections.Specialized.StringCollection();
            }
            else
            {
                foreach (var folderPath in Properties.Settings.Default.Folders)
                {
                    if (Directory.Exists(folderPath))
                    {
                        AddSelectedFolder(folderPath);
                        UpdateSongList(folderPath);
                    }
                }
            }

            trackBarVolume.Value = (int)Properties.Settings.Default.Volume;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentSongIndex > 0)
            {
                currentSongIndex--;
            }
            else
            {
                currentSongIndex = lstSongs.Items.Count - 1;
            }

            lstSongs.SelectedIndex = currentSongIndex;
            btnPlay_Click(null, null);
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    lastSelectedFolderPath = folderDialog.SelectedPath;
                    AddSelectedFolder(lastSelectedFolderPath);
                    UpdateSongList(lastSelectedFolderPath);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    waveOutEvent.Play();
                    isPaused = false;
                }
                else
                {
                    if (waveOutEvent != null && waveOutEvent.PlaybackState == PlaybackState.Playing)
                    {
                        waveOutEvent.Stop();
                        waveOutEvent.Dispose();
                    }

                    currentSongIndex = lstSongs.SelectedIndex;
                    audioFileReader = new AudioFileReader(songs[currentSongIndex]);
                    waveOutEvent = new WaveOutEvent();
                    waveOutEvent.Init(audioFileReader);
                    waveOutEvent.Play();
                    trackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                    Timer1.Start();
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (waveOutEvent != null && waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                waveOutEvent.Pause();
                isPaused = true;
            }
        }

        private void lstFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFolder.SelectedItem is FolderItem selectedFolder)
            {
                UpdateSongList(selectedFolder.Path);
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndex >= 0)
            {
                currentSongIndex = lstSongs.SelectedIndex;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentSongIndex < lstSongs.Items.Count - 1)
            {
                currentSongIndex++;
            }
            else
            {
                currentSongIndex = 0;
            }

            lstSongs.SelectedIndex = currentSongIndex;
            btnPlay_Click(null, null);
        }

        private void lstSongs_DoubleClick(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    waveOutEvent.Play();
                    isPaused = false;
                }
                else
                {
                    if (waveOutEvent != null && waveOutEvent.PlaybackState == PlaybackState.Playing)
                    {
                        waveOutEvent.Stop();
                        waveOutEvent.Dispose();
                    }

                    currentSongIndex = lstSongs.SelectedIndex;
                    audioFileReader = new AudioFileReader(songs[currentSongIndex]);
                    waveOutEvent = new WaveOutEvent();
                    waveOutEvent.Init(audioFileReader);
                    waveOutEvent.Play();
                    trackBar.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                    Timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOutEvent != null)
            {
                if (waveOutEvent.PlaybackState == PlaybackState.Playing)
                {
                    if (!isDraggingTrackBar)
                    {
                        trackBar.Value = (int)audioFileReader.CurrentTime.TotalSeconds;
                    }
                    lblElapsedTime.Text = audioFileReader.CurrentTime.ToString(@"mm\:ss");
                }
                else if (waveOutEvent.PlaybackState == PlaybackState.Stopped)
                {
                    Timer1.Stop();
                    trackBar.Value = 0;
                    lblElapsedTime.Text = "00:00";
                    audioFileReader.Dispose();
                    waveOutEvent.Dispose();

                    if (currentSongIndex < lstSongs.Items.Count - 1)
                    {
                        currentSongIndex++;
                    }
                    else
                    {
                        currentSongIndex = 0;
                    }

                    lstSongs.SelectedIndex = currentSongIndex;
                    btnPlay_Click(null, null);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOutEvent != null)
            {
                if (waveOutEvent.PlaybackState != PlaybackState.Stopped)
                {
                    isDraggingTrackBar = true;
                    waveOutEvent.Pause();
                    audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackBar.Value);
                    waveOutEvent.Play();
                    isDraggingTrackBar = false;
                }
            }
        }

        private class FolderItem
        {
            public string Name { get; set; }
            public string Path { get; set; }

            public FolderItem(string name, string path)
            {
                Name = name;
                Path = path;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private void AddSelectedFolder(string folderPath)
        {
            string folderName = Path.GetFileName(folderPath);
            lstFolder.Items.Add(new FolderItem(folderName, folderPath)); // Создание объекта FolderItem с именем и полным путем к папке
        }

        private void UpdateSongList(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                // Получаем список песен в выбранной папке
                songs = Directory.GetFiles(folderPath, "*.mp3");
                lstSongs.Items.Clear();

                // Добавляем песни в ListBox
                foreach (var song in songs)
                {
                    lstSongs.Items.Add(Path.GetFileName(song));
                }
            }
        }

        private void lblElapsedTime_Click(object sender, EventArgs e)
        {

        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            float volume = (float)trackBarVolume.Value / 100;
            waveOutEvent.Volume = volume;
            Settings.Default.Volume = Convert.ToInt32(trackBarVolume.Value);
            Settings.Default.Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получаем выбранный трек из lstSongs
            string selectedTrack = lstSongs.SelectedItem as string;

            // Проверяем, что трек выбран
            if (!string.IsNullOrEmpty(selectedTrack))
            {
                // Добавляем трек в lstPlaylist
                lstPlaylist.Items.Add(selectedTrack);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Получаем выбранный трек из lstPlaylist
            string selectedTrack = lstPlaylist.SelectedItem as string;

            // Проверяем, что трек выбран
            if (!string.IsNullOrEmpty(selectedTrack))
            {
                // Удаляем выбранный трек из lstPlaylist
                lstPlaylist.Items.Remove(selectedTrack);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Очищаем lstPlaylist
            lstPlaylist.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Volume = trackBarVolume.Value;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            // Очистить предыдущий список папок
            Properties.Settings.Default.Folders.Clear();

            // Добавить текущий список папок
            foreach (var folderItem in lstFolder.Items)
            {
                if (folderItem is FolderItem folder)
                {
                    Properties.Settings.Default.Folders.Add(folder.Path);
                }
            }

            Properties.Settings.Default.Save();
        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}