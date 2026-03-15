using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SkladApp
{
    public partial class Sklad : Form
    {
        private string connectionString = @"Data Source=DESKTOP-HKB5J94;Initial Catalog=Supermarket;Integrated Security=True;TrustServerCertificate=true;Encrypt=false";
        
        public Sklad()
        {
            InitializeComponent();
        }

        // Добавьте этот метод для обработки события загрузки формы
        private void Sklad_Load(object sender, EventArgs e)
        {
            LoadProducts();

            // Заполняем комбобокс начальными значениями
            nametovcombobox.Items.AddRange(new object[] {
                "Хлеб", "Вода", "Сладости", "Газировка", "Молоко", "Мясо", "Овощи", "Фрукты"
            });

            // Устанавливаем текст подсказки для поля поиска
            nametvpostxt.Text = "Имя товара для поиска";
            nametvpostxt.ForeColor = System.Drawing.Color.Gray;
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newnametxt.Text))
            {
                MessageBox.Show("Введите новое наименование товара!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Получаем максимальный ID для нового товара
                    string getMaxIdQuery = "SELECT ISNULL(MAX(id), 0) + 1 FROM products";
                    SqlCommand getMaxIdCmd = new SqlCommand(getMaxIdQuery, connection);
                    int newId = Convert.ToInt32(getMaxIdCmd.ExecuteScalar());

                    string query = @"INSERT INTO products (id, name, stillage, cell, quantity) 
                                   VALUES (@id, @name, @stillage, @cell, @quantity)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", newId);
                    command.Parameters.AddWithValue("@name", newnametxt.Text);
                    command.Parameters.AddWithValue("@stillage", nomstupdovn.Value);
                    command.Parameters.AddWithValue("@cell", nomichupdovn.Value);
                    command.Parameters.AddWithValue("@quantity", kolvoupdovn.Value);

                    command.ExecuteNonQuery();
                    LoadProducts();
                    ClearAddFields();
                    MessageBox.Show("Товар успешно добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?", "Подтверждение удаления",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM products WHERE id = @id";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", productId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                LoadProducts();
                                MessageBox.Show("Товар успешно удален!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления!");
            }
        }

        private void psponzvbtn_Click(object sender, EventArgs e)
        {
            string searchName = nametvpostxt.Text.Trim();
            if (!string.IsNullOrEmpty(searchName) && searchName != "Имя товара для поиска")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM products WHERE name LIKE @name";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        adapter.SelectCommand.Parameters.AddWithValue("@name", "%" + searchName + "%");
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка поиска: " + ex.Message);
                }
            }
            else
            {
                LoadProducts();
            }
        }

        private void poiskpokoordinatambtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM products WHERE cell = @cell AND stillage = @stillage";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@cell", (int)ijeikaUpDown.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@stillage", (int)stelajjUpDown.Value);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска: " + ex.Message);
            }
        }

        private void otkbtn_Click(object sender, EventArgs e)
        {
            LoadProducts();
            ClearAddFields();
            ClearSearchFields();
        }

        private void sohbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить данные о продуктах";
                saveFileDialog.FileName = "products_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Заголовок
                        writer.WriteLine("ID;Название;Стеллаж;Ячейка;Количество");

                        // Данные
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                writer.WriteLine($"{row.Cells["id"].Value};{row.Cells["name"].Value};{row.Cells["stillage"].Value};{row.Cells["cell"].Value};{row.Cells["quantity"].Value}");
                            }
                        }
                    }
                    MessageBox.Show($"Данные успешно сохранены в файл: {saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения в файл: " + ex.Message);
            }
        }

        private void dobname_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nametovcombobox.Text))
            {
                newnametxt.Text = nametovcombobox.Text;
            }
        }

        private void ClearAddFields()
        {
            newnametxt.Clear();
            nomstupdovn.Value = 0;
            nomichupdovn.Value = 0;
            kolvoupdovn.Value = 0;
        }

        private void ClearSearchFields()
        {
            nametvpostxt.Text = "Имя товара для поиска";
            nametvpostxt.ForeColor = System.Drawing.Color.Gray;
            ijeikaUpDown.Value = 0;
            stelajjUpDown.Value = 0;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Автозаполнение полей при выборе товара
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                newnametxt.Text = row.Cells["name"].Value?.ToString() ?? "";
                nomstupdovn.Value = Convert.ToDecimal(row.Cells["stillage"].Value ?? 0);
                nomichupdovn.Value = Convert.ToDecimal(row.Cells["cell"].Value ?? 0);
                kolvoupdovn.Value = Convert.ToDecimal(row.Cells["quantity"].Value ?? 0);
            }
        }

        private void nametvpostxt_Enter(object sender, EventArgs e)
        {
            if (nametvpostxt.Text == "Имя товара для поиска")
            {
                nametvpostxt.Text = "";
                nametvpostxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void nametvpostxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nametvpostxt.Text))
            {
                nametvpostxt.Text = "Имя товара для поиска";
                nametvpostxt.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}