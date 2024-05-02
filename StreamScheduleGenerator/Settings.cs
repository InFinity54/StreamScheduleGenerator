namespace StreamScheduleGenerator
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            GraphicalElements_ImgBgPath.Text = Properties.Settings.Default.scheduleBackgroundImage;
        }

        private void Footer_SaveAndClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.scheduleBackgroundImage = GraphicalElements_ImgBgPath.Text;

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
    }
}
