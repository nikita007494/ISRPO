using Microsoft.Data.SqlClient;
using PR7;
using System.Windows.Forms;

namespace PR7
{
    public partial class MainForm : Form
    {
        private DatabaseHelper dbHelper;

        public MainForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadBooks();
            TestConnection();
        }

        private void TestConnection()
        {
            try
            {
                if (dbHelper.TestConnection())
                {
                    statusLabel.Text = "Подключено к базе данных";
                    statusLabel.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    statusLabel.Text = "Ошибка подключения к БД";
                    statusLabel.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Ошибка: {ex.Message}";
                statusLabel.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void LoadBooks()
        {
            try
            {
                var books = dbHelper.GetBooks();
                booksListBox.DataSource = books;
                booksListBox.DisplayMember = "Title";
                booksListBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке книг: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите книгу для заказа", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedBook = (Book)booksListBox.SelectedItem;
            var orderForm = new FormOrder(dbHelper, selectedBook);
            orderForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}