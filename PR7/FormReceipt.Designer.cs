namespace PR7
{
    partial class FormReceipt
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelReceiptTitle;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox receiptTextBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox receiptGroupBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelReceiptTitle = new Label();
            labelOrderNumber = new Label();
            orderNumberLabel = new Label();
            labelOrderDate = new Label();
            orderDateLabel = new Label();
            labelBookTitle = new Label();
            bookTitleLabel = new Label();
            labelCustomerName = new Label();
            customerNameLabel = new Label();
            labelOffice = new Label();
            officeLabel = new Label();
            labelPrice = new Label();
            priceLabel = new Label();
            receiptTextBox = new TextBox();
            printButton = new Button();
            saveButton = new Button();
            closeButton = new Button();
            receiptGroupBox = new GroupBox();
            receiptGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // labelReceiptTitle
            // 
            labelReceiptTitle.AutoSize = true;
            labelReceiptTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            labelReceiptTitle.Location = new Point(160, 31);
            labelReceiptTitle.Margin = new Padding(4, 0, 4, 0);
            labelReceiptTitle.Name = "labelReceiptTitle";
            labelReceiptTitle.Size = new Size(238, 29);
            labelReceiptTitle.TabIndex = 0;
            labelReceiptTitle.Text = "ЧЕК ПРЕДЗАКАЗА";
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Location = new Point(40, 46);
            labelOrderNumber.Margin = new Padding(4, 0, 4, 0);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new Size(109, 20);
            labelOrderNumber.TabIndex = 0;
            labelOrderNumber.Text = "Номер заказа:";
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            orderNumberLabel.Location = new Point(160, 46);
            orderNumberLabel.Margin = new Padding(4, 0, 4, 0);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new Size(0, 18);
            orderNumberLabel.TabIndex = 1;
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Location = new Point(40, 85);
            labelOrderDate.Margin = new Padding(4, 0, 4, 0);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(44, 20);
            labelOrderDate.TabIndex = 2;
            labelOrderDate.Text = "Дата:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new Point(160, 85);
            orderDateLabel.Margin = new Padding(4, 0, 4, 0);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new Size(0, 20);
            orderDateLabel.TabIndex = 3;
            // 
            // labelBookTitle
            // 
            labelBookTitle.AutoSize = true;
            labelBookTitle.Location = new Point(40, 123);
            labelBookTitle.Margin = new Padding(4, 0, 4, 0);
            labelBookTitle.Name = "labelBookTitle";
            labelBookTitle.Size = new Size(53, 20);
            labelBookTitle.TabIndex = 4;
            labelBookTitle.Text = "Книга:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Location = new Point(160, 123);
            bookTitleLabel.Margin = new Padding(4, 0, 4, 0);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(0, 20);
            bookTitleLabel.TabIndex = 5;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(40, 162);
            labelCustomerName.Margin = new Padding(4, 0, 4, 0);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(61, 20);
            labelCustomerName.TabIndex = 6;
            labelCustomerName.Text = "Клиент:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(160, 162);
            customerNameLabel.Margin = new Padding(4, 0, 4, 0);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(0, 20);
            customerNameLabel.TabIndex = 7;
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.Location = new Point(40, 200);
            labelOffice.Margin = new Padding(4, 0, 4, 0);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(105, 20);
            labelOffice.TabIndex = 8;
            labelOffice.Text = "Офис выдачи:";
            // 
            // officeLabel
            // 
            officeLabel.AutoSize = true;
            officeLabel.Location = new Point(160, 200);
            officeLabel.Margin = new Padding(4, 0, 4, 0);
            officeLabel.Name = "officeLabel";
            officeLabel.Size = new Size(0, 20);
            officeLabel.TabIndex = 9;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelPrice.Location = new Point(40, 238);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(100, 18);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "Стоимость:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            priceLabel.ForeColor = Color.Green;
            priceLabel.Location = new Point(160, 238);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(0, 18);
            priceLabel.TabIndex = 11;
            // 
            // receiptTextBox
            // 
            receiptTextBox.Location = new Point(27, 369);
            receiptTextBox.Margin = new Padding(4, 5, 4, 5);
            receiptTextBox.Multiline = true;
            receiptTextBox.Name = "receiptTextBox";
            receiptTextBox.ReadOnly = true;
            receiptTextBox.ScrollBars = ScrollBars.Vertical;
            receiptTextBox.Size = new Size(479, 152);
            receiptTextBox.TabIndex = 2;
            // 
            // printButton
            // 
            printButton.Location = new Point(27, 554);
            printButton.Margin = new Padding(4, 5, 4, 5);
            printButton.Name = "printButton";
            printButton.Size = new Size(133, 46);
            printButton.TabIndex = 3;
            printButton.Text = "Печать";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(200, 554);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(133, 46);
            saveButton.TabIndex = 4;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(373, 554);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(133, 46);
            closeButton.TabIndex = 5;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // receiptGroupBox
            // 
            receiptGroupBox.Controls.Add(labelOrderNumber);
            receiptGroupBox.Controls.Add(orderNumberLabel);
            receiptGroupBox.Controls.Add(labelOrderDate);
            receiptGroupBox.Controls.Add(orderDateLabel);
            receiptGroupBox.Controls.Add(labelBookTitle);
            receiptGroupBox.Controls.Add(bookTitleLabel);
            receiptGroupBox.Controls.Add(labelCustomerName);
            receiptGroupBox.Controls.Add(customerNameLabel);
            receiptGroupBox.Controls.Add(labelOffice);
            receiptGroupBox.Controls.Add(officeLabel);
            receiptGroupBox.Controls.Add(labelPrice);
            receiptGroupBox.Controls.Add(priceLabel);
            receiptGroupBox.Location = new Point(27, 77);
            receiptGroupBox.Margin = new Padding(4, 5, 4, 5);
            receiptGroupBox.Name = "receiptGroupBox";
            receiptGroupBox.Padding = new Padding(4, 5, 4, 5);
            receiptGroupBox.Size = new Size(480, 277);
            receiptGroupBox.TabIndex = 1;
            receiptGroupBox.TabStop = false;
            receiptGroupBox.Text = "Информация о заказе";
            receiptGroupBox.Enter += receiptGroupBox_Enter;
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 631);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(printButton);
            Controls.Add(receiptTextBox);
            Controls.Add(receiptGroupBox);
            Controls.Add(labelReceiptTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormReceipt";
            Text = "Чек предзаказа";
            receiptGroupBox.ResumeLayout(false);
            receiptGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}