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
    public partial class RecurrenceForm : Form
    {
        private int _periodID = 1;
        public RecurrenceForm(DateTime currentDate)
        {
            InitializeComponent();
            codeeloDateTimePicker1.Value = currentDate;
            codeeloDateTimePicker2.Value = currentDate.AddDays(1);

            new List<Control> { codeeloGradientPanel1, codeeloGroupBox1, codeeloGroupBox2 }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });
        }

        private void codeeloRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(codeeloRadioButton1.Checked)
            {
                label1.Text = "Повторять каждый";
                label2.Text = "день";
                _periodID = 1;
            }
        }

        private void codeeloRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (codeeloRadioButton2.Checked)
            {
                label1.Text = "Повторять каждую";
                label2.Text = "неделю";
                _periodID = 2;
            }
        }

        private void codeeloRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (codeeloRadioButton4.Checked)
            {
                label1.Text = "Повторять каждый";
                label2.Text = "месяц";
                _periodID = 3;
            }
        }

        private void codeeloRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (codeeloRadioButton3.Checked)
            {
                label1.Text = "Повторять каждый";
                label2.Text = "год";
                _periodID = 4;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime endDate = codeeloRadioButton7.Checked ? codeeloDateTimePicker2.Value : DateTime.MinValue;
            int recurrenceCount = codeeloRadioButton6.Checked ? (int)numericUpDown2.Value : 0;

            Singleton.Instance.recurrenceTemplate = new RecurrenceTemplate();
            Singleton.Instance.recurrenceTemplate.PeriodID = _periodID;
            Singleton.Instance.recurrenceTemplate.PeriodValue = (int)numericUpDown1.Value;
            Singleton.Instance.recurrenceTemplate.StartDate = codeeloDateTimePicker1.Value;
            Singleton.Instance.recurrenceTemplate.HasEnd = !codeeloRadioButton5.Checked;
            if(Singleton.Instance.recurrenceTemplate.HasEnd)
            {
                Singleton.Instance.recurrenceTemplate.RecurrenceCount = recurrenceCount;
                Singleton.Instance.recurrenceTemplate.EndDate = endDate;
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) => Close();

        private void codeeloRadioButton6_CheckedChanged(object sender, EventArgs e) 
            => numericUpDown2.Enabled = codeeloRadioButton6.Checked;

        private void codeeloRadioButton7_CheckedChanged(object sender, EventArgs e)
            => codeeloDateTimePicker2.Enabled = codeeloRadioButton7.Checked;

        private void codeeloRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(codeeloRadioButton5.Checked)
            {
                numericUpDown2.Enabled = codeeloDateTimePicker2.Enabled = false;
            }
        }
    }
}
