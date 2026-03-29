namespace Fieldofmiracles
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtShuffled;
        private System.Windows.Forms.TextBox txtResult;

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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtShuffled = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SuspendLayout();

            // txtShuffled
            this.txtShuffled.Location = new System.Drawing.Point(50, 30);
            this.txtShuffled.Size = new System.Drawing.Size(300, 22);
            this.txtShuffled.ReadOnly = true;

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(50, 70);
            this.txtResult.Size = new System.Drawing.Size(300, 22);

            // btnNewGame
            this.btnNewGame.Location = new System.Drawing.Point(50, 110);
            this.btnNewGame.Size = new System.Drawing.Size(100, 30);
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            // btnCheck
            this.btnCheck.Location = new System.Drawing.Point(160, 110);
            this.btnCheck.Size = new System.Drawing.Size(90, 30);
            this.btnCheck.Text = "Проверить";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);

            // btnUndo
            this.btnUndo.Location = new System.Drawing.Point(260, 110);
            this.btnUndo.Size = new System.Drawing.Size(90, 30);
            this.btnUndo.Text = "Отмена";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);



            // Form
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.txtShuffled);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnUndo);

            this.Text = "Поле чудес";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}