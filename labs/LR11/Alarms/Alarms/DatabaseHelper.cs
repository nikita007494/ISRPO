using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Alarms
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=AlarmClockDB;Trusted_Connection=True;";

        public List<Alarm> GetAlarms()
        {
            var alarms = new List<Alarm>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Alarms", conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alarms.Add(new Alarm
                        {
                            Id = (int)reader["Id"],
                            AlarmTime = (TimeSpan)reader["AlarmTime"],
                            //AlarmDate = reader["AlarmDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["AlarmDate"],
                            IsEnabled = (bool)reader["IsEnabled"],
                            Label = reader["Label"] == DBNull.Value ? "" : reader["Label"].ToString(),
                            //RepeatDays = reader["RepeatDays"] == DBNull.Value ? "" : reader["RepeatDays"].ToString(),
                            SnoozeMinutes = (int)reader["SnoozeMinutes"]
                        });
                    }
                }
            }
            return alarms;
        }

        public void AddAlarm(Alarm alarm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Исправленный запрос - количество столбцов соответствует количеству значений
                string query = @"INSERT INTO Alarms
        (AlarmTime, IsEnabled, Label, SnoozeMinutes)
        VALUES (@time, @enabled, @label, @snooze)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@time", SqlDbType.Time).Value = alarm.AlarmTime;
                    cmd.Parameters.Add("@enabled", SqlDbType.Bit).Value = alarm.IsEnabled;
                    cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value =
                        string.IsNullOrEmpty(alarm.Label) ? (object)DBNull.Value : alarm.Label;
                    cmd.Parameters.Add("@snooze", SqlDbType.Int).Value = alarm.SnoozeMinutes;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteAlarm(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Alarms WHERE Id=@id", conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAlarm(Alarm alarm)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE Alarms SET
                AlarmTime=@time,
                
                IsEnabled=@enabled,
                Label=@label,
                
                SnoozeMinutes=@snooze
                WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@time", SqlDbType.Time).Value = alarm.AlarmTime;

                    

                    cmd.Parameters.Add("@enabled", SqlDbType.Bit).Value = alarm.IsEnabled;

                    cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value =
                        string.IsNullOrEmpty(alarm.Label) ? (object)DBNull.Value : alarm.Label;

                    

                    cmd.Parameters.Add("@snooze", SqlDbType.Int).Value = alarm.SnoozeMinutes;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = alarm.Id;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}