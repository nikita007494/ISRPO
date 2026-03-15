using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABA_1
{
    public partial class Form1 : Form
    {
        // Подключение к базе данных supermarket
        private string connectionString = "Data Source=DESKTOP-HKB5J94;Initial Catalog=Supermarket;Integrated Security=True";

        // Словарь для хранения цен по названию продукта
        private Dictionary<string, decimal> products = new Dictionary<string, decimal>();

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // Загружаем продукты из базы данных в ComboBox
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, price FROM products";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    decimal price = reader.GetDecimal(1);
                    products[name] = price;
                    Tovar_comboBox.Items.Add(name);
                }
            }
        }

        // Добавить выбранный продукт в ListBox
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Tovar_comboBox.SelectedItem != null)
            {
                string product = Tovar_comboBox.SelectedItem.ToString();
                listBox1.Items.Add(product);
            }
            else
            {
                MessageBox.Show("Выберите продукт!");
            }
        }

        // Очистить список
        private void Clear_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Resulit_textBox.Clear();
        }

        // Посчитать итоговую сумму
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Resulit_button_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var item in listBox1.Items)
            {
                string name = item.ToString();
                if (products.ContainsKey(name))
                    total += products[name];
            }
            Resulit_textBox.Text = $"Итого: {total:C}";
        }
    }
}
