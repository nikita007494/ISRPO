namespace ConverterApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "Введите число";

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(20, 40);
            this.txtInput.Size = new System.Drawing.Size(200, 22);

            // label2
            this.label2.Location = new System.Drawing.Point(240, 20);
            this.label2.Text = "Из системы";

            // cmbFrom
            this.cmbFrom.Location = new System.Drawing.Point(240, 40);
            this.cmbFrom.Size = new System.Drawing.Size(80, 24);
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // label3
            this.label3.Location = new System.Drawing.Point(340, 20);
            this.label3.Text = "В систему";

            // cmbTo
            this.cmbTo.Location = new System.Drawing.Point(340, 40);
            this.cmbTo.Size = new System.Drawing.Size(80, 24);
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnConvert
            this.btnConvert.Location = new System.Drawing.Point(440, 35);
            this.btnConvert.Size = new System.Drawing.Size(120, 30);
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

            // label4
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Text = "Результат";

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(20, 100);
            this.txtResult.Size = new System.Drawing.Size(200, 22);
            this.txtResult.ReadOnly = true;

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(20, 140);
            this.dataGridView1.Size = new System.Drawing.Size(540, 250);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.dataGridView1);
            this.Text = "Конвертер систем счисления";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}