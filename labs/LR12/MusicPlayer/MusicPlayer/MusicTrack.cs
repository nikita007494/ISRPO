using System;

namespace MusicPlayer
{
    public class MusicTrack
    {
        public int Id { get; set; }

        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        public int Duration { get; set; }
        public int PlayCount { get; set; }

        public DateTime AddedDate { get; set; }
    }
}