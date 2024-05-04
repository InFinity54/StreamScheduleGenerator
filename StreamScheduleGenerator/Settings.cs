using System.Drawing.Text;

namespace StreamScheduleGenerator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            InitializeFontList();

            Identity_StreamPlatform.SelectedIndex = Identity_StreamPlatform.FindString(Properties.Settings.Default.scheduleStreamPlatform);
            Identity_ChannelName.Text = Properties.Settings.Default.scheduleChannelName;
            GraphicalElements_Font.SelectedIndex = GraphicalElements_Font.FindString(Properties.Settings.Default.scheduleFont);
            GraphicalElements_ImgBgPath.Text = Properties.Settings.Default.scheduleBackgroundImage;
            Colors_TitlesColor.Text = Properties.Settings.Default.scheduleColorTitles;
            Colors_OffDayColor.Text = Properties.Settings.Default.scheduleColorDayOff;
            Colors_OnDayColor.Text = Properties.Settings.Default.scheduleColorDayOn;
            Colors_OnDayContrastColor.Text = Properties.Settings.Default.scheduleColorDayOnContrast;

            if (Properties.Settings.Default.scheduleShowFullChannelLink)
            {
                Identity_ChannelFullLink_Yes.Checked = true;
            }
            else
            {
                Identity_ChannelFullLink_No.Checked = false;
            }

            switch (Properties.Settings.Default.scheduleStreamPlatformColor)
            {
                case "default":
                default:
                    Identity_StreamPlatformLogoColor.SelectedIndex = Identity_StreamPlatformLogoColor.FindString("Couleur par défaut");
                    break;
                case "light":
                    Identity_StreamPlatformLogoColor.SelectedIndex = Identity_StreamPlatformLogoColor.FindString("Blanc");
                    break;
                case "dark":
                    Identity_StreamPlatformLogoColor.SelectedIndex = Identity_StreamPlatformLogoColor.FindString("Noir");
                    break;
            }
        }

        private void InitializeFontList()
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                GraphicalElements_Font.Items.Add(fontFamily.Name);
            }
        }

        private void Footer_SaveAndClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.scheduleStreamPlatform = Identity_StreamPlatform.Text;
            Properties.Settings.Default.scheduleChannelName = Identity_ChannelName.Text;
            Properties.Settings.Default.scheduleBackgroundImage = GraphicalElements_ImgBgPath.Text;
            Properties.Settings.Default.scheduleColorTitles = Colors_TitlesColor.Text;
            Properties.Settings.Default.scheduleColorDayOff = Colors_OffDayColor.Text;
            Properties.Settings.Default.scheduleColorDayOn = Colors_OnDayColor.Text;
            Properties.Settings.Default.scheduleColorDayOnContrast = Colors_OnDayContrastColor.Text;
            Properties.Settings.Default.scheduleFont = GraphicalElements_Font.Text;

            if (Identity_ChannelFullLink_Yes.Checked)
            {
                Properties.Settings.Default.scheduleShowFullChannelLink = true;
            }
            else
            {
                Properties.Settings.Default.scheduleShowFullChannelLink = false;
            }

            switch (Identity_StreamPlatformLogoColor.Text)
            {
                case "Couleur par défaut":
                default:
                    Properties.Settings.Default.scheduleStreamPlatformColor = "default";
                    break;
                case "Blanc":
                    Properties.Settings.Default.scheduleStreamPlatformColor = "light";
                    break;
                case "Noir":
                    Properties.Settings.Default.scheduleStreamPlatformColor = "dark";
                    break;
            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void GraphicalElements_ImgBgPath_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(GraphicalElements_ImgBgPath.Text))
            {
                MessageBox.Show("Le fichier \"" + GraphicalElements_ImgBgPath.Text + "\" n'existe pas. Veuillez choisir un autre fichier.");
                GraphicalElements_ImgBgPath.Text = "";
            }

            if (File.Exists(GraphicalElements_ImgBgPath.Text) && !FileUtilities.MimeTypes.DetermineFileTypeByExtension(GraphicalElements_ImgBgPath.Text).StartsWith("image"))
            {
                MessageBox.Show("Le fichier sélectionné doit être une image. Veuillez choisir un autre fichier.");
                GraphicalElements_ImgBgPath.Text = "";
            }
        }

        private void GraphicalElements_ImgBgFind_Click(object sender, EventArgs e)
        {
            SettingsUserFileChoose.ShowDialog(this);
            GraphicalElements_ImgBgPath.Text = SettingsUserFileChoose.FileName;
            GraphicalElements_ImgBgPath_Leave(sender, e);
        }

        private void Colors_TitlesColorSelect_Click(object sender, EventArgs e)
        {
            SettingsColorPicker.ShowDialog(this);
            Colors_TitlesColor.Text = ColorUtilities.ColorConvertor.ToHex(SettingsColorPicker.Color);
        }

        private void Colors_OffDayColorSelect_Click(object sender, EventArgs e)
        {
            SettingsColorPicker.ShowDialog(this);
            Colors_OffDayColor.Text = ColorUtilities.ColorConvertor.ToHex(SettingsColorPicker.Color);
        }

        private void Colors_OnDayColorSelect_Click(object sender, EventArgs e)
        {
            SettingsColorPicker.ShowDialog(this);
            Colors_OnDayColor.Text = ColorUtilities.ColorConvertor.ToHex(SettingsColorPicker.Color);
        }

        private void Colors_OnDayContrastColorSelect_Click(object sender, EventArgs e)
        {
            SettingsColorPicker.ShowDialog(this);
            Colors_OnDayContrastColor.Text = ColorUtilities.ColorConvertor.ToHex(SettingsColorPicker.Color);
        }
    }
}
