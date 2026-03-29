using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Fieldofmiracles
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Server=DESKTOP-HKB5J94\SQLEXPRESS;Database=FieldOfMiraclesDB;Trusted_Connection=True;";

        private string currentWord;
        private string shuffledWord;

        private Stack<string> history = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateLetterButtons();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            currentWord = Normalize(GetRandomWord());
            shuffledWord = Shuffle(currentWord);

            txtShuffled.Text = shuffledWord;
            txtResult.Text = "";

            history.Clear();
        }

        private string GetRandomWord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 Word FROM Words ORDER BY NEWID()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        private string Shuffle(string word)
        {
            Random rnd = new Random();
            return new string(word.ToCharArray().OrderBy(x => rnd.Next()).ToArray());
        }

        private string Normalize(string input)
        {
            return input.Replace('ё', 'е').Replace('Ё', 'Е');
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Normalize(txtResult.Text).Trim().ToLower() == currentWord.Trim().ToLower())
            {
                MessageBox.Show("Вы угадали слово!");
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }
        private void CreateLetterButtons()
        {
            int x = 50;
            int y = 160;

            string letters = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩ";

            foreach (char c in letters)
            {
                Button btn = new Button();
                btn.Text = c.ToString();
                btn.Width = 35;
                btn.Height = 35;
                btn.Left = x;
                btn.Top = y;

                btn.Click += Letter_Click;

                this.Controls.Add(btn);

                x += 40;
                if (x > 350)
                {
                    x = 50;
                    y += 40;
                }
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                txtResult.Text = history.Pop();
            }
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            history.Push(txtResult.Text);

            txtResult.Text += btn.Text;
        }
    }
}