namespace StreamScheduleGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();

            // Sélection du mois courante
            PlanningMonthSelection_Month.SelectedIndex = DateTime.Now.Month - 1;

            // Initialisation de la liste des années
            for (int i = DateTime.Now.Year; i <= DateTime.Now.Year + 10; i++)
            {
                PlanningMonthSelection_Year.Items.Add(i.ToString());
            }

            // Sélection de l'année courante
            PlanningMonthSelection_Year.SelectedIndex = 0;
        }

        private void Footer_NewWeek_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Semaine " + (WeeksSettings_Tabs.TabPages.Count + 1).ToString();

            Generator_WeekSettings weekForm = new Generator_WeekSettings();
            weekForm.Show();
            weekForm.TopLevel = false;
            weekForm.Dock = DockStyle.Fill;
            weekForm.Visible = true;

            tabPage.Controls.Add(weekForm);
            WeeksSettings_Tabs.TabPages.Add(tabPage);
        }
    }
}
