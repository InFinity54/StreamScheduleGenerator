namespace StreamScheduleGenerator
{
    partial class Generator_WeekSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MondaySettings_Group = new GroupBox();
            MondaySettings_StreamStartHour = new DateTimePicker();
            MondaySettings_HourSelectionLabel = new Label();
            MondaySettings_Games = new ListBox();
            MondaySettings_HasMultipleGames = new CheckBox();
            MondaySettings_GamesLabel = new Label();
            MondaySettings_IsDayOff = new CheckBox();
            TuesdaySettings_Group = new GroupBox();
            TuesdaySettings_StreamStartHour = new DateTimePicker();
            TuesdaySettings_Games = new ListBox();
            TuesdaySettings_HourSelectionLabel = new Label();
            TuesdaySettings_HasMultipleGames = new CheckBox();
            TuesdaySettings_GamesLabel = new Label();
            TuesdaySettings_IsDayOff = new CheckBox();
            ThursdaySettings_Group = new GroupBox();
            ThursdaySettings_StreamStartHour = new DateTimePicker();
            ThursdaySettings_HourSelectionLabel = new Label();
            ThursdaySettings_Games = new ListBox();
            ThursdaySettings_HasMultipleGames = new CheckBox();
            ThursdaySettings_GamesLabel = new Label();
            ThursdaySettings_IsDayOff = new CheckBox();
            WednesdaySettings_Group = new GroupBox();
            WednesdaySettings_StreamStartHour = new DateTimePicker();
            WednesdaySettings_HourSelectionLabel = new Label();
            WednesdaySettings_Games = new ListBox();
            WednesdaySettings_HasMultipleGames = new CheckBox();
            WednesdaySettings_GamesLabel = new Label();
            WednesdaySettings_IsDayOff = new CheckBox();
            SaturdaySettings_Group = new GroupBox();
            SaturdaySettings_StreamStartHour = new DateTimePicker();
            SaturdaySettings_HourSelectionLabel = new Label();
            SaturdaySettings_Games = new ListBox();
            SaturdaySettings_HasMultipleGames = new CheckBox();
            SaturdaySettings_GamesLabel = new Label();
            SaturdaySettings_IsDayOff = new CheckBox();
            FridaySettings_Group = new GroupBox();
            FridaySettings_StreamStartHour = new DateTimePicker();
            FridaySettings_HourSelectionLabel = new Label();
            FridaySettings_Games = new ListBox();
            FridaySettings_HasMultipleGames = new CheckBox();
            FridaySettings_GamesLabel = new Label();
            FridaySettings_IsDayOff = new CheckBox();
            SundaySettings_Group = new GroupBox();
            SundaySettings_StreamStartHour = new DateTimePicker();
            SundaySettings_HourSelectionLabel = new Label();
            SundaySettings_Games = new ListBox();
            SundaySettings_HasMultipleGames = new CheckBox();
            SundaySettings_GamesLabel = new Label();
            SundaySettings_IsDayOff = new CheckBox();
            WeekDates_Label_1 = new Label();
            WeekDates_Start = new DateTimePicker();
            WeekDates_End = new DateTimePicker();
            WeekDates_Label_2 = new Label();
            MondaySettings_Group.SuspendLayout();
            TuesdaySettings_Group.SuspendLayout();
            ThursdaySettings_Group.SuspendLayout();
            WednesdaySettings_Group.SuspendLayout();
            SaturdaySettings_Group.SuspendLayout();
            FridaySettings_Group.SuspendLayout();
            SundaySettings_Group.SuspendLayout();
            SuspendLayout();
            // 
            // MondaySettings_Group
            // 
            MondaySettings_Group.Controls.Add(MondaySettings_StreamStartHour);
            MondaySettings_Group.Controls.Add(MondaySettings_HourSelectionLabel);
            MondaySettings_Group.Controls.Add(MondaySettings_Games);
            MondaySettings_Group.Controls.Add(MondaySettings_HasMultipleGames);
            MondaySettings_Group.Controls.Add(MondaySettings_GamesLabel);
            MondaySettings_Group.Controls.Add(MondaySettings_IsDayOff);
            MondaySettings_Group.ForeColor = Color.White;
            MondaySettings_Group.Location = new Point(12, 70);
            MondaySettings_Group.Name = "MondaySettings_Group";
            MondaySettings_Group.Size = new Size(499, 82);
            MondaySettings_Group.TabIndex = 0;
            MondaySettings_Group.TabStop = false;
            MondaySettings_Group.Text = "Lundi";
            // 
            // MondaySettings_StreamStartHour
            // 
            MondaySettings_StreamStartHour.CustomFormat = "HH:mm";
            MondaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            MondaySettings_StreamStartHour.Location = new Point(64, 35);
            MondaySettings_StreamStartHour.Name = "MondaySettings_StreamStartHour";
            MondaySettings_StreamStartHour.ShowUpDown = true;
            MondaySettings_StreamStartHour.Size = new Size(59, 23);
            MondaySettings_StreamStartHour.TabIndex = 13;
            MondaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            MondaySettings_StreamStartHour.Visible = false;
            // 
            // MondaySettings_HourSelectionLabel
            // 
            MondaySettings_HourSelectionLabel.AutoSize = true;
            MondaySettings_HourSelectionLabel.Location = new Point(5, 38);
            MondaySettings_HourSelectionLabel.Name = "MondaySettings_HourSelectionLabel";
            MondaySettings_HourSelectionLabel.Size = new Size(53, 17);
            MondaySettings_HourSelectionLabel.TabIndex = 12;
            MondaySettings_HourSelectionLabel.Text = "Heure :";
            MondaySettings_HourSelectionLabel.Visible = false;
            // 
            // MondaySettings_Games
            // 
            MondaySettings_Games.FormattingEnabled = true;
            MondaySettings_Games.ItemHeight = 17;
            MondaySettings_Games.Location = new Point(278, 17);
            MondaySettings_Games.Name = "MondaySettings_Games";
            MondaySettings_Games.Size = new Size(215, 55);
            MondaySettings_Games.Sorted = true;
            MondaySettings_Games.TabIndex = 11;
            MondaySettings_Games.Visible = false;
            // 
            // MondaySettings_HasMultipleGames
            // 
            MondaySettings_HasMultipleGames.AutoSize = true;
            MondaySettings_HasMultipleGames.Location = new Point(6, 57);
            MondaySettings_HasMultipleGames.Name = "MondaySettings_HasMultipleGames";
            MondaySettings_HasMultipleGames.Size = new Size(172, 21);
            MondaySettings_HasMultipleGames.TabIndex = 3;
            MondaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            MondaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            MondaySettings_HasMultipleGames.Visible = false;
            MondaySettings_HasMultipleGames.CheckedChanged += MondaySettings_HasMultipleGames_CheckedChanged;
            // 
            // MondaySettings_GamesLabel
            // 
            MondaySettings_GamesLabel.AutoSize = true;
            MondaySettings_GamesLabel.Location = new Point(219, 35);
            MondaySettings_GamesLabel.Name = "MondaySettings_GamesLabel";
            MondaySettings_GamesLabel.Size = new Size(53, 17);
            MondaySettings_GamesLabel.TabIndex = 2;
            MondaySettings_GamesLabel.Text = "Jeu(x) :";
            MondaySettings_GamesLabel.Visible = false;
            // 
            // MondaySettings_IsDayOff
            // 
            MondaySettings_IsDayOff.AutoSize = true;
            MondaySettings_IsDayOff.Checked = true;
            MondaySettings_IsDayOff.CheckState = CheckState.Checked;
            MondaySettings_IsDayOff.Location = new Point(6, 17);
            MondaySettings_IsDayOff.Name = "MondaySettings_IsDayOff";
            MondaySettings_IsDayOff.Size = new Size(75, 21);
            MondaySettings_IsDayOff.TabIndex = 0;
            MondaySettings_IsDayOff.Text = "Jour off";
            MondaySettings_IsDayOff.UseVisualStyleBackColor = true;
            MondaySettings_IsDayOff.CheckedChanged += MondaySettings_IsDayOff_CheckedChanged;
            // 
            // TuesdaySettings_Group
            // 
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_StreamStartHour);
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_Games);
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_HourSelectionLabel);
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_HasMultipleGames);
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_GamesLabel);
            TuesdaySettings_Group.Controls.Add(TuesdaySettings_IsDayOff);
            TuesdaySettings_Group.ForeColor = Color.White;
            TuesdaySettings_Group.Location = new Point(524, 70);
            TuesdaySettings_Group.Name = "TuesdaySettings_Group";
            TuesdaySettings_Group.Size = new Size(499, 82);
            TuesdaySettings_Group.TabIndex = 1;
            TuesdaySettings_Group.TabStop = false;
            TuesdaySettings_Group.Text = "Mardi";
            // 
            // TuesdaySettings_StreamStartHour
            // 
            TuesdaySettings_StreamStartHour.CustomFormat = "HH:mm";
            TuesdaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            TuesdaySettings_StreamStartHour.Location = new Point(65, 35);
            TuesdaySettings_StreamStartHour.Name = "TuesdaySettings_StreamStartHour";
            TuesdaySettings_StreamStartHour.ShowUpDown = true;
            TuesdaySettings_StreamStartHour.Size = new Size(59, 23);
            TuesdaySettings_StreamStartHour.TabIndex = 15;
            TuesdaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            TuesdaySettings_StreamStartHour.Visible = false;
            // 
            // TuesdaySettings_Games
            // 
            TuesdaySettings_Games.FormattingEnabled = true;
            TuesdaySettings_Games.ItemHeight = 17;
            TuesdaySettings_Games.Location = new Point(278, 17);
            TuesdaySettings_Games.Name = "TuesdaySettings_Games";
            TuesdaySettings_Games.Size = new Size(215, 55);
            TuesdaySettings_Games.Sorted = true;
            TuesdaySettings_Games.TabIndex = 15;
            TuesdaySettings_Games.Visible = false;
            // 
            // TuesdaySettings_HourSelectionLabel
            // 
            TuesdaySettings_HourSelectionLabel.AutoSize = true;
            TuesdaySettings_HourSelectionLabel.Location = new Point(6, 38);
            TuesdaySettings_HourSelectionLabel.Name = "TuesdaySettings_HourSelectionLabel";
            TuesdaySettings_HourSelectionLabel.Size = new Size(53, 17);
            TuesdaySettings_HourSelectionLabel.TabIndex = 14;
            TuesdaySettings_HourSelectionLabel.Text = "Heure :";
            TuesdaySettings_HourSelectionLabel.Visible = false;
            // 
            // TuesdaySettings_HasMultipleGames
            // 
            TuesdaySettings_HasMultipleGames.AutoSize = true;
            TuesdaySettings_HasMultipleGames.Location = new Point(6, 57);
            TuesdaySettings_HasMultipleGames.Name = "TuesdaySettings_HasMultipleGames";
            TuesdaySettings_HasMultipleGames.Size = new Size(172, 21);
            TuesdaySettings_HasMultipleGames.TabIndex = 14;
            TuesdaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            TuesdaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            TuesdaySettings_HasMultipleGames.Visible = false;
            TuesdaySettings_HasMultipleGames.CheckedChanged += TuesdaySettings_HasMultipleGames_CheckedChanged;
            // 
            // TuesdaySettings_GamesLabel
            // 
            TuesdaySettings_GamesLabel.AutoSize = true;
            TuesdaySettings_GamesLabel.Location = new Point(219, 35);
            TuesdaySettings_GamesLabel.Name = "TuesdaySettings_GamesLabel";
            TuesdaySettings_GamesLabel.Size = new Size(53, 17);
            TuesdaySettings_GamesLabel.TabIndex = 13;
            TuesdaySettings_GamesLabel.Text = "Jeu(x) :";
            TuesdaySettings_GamesLabel.Visible = false;
            // 
            // TuesdaySettings_IsDayOff
            // 
            TuesdaySettings_IsDayOff.AutoSize = true;
            TuesdaySettings_IsDayOff.Checked = true;
            TuesdaySettings_IsDayOff.CheckState = CheckState.Checked;
            TuesdaySettings_IsDayOff.Location = new Point(6, 17);
            TuesdaySettings_IsDayOff.Name = "TuesdaySettings_IsDayOff";
            TuesdaySettings_IsDayOff.Size = new Size(75, 21);
            TuesdaySettings_IsDayOff.TabIndex = 12;
            TuesdaySettings_IsDayOff.Text = "Jour off";
            TuesdaySettings_IsDayOff.UseVisualStyleBackColor = true;
            TuesdaySettings_IsDayOff.CheckedChanged += TuesdaySettings_IsDayOff_CheckedChanged;
            // 
            // ThursdaySettings_Group
            // 
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_StreamStartHour);
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_HourSelectionLabel);
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_Games);
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_HasMultipleGames);
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_GamesLabel);
            ThursdaySettings_Group.Controls.Add(ThursdaySettings_IsDayOff);
            ThursdaySettings_Group.ForeColor = Color.White;
            ThursdaySettings_Group.Location = new Point(524, 158);
            ThursdaySettings_Group.Name = "ThursdaySettings_Group";
            ThursdaySettings_Group.Size = new Size(499, 82);
            ThursdaySettings_Group.TabIndex = 3;
            ThursdaySettings_Group.TabStop = false;
            ThursdaySettings_Group.Text = "Jeudi";
            // 
            // ThursdaySettings_StreamStartHour
            // 
            ThursdaySettings_StreamStartHour.CustomFormat = "HH:mm";
            ThursdaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            ThursdaySettings_StreamStartHour.Location = new Point(65, 34);
            ThursdaySettings_StreamStartHour.Name = "ThursdaySettings_StreamStartHour";
            ThursdaySettings_StreamStartHour.ShowUpDown = true;
            ThursdaySettings_StreamStartHour.Size = new Size(59, 23);
            ThursdaySettings_StreamStartHour.TabIndex = 17;
            ThursdaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            ThursdaySettings_StreamStartHour.Visible = false;
            // 
            // ThursdaySettings_HourSelectionLabel
            // 
            ThursdaySettings_HourSelectionLabel.AutoSize = true;
            ThursdaySettings_HourSelectionLabel.Location = new Point(6, 37);
            ThursdaySettings_HourSelectionLabel.Name = "ThursdaySettings_HourSelectionLabel";
            ThursdaySettings_HourSelectionLabel.Size = new Size(53, 17);
            ThursdaySettings_HourSelectionLabel.TabIndex = 16;
            ThursdaySettings_HourSelectionLabel.Text = "Heure :";
            ThursdaySettings_HourSelectionLabel.Visible = false;
            // 
            // ThursdaySettings_Games
            // 
            ThursdaySettings_Games.FormattingEnabled = true;
            ThursdaySettings_Games.ItemHeight = 17;
            ThursdaySettings_Games.Location = new Point(278, 17);
            ThursdaySettings_Games.Name = "ThursdaySettings_Games";
            ThursdaySettings_Games.Size = new Size(215, 55);
            ThursdaySettings_Games.Sorted = true;
            ThursdaySettings_Games.TabIndex = 15;
            ThursdaySettings_Games.Visible = false;
            // 
            // ThursdaySettings_HasMultipleGames
            // 
            ThursdaySettings_HasMultipleGames.AutoSize = true;
            ThursdaySettings_HasMultipleGames.Location = new Point(6, 57);
            ThursdaySettings_HasMultipleGames.Name = "ThursdaySettings_HasMultipleGames";
            ThursdaySettings_HasMultipleGames.Size = new Size(172, 21);
            ThursdaySettings_HasMultipleGames.TabIndex = 14;
            ThursdaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            ThursdaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            ThursdaySettings_HasMultipleGames.Visible = false;
            ThursdaySettings_HasMultipleGames.CheckedChanged += ThursdaySettings_HasMultipleGames_CheckedChanged;
            // 
            // ThursdaySettings_GamesLabel
            // 
            ThursdaySettings_GamesLabel.AutoSize = true;
            ThursdaySettings_GamesLabel.Location = new Point(219, 35);
            ThursdaySettings_GamesLabel.Name = "ThursdaySettings_GamesLabel";
            ThursdaySettings_GamesLabel.Size = new Size(53, 17);
            ThursdaySettings_GamesLabel.TabIndex = 13;
            ThursdaySettings_GamesLabel.Text = "Jeu(x) :";
            ThursdaySettings_GamesLabel.Visible = false;
            // 
            // ThursdaySettings_IsDayOff
            // 
            ThursdaySettings_IsDayOff.AutoSize = true;
            ThursdaySettings_IsDayOff.Checked = true;
            ThursdaySettings_IsDayOff.CheckState = CheckState.Checked;
            ThursdaySettings_IsDayOff.Location = new Point(6, 17);
            ThursdaySettings_IsDayOff.Name = "ThursdaySettings_IsDayOff";
            ThursdaySettings_IsDayOff.Size = new Size(75, 21);
            ThursdaySettings_IsDayOff.TabIndex = 12;
            ThursdaySettings_IsDayOff.Text = "Jour off";
            ThursdaySettings_IsDayOff.UseVisualStyleBackColor = true;
            ThursdaySettings_IsDayOff.CheckedChanged += ThursdaySettings_IsDayOff_CheckedChanged;
            // 
            // WednesdaySettings_Group
            // 
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_StreamStartHour);
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_HourSelectionLabel);
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_Games);
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_HasMultipleGames);
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_GamesLabel);
            WednesdaySettings_Group.Controls.Add(WednesdaySettings_IsDayOff);
            WednesdaySettings_Group.ForeColor = Color.White;
            WednesdaySettings_Group.Location = new Point(12, 158);
            WednesdaySettings_Group.Name = "WednesdaySettings_Group";
            WednesdaySettings_Group.Size = new Size(499, 82);
            WednesdaySettings_Group.TabIndex = 2;
            WednesdaySettings_Group.TabStop = false;
            WednesdaySettings_Group.Text = "Mercredi";
            // 
            // WednesdaySettings_StreamStartHour
            // 
            WednesdaySettings_StreamStartHour.CustomFormat = "HH:mm";
            WednesdaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            WednesdaySettings_StreamStartHour.Location = new Point(65, 35);
            WednesdaySettings_StreamStartHour.Name = "WednesdaySettings_StreamStartHour";
            WednesdaySettings_StreamStartHour.ShowUpDown = true;
            WednesdaySettings_StreamStartHour.Size = new Size(59, 23);
            WednesdaySettings_StreamStartHour.TabIndex = 17;
            WednesdaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            WednesdaySettings_StreamStartHour.Visible = false;
            // 
            // WednesdaySettings_HourSelectionLabel
            // 
            WednesdaySettings_HourSelectionLabel.AutoSize = true;
            WednesdaySettings_HourSelectionLabel.Location = new Point(6, 38);
            WednesdaySettings_HourSelectionLabel.Name = "WednesdaySettings_HourSelectionLabel";
            WednesdaySettings_HourSelectionLabel.Size = new Size(53, 17);
            WednesdaySettings_HourSelectionLabel.TabIndex = 16;
            WednesdaySettings_HourSelectionLabel.Text = "Heure :";
            WednesdaySettings_HourSelectionLabel.Visible = false;
            // 
            // WednesdaySettings_Games
            // 
            WednesdaySettings_Games.FormattingEnabled = true;
            WednesdaySettings_Games.ItemHeight = 17;
            WednesdaySettings_Games.Location = new Point(278, 17);
            WednesdaySettings_Games.Name = "WednesdaySettings_Games";
            WednesdaySettings_Games.Size = new Size(215, 55);
            WednesdaySettings_Games.Sorted = true;
            WednesdaySettings_Games.TabIndex = 15;
            WednesdaySettings_Games.Visible = false;
            // 
            // WednesdaySettings_HasMultipleGames
            // 
            WednesdaySettings_HasMultipleGames.AutoSize = true;
            WednesdaySettings_HasMultipleGames.Location = new Point(6, 57);
            WednesdaySettings_HasMultipleGames.Name = "WednesdaySettings_HasMultipleGames";
            WednesdaySettings_HasMultipleGames.Size = new Size(172, 21);
            WednesdaySettings_HasMultipleGames.TabIndex = 14;
            WednesdaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            WednesdaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            WednesdaySettings_HasMultipleGames.Visible = false;
            WednesdaySettings_HasMultipleGames.CheckedChanged += WednesdaySettings_HasMultipleGames_CheckedChanged;
            // 
            // WednesdaySettings_GamesLabel
            // 
            WednesdaySettings_GamesLabel.AutoSize = true;
            WednesdaySettings_GamesLabel.Location = new Point(219, 35);
            WednesdaySettings_GamesLabel.Name = "WednesdaySettings_GamesLabel";
            WednesdaySettings_GamesLabel.Size = new Size(53, 17);
            WednesdaySettings_GamesLabel.TabIndex = 13;
            WednesdaySettings_GamesLabel.Text = "Jeu(x) :";
            WednesdaySettings_GamesLabel.Visible = false;
            // 
            // WednesdaySettings_IsDayOff
            // 
            WednesdaySettings_IsDayOff.AutoSize = true;
            WednesdaySettings_IsDayOff.Checked = true;
            WednesdaySettings_IsDayOff.CheckState = CheckState.Checked;
            WednesdaySettings_IsDayOff.Location = new Point(6, 17);
            WednesdaySettings_IsDayOff.Name = "WednesdaySettings_IsDayOff";
            WednesdaySettings_IsDayOff.Size = new Size(75, 21);
            WednesdaySettings_IsDayOff.TabIndex = 12;
            WednesdaySettings_IsDayOff.Text = "Jour off";
            WednesdaySettings_IsDayOff.UseVisualStyleBackColor = true;
            WednesdaySettings_IsDayOff.CheckedChanged += WednesdaySettings_IsDayOff_CheckedChanged;
            // 
            // SaturdaySettings_Group
            // 
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_StreamStartHour);
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_HourSelectionLabel);
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_Games);
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_HasMultipleGames);
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_GamesLabel);
            SaturdaySettings_Group.Controls.Add(SaturdaySettings_IsDayOff);
            SaturdaySettings_Group.ForeColor = Color.White;
            SaturdaySettings_Group.Location = new Point(524, 246);
            SaturdaySettings_Group.Name = "SaturdaySettings_Group";
            SaturdaySettings_Group.Size = new Size(499, 82);
            SaturdaySettings_Group.TabIndex = 5;
            SaturdaySettings_Group.TabStop = false;
            SaturdaySettings_Group.Text = "Samedi";
            // 
            // SaturdaySettings_StreamStartHour
            // 
            SaturdaySettings_StreamStartHour.CustomFormat = "HH:mm";
            SaturdaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            SaturdaySettings_StreamStartHour.Location = new Point(65, 36);
            SaturdaySettings_StreamStartHour.Name = "SaturdaySettings_StreamStartHour";
            SaturdaySettings_StreamStartHour.ShowUpDown = true;
            SaturdaySettings_StreamStartHour.Size = new Size(59, 23);
            SaturdaySettings_StreamStartHour.TabIndex = 17;
            SaturdaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            SaturdaySettings_StreamStartHour.Visible = false;
            // 
            // SaturdaySettings_HourSelectionLabel
            // 
            SaturdaySettings_HourSelectionLabel.AutoSize = true;
            SaturdaySettings_HourSelectionLabel.Location = new Point(6, 39);
            SaturdaySettings_HourSelectionLabel.Name = "SaturdaySettings_HourSelectionLabel";
            SaturdaySettings_HourSelectionLabel.Size = new Size(53, 17);
            SaturdaySettings_HourSelectionLabel.TabIndex = 16;
            SaturdaySettings_HourSelectionLabel.Text = "Heure :";
            SaturdaySettings_HourSelectionLabel.Visible = false;
            // 
            // SaturdaySettings_Games
            // 
            SaturdaySettings_Games.FormattingEnabled = true;
            SaturdaySettings_Games.ItemHeight = 17;
            SaturdaySettings_Games.Location = new Point(278, 18);
            SaturdaySettings_Games.Name = "SaturdaySettings_Games";
            SaturdaySettings_Games.Size = new Size(215, 55);
            SaturdaySettings_Games.Sorted = true;
            SaturdaySettings_Games.TabIndex = 15;
            SaturdaySettings_Games.Visible = false;
            // 
            // SaturdaySettings_HasMultipleGames
            // 
            SaturdaySettings_HasMultipleGames.AutoSize = true;
            SaturdaySettings_HasMultipleGames.Location = new Point(6, 58);
            SaturdaySettings_HasMultipleGames.Name = "SaturdaySettings_HasMultipleGames";
            SaturdaySettings_HasMultipleGames.Size = new Size(172, 21);
            SaturdaySettings_HasMultipleGames.TabIndex = 14;
            SaturdaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            SaturdaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            SaturdaySettings_HasMultipleGames.Visible = false;
            SaturdaySettings_HasMultipleGames.CheckedChanged += SaturdaySettings_HasMultipleGames_CheckedChanged;
            // 
            // SaturdaySettings_GamesLabel
            // 
            SaturdaySettings_GamesLabel.AutoSize = true;
            SaturdaySettings_GamesLabel.Location = new Point(219, 36);
            SaturdaySettings_GamesLabel.Name = "SaturdaySettings_GamesLabel";
            SaturdaySettings_GamesLabel.Size = new Size(53, 17);
            SaturdaySettings_GamesLabel.TabIndex = 13;
            SaturdaySettings_GamesLabel.Text = "Jeu(x) :";
            SaturdaySettings_GamesLabel.Visible = false;
            // 
            // SaturdaySettings_IsDayOff
            // 
            SaturdaySettings_IsDayOff.AutoSize = true;
            SaturdaySettings_IsDayOff.Checked = true;
            SaturdaySettings_IsDayOff.CheckState = CheckState.Checked;
            SaturdaySettings_IsDayOff.Location = new Point(6, 18);
            SaturdaySettings_IsDayOff.Name = "SaturdaySettings_IsDayOff";
            SaturdaySettings_IsDayOff.Size = new Size(75, 21);
            SaturdaySettings_IsDayOff.TabIndex = 12;
            SaturdaySettings_IsDayOff.Text = "Jour off";
            SaturdaySettings_IsDayOff.UseVisualStyleBackColor = true;
            SaturdaySettings_IsDayOff.CheckedChanged += SaturdaySettings_IsDayOff_CheckedChanged;
            // 
            // FridaySettings_Group
            // 
            FridaySettings_Group.Controls.Add(FridaySettings_StreamStartHour);
            FridaySettings_Group.Controls.Add(FridaySettings_HourSelectionLabel);
            FridaySettings_Group.Controls.Add(FridaySettings_Games);
            FridaySettings_Group.Controls.Add(FridaySettings_HasMultipleGames);
            FridaySettings_Group.Controls.Add(FridaySettings_GamesLabel);
            FridaySettings_Group.Controls.Add(FridaySettings_IsDayOff);
            FridaySettings_Group.ForeColor = Color.White;
            FridaySettings_Group.Location = new Point(12, 246);
            FridaySettings_Group.Name = "FridaySettings_Group";
            FridaySettings_Group.Size = new Size(499, 82);
            FridaySettings_Group.TabIndex = 4;
            FridaySettings_Group.TabStop = false;
            FridaySettings_Group.Text = "Vendredi";
            // 
            // FridaySettings_StreamStartHour
            // 
            FridaySettings_StreamStartHour.CustomFormat = "HH:mm";
            FridaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            FridaySettings_StreamStartHour.Location = new Point(65, 35);
            FridaySettings_StreamStartHour.Name = "FridaySettings_StreamStartHour";
            FridaySettings_StreamStartHour.ShowUpDown = true;
            FridaySettings_StreamStartHour.Size = new Size(59, 23);
            FridaySettings_StreamStartHour.TabIndex = 17;
            FridaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            FridaySettings_StreamStartHour.Visible = false;
            // 
            // FridaySettings_HourSelectionLabel
            // 
            FridaySettings_HourSelectionLabel.AutoSize = true;
            FridaySettings_HourSelectionLabel.Location = new Point(6, 38);
            FridaySettings_HourSelectionLabel.Name = "FridaySettings_HourSelectionLabel";
            FridaySettings_HourSelectionLabel.Size = new Size(53, 17);
            FridaySettings_HourSelectionLabel.TabIndex = 16;
            FridaySettings_HourSelectionLabel.Text = "Heure :";
            FridaySettings_HourSelectionLabel.Visible = false;
            // 
            // FridaySettings_Games
            // 
            FridaySettings_Games.FormattingEnabled = true;
            FridaySettings_Games.ItemHeight = 17;
            FridaySettings_Games.Location = new Point(278, 17);
            FridaySettings_Games.Name = "FridaySettings_Games";
            FridaySettings_Games.Size = new Size(215, 55);
            FridaySettings_Games.Sorted = true;
            FridaySettings_Games.TabIndex = 15;
            FridaySettings_Games.Visible = false;
            // 
            // FridaySettings_HasMultipleGames
            // 
            FridaySettings_HasMultipleGames.AutoSize = true;
            FridaySettings_HasMultipleGames.Location = new Point(6, 57);
            FridaySettings_HasMultipleGames.Name = "FridaySettings_HasMultipleGames";
            FridaySettings_HasMultipleGames.Size = new Size(172, 21);
            FridaySettings_HasMultipleGames.TabIndex = 14;
            FridaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            FridaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            FridaySettings_HasMultipleGames.Visible = false;
            FridaySettings_HasMultipleGames.CheckedChanged += FridaySettings_HasMultipleGames_CheckedChanged;
            // 
            // FridaySettings_GamesLabel
            // 
            FridaySettings_GamesLabel.AutoSize = true;
            FridaySettings_GamesLabel.Location = new Point(219, 35);
            FridaySettings_GamesLabel.Name = "FridaySettings_GamesLabel";
            FridaySettings_GamesLabel.Size = new Size(53, 17);
            FridaySettings_GamesLabel.TabIndex = 13;
            FridaySettings_GamesLabel.Text = "Jeu(x) :";
            FridaySettings_GamesLabel.Visible = false;
            // 
            // FridaySettings_IsDayOff
            // 
            FridaySettings_IsDayOff.AutoSize = true;
            FridaySettings_IsDayOff.Checked = true;
            FridaySettings_IsDayOff.CheckState = CheckState.Checked;
            FridaySettings_IsDayOff.Location = new Point(6, 17);
            FridaySettings_IsDayOff.Name = "FridaySettings_IsDayOff";
            FridaySettings_IsDayOff.Size = new Size(75, 21);
            FridaySettings_IsDayOff.TabIndex = 12;
            FridaySettings_IsDayOff.Text = "Jour off";
            FridaySettings_IsDayOff.UseVisualStyleBackColor = true;
            FridaySettings_IsDayOff.CheckedChanged += FridaySettings_IsDayOff_CheckedChanged;
            // 
            // SundaySettings_Group
            // 
            SundaySettings_Group.Controls.Add(SundaySettings_StreamStartHour);
            SundaySettings_Group.Controls.Add(SundaySettings_HourSelectionLabel);
            SundaySettings_Group.Controls.Add(SundaySettings_Games);
            SundaySettings_Group.Controls.Add(SundaySettings_HasMultipleGames);
            SundaySettings_Group.Controls.Add(SundaySettings_GamesLabel);
            SundaySettings_Group.Controls.Add(SundaySettings_IsDayOff);
            SundaySettings_Group.ForeColor = Color.White;
            SundaySettings_Group.Location = new Point(12, 334);
            SundaySettings_Group.Name = "SundaySettings_Group";
            SundaySettings_Group.Size = new Size(499, 82);
            SundaySettings_Group.TabIndex = 6;
            SundaySettings_Group.TabStop = false;
            SundaySettings_Group.Text = "Dimanche";
            // 
            // SundaySettings_StreamStartHour
            // 
            SundaySettings_StreamStartHour.CustomFormat = "HH:mm";
            SundaySettings_StreamStartHour.Format = DateTimePickerFormat.Custom;
            SundaySettings_StreamStartHour.Location = new Point(65, 35);
            SundaySettings_StreamStartHour.Name = "SundaySettings_StreamStartHour";
            SundaySettings_StreamStartHour.ShowUpDown = true;
            SundaySettings_StreamStartHour.Size = new Size(59, 23);
            SundaySettings_StreamStartHour.TabIndex = 17;
            SundaySettings_StreamStartHour.Value = new DateTime(2024, 5, 2, 21, 0, 0, 0);
            SundaySettings_StreamStartHour.Visible = false;
            // 
            // SundaySettings_HourSelectionLabel
            // 
            SundaySettings_HourSelectionLabel.AutoSize = true;
            SundaySettings_HourSelectionLabel.Location = new Point(6, 38);
            SundaySettings_HourSelectionLabel.Name = "SundaySettings_HourSelectionLabel";
            SundaySettings_HourSelectionLabel.Size = new Size(53, 17);
            SundaySettings_HourSelectionLabel.TabIndex = 16;
            SundaySettings_HourSelectionLabel.Text = "Heure :";
            SundaySettings_HourSelectionLabel.Visible = false;
            // 
            // SundaySettings_Games
            // 
            SundaySettings_Games.FormattingEnabled = true;
            SundaySettings_Games.ItemHeight = 17;
            SundaySettings_Games.Location = new Point(278, 17);
            SundaySettings_Games.Name = "SundaySettings_Games";
            SundaySettings_Games.Size = new Size(215, 55);
            SundaySettings_Games.Sorted = true;
            SundaySettings_Games.TabIndex = 15;
            SundaySettings_Games.Visible = false;
            // 
            // SundaySettings_HasMultipleGames
            // 
            SundaySettings_HasMultipleGames.AutoSize = true;
            SundaySettings_HasMultipleGames.Location = new Point(6, 57);
            SundaySettings_HasMultipleGames.Name = "SundaySettings_HasMultipleGames";
            SundaySettings_HasMultipleGames.Size = new Size(172, 21);
            SundaySettings_HasMultipleGames.TabIndex = 14;
            SundaySettings_HasMultipleGames.Text = "Plusieurs jeux ce jour-là";
            SundaySettings_HasMultipleGames.UseVisualStyleBackColor = true;
            SundaySettings_HasMultipleGames.Visible = false;
            SundaySettings_HasMultipleGames.CheckedChanged += SundaySettings_HasMultipleGames_CheckedChanged;
            // 
            // SundaySettings_GamesLabel
            // 
            SundaySettings_GamesLabel.AutoSize = true;
            SundaySettings_GamesLabel.Location = new Point(219, 35);
            SundaySettings_GamesLabel.Name = "SundaySettings_GamesLabel";
            SundaySettings_GamesLabel.Size = new Size(53, 17);
            SundaySettings_GamesLabel.TabIndex = 13;
            SundaySettings_GamesLabel.Text = "Jeu(x) :";
            SundaySettings_GamesLabel.Visible = false;
            // 
            // SundaySettings_IsDayOff
            // 
            SundaySettings_IsDayOff.AutoSize = true;
            SundaySettings_IsDayOff.Checked = true;
            SundaySettings_IsDayOff.CheckState = CheckState.Checked;
            SundaySettings_IsDayOff.Location = new Point(6, 17);
            SundaySettings_IsDayOff.Name = "SundaySettings_IsDayOff";
            SundaySettings_IsDayOff.Size = new Size(75, 21);
            SundaySettings_IsDayOff.TabIndex = 12;
            SundaySettings_IsDayOff.Text = "Jour off";
            SundaySettings_IsDayOff.UseVisualStyleBackColor = true;
            SundaySettings_IsDayOff.CheckedChanged += SundaySettings_IsDayOff_CheckedChanged;
            // 
            // WeekDates_Label_1
            // 
            WeekDates_Label_1.AutoSize = true;
            WeekDates_Label_1.Location = new Point(12, 19);
            WeekDates_Label_1.Name = "WeekDates_Label_1";
            WeekDates_Label_1.Size = new Size(84, 17);
            WeekDates_Label_1.TabIndex = 7;
            WeekDates_Label_1.Text = "Semaine du";
            // 
            // WeekDates_Start
            // 
            WeekDates_Start.Format = DateTimePickerFormat.Short;
            WeekDates_Start.Location = new Point(102, 16);
            WeekDates_Start.Name = "WeekDates_Start";
            WeekDates_Start.Size = new Size(126, 23);
            WeekDates_Start.TabIndex = 8;
            WeekDates_Start.Value = new DateTime(2024, 5, 2, 3, 53, 50, 0);
            // 
            // WeekDates_End
            // 
            WeekDates_End.Format = DateTimePickerFormat.Short;
            WeekDates_End.Location = new Point(265, 16);
            WeekDates_End.Name = "WeekDates_End";
            WeekDates_End.Size = new Size(126, 23);
            WeekDates_End.TabIndex = 10;
            WeekDates_End.Value = new DateTime(2024, 5, 2, 3, 53, 50, 0);
            // 
            // WeekDates_Label_2
            // 
            WeekDates_Label_2.AutoSize = true;
            WeekDates_Label_2.Location = new Point(234, 19);
            WeekDates_Label_2.Name = "WeekDates_Label_2";
            WeekDates_Label_2.Size = new Size(25, 17);
            WeekDates_Label_2.TabIndex = 9;
            WeekDates_Label_2.Text = "au";
            // 
            // Generator_WeekSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1035, 440);
            Controls.Add(WeekDates_End);
            Controls.Add(WeekDates_Label_2);
            Controls.Add(WeekDates_Start);
            Controls.Add(WeekDates_Label_1);
            Controls.Add(SundaySettings_Group);
            Controls.Add(SaturdaySettings_Group);
            Controls.Add(FridaySettings_Group);
            Controls.Add(ThursdaySettings_Group);
            Controls.Add(WednesdaySettings_Group);
            Controls.Add(TuesdaySettings_Group);
            Controls.Add(MondaySettings_Group);
            Font = new Font("Century Gothic", 9.75F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Generator_WeekSettings";
            Text = "Generator_WeekSettings";
            MondaySettings_Group.ResumeLayout(false);
            MondaySettings_Group.PerformLayout();
            TuesdaySettings_Group.ResumeLayout(false);
            TuesdaySettings_Group.PerformLayout();
            ThursdaySettings_Group.ResumeLayout(false);
            ThursdaySettings_Group.PerformLayout();
            WednesdaySettings_Group.ResumeLayout(false);
            WednesdaySettings_Group.PerformLayout();
            SaturdaySettings_Group.ResumeLayout(false);
            SaturdaySettings_Group.PerformLayout();
            FridaySettings_Group.ResumeLayout(false);
            FridaySettings_Group.PerformLayout();
            SundaySettings_Group.ResumeLayout(false);
            SundaySettings_Group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox MondaySettings_Group;
        private GroupBox TuesdaySettings_Group;
        private GroupBox ThursdaySettings_Group;
        private GroupBox WednesdaySettings_Group;
        private GroupBox SaturdaySettings_Group;
        private GroupBox FridaySettings_Group;
        private GroupBox SundaySettings_Group;
        private CheckBox MondaySettings_HasMultipleGames;
        private Label MondaySettings_GamesLabel;
        private CheckBox MondaySettings_IsDayOff;
        private Label WeekDates_Label_1;
        private DateTimePicker WeekDates_Start;
        private DateTimePicker WeekDates_End;
        private Label WeekDates_Label_2;
        private ListBox MondaySettings_Games;
        private ListBox TuesdaySettings_Games;
        private CheckBox TuesdaySettings_HasMultipleGames;
        private Label TuesdaySettings_GamesLabel;
        private CheckBox TuesdaySettings_IsDayOff;
        private ListBox ThursdaySettings_Games;
        private CheckBox ThursdaySettings_HasMultipleGames;
        private Label ThursdaySettings_GamesLabel;
        private CheckBox ThursdaySettings_IsDayOff;
        private ListBox WednesdaySettings_Games;
        private CheckBox WednesdaySettings_HasMultipleGames;
        private Label WednesdaySettings_GamesLabel;
        private CheckBox WednesdaySettings_IsDayOff;
        private ListBox FridaySettings_Games;
        private CheckBox FridaySettings_HasMultipleGames;
        private Label FridaySettings_GamesLabel;
        private CheckBox FridaySettings_IsDayOff;
        private ListBox SaturdaySettings_Games;
        private CheckBox SaturdaySettings_HasMultipleGames;
        private Label SaturdaySettings_GamesLabel;
        private CheckBox SaturdaySettings_IsDayOff;
        private ListBox SundaySettings_Games;
        private CheckBox SundaySettings_HasMultipleGames;
        private Label SundaySettings_GamesLabel;
        private CheckBox SundaySettings_IsDayOff;
        private DateTimePicker MondaySettings_StreamStartHour;
        private Label MondaySettings_HourSelectionLabel;
        private DateTimePicker TuesdaySettings_StreamStartHour;
        private Label TuesdaySettings_HourSelectionLabel;
        private DateTimePicker ThursdaySettings_StreamStartHour;
        private Label ThursdaySettings_HourSelectionLabel;
        private DateTimePicker WednesdaySettings_StreamStartHour;
        private Label WednesdaySettings_HourSelectionLabel;
        private DateTimePicker SaturdaySettings_StreamStartHour;
        private Label SaturdaySettings_HourSelectionLabel;
        private DateTimePicker FridaySettings_StreamStartHour;
        private Label FridaySettings_HourSelectionLabel;
        private DateTimePicker SundaySettings_StreamStartHour;
        private Label SundaySettings_HourSelectionLabel;
    }
}