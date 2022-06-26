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
    public partial class NewAppointmentForm : Form
    {
        private DateTime _currentDate;
        private Appointment _appointment;
        public NewAppointmentForm(DateTime currentDate, Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            _currentDate = currentDate;
            Singleton.Instance.recurrenceTemplate = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => codeeloTextBox3.Enabled = checkBox1.Checked;

        private void codeeloButton2_Click(object sender, EventArgs e) => Close();

        private void codeeloButton1_Click(object sender, EventArgs e)
        {
            if(_appointment == null)
            {
                SaveAppointment();
            }
            else
            {
                UpdateAppointment();
            }
            Singleton.Instance.MainForm.RefreshCalendar(_currentDate.Year, _currentDate.Month);
            Close();
        }
        private void SaveAppointment()
        {
            if (Singleton.Instance.recurrenceTemplate == null)
            {
                var appointment = new Appointment()
                {
                    Title = codeeloTextBox1.Text,
                    EndDate = codeeloDateTimePicker1.Value,
                    Description = codeeloTextBox2.Text,
                    IsCompleted = false
                };
                CodeeloSQL.AddAppointment(appointment);
            }
            else
            {
                var appointment = new Appointment()
                {
                    Title = codeeloTextBox1.Text,
                    Description = codeeloTextBox2.Text
                };
                 CodeeloSQL.AddRecurrenceInfo(appointment,Singleton.Instance.recurrenceTemplate);
            }
        }
        private void UpdateAppointment()
        {
            _appointment.Title = codeeloTextBox1.Text;
            _appointment.EndDate = codeeloDateTimePicker1.Value;
            _appointment.Description = codeeloTextBox2.Text;
            

            if(_appointment.ID == 0)
            {
                _appointment.ID = CodeeloSQL.GetNextAppointmentID();
                CodeeloSQL.AddAppointment(_appointment);
            }
            if(checkBox1.Checked)
            {
                _appointment.IsCompleted = checkBox1.Checked;
                _appointment.Result = codeeloTextBox3.Text;
            }
            CodeeloSQL.UpdateAppointment(_appointment);
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            codeeloDateTimePicker1.Value = _currentDate;
            if(_appointment != null)
            {
                codeeloTextBox1.Text = _appointment.Title;
                codeeloTextBox2.Text = _appointment.Description;
                codeeloTextBox3.Text = _appointment.Result;
                codeeloDateTimePicker1.Value = _appointment.EndDate;
                checkBox1.Checked = _appointment.IsCompleted;
            }
        }

        private void codeeloButton3_Click(object sender, EventArgs e)
        {
            var recurrenceForm = new RecurrenceForm(_currentDate);
            recurrenceForm.ShowDialog();
        }
    }
}
