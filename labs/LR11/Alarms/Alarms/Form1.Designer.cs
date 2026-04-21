namespace Alarms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToggle;

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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // =====================
            // labelTime
            // =====================
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelTime.Location = new System.Drawing.Point(20, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(300, 50);
            this.labelTime.Text = "00:00:00";

            // =====================
            // labelDate
            // =====================
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelDate.Location = new System.Drawing.Point(20, 60);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(300, 30);
            this.labelDate.Text = "01.01.2025";

            // =====================
            // listBoxAlarms
            // =====================
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.Location = new System.Drawing.Point(20, 100);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(350, 160);

            // =====================
            // timePicker
            // =====================
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Location = new System.Drawing.Point(20, 270);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(120, 22);

            // =====================
            // txtLabel
            // =====================
            this.txtLabel.Location = new System.Drawing.Point(150, 270);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(220, 22);

            // =====================
            // btnAdd
            // =====================
            this.btnAdd.Location = new System.Drawing.Point(20, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // =====================
            // btnDelete
            // =====================
            this.btnDelete.Location = new System.Drawing.Point(130, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // =====================
            // btnToggle
            // =====================
            this.btnToggle.Location = new System.Drawing.Point(240, 310);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(130, 30);
            this.btnToggle.Text = "Вкл / Выкл";
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);

            // =====================
            // Form1
            // =====================
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listBoxAlarms);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnToggle);
            this.Name = "Form1";
            this.Text = "Будильник";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}