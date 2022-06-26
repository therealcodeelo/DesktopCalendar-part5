using System;

namespace DesktopCalendar
{
    internal class RecurrencePattern
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasEnd { get; set; }
        public DateTime EndDate { get; set; }
        public int RecurrenceCount { get; set; }
        public int PeriodID { get; set; }
        public int PeriodValue { get; set; }
    }
}
