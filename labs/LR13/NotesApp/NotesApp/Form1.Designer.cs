namespace NotesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ListBox listBoxNotes;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAllNotes;
        private System.Windows.Forms.Button btnSave;
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();


            // =====================
            // btnSave
            // =====================
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Location = new System.Drawing.Point(420, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.Controls.Add(this.btnSave);
            // =====================
            // calendar
            // =====================
            this.calendar.Location = new System.Drawing.Point(20, 20);
            this.calendar.Name = "calendar";

            // =====================
            // chkAllNotes
            // =====================
            this.chkAllNotes = new System.Windows.Forms.CheckBox();
            this.chkAllNotes.Location = new System.Drawing.Point(300, 230);
            this.chkAllNotes.Name = "chkAllNotes";
            this.chkAllNotes.Size = new System.Drawing.Size(200, 24);
            this.chkAllNotes.Text = "Показать все заметки";
            this.chkAllNotes.CheckedChanged += new System.EventHandler(this.chkAllNotes_CheckedChanged);

            // ❗ ВАЖНО
            this.Controls.Add(this.chkAllNotes);
            // =====================
            // listBoxNotes
            // =====================
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.ItemHeight = 16;
            this.listBoxNotes.Location = new System.Drawing.Point(300, 20);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(400, 196);

            // =====================
            // label1 (Время)
            // =====================
            this.label1.Location = new System.Drawing.Point(20, 200);
            this.label1.Text = "Время";

            // =====================
            // timePicker
            // =====================
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Location = new System.Drawing.Point(20, 220);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 22);

            // =====================
            // label2 (Текст)
            // =====================
            this.label2.Location = new System.Drawing.Point(20, 250);
            this.label2.Text = "Заметка";

            // =====================
            // txtNote
            // =====================
            this.txtNote.Location = new System.Drawing.Point(20, 270);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(680, 60);

            // =====================
            // btnAdd
            // =====================
            this.btnAdd.Location = new System.Drawing.Point(20, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // =====================
            // btnEdit
            // =====================
            this.btnEdit.Location = new System.Drawing.Point(150, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // =====================
            // btnDelete
            // =====================
            this.btnDelete.Location = new System.Drawing.Point(280, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // =====================
            // Form1
            // =====================
            this.ClientSize = new System.Drawing.Size(740, 420);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Заметки с календарем";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}