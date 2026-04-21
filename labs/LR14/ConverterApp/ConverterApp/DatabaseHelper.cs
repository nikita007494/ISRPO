using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConverterApp
{
    public class DatabaseHelper
    {
        private string connectionString =
            @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=ConverterDB;Trusted_Connection=True;";

        public void SaveConversion(Conversion conv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO ConversionHistory
                    (InputNumber, InputBase, OutputNumber, OutputBase)
                    VALUES (@in, @inBase, @out, @outBase)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@in", SqlDbType.NVarChar).Value = conv.InputNumber;
                        cmd.Parameters.Add("@inBase", SqlDbType.Int).Value = conv.InputBase;
                        cmd.Parameters.Add("@out", SqlDbType.NVarChar).Value = conv.OutputNumber;
                        cmd.Parameters.Add("@outBase", SqlDbType.Int).Value = conv.OutputBase;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
        }

        public List<Conversion> GetHistory()
        {
            var list = new List<Conversion>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM ConversionHistory ORDER BY ConversionDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Conversion
                            {
                                Id = (int)reader["Id"],
                                InputNumber = reader["InputNumber"].ToString(),
                                InputBase = (int)reader["InputBase"],
                                OutputNumber = reader["OutputNumber"].ToString(),
                                OutputBase = (int)reader["OutputBase"],
                                ConversionDate = (DateTime)reader["ConversionDate"]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки истории: " + ex.Message);
            }

            return list;
        }
    }
}