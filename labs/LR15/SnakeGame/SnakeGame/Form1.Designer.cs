namespace SnakeGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.BackColor = System.Drawing.Color.White;

            this.ResumeLayout(false);
        }
    }
}