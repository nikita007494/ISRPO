using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum
{
    public partial class Form1 : Form
    {
        private readonly string[] currencies = { "RUB", "USD", "EUR", "CNY", "KRW" };

        // Курсы относительно RUB
        private readonly double[] rubRates = { 1, 77.70, 90.34, 10.96, 0.0670 };
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }
        
        private void InitializeComboBoxes()
        {
            cmBIz.Items.AddRange(currencies);
            cmBb.Items.AddRange(currencies);
            cmBIz.SelectedIndex = 0;
            cmBb.SelectedIndex = 0;
        }

        private void btnKonvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSumma.Text, out double amount) && amount > 0)
            {
                int fromIndex = cmBIz.SelectedIndex;
                int toIndex = cmBb.SelectedIndex;

                // Конвертация через RUB как базовую валюту
                double rubAmount = amount * rubRates[fromIndex];
                double result = rubAmount / rubRates[toIndex];

                txtResult.Text = $"{result:F2}";
            }
            else
            {
                MessageBox.Show("Введите корректную сумму");
            }
        }
    }
}
