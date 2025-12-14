using System;
using System.Windows.Forms;

namespace PR7
{
    public partial class FormOrder : Form
    {
        private DatabaseHelper dbHelper;
        private Book selectedBook;

        public FormOrder(DatabaseHelper dbHelper, Book book)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            this.selectedBook = book;

            LoadOffices();
            InitializeForm();
        }

        private void InitializeForm()
        {
            bookTitleLabel.Text = selectedBook.Title;
            authorLabel.Text = selectedBook.AuthorName;
            yearLabel.Text = selectedBook.ReleaseYear.ToString();
            priceLabel.Text = $"{selectedBook.Price:C}";
        }

        private void LoadOffices()
        {
            try
            {
                var offices = dbHelper.GetOffices();
                officeComboBox.DataSource = offices;
                officeComboBox.DisplayMember = "Name";
                officeComboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке офисов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация данных
                if (string.IsNullOrWhiteSpace(customerNameTextBox.Text))
                {
                    MessageBox.Show("Введите ФИО клиента", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (officeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите офис", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем клиента
                var customer = new Customer
                {
                    Name = customerNameTextBox.Text,
                    Address = addressTextBox.Text,
                    Phone = phoneTextBox.Text
                };

                // Сохраняем клиента в БД
                int customerId = dbHelper.CreateCustomer(customer);

                // Создаем заказ
                var office = (Office)officeComboBox.SelectedItem;
                var order = new Order
                {
                    OrderName = $"Предзаказ: {selectedBook.Title}",
                    BookId = selectedBook.Id,
                    OfficeId = office.Id,
                    CustomerId = customerId,
                    OrderDate = DateTime.Now,
                    Price = selectedBook.Price
                };

                // Сохраняем заказ в БД
                int orderId = dbHelper.CreateOrder(order);

                // Показываем чек
                var receiptForm = new FormReceipt(dbHelper, orderId);
                receiptForm.ShowDialog();

                MessageBox.Show("Заказ успешно оформлен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при оформлении заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }
    }
}