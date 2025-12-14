namespace PR7
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label booksLabel;

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
            titleLabel = new Label();
            booksLabel = new Label();
            booksListBox = new ListBox();
            createOrderButton = new Button();
            exitButton = new Button();
            statusLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(27, 31);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(533, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Издательство - Система предзаказов";
            // 
            // booksLabel
            // 
            booksLabel.Location = new Point(27, 108);
            booksLabel.Margin = new Padding(4, 0, 4, 0);
            booksLabel.Name = "booksLabel";
            booksLabel.Size = new Size(267, 31);
            booksLabel.TabIndex = 1;
            booksLabel.Text = "Доступные книги:";
            // 
            // booksListBox
            // 
            booksListBox.FormattingEnabled = true;
            booksListBox.Location = new Point(27, 154);
            booksListBox.Margin = new Padding(4, 5, 4, 5);
            booksListBox.Name = "booksListBox";
            booksListBox.Size = new Size(465, 304);
            booksListBox.TabIndex = 2;
            // 
            // createOrderButton
            // 
            createOrderButton.Location = new Point(27, 492);
            createOrderButton.Margin = new Padding(4, 5, 4, 5);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(200, 46);
            createOrderButton.TabIndex = 3;
            createOrderButton.Text = "Оформить предзаказ";
            createOrderButton.Click += createOrderButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(240, 492);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(133, 46);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выход";
            exitButton.Click += exitButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(27, 569);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(467, 31);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Статус подключения...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 615);
            Controls.Add(titleLabel);
            Controls.Add(booksLabel);
            Controls.Add(booksListBox);
            Controls.Add(createOrderButton);
            Controls.Add(exitButton);
            Controls.Add(statusLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Издательство - Система предзаказов";
            Load += MainForm_Load;
            ResumeLayout(false);
        }
    }
}