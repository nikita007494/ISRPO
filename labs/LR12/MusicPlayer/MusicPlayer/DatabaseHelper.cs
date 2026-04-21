using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MusicPlayer
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=MusicPlayerDB;Trusted_Connection=True;";

        public List<MusicTrack> GetTracks()
        {
            var list = new List<MusicTrack>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM MusicTracks", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new MusicTrack
                    {
                        Id = (int)reader["Id"],
                        FileName = reader["FileName"].ToString(),
                        Title = reader["Title"].ToString(),
                        Artist = reader["Artist"].ToString(),
                        Album = reader["Album"].ToString(),
                        Duration = reader["Duration"] == DBNull.Value ? 0 : (int)reader["Duration"],
                        PlayCount = (int)reader["PlayCount"],
                        AddedDate = (DateTime)reader["AddedDate"]
                    });
                }
            }
            return list;
        }

        public void AddTrack(MusicTrack track)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(@"
INSERT INTO MusicTracks 
(FileName, FileData, Title, Artist, Album, Duration)
VALUES (@name, @data, @title, @artist, @album, @duration)", conn);

                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = track.FileName;
                cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = track.FileData;
                cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = track.Title;
                cmd.Parameters.Add("@artist", SqlDbType.NVarChar).Value = track.Artist;
                cmd.Parameters.Add("@album", SqlDbType.NVarChar).Value = track.Album;
                cmd.Parameters.Add("@duration", SqlDbType.Int).Value = track.Duration;

                cmd.ExecuteNonQuery();
            }
        }

        public byte[] GetFile(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("SELECT FileData FROM MusicTracks WHERE Id=@id", conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                return (byte[])cmd.ExecuteScalar();
            }
        }

        public void IncrementPlayCount(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand(
                    "UPDATE MusicTracks SET PlayCount = PlayCount + 1 WHERE Id=@id", conn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTrack(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("DELETE FROM MusicTracks WHERE Id=@id", conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();
            }
        }
    }
}