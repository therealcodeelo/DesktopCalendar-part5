using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class AppointmentViewPanel : UserControl
    {
        public override  Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set 
            { 
                base.BackColor = value;
                codeeloDateTimePicker1.BackColor = value;
            }
            
        }
        public AppointmentViewPanel()
        {
            InitializeComponent();

        }

        public void FillView(List<Appointment> appointments)
        {
            codeeloGradientPanel1.Controls.Clear();
            foreach (var item in appointments)
            {
                var appointment = new AppointmentView(item);
                appointment.Dock = DockStyle.Top;
                codeeloGradientPanel1.Controls.Add(appointment);
            }
            codeeloDateTimePicker1.Value = appointments[0].EndDate;
        }
    }
}
