using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alarms
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        List<Alarm> alarms = new List<Alarm>();
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            listBoxAlarms.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxAlarms.DrawItem += listBoxAlarms_DrawItem;
            // настройка таймера
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            LoadAlarms();
        }
        private void listBoxAlarms_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var alarm = alarms[e.Index];

            e.DrawBackground();

            var brush = alarm.IsEnabled ? Brushes.Green : Brushes.Red;

            e.Graphics.DrawString(
                $"{alarm.AlarmTime:hh\\:mm}  |  {alarm.Label}",
                e.Font,
                brush,
                e.Bounds);

            e.DrawFocusRectangle();
        }
        // =========================
        // Загрузка будильников
        // =========================
        private void LoadAlarms()
        {
            alarms = db.GetAlarms();

            listBoxAlarms.DataSource = null;
            listBoxAlarms.DataSource = alarms;
            listBoxAlarms.DisplayMember = "Label";
        }

        // =========================
        // Таймер (каждую секунду)
        // =========================
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            labelTime.Text = now.ToString("HH:mm:ss");
            labelDate.Text = now.ToString("dd.MM.yyyy");

            CheckAlarms(now);
        }

        // =========================
        // Проверка будильников
        // =========================
        private HashSet<int> triggered = new HashSet<int>();

        private void CheckAlarms(DateTime now)
        {
            foreach (var alarm in alarms)
            {
                if (!alarm.IsEnabled) continue;

                if (alarm.AlarmTime.Hours == now.Hour &&
                    alarm.AlarmTime.Minutes == now.Minute)
                {
                    if (!triggered.Contains(alarm.Id))
                    {
                        TriggerAlarm(alarm);
                        triggered.Add(alarm.Id);
                    }
                }
            }

            if (now.Hour == 0 && now.Minute == 0)
                triggered.Clear();
        }

        // =========================
        // Срабатывание
        // =========================
        private void TriggerAlarm(Alarm alarm)
        {
            timer.Stop();

            System.Media.SystemSounds.Beep.Play();

            var result = MessageBox.Show(
                $"⏰ Будильник!\n{alarm.Label}\n\nОтложить?",
                "Сигнал",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                SnoozeAlarm(alarm);
            }
            else
            {
                // можно выключить будильник
                alarm.IsEnabled = false;
                db.UpdateAlarm(alarm);
            }

            LoadAlarms();
            timer.Start();
        }

        // =========================
        // Snooze (отложить)
        // =========================
        private void SnoozeAlarm(Alarm alarm)
        {
            alarm.AlarmTime = alarm.AlarmTime.Add(TimeSpan.FromMinutes(alarm.SnoozeMinutes));

            db.UpdateAlarm(alarm);
        }

        // =========================
        // Добавить будильник
        // =========================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLabel.Text))
            {
                MessageBox.Show("Введите название");
                return;
            }

            Alarm alarm = new Alarm
            {
                AlarmTime = timePicker.Value.TimeOfDay,
                Label = txtLabel.Text,
                IsEnabled = true,
                SnoozeMinutes = 5
            };

            db.AddAlarm(alarm);
            LoadAlarms();
        }

        // =========================
        // Удалить
        // =========================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem is Alarm selected)
            {
                db.DeleteAlarm(selected.Id);
                LoadAlarms();
            }
        }

        // =========================
        // Включить / выключить
        // =========================
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (listBoxAlarms.SelectedItem is Alarm selected)
            {
                selected.IsEnabled = !selected.IsEnabled;
                db.UpdateAlarm(selected);
                LoadAlarms();
            }
        }

        // =========================
        // Красивое отображение в списке
        // =========================
        private void listBoxAlarms_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Alarm alarm)
            {
                string status = alarm.IsEnabled ? "ON" : "OFF";

                e.Value = $"{alarm.AlarmTime:hh\\:mm} | {alarm.Label} | {status}";
            }
        }
    }
}