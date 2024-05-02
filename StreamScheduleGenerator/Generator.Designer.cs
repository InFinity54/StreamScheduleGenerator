﻿namespace StreamScheduleGenerator
{
    partial class Generator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            Header_Icon = new PictureBox();
            Header_Title = new Label();
            Header_Settings = new Button();
            PlanningMonthSelection_Month = new ComboBox();
            PlanningMonthSelection_Year = new ComboBox();
            PlanningMonthSelection_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)Header_Icon).BeginInit();
            SuspendLayout();
            // 
            // Header_Icon
            // 
            Header_Icon.Image = Properties.Resources.app_icon;
            Header_Icon.Location = new Point(12, 12);
            Header_Icon.Name = "Header_Icon";
            Header_Icon.Size = new Size(50, 50);
            Header_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            Header_Icon.TabIndex = 0;
            Header_Icon.TabStop = false;
            // 
            // Header_Title
            // 
            Header_Title.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header_Title.Location = new Point(68, 12);
            Header_Title.Name = "Header_Title";
            Header_Title.Size = new Size(421, 50);
            Header_Title.TabIndex = 1;
            Header_Title.Text = "Générateur de planning de stream personnalisé";
            Header_Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Header_Settings
            // 
            Header_Settings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Header_Settings.Image = Properties.Resources.app_header_settingsbuttonicon;
            Header_Settings.Location = new Point(1005, 12);
            Header_Settings.Name = "Header_Settings";
            Header_Settings.Size = new Size(50, 50);
            Header_Settings.TabIndex = 2;
            Header_Settings.UseVisualStyleBackColor = true;
            // 
            // PlanningMonthSelection_Month
            // 
            PlanningMonthSelection_Month.FormattingEnabled = true;
            PlanningMonthSelection_Month.Items.AddRange(new object[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" });
            PlanningMonthSelection_Month.Location = new Point(685, 26);
            PlanningMonthSelection_Month.Name = "PlanningMonthSelection_Month";
            PlanningMonthSelection_Month.Size = new Size(121, 25);
            PlanningMonthSelection_Month.TabIndex = 3;
            // 
            // PlanningMonthSelection_Year
            // 
            PlanningMonthSelection_Year.FormattingEnabled = true;
            PlanningMonthSelection_Year.Location = new Point(812, 26);
            PlanningMonthSelection_Year.Name = "PlanningMonthSelection_Year";
            PlanningMonthSelection_Year.Size = new Size(121, 25);
            PlanningMonthSelection_Year.TabIndex = 4;
            // 
            // PlanningMonthSelection_Label
            // 
            PlanningMonthSelection_Label.Location = new Point(524, 26);
            PlanningMonthSelection_Label.Name = "PlanningMonthSelection_Label";
            PlanningMonthSelection_Label.Size = new Size(155, 25);
            PlanningMonthSelection_Label.TabIndex = 5;
            PlanningMonthSelection_Label.Text = "Planning du mois de :";
            PlanningMonthSelection_Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Generator
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1067, 579);
            Controls.Add(PlanningMonthSelection_Label);
            Controls.Add(PlanningMonthSelection_Year);
            Controls.Add(PlanningMonthSelection_Month);
            Controls.Add(Header_Settings);
            Controls.Add(Header_Title);
            Controls.Add(Header_Icon);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Generator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Générateur de planning de stream personnalisé";
            ((System.ComponentModel.ISupportInitialize)Header_Icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Header_Icon;
        private Label Header_Title;
        private Button Header_Settings;
        private ComboBox PlanningMonthSelection_Month;
        private ComboBox PlanningMonthSelection_Year;
        private Label PlanningMonthSelection_Label;
    }
}
