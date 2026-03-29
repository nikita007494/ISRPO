namespace LABA_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clear_button = new System.Windows.Forms.Button();
            this.Resulit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Tovar_comboBox = new System.Windows.Forms.ComboBox();
            this.Resulit_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(251, 253);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 0;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // Resulit_button
            // 
            this.Resulit_button.Location = new System.Drawing.Point(458, 244);
            this.Resulit_button.Name = "Resulit_button";
            this.Resulit_button.Size = new System.Drawing.Size(75, 40);
            this.Resulit_button.TabIndex = 1;
            this.Resulit_button.Text = "Посчитать итог";
            this.Resulit_button.UseVisualStyleBackColor = true;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(352, 186);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Tovar_comboBox
            // 
            this.Tovar_comboBox.FormattingEnabled = true;
            this.Tovar_comboBox.Location = new System.Drawing.Point(332, 147);
            this.Tovar_comboBox.Name = "Tovar_comboBox";
            this.Tovar_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Tovar_comboBox.TabIndex = 4;
            // 
            // Resulit_textBox
            // 
            this.Resulit_textBox.Location = new System.Drawing.Point(443, 327);
            this.Resulit_textBox.Name = "Resulit_textBox";
            this.Resulit_textBox.Size = new System.Drawing.Size(100, 20);
            this.Resulit_textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Итоговая сумма за покупку";
            // 
            // Form1
            // 

            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            this.Resulit_button.Click += new System.EventHandler(this.Resulit_button_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resulit_textBox);
            this.Controls.Add(this.Tovar_comboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Resulit_button);
            this.Controls.Add(this.Clear_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Resulit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox Tovar_comboBox;
        private System.Windows.Forms.TextBox Resulit_textBox;
        private System.Windows.Forms.Label label1;
    }
}

