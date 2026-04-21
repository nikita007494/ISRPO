using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NotesApp
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=NotesDB;Trusted_Connection=True;";

        public List<Note> GetNotesByDate(DateTime date)
        {
            var notes = new List<Note>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT * FROM Notes
                                 WHERE CAST(NoteDate AS DATE) = @date
                                 ORDER BY NoteDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = date.Date;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            notes.Add(new Note
                            {
                                Id = (int)reader["Id"],
                                NoteDate = (DateTime)reader["NoteDate"],
                                NoteText = reader["NoteText"].ToString(),
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            });
                        }
                    }
                }
            }

            return notes;
        }
        public List<Note> GetAllNotes()
        {
            var notes = new List<Note>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM Notes ORDER BY NoteDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notes.Add(new Note
                        {
                            Id = (int)reader["Id"],
                            NoteDate = (DateTime)reader["NoteDate"],
                            NoteText = reader["NoteText"].ToString(),
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        });
                    }
                }
            }

            return notes;
        }
        public void AddNote(Note note)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Notes (NoteDate, NoteText)
                                 VALUES (@date, @text)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = note.NoteDate;
                    cmd.Parameters.Add("@text", SqlDbType.NVarChar).Value = note.NoteText;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateNote(Note note)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Notes
                                 SET NoteDate=@date, NoteText=@text
                                 WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = note.NoteDate;
                    cmd.Parameters.Add("@text", SqlDbType.NVarChar).Value = note.NoteText;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = note.Id;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteNote(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Notes WHERE Id=@id", conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}