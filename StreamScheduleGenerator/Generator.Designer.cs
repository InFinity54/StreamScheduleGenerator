namespace StreamScheduleGenerator
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
            WeeksSettings_Tabs = new TabControl();
            Footer_NewWeek = new Button();
            Footer_GenerationStart = new Button();
            GeneratedScheduleSaveDialog = new SaveFileDialog();
            GeneratingIndicator = new Label();
            Footer_Version = new Label();
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
            Header_Settings.Click += Header_Settings_Click;
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
            // WeeksSettings_Tabs
            // 
            WeeksSettings_Tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeeksSettings_Tabs.Location = new Point(12, 68);
            WeeksSettings_Tabs.Name = "WeeksSettings_Tabs";
            WeeksSettings_Tabs.SelectedIndex = 0;
            WeeksSettings_Tabs.Size = new Size(1043, 470);
            WeeksSettings_Tabs.TabIndex = 6;
            // 
            // Footer_NewWeek
            // 
            Footer_NewWeek.ForeColor = Color.Black;
            Footer_NewWeek.Location = new Point(750, 544);
            Footer_NewWeek.Name = "Footer_NewWeek";
            Footer_NewWeek.Size = new Size(143, 23);
            Footer_NewWeek.TabIndex = 7;
            Footer_NewWeek.Text = "&Nouvelle semaine";
            Footer_NewWeek.UseVisualStyleBackColor = true;
            Footer_NewWeek.Click += Footer_NewWeek_Click;
            // 
            // Footer_GenerationStart
            // 
            Footer_GenerationStart.ForeColor = Color.Black;
            Footer_GenerationStart.Location = new Point(899, 544);
            Footer_GenerationStart.Name = "Footer_GenerationStart";
            Footer_GenerationStart.Size = new Size(156, 23);
            Footer_GenerationStart.TabIndex = 8;
            Footer_GenerationStart.Text = "&Générer le planning";
            Footer_GenerationStart.UseVisualStyleBackColor = true;
            Footer_GenerationStart.Click += Footer_GenerationStart_Click;
            // 
            // GeneratedScheduleSaveDialog
            // 
            GeneratedScheduleSaveDialog.DefaultExt = "jpg";
            GeneratedScheduleSaveDialog.Filter = "Image JPG|*.jpg";
            GeneratedScheduleSaveDialog.Title = "Où enregistrer le planning de stream généré ?";
            // 
            // GeneratingIndicator
            // 
            GeneratingIndicator.Image = Properties.Resources.app_generatingindicator;
            GeneratingIndicator.Location = new Point(12, 68);
            GeneratingIndicator.Name = "GeneratingIndicator";
            GeneratingIndicator.Size = new Size(1043, 470);
            GeneratingIndicator.TabIndex = 9;
            GeneratingIndicator.Visible = false;
            // 
            // Footer_Version
            // 
            Footer_Version.ForeColor = SystemColors.WindowFrame;
            Footer_Version.Location = new Point(12, 543);
            Footer_Version.Name = "Footer_Version";
            Footer_Version.Size = new Size(155, 25);
            Footer_Version.TabIndex = 10;
            Footer_Version.Text = "%version%";
            Footer_Version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Generator
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1067, 579);
            Controls.Add(Footer_Version);
            Controls.Add(Footer_GenerationStart);
            Controls.Add(Footer_NewWeek);
            Controls.Add(WeeksSettings_Tabs);
            Controls.Add(PlanningMonthSelection_Label);
            Controls.Add(PlanningMonthSelection_Year);
            Controls.Add(PlanningMonthSelection_Month);
            Controls.Add(Header_Settings);
            Controls.Add(Header_Title);
            Controls.Add(Header_Icon);
            Controls.Add(GeneratingIndicator);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Generator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Générateur de planning de stream personnalisé";
            FormClosing += Generator_FormClosing;
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
        private TabControl WeeksSettings_Tabs;
        private Button Footer_NewWeek;
        private Button Footer_GenerationStart;
        private SaveFileDialog GeneratedScheduleSaveDialog;
        private Label GeneratingIndicator;
        private Label Footer_Version;
    }
}
