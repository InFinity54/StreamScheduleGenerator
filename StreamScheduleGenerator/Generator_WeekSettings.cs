namespace StreamScheduleGenerator
{
    public partial class Generator_WeekSettings : Form
    {
        public Generator_WeekSettings()
        {
            InitializeComponent();
        }

        private void MondaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (MondaySettings_IsDayOff.Checked == true)
            {
                MondaySettings_HourSelectionLabel.Visible = false;
                MondaySettings_StreamStartHour.Visible = false;
                MondaySettings_HasMultipleGames.Visible = false;
                MondaySettings_GamesLabel.Visible = false;
                MondaySettings_Games.Visible = false;

                MondaySettings_HasMultipleGames.Checked = false;
                MondaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                MondaySettings_HourSelectionLabel.Visible = true;
                MondaySettings_StreamStartHour.Visible = true;
                MondaySettings_HasMultipleGames.Visible = true;
                MondaySettings_GamesLabel.Visible = true;
                MondaySettings_Games.Visible = true;
            }
        }

        private void MondaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            MondaySettings_Games.SelectedItems.Clear();

            if (MondaySettings_HasMultipleGames.Checked == true)
            {
                MondaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                MondaySettings_Games.SelectionMode = SelectionMode.One;
                MondaySettings_Games.SelectedItems.Clear();
            }
        }

        private void TuesdaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (TuesdaySettings_IsDayOff.Checked == true)
            {
                TuesdaySettings_HourSelectionLabel.Visible = false;
                TuesdaySettings_StreamStartHour.Visible = false;
                TuesdaySettings_HasMultipleGames.Visible = false;
                TuesdaySettings_GamesLabel.Visible = false;
                TuesdaySettings_Games.Visible = false;

                TuesdaySettings_HasMultipleGames.Checked = false;
                TuesdaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                TuesdaySettings_HourSelectionLabel.Visible = true;
                TuesdaySettings_StreamStartHour.Visible = true;
                TuesdaySettings_HasMultipleGames.Visible = true;
                TuesdaySettings_GamesLabel.Visible = true;
                TuesdaySettings_Games.Visible = true;
            }
        }

        private void TuesdaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            TuesdaySettings_Games.SelectedItems.Clear();

            if (TuesdaySettings_HasMultipleGames.Checked == true)
            {
                TuesdaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                TuesdaySettings_Games.SelectionMode = SelectionMode.One;
                TuesdaySettings_Games.SelectedItems.Clear();
            }
        }

        private void WednesdaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (WednesdaySettings_IsDayOff.Checked == true)
            {
                WednesdaySettings_HourSelectionLabel.Visible = false;
                WednesdaySettings_StreamStartHour.Visible = false;
                WednesdaySettings_HasMultipleGames.Visible = false;
                WednesdaySettings_GamesLabel.Visible = false;
                WednesdaySettings_Games.Visible = false;

                WednesdaySettings_HasMultipleGames.Checked = false;
                WednesdaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                WednesdaySettings_HourSelectionLabel.Visible = true;
                WednesdaySettings_StreamStartHour.Visible = true;
                WednesdaySettings_HasMultipleGames.Visible = true;
                WednesdaySettings_GamesLabel.Visible = true;
                WednesdaySettings_Games.Visible = true;
            }
        }

        private void WednesdaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            WednesdaySettings_Games.SelectedItems.Clear();

            if (WednesdaySettings_HasMultipleGames.Checked == true)
            {
                WednesdaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                WednesdaySettings_Games.SelectionMode = SelectionMode.One;
                WednesdaySettings_Games.SelectedItems.Clear();
            }
        }

        private void ThursdaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (ThursdaySettings_IsDayOff.Checked == true)
            {
                ThursdaySettings_HourSelectionLabel.Visible = false;
                ThursdaySettings_StreamStartHour.Visible = false;
                ThursdaySettings_HasMultipleGames.Visible = false;
                ThursdaySettings_GamesLabel.Visible = false;
                ThursdaySettings_Games.Visible = false;

                ThursdaySettings_HasMultipleGames.Checked = false;
                ThursdaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                ThursdaySettings_HourSelectionLabel.Visible = true;
                ThursdaySettings_StreamStartHour.Visible = true;
                ThursdaySettings_HasMultipleGames.Visible = true;
                ThursdaySettings_GamesLabel.Visible = true;
                ThursdaySettings_Games.Visible = true;
            }
        }

        private void ThursdaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            ThursdaySettings_Games.SelectedItems.Clear();

            if (ThursdaySettings_HasMultipleGames.Checked == true)
            {
                ThursdaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                ThursdaySettings_Games.SelectionMode = SelectionMode.One;
                ThursdaySettings_Games.SelectedItems.Clear();
            }
        }

        private void FridaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (FridaySettings_IsDayOff.Checked == true)
            {
                FridaySettings_HourSelectionLabel.Visible = false;
                FridaySettings_StreamStartHour.Visible = false;
                FridaySettings_HasMultipleGames.Visible = false;
                FridaySettings_GamesLabel.Visible = false;
                FridaySettings_Games.Visible = false;

                FridaySettings_HasMultipleGames.Checked = false;
                FridaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                FridaySettings_HourSelectionLabel.Visible = true;
                FridaySettings_StreamStartHour.Visible = true;
                FridaySettings_HasMultipleGames.Visible = true;
                FridaySettings_GamesLabel.Visible = true;
                FridaySettings_Games.Visible = true;
            }
        }

        private void FridaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            FridaySettings_Games.SelectedItems.Clear();

            if (FridaySettings_HasMultipleGames.Checked == true)
            {
                FridaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                FridaySettings_Games.SelectionMode = SelectionMode.One;
                FridaySettings_Games.SelectedItems.Clear();
            }
        }

        private void SaturdaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (SaturdaySettings_IsDayOff.Checked == true)
            {
                SaturdaySettings_HourSelectionLabel.Visible = false;
                SaturdaySettings_StreamStartHour.Visible = false;
                SaturdaySettings_HasMultipleGames.Visible = false;
                SaturdaySettings_GamesLabel.Visible = false;
                SaturdaySettings_Games.Visible = false;

                SaturdaySettings_HasMultipleGames.Checked = false;
                SaturdaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                SaturdaySettings_HourSelectionLabel.Visible = true;
                SaturdaySettings_StreamStartHour.Visible = true;
                SaturdaySettings_HasMultipleGames.Visible = true;
                SaturdaySettings_GamesLabel.Visible = true;
                SaturdaySettings_Games.Visible = true;
            }
        }

        private void SaturdaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            SaturdaySettings_Games.SelectedItems.Clear();

            if (SaturdaySettings_HasMultipleGames.Checked == true)
            {
                SaturdaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                SaturdaySettings_Games.SelectionMode = SelectionMode.One;
                SaturdaySettings_Games.SelectedItems.Clear();
            }
        }

        private void SundaySettings_IsDayOff_CheckedChanged(object sender, EventArgs e)
        {
            if (SundaySettings_IsDayOff.Checked == true)
            {
                SundaySettings_HourSelectionLabel.Visible = false;
                SundaySettings_StreamStartHour.Visible = false;
                SundaySettings_HasMultipleGames.Visible = false;
                SundaySettings_GamesLabel.Visible = false;
                SundaySettings_Games.Visible = false;

                SundaySettings_HasMultipleGames.Checked = false;
                SundaySettings_Games.SelectedItems.Clear();
            }
            else
            {
                SundaySettings_HourSelectionLabel.Visible = true;
                SundaySettings_StreamStartHour.Visible = true;
                SundaySettings_HasMultipleGames.Visible = true;
                SundaySettings_GamesLabel.Visible = true;
                SundaySettings_Games.Visible = true;
            }
        }

        private void SundaySettings_HasMultipleGames_CheckedChanged(object sender, EventArgs e)
        {
            SundaySettings_Games.SelectedItems.Clear();

            if (SundaySettings_HasMultipleGames.Checked == true)
            {
                SundaySettings_Games.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                SundaySettings_Games.SelectionMode = SelectionMode.One;
                SundaySettings_Games.SelectedItems.Clear();
            }
        }
    }
}
