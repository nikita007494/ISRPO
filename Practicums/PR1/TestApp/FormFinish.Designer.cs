namespace Praktikum1
{
    partial class FormFinish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtvet = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnVixod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZanovo1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(206, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тест пройден!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOtvet
            // 
            this.lblOtvet.AutoSize = true;
            this.lblOtvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtvet.Location = new System.Drawing.Point(156, 88);
            this.lblOtvet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtvet.Name = "lblOtvet";
            this.lblOtvet.Size = new System.Drawing.Size(0, 24);
            this.lblOtvet.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(208, 140);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 2;
            // 
            // btnVixod
            // 
            this.btnVixod.Location = new System.Drawing.Point(386, 288);
            this.btnVixod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVixod.Name = "btnVixod";
            this.btnVixod.Size = new System.Drawing.Size(126, 34);
            this.btnVixod.TabIndex = 4;
            this.btnVixod.Text = "Выход";
            this.btnVixod.UseVisualStyleBackColor = true;
            this.btnVixod.Click += new System.EventHandler(this.btnVixod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 140);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 144);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnZanovo1
            // 
            this.btnZanovo1.Location = new System.Drawing.Point(78, 288);
            this.btnZanovo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZanovo1.Name = "btnZanovo1";
            this.btnZanovo1.Size = new System.Drawing.Size(126, 34);
            this.btnZanovo1.TabIndex = 7;
            this.btnZanovo1.Text = "Пройти заново";
            this.btnZanovo1.UseVisualStyleBackColor = true;
            this.btnZanovo1.Click += new System.EventHandler(this.btnZanovo1_Click);
            // 
            // FormFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnZanovo1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVixod);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOtvet);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFinish";
            this.Text = "FormFinish";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtvet;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnVixod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZanovo1;
    }
}