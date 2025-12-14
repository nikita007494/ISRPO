namespace PR7
{
    partial class FormOrder
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelBookInfo;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label labelCustomerInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label labelOffice;
        private System.Windows.Forms.ComboBox officeComboBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button cancelButton;

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
            labelBookInfo = new Label();
            bookTitleLabel = new Label();
            authorLabel = new Label();
            yearLabel = new Label();
            priceLabel = new Label();
            labelCustomerInfo = new Label();
            labelName = new Label();
            customerNameTextBox = new TextBox();
            labelAddress = new Label();
            addressTextBox = new TextBox();
            labelPhone = new Label();
            phoneTextBox = new TextBox();
            labelOffice = new Label();
            officeComboBox = new ComboBox();
            createOrderButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // labelBookInfo
            // 
            labelBookInfo.AutoSize = true;
            labelBookInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelBookInfo.Location = new Point(27, 31);
            labelBookInfo.Margin = new Padding(4, 0, 4, 0);
            labelBookInfo.Name = "labelBookInfo";
            labelBookInfo.Size = new Size(203, 20);
            labelBookInfo.TabIndex = 0;
            labelBookInfo.Text = "Информация о книге";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Location = new Point(53, 77);
            bookTitleLabel.Margin = new Padding(4, 0, 4, 0);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(80, 20);
            bookTitleLabel.TabIndex = 1;
            bookTitleLabel.Text = "Название:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(53, 115);
            authorLabel.Margin = new Padding(4, 0, 4, 0);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(54, 20);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Автор:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(53, 154);
            yearLabel.Margin = new Padding(4, 0, 4, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(36, 20);
            yearLabel.TabIndex = 3;
            yearLabel.Text = "Год:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            priceLabel.ForeColor = Color.Green;
            priceLabel.Location = new Point(53, 192);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(52, 18);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Цена:";
            // 
            // labelCustomerInfo
            // 
            labelCustomerInfo.AutoSize = true;
            labelCustomerInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelCustomerInfo.Location = new Point(27, 246);
            labelCustomerInfo.Margin = new Padding(4, 0, 4, 0);
            labelCustomerInfo.Name = "labelCustomerInfo";
            labelCustomerInfo.Size = new Size(162, 20);
            labelCustomerInfo.TabIndex = 5;
            labelCustomerInfo.Text = "Данные клиента";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(53, 292);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 20);
            labelName.TabIndex = 6;
            labelName.Text = "ФИО:";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(160, 288);
            customerNameTextBox.Margin = new Padding(4, 5, 4, 5);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(332, 27);
            customerNameTextBox.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(53, 338);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(54, 20);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(160, 334);
            addressTextBox.Margin = new Padding(4, 5, 4, 5);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(332, 27);
            addressTextBox.TabIndex = 9;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(53, 385);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 20);
            labelPhone.TabIndex = 10;
            labelPhone.Text = "Телефон:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(160, 380);
            phoneTextBox.Margin = new Padding(4, 5, 4, 5);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(332, 27);
            phoneTextBox.TabIndex = 11;
            // 
            // labelOffice
            // 
            labelOffice.AutoSize = true;
            labelOffice.Location = new Point(53, 431);
            labelOffice.Margin = new Padding(4, 0, 4, 0);
            labelOffice.Name = "labelOffice";
            labelOffice.Size = new Size(105, 20);
            labelOffice.TabIndex = 12;
            labelOffice.Text = "Офис выдачи:";
            // 
            // officeComboBox
            // 
            officeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            officeComboBox.FormattingEnabled = true;
            officeComboBox.Location = new Point(160, 426);
            officeComboBox.Margin = new Padding(4, 5, 4, 5);
            officeComboBox.Name = "officeComboBox";
            officeComboBox.Size = new Size(332, 28);
            officeComboBox.TabIndex = 13;
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(133, 492);
            createOrderButton.Margin = new Padding(4, 5, 4, 5);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(160, 46);
            createOrderButton.TabIndex = 14;
            createOrderButton.Text = "Оформить заказ";
            createOrderButton.UseVisualStyleBackColor = true;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(333, 492);
            cancelButton.Margin = new Padding(4, 5, 4, 5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(133, 46);
            cancelButton.TabIndex = 15;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 569);
            Controls.Add(cancelButton);
            Controls.Add(createOrderButton);
            Controls.Add(officeComboBox);
            Controls.Add(labelOffice);
            Controls.Add(phoneTextBox);
            Controls.Add(labelPhone);
            Controls.Add(addressTextBox);
            Controls.Add(labelAddress);
            Controls.Add(customerNameTextBox);
            Controls.Add(labelName);
            Controls.Add(labelCustomerInfo);
            Controls.Add(priceLabel);
            Controls.Add(yearLabel);
            Controls.Add(authorLabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(labelBookInfo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormOrder";
            Text = "Оформление предзаказа";
            Load += FormOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}