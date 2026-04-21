using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        List<MusicTrack> tracks = new List<MusicTrack>();

        WindowsMediaPlayer player = new WindowsMediaPlayer();

        int currentIndex = -1;
        Timer progressTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            LoadTracks();

            // 🎧 громкость
            trackBarVolume.Scroll += (s, e) =>
                player.settings.volume = trackBarVolume.Value;

            // ⏱ прогресс
            progressTimer.Interval = 500;
            progressTimer.Tick += ProgressTimer_Tick;
            progressTimer.Start();

            // 📊 события
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.CellDoubleClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    PlayTrack(e.RowIndex);
            };

            trackBarProgress.MouseUp += (s, e) =>
                player.controls.currentPosition = trackBarProgress.Value;

            // 🎨 hover эффекты
            AddHoverEffect(btnPlay);
            AddHoverEffect(btnPause);
            AddHoverEffect(btnNext);
            AddHoverEffect(btnPrev);
            AddHoverEffect(btnAdd);
            AddHoverEffect(btnDelete);
        }

        private void LoadTracks()
        {
            tracks = db.GetTracks();
            dataGridView1.DataSource = tracks;
        }

        // =========================
        // ▶ Воспроизведение
        // =========================
        private void PlayTrack(int index)
        {
            if (index < 0 || index >= tracks.Count) return;

            var track = tracks[index];

            byte[] data = db.GetFile(track.Id);

            string tempPath = Path.Combine(Path.GetTempPath(), track.FileName);
            File.WriteAllBytes(tempPath, data);

            player.URL = tempPath;
            player.controls.play();

            db.IncrementPlayCount(track.Id);

            currentIndex = index;

            HighlightRow(index);
        }

        // =========================
        // ⏱ Прогресс
        // =========================
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia == null) return;

            double current = player.controls.currentPosition;
            double total = player.currentMedia.duration;

            if (total > 0)
            {
                trackBarProgress.Maximum = (int)total;
                trackBarProgress.Value = Math.Min((int)current, trackBarProgress.Maximum);

                lblTime.Text =
                    $"{TimeSpan.FromSeconds(current):mm\\:ss} / {TimeSpan.FromSeconds(total):mm\\:ss}";
            }
        }

        // =========================
        // 🎯 Выбор трека
        // =========================
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var track = (MusicTrack)dataGridView1.CurrentRow.DataBoundItem;

            lblTitle.Text = $"🎵 {track.Title}";
            lblArtist.Text = $"👤 {track.Artist}";
            lblTime.Text = $"⏱ {TimeSpan.FromSeconds(track.Duration):mm\\:ss}";

            currentIndex = dataGridView1.CurrentRow.Index;
        }

        // =========================
        // 🎨 Подсветка текущего
        // =========================
        private void HighlightRow(int index)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);

            dataGridView1.Rows[index].DefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);
        }

        // =========================
        // 🖱 Hover кнопки
        // =========================
        private void AddHoverEffect(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(60, 60, 65);
            btn.ForeColor = Color.White;

            btn.MouseEnter += (s, e) =>
                btn.BackColor = Color.FromArgb(0, 120, 215);

            btn.MouseLeave += (s, e) =>
                btn.BackColor = Color.FromArgb(60, 60, 65);
        }

        // =========================
        // КНОПКИ
        // =========================
        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayTrack(currentIndex == -1 ? 0 : currentIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PlayTrack(currentIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PlayTrack(currentIndex - 1);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        // =========================
        // ➕ Добавить
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Audio|*.mp3;*.wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileBytes = File.ReadAllBytes(dlg.FileName);

                var track = new MusicTrack
                {
                    FileName = Path.GetFileName(dlg.FileName),
                    FileData = fileBytes,
                    Title = Path.GetFileNameWithoutExtension(dlg.FileName),
                    Artist = "Unknown",
                    Album = "",
                    Duration = 0
                };

                db.AddTrack(track);
                LoadTracks();
            }
        }

        // =========================
        // 🗑 Удалить
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var track = (MusicTrack)dataGridView1.CurrentRow.DataBoundItem;

            db.DeleteTrack(track.Id);
            LoadTracks();
        }
    }
}