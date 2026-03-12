namespace Praktikum1
{
    partial class FormStart
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImya = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.btnNacalo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тестирование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия:";
            // 
            // txtImya
            // 
            this.txtImya.Location = new System.Drawing.Point(149, 153);
            this.txtImya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImya.Name = "txtImya";
            this.txtImya.Size = new System.Drawing.Size(175, 20);
            this.txtImya.TabIndex = 3;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(149, 106);
            this.txtFamilia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(175, 20);
            this.txtFamilia.TabIndex = 4;
            // 
            // btnNacalo
            // 
            this.btnNacalo.Location = new System.Drawing.Point(149, 193);
            this.btnNacalo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNacalo.Name = "btnNacalo";
            this.btnNacalo.Size = new System.Drawing.Size(175, 32);
            this.btnNacalo.TabIndex = 5;
            this.btnNacalo.Text = "Пройти тест";
            this.btnNacalo.UseVisualStyleBackColor = true;
            this.btnNacalo.Click += new System.EventHandler(this.btnNacalo_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 297);
            this.Controls.Add(this.btnNacalo);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.txtImya);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStart";
            this.Text = "Начало тестирования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImya;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Button btnNacalo;
    }
}

