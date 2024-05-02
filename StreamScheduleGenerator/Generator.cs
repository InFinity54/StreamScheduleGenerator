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
            for (int i = DateTime.Now.Year;  i <= DateTime.Now.Year + 10; i++)
            {
                PlanningMonthSelection_Year.Items.Add(i.ToString());
            }

            // Sélection de l'année courante
            PlanningMonthSelection_Year.SelectedIndex = 0;
        }
    }
}
