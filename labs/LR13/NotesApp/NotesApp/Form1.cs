using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        List<Note> notes = new List<Note>();
        ToolTip toolTip = new ToolTip();
        private Note selectedNote = null;
        public Form1()
        {
            InitializeComponent();

            calendar.DateChanged += Calendar_DateChanged;
            listBoxNotes.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxNotes.DrawItem += ListBoxNotes_DrawItem;

            LoadNotes();
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            if (chkAllNotes.Checked)
            {
                notes = db.GetAllNotes();
            }
            else
            {
                DateTime selectedDate = calendar.SelectionStart;
                notes = db.GetNotesByDate(selectedDate);
            }

            listBoxNotes.DataSource = null;
            listBoxNotes.DataSource = notes;
        }
        private void chkAllNotes_CheckedChanged(object sender, EventArgs e)
        {
            calendar.Enabled = !chkAllNotes.Checked;
            LoadNotes();
        }
        // 🎨 отображение
        private void ListBoxNotes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var note = notes[e.Index];
            e.DrawBackground();

            string shortText = note.NoteText.Length > 30
                ? note.NoteText.Substring(0, 30) + "..."
                : note.NoteText;

            string text;

            if (chkAllNotes.Checked)
                text = $"{note.NoteDate:dd.MM HH:mm} - {shortText}";
            else
                text = $"{note.NoteDate:HH:mm} - {shortText}";

            e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);

            toolTip.SetToolTip(listBoxNotes, note.NoteText);

            e.DrawFocusRectangle();
        }

        // ➕ Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNote.Text)) return;

            DateTime date = calendar.SelectionStart.Date + timePicker.Value.TimeOfDay;

            db.AddNote(new Note
            {
                NoteDate = date,
                NoteText = txtNote.Text
            });

            txtNote.Clear();
            LoadNotes();
        }

        // ❌ Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem is Note note)
            {
                var result = MessageBox.Show("Удалить заметку?", "Подтверждение",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    db.DeleteNote(note.Id);
                    LoadNotes();
                }
            }
        }

        // ✏️ Редактировать
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem is Note note)
            {
                selectedNote = note;

                txtNote.Text = note.NoteText;
                timePicker.Value = note.NoteDate;

                MessageBox.Show("Теперь нажмите 'Сохранить' после редактирования");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedNote == null)
            {
                MessageBox.Show("Сначала выберите заметку для редактирования");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Введите текст заметки");
                return;
            }

            selectedNote.NoteText = txtNote.Text;
            selectedNote.NoteDate = calendar.SelectionStart.Date + timePicker.Value.TimeOfDay;

            db.UpdateNote(selectedNote);

            selectedNote = null; // сброс

            txtNote.Clear();
            LoadNotes();

            MessageBox.Show("Изменения сохранены");
        }
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItem is Note note)
            {
                txtNote.Text = note.NoteText;
                timePicker.Value = note.NoteDate;
            }
        }
    }
}