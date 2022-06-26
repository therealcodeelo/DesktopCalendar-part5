using System;

namespace DesktopCalendar
{
    internal class RecurrenceTemplate
    {
        public int PeriodID { get; set; }
        public int PeriodValue { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasEnd { get; set; }
        public DateTime EndDate { get; set; }
        public int RecurrenceCount { get; set; }
    }
}
