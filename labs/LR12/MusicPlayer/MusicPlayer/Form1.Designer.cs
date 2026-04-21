namespace MusicPlayer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelRight;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTime;

        private System.Windows.Forms.TrackBar trackBarProgress;
        private System.Windows.Forms.TrackBar trackBarVolume;

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnNext;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelRight.Controls.Add(this.lblTitle);
            this.panelRight.Controls.Add(this.lblArtist);
            this.panelRight.Controls.Add(this.lblTime);
            this.panelRight.Controls.Add(this.trackBarProgress);
            this.panelRight.Controls.Add(this.trackBarVolume);
            this.panelRight.Controls.Add(this.btnPrev);
            this.panelRight.Controls.Add(this.btnPlay);
            this.panelRight.Controls.Add(this.btnPause);
            this.panelRight.Controls.Add(this.btnNext);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Location = new System.Drawing.Point(570, 10);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(320, 480);
            this.panelRight.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название";
            // 
            // lblArtist
            // 
            this.lblArtist.ForeColor = System.Drawing.Color.LightGray;
            this.lblArtist.Location = new System.Drawing.Point(10, 45);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(300, 25);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Исполнитель";
            // 
            // lblTime
            // 
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(10, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(300, 25);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00 / 00:00";
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Location = new System.Drawing.Point(10, 100);
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(300, 45);
            this.trackBarProgress.TabIndex = 3;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(10, 140);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(300, 45);
            this.trackBarVolume.TabIndex = 4;
            this.trackBarVolume.Value = 50;
            // 
            // btnPrev
            // 
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(10, 200);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(60, 45);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "⏮";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(80, 200);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 45);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "▶";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(150, 200);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(60, 45);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "⏸";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(220, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 45);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "⏭";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(170, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelRight);
            this.Name = "Form1";
            this.Text = "Музыкальный плеер";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }
    }
}