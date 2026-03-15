namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.label_resulit_numbers = new System.Windows.Forms.Label();
            this.label_resulits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Генератор и проверка счастливых билетов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(318, 204);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(163, 23);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Сгенерировать билет";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // label_resulit_numbers
            // 
            this.label_resulit_numbers.AutoSize = true;
            this.label_resulit_numbers.Location = new System.Drawing.Point(384, 277);
            this.label_resulit_numbers.Name = "label_resulit_numbers";
            this.label_resulit_numbers.Size = new System.Drawing.Size(35, 13);
            this.label_resulit_numbers.TabIndex = 2;
            this.label_resulit_numbers.Text = "label2";
            // 
            // label_resulits
            // 
            this.label_resulits.AutoSize = true;
            this.label_resulits.Location = new System.Drawing.Point(384, 325);
            this.label_resulits.Name = "label_resulits";
            this.label_resulits.Size = new System.Drawing.Size(35, 13);
            this.label_resulits.TabIndex = 3;
            this.label_resulits.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 484);
            this.Controls.Add(this.label_resulits);
            this.Controls.Add(this.label_resulit_numbers);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Label label_resulit_numbers;
        private System.Windows.Forms.Label label_resulits;
    }
}

