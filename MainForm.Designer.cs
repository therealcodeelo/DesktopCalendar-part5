
namespace DesktopCalendar
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.codeeloGradientPanel2 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloGradientPanel3 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.AppointmentInfoPanel = new System.Windows.Forms.Panel();
            this.MonthNavigationPanel = new System.Windows.Forms.Panel();
            this.DecemberButton = new System.Windows.Forms.Button();
            this.NovemberButton = new System.Windows.Forms.Button();
            this.OctoberButton = new System.Windows.Forms.Button();
            this.SeptemberButton = new System.Windows.Forms.Button();
            this.AugustButton = new System.Windows.Forms.Button();
            this.JuleButton = new System.Windows.Forms.Button();
            this.JuneButton = new System.Windows.Forms.Button();
            this.MayButton = new System.Windows.Forms.Button();
            this.AprilButton = new System.Windows.Forms.Button();
            this.MarchButton = new System.Windows.Forms.Button();
            this.FebruaryButton = new System.Windows.Forms.Button();
            this.JanuaryButton = new System.Windows.Forms.Button();
            this.YearNavigationPanel = new System.Windows.Forms.Panel();
            this.YearButton = new System.Windows.Forms.Button();
            this.PreviousYearButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.appointmentViewPanel1 = new DesktopCalendar.AppointmentViewPanel();
            this.codeeloGradientPanel3.SuspendLayout();
            this.AppointmentInfoPanel.SuspendLayout();
            this.MonthNavigationPanel.SuspendLayout();
            this.YearNavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeeloGradientPanel2
            // 
            this.codeeloGradientPanel2.AccessibleRole = null;
            this.codeeloGradientPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel2.CausesValidation = false;
            this.codeeloGradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel2.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.codeeloGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel2.Location = new System.Drawing.Point(0, 29);
            this.codeeloGradientPanel2.Name = "codeeloGradientPanel2";
            this.codeeloGradientPanel2.Size = new System.Drawing.Size(1085, 590);
            this.codeeloGradientPanel2.TabIndex = 3;
            // 
            // codeeloGradientPanel3
            // 
            this.codeeloGradientPanel3.AccessibleRole = null;
            this.codeeloGradientPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel3.CausesValidation = false;
            this.codeeloGradientPanel3.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.codeeloGradientPanel3.ColorFillSecond = System.Drawing.Color.Gray;
            this.codeeloGradientPanel3.Controls.Add(this.AppointmentInfoPanel);
            this.codeeloGradientPanel3.Controls.Add(this.MonthNavigationPanel);
            this.codeeloGradientPanel3.Controls.Add(this.YearNavigationPanel);
            this.codeeloGradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeeloGradientPanel3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel3.Location = new System.Drawing.Point(1085, 29);
            this.codeeloGradientPanel3.Name = "codeeloGradientPanel3";
            this.codeeloGradientPanel3.Size = new System.Drawing.Size(360, 590);
            this.codeeloGradientPanel3.TabIndex = 2;
            // 
            // AppointmentInfoPanel
            // 
            this.AppointmentInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentInfoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppointmentInfoPanel.BackgroundImage")));
            this.AppointmentInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppointmentInfoPanel.Controls.Add(this.appointmentViewPanel1);
            this.AppointmentInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppointmentInfoPanel.Location = new System.Drawing.Point(0, 42);
            this.AppointmentInfoPanel.Name = "AppointmentInfoPanel";
            this.AppointmentInfoPanel.Size = new System.Drawing.Size(219, 548);
            this.AppointmentInfoPanel.TabIndex = 2;
            // 
            // MonthNavigationPanel
            // 
            this.MonthNavigationPanel.Controls.Add(this.DecemberButton);
            this.MonthNavigationPanel.Controls.Add(this.NovemberButton);
            this.MonthNavigationPanel.Controls.Add(this.OctoberButton);
            this.MonthNavigationPanel.Controls.Add(this.SeptemberButton);
            this.MonthNavigationPanel.Controls.Add(this.AugustButton);
            this.MonthNavigationPanel.Controls.Add(this.JuleButton);
            this.MonthNavigationPanel.Controls.Add(this.JuneButton);
            this.MonthNavigationPanel.Controls.Add(this.MayButton);
            this.MonthNavigationPanel.Controls.Add(this.AprilButton);
            this.MonthNavigationPanel.Controls.Add(this.MarchButton);
            this.MonthNavigationPanel.Controls.Add(this.FebruaryButton);
            this.MonthNavigationPanel.Controls.Add(this.JanuaryButton);
            this.MonthNavigationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MonthNavigationPanel.Location = new System.Drawing.Point(219, 42);
            this.MonthNavigationPanel.Name = "MonthNavigationPanel";
            this.MonthNavigationPanel.Size = new System.Drawing.Size(141, 548);
            this.MonthNavigationPanel.TabIndex = 1;
            // 
            // DecemberButton
            // 
            this.DecemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.DecemberButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecemberButton.FlatAppearance.BorderSize = 0;
            this.DecemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecemberButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DecemberButton.Image = global::DesktopCalendar.Properties.Resources.december_40px;
            this.DecemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecemberButton.Location = new System.Drawing.Point(0, 500);
            this.DecemberButton.Name = "DecemberButton";
            this.DecemberButton.Size = new System.Drawing.Size(141, 48);
            this.DecemberButton.TabIndex = 12;
            this.DecemberButton.Text = "Декабрь";
            this.DecemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DecemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DecemberButton.UseVisualStyleBackColor = false;
            // 
            // NovemberButton
            // 
            this.NovemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.NovemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NovemberButton.FlatAppearance.BorderSize = 0;
            this.NovemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NovemberButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NovemberButton.Image = global::DesktopCalendar.Properties.Resources.november_40px;
            this.NovemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NovemberButton.Location = new System.Drawing.Point(0, 455);
            this.NovemberButton.Name = "NovemberButton";
            this.NovemberButton.Size = new System.Drawing.Size(141, 45);
            this.NovemberButton.TabIndex = 11;
            this.NovemberButton.Text = "Ноябрь";
            this.NovemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NovemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NovemberButton.UseVisualStyleBackColor = false;
            // 
            // OctoberButton
            // 
            this.OctoberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.OctoberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OctoberButton.FlatAppearance.BorderSize = 0;
            this.OctoberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OctoberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OctoberButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OctoberButton.Image = global::DesktopCalendar.Properties.Resources.october_40px;
            this.OctoberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OctoberButton.Location = new System.Drawing.Point(0, 409);
            this.OctoberButton.Name = "OctoberButton";
            this.OctoberButton.Size = new System.Drawing.Size(141, 46);
            this.OctoberButton.TabIndex = 10;
            this.OctoberButton.Text = "Октябрь";
            this.OctoberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OctoberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OctoberButton.UseVisualStyleBackColor = false;
            // 
            // SeptemberButton
            // 
            this.SeptemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.SeptemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeptemberButton.FlatAppearance.BorderSize = 0;
            this.SeptemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeptemberButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeptemberButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeptemberButton.Image = global::DesktopCalendar.Properties.Resources.september_40px;
            this.SeptemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeptemberButton.Location = new System.Drawing.Point(0, 364);
            this.SeptemberButton.Name = "SeptemberButton";
            this.SeptemberButton.Size = new System.Drawing.Size(141, 45);
            this.SeptemberButton.TabIndex = 9;
            this.SeptemberButton.Text = "Сентябрь";
            this.SeptemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SeptemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SeptemberButton.UseVisualStyleBackColor = false;
            // 
            // AugustButton
            // 
            this.AugustButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AugustButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AugustButton.FlatAppearance.BorderSize = 0;
            this.AugustButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AugustButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AugustButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AugustButton.Image = global::DesktopCalendar.Properties.Resources.august_40px;
            this.AugustButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AugustButton.Location = new System.Drawing.Point(0, 318);
            this.AugustButton.Name = "AugustButton";
            this.AugustButton.Size = new System.Drawing.Size(141, 46);
            this.AugustButton.TabIndex = 8;
            this.AugustButton.Text = "Август";
            this.AugustButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AugustButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AugustButton.UseVisualStyleBackColor = false;
            // 
            // JuleButton
            // 
            this.JuleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JuleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JuleButton.FlatAppearance.BorderSize = 0;
            this.JuleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JuleButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JuleButton.Image = global::DesktopCalendar.Properties.Resources.july_40px;
            this.JuleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuleButton.Location = new System.Drawing.Point(0, 273);
            this.JuleButton.Name = "JuleButton";
            this.JuleButton.Size = new System.Drawing.Size(141, 45);
            this.JuleButton.TabIndex = 7;
            this.JuleButton.Text = "Июль";
            this.JuleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JuleButton.UseVisualStyleBackColor = false;
            // 
            // JuneButton
            // 
            this.JuneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JuneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JuneButton.FlatAppearance.BorderSize = 0;
            this.JuneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JuneButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JuneButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JuneButton.Image = global::DesktopCalendar.Properties.Resources.june_40px;
            this.JuneButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuneButton.Location = new System.Drawing.Point(0, 227);
            this.JuneButton.Name = "JuneButton";
            this.JuneButton.Size = new System.Drawing.Size(141, 46);
            this.JuneButton.TabIndex = 6;
            this.JuneButton.Text = "Июнь";
            this.JuneButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JuneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JuneButton.UseVisualStyleBackColor = false;
            // 
            // MayButton
            // 
            this.MayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MayButton.FlatAppearance.BorderSize = 0;
            this.MayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MayButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MayButton.Image = global::DesktopCalendar.Properties.Resources.may_40px;
            this.MayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MayButton.Location = new System.Drawing.Point(0, 182);
            this.MayButton.Name = "MayButton";
            this.MayButton.Size = new System.Drawing.Size(141, 45);
            this.MayButton.TabIndex = 5;
            this.MayButton.Text = "Май";
            this.MayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MayButton.UseVisualStyleBackColor = false;
            // 
            // AprilButton
            // 
            this.AprilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.AprilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AprilButton.FlatAppearance.BorderSize = 0;
            this.AprilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AprilButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AprilButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AprilButton.Image = global::DesktopCalendar.Properties.Resources.april_40px;
            this.AprilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AprilButton.Location = new System.Drawing.Point(0, 136);
            this.AprilButton.Name = "AprilButton";
            this.AprilButton.Size = new System.Drawing.Size(141, 46);
            this.AprilButton.TabIndex = 4;
            this.AprilButton.Text = "Апрель";
            this.AprilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AprilButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AprilButton.UseVisualStyleBackColor = false;
            // 
            // MarchButton
            // 
            this.MarchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MarchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarchButton.FlatAppearance.BorderSize = 0;
            this.MarchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarchButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MarchButton.Image = global::DesktopCalendar.Properties.Resources.march_40px;
            this.MarchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarchButton.Location = new System.Drawing.Point(0, 91);
            this.MarchButton.Name = "MarchButton";
            this.MarchButton.Size = new System.Drawing.Size(141, 45);
            this.MarchButton.TabIndex = 3;
            this.MarchButton.Text = "Март";
            this.MarchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MarchButton.UseVisualStyleBackColor = false;
            // 
            // FebruaryButton
            // 
            this.FebruaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.FebruaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FebruaryButton.FlatAppearance.BorderSize = 0;
            this.FebruaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FebruaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FebruaryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FebruaryButton.Image = global::DesktopCalendar.Properties.Resources.february_40px;
            this.FebruaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FebruaryButton.Location = new System.Drawing.Point(0, 45);
            this.FebruaryButton.Name = "FebruaryButton";
            this.FebruaryButton.Size = new System.Drawing.Size(141, 46);
            this.FebruaryButton.TabIndex = 2;
            this.FebruaryButton.Text = "Февраль";
            this.FebruaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FebruaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FebruaryButton.UseVisualStyleBackColor = false;
            // 
            // JanuaryButton
            // 
            this.JanuaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.JanuaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.JanuaryButton.FlatAppearance.BorderSize = 0;
            this.JanuaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JanuaryButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JanuaryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JanuaryButton.Image = global::DesktopCalendar.Properties.Resources.january_40px;
            this.JanuaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JanuaryButton.Location = new System.Drawing.Point(0, 0);
            this.JanuaryButton.Name = "JanuaryButton";
            this.JanuaryButton.Size = new System.Drawing.Size(141, 45);
            this.JanuaryButton.TabIndex = 1;
            this.JanuaryButton.Text = "Январь";
            this.JanuaryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JanuaryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JanuaryButton.UseVisualStyleBackColor = false;
            // 
            // YearNavigationPanel
            // 
            this.YearNavigationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.YearNavigationPanel.Controls.Add(this.YearButton);
            this.YearNavigationPanel.Controls.Add(this.PreviousYearButton);
            this.YearNavigationPanel.Controls.Add(this.NextYearButton);
            this.YearNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.YearNavigationPanel.Name = "YearNavigationPanel";
            this.YearNavigationPanel.Size = new System.Drawing.Size(360, 42);
            this.YearNavigationPanel.TabIndex = 0;
            // 
            // YearButton
            // 
            this.YearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.YearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearButton.FlatAppearance.BorderSize = 0;
            this.YearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YearButton.Location = new System.Drawing.Point(75, 0);
            this.YearButton.Name = "YearButton";
            this.YearButton.Size = new System.Drawing.Size(210, 42);
            this.YearButton.TabIndex = 2;
            this.YearButton.Text = "ГОД";
            this.YearButton.UseVisualStyleBackColor = false;
            // 
            // PreviousYearButton
            // 
            this.PreviousYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.PreviousYearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousYearButton.FlatAppearance.BorderSize = 0;
            this.PreviousYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousYearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PreviousYearButton.Location = new System.Drawing.Point(0, 0);
            this.PreviousYearButton.Name = "PreviousYearButton";
            this.PreviousYearButton.Size = new System.Drawing.Size(75, 42);
            this.PreviousYearButton.TabIndex = 1;
            this.PreviousYearButton.Text = "<<";
            this.PreviousYearButton.UseVisualStyleBackColor = false;
            this.PreviousYearButton.Click += new System.EventHandler(this.PreviousYearButton_Click);
            // 
            // NextYearButton
            // 
            this.NextYearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.NextYearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextYearButton.FlatAppearance.BorderSize = 0;
            this.NextYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextYearButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextYearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextYearButton.Location = new System.Drawing.Point(285, 0);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(75, 42);
            this.NextYearButton.TabIndex = 0;
            this.NextYearButton.Text = ">>";
            this.NextYearButton.UseVisualStyleBackColor = false;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButton_Click);
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(1445, 29);
            this.codeeloGradientPanel1.TabIndex = 0;
            // 
            // appointmentViewPanel1
            // 
            this.appointmentViewPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.appointmentViewPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentViewPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.appointmentViewPanel1.Location = new System.Drawing.Point(0, 0);
            this.appointmentViewPanel1.Name = "appointmentViewPanel1";
            this.appointmentViewPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.appointmentViewPanel1.Size = new System.Drawing.Size(219, 548);
            this.appointmentViewPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1445, 619);
            this.Controls.Add(this.codeeloGradientPanel2);
            this.Controls.Add(this.codeeloGradientPanel3);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.codeeloGradientPanel3.ResumeLayout(false);
            this.AppointmentInfoPanel.ResumeLayout(false);
            this.MonthNavigationPanel.ResumeLayout(false);
            this.YearNavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel3;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel2;
        private System.Windows.Forms.Panel AppointmentInfoPanel;
        private System.Windows.Forms.Panel MonthNavigationPanel;
        private System.Windows.Forms.Button DecemberButton;
        private System.Windows.Forms.Button NovemberButton;
        private System.Windows.Forms.Button OctoberButton;
        private System.Windows.Forms.Button SeptemberButton;
        private System.Windows.Forms.Button AugustButton;
        private System.Windows.Forms.Button JuleButton;
        private System.Windows.Forms.Button JuneButton;
        private System.Windows.Forms.Button MayButton;
        private System.Windows.Forms.Button AprilButton;
        private System.Windows.Forms.Button MarchButton;
        private System.Windows.Forms.Button FebruaryButton;
        private System.Windows.Forms.Button JanuaryButton;
        private System.Windows.Forms.Panel YearNavigationPanel;
        private System.Windows.Forms.Button YearButton;
        private System.Windows.Forms.Button PreviousYearButton;
        private System.Windows.Forms.Button NextYearButton;
        public AppointmentViewPanel appointmentViewPanel1;
    }
}

