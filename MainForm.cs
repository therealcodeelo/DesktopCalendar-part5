using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopCalendar
{
    public partial class MainForm : Form
    {
        private CustomCalendar _calendar;
        private int _selectedMonth;

        private Color ACTIVE_BUTTON_COLOR = Color.FromArgb(255, 107, 107);
        private Color NOT_ACTIVE_COLOR = Color.FromArgb(84, 160, 255);
        public MainForm()
        {
            InitializeComponent();
            new List<Control>{codeeloGradientPanel1}.ForEach(x=>x.MouseDown += (s, a) =>
            {
                x.Capture = false; Capture = false;
                Message m = Message.Create(Handle,0xA1,new IntPtr(2),IntPtr.Zero);
                base.WndProc(ref m);
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _calendar = new CustomCalendar();
            _calendar.Dock = DockStyle.Fill;
            _calendar.DisplayDays(DateTime.Now);

            codeeloGradientPanel2.Controls.Add(_calendar);
            YearButton.Text = DateTime.Now.Year.ToString();
            _selectedMonth = DateTime.Now.Month;
            ChooseActiveButton(_selectedMonth).BackColor = ACTIVE_BUTTON_COLOR;

            new List<Control> { JanuaryButton,FebruaryButton,MarchButton,AprilButton,MayButton,JuneButton,JuleButton,
            AugustButton,SeptemberButton,OctoberButton,NovemberButton,DecemberButton}.ForEach((Action<Control>)(x =>
            {
                x.Click += MonthButtonClick;
            }));
        }

        private void MonthButtonClick(object sender, EventArgs e)
        {
            _selectedMonth = (sender as Button).TabIndex;
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }
        public void RefreshCalendar(int year, int month)
        {
            var date = new DateTime(year, month, 1);
            _calendar.DisplayDays(date);
            SetMonthButtonActive(ChooseActiveButton(month));
        }
        private Button ChooseActiveButton(int index)
        {
            switch (index)
            {
                case 1:
                    return JanuaryButton;
                case 2:
                    return FebruaryButton;
                case 3:
                    return MarchButton;
                case 4:
                    return AprilButton;
                case 5:
                    return MayButton;
                case 6:
                    return JuneButton;
                case 7:
                    return JuleButton;
                case 8:
                    return AugustButton;
                case 9:
                    return SeptemberButton;
                case 10:
                    return OctoberButton;
                case 11:
                    return NovemberButton;
                case 12:
                    return DecemberButton;
            }
            return null;
        }
        private void SetMonthButtonActive(Button activeButton)
        {
            foreach (Control item in MonthNavigationPanel.Controls)
            {
                if (item.GetType() == typeof(Button))
                    item.BackColor = NOT_ACTIVE_COLOR;
            }
            activeButton.BackColor = ACTIVE_BUTTON_COLOR;
        }
        private void PreviousYearButton_Click(object sender, EventArgs e)
        {
            YearButton.Text = (int.Parse(YearButton.Text) - 1).ToString();
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }

        private void NextYearButton_Click(object sender, EventArgs e)
        {
            YearButton.Text = (int.Parse(YearButton.Text) + 1).ToString();
            RefreshCalendar(int.Parse(YearButton.Text), _selectedMonth);
        }
    }
}
