using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string bilet = random.Next(100000, 999999).ToString();

            label_resulit_numbers.Text = bilet;


            // проверка на счастливый билет

            int sum_1 = (bilet[0] - '0') + (bilet[1] - '0') + (bilet[2] - '0');
            int sum_2 = (bilet[3] - '0') + (bilet[4] - '0') + (bilet[5] - '0');

            if (sum_1 == sum_2)
            {
                label_resulits.Text = "СЧАСТЛИВЫЙ БИЛЕТ!";
                label_resulits.ForeColor = Color.Green;
                
                label_resulit_numbers.ForeColor = Color.Green;
            }
            else 
            {
                label_resulits.Text = "ГАЛИМЫЙ БИЛЕТ!";
                label_resulits.ForeColor = Color.Red;

                label_resulit_numbers.ForeColor = Color.Red;

            }
        }
    }
}
