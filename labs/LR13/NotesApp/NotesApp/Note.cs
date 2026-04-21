using System;

namespace NotesApp
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime NoteDate { get; set; }
        public string NoteText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}