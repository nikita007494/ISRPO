using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SnakeGame
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=SnakeGameDB;Trusted_Connection=True;";

        public void SaveResult(string name, int score, int duration)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO GameResults 
                    (PlayerName, Score, GameDuration)
                    VALUES (@name, @score, @time)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@score", SqlDbType.Int).Value = score;
                        cmd.Parameters.Add("@time", SqlDbType.Int).Value = duration;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
        }
    }
}