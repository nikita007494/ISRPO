using System;
using System.Windows.Forms;

namespace PR7
{
    public partial class FormReceipt : Form
    {
        private DatabaseHelper dbHelper;
        private int orderId;

        public FormReceipt(DatabaseHelper dbHelper, int orderId)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.orderId = orderId;

            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            try
            {
                var order = dbHelper.GetOrderDetails(orderId);

                if (order != null)
                {
                    orderNumberLabel.Text = $"№ {order.Id}";
                    orderDateLabel.Text = order.OrderDate.ToString("dd.MM.yyyy HH:mm");
                    bookTitleLabel.Text = order.BookTitle;
                    customerNameLabel.Text = order.CustomerName;
                    officeLabel.Text = order.OfficeName;
                    priceLabel.Text = $"{order.Price:C}";

                    // Генерация текста для печати/сохранения
                    receiptTextBox.Text = GenerateReceiptText(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных чека: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateReceiptText(Order order)
        {
            return $"================================\n" +
                   $"        ЧЕК ПРЕДЗАКАЗА\n" +
                   $"================================\n" +
                   $"Номер заказа: {order.Id}\n" +
                   $"Дата: {order.OrderDate:dd.MM.yyyy HH:mm}\n" +
                   $"================================\n" +
                   $"Книга: {order.BookTitle}\n" +
                   $"Клиент: {order.CustomerName}\n" +
                   $"Офис получения: {order.OfficeName}\n" +
                   $"================================\n" +
                   $"Стоимость: {order.Price:C}\n" +
                   $"================================\n" +
                   $"Спасибо за заказ!\n" +
                   $"Ожидайте уведомления о поступлении.";
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Здесь можно реализовать печать чека
                MessageBox.Show("Функция печати будет реализована позже", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при печати: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveDialog.Title = "Сохранить чек";
                saveDialog.FileName = $"чек_заказа_{orderId}.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveDialog.FileName, receiptTextBox.Text);
                    MessageBox.Show("Чек успешно сохранен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void receiptGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}