using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class AppointmentView : UserControl
    {
        private Appointment _appointment;
        public AppointmentView(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            FillAppointmentCard(appointment.Title, appointment.Description);
            ContextMenuStrip = CreateMenu();
        }


        private ContextMenuStrip CreateMenu()
        {
            var contextMenuStrip = new ContextMenuStrip();

            var editAppointment = new ToolStripMenuItem();
            editAppointment.Text = "Редактировать";
            editAppointment.Click += EditAppointment_Click;

            var deleteAppointment = new ToolStripMenuItem();
            deleteAppointment.Text = "Удалить";
            deleteAppointment.Click += DeleteAppointment_Click;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editAppointment, deleteAppointment });
            return contextMenuStrip;
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данное мероприятие?", "Внимание!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                CodeeloSQL.ExecuteQuery("delete from Appointments where ID =" + _appointment.ID);
                Singleton.Instance.MainForm.RefreshCalendar(_appointment.EndDate.Year, _appointment.EndDate.Month);
            }
        }

        private void EditAppointment_Click(object sender, EventArgs e)
        {
            var editAppointment = new NewAppointmentForm(_appointment.EndDate, _appointment);
            editAppointment.ShowDialog();
        }

        private void FillAppointmentCard(string title, string description)
        {
            label1.Text = title;
            label2.Text = description;

            if(_appointment.IsCompleted)
            {
                label1.ForeColor = Color.MediumSpringGreen;
                label1.Text = "Выполнено: " + _appointment.Result + Environment.NewLine + label1.Text;
            }

            var titleHeight = TextRenderer.MeasureText(title, new Font("Bahnschrift", 13f), new Size(210, 30), TextFormatFlags.WordBreak).Height;
            var descriptionHeight = TextRenderer.MeasureText(description, new Font("Bahnschrift", 10f), new Size(210, 60), TextFormatFlags.WordBreak).Height;

            descriptionHeight = descriptionHeight > 100 ? descriptionHeight + 60 : descriptionHeight + 30;
            titleHeight = titleHeight > 20 ? titleHeight + 40 : titleHeight + 20;
            titleHeight = titleHeight > 100 ? titleHeight + 60 : titleHeight + 30;

            label1.Height = titleHeight;

            Height = label1.Height + descriptionHeight;
        }
    }
}
