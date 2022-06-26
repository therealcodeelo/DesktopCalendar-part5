using System;

namespace DesktopCalendar
{
    public class Appointment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
        public string Result { get; set; }
        public int RecurrenceID { get; set; }
    }
}
