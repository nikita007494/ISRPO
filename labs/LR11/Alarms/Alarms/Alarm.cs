using System;

namespace Alarms
{
    public class Alarm
    {
        public int Id { get; set; }
        public TimeSpan AlarmTime { get; set; }
        public DateTime AlarmDate { get; set; }
        public bool IsEnabled { get; set; }
        public string Label { get; set; }
        public string RepeatDays { get; set; }
        public int SnoozeMinutes { get; set; }
    }
}