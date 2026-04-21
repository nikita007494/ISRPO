using System;
using System.Windows.Forms;

namespace ConverterApp
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();

            cmbFrom.Items.AddRange(new object[] { "2", "8", "10", "16" });
            cmbTo.Items.AddRange(new object[] { "2", "8", "10", "16" });

            cmbFrom.SelectedIndex = 2;
            cmbTo.SelectedIndex = 0;

            LoadHistory();
        }

        // =========================
        // Конвертация
        // =========================
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите число!");
                return;
            }

            int fromBase = int.Parse(cmbFrom.SelectedItem.ToString());
            int toBase = int.Parse(cmbTo.SelectedItem.ToString());

            if (!ValidateInput(input, fromBase))
            {
                MessageBox.Show("Некорректный ввод!");
                return;
            }

            try
            {
                int number = Convert.ToInt32(input, fromBase);
                string result = Convert.ToString(number, toBase).ToUpper();

                txtResult.Text = result;

                db.SaveConversion(new Conversion
                {
                    InputNumber = input,
                    InputBase = fromBase,
                    OutputNumber = result,
                    OutputBase = toBase
                });

                LoadHistory();
            }
            catch
            {
                MessageBox.Show("Ошибка конвертации");
            }
        }

        // =========================
        // Валидация
        // =========================
        private bool ValidateInput(string input, int baseSystem)
        {
            string pattern = "";

            switch (baseSystem)
            {
                case 2:
                    pattern = "^[01]+$";
                    break;

                case 8:
                    pattern = "^[0-7]+$";
                    break;

                case 10:
                    pattern = "^[0-9]+$";
                    break;

                case 16:
                    pattern = "^[0-9A-Fa-f]+$";
                    break;
            }

            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
        }

        // =========================
        // Загрузка истории
        // =========================
        private void LoadHistory()
        {
            dataGridView1.DataSource = db.GetHistory();
        }
    }
}