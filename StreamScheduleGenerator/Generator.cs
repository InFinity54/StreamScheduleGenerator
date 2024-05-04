using CefSharp;
using CefSharp.Web;
using CefSharp.OffScreen;
using StreamScheduleGenerator.Generation;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Pickers.Provider;
using WinRT.Interop;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace StreamScheduleGenerator
{
    public partial class Generator : Form
    {
        private static ChromiumWebBrowser webBrowser;
        private static string webBrowserScreenSavePath = "";

        public Generator()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
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

        private void Header_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
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

        private void Footer_GenerationStart_Click(object sender, EventArgs e)
        {
            if (
                Properties.Settings.Default.scheduleBackgroundImage == "" || Properties.Settings.Default.scheduleColorTitles == "" |
                Properties.Settings.Default.scheduleColorDayOff == "" || Properties.Settings.Default.scheduleColorDayOn == "" ||
                Properties.Settings.Default.scheduleColorDayOnContrast == "" || Properties.Settings.Default.scheduleFont == "" ||
                Properties.Settings.Default.scheduleChannelName == "" || Properties.Settings.Default.scheduleStreamPlatform == "" ||
                Properties.Settings.Default.scheduleStreamPlatformColor == ""
            )
            {
                MessageBox.Show("La configuration du générateur est incomplète. Elle doit être complétée avant la génération.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Header_Settings.PerformClick();
            }
            else if (WeeksSettings_Tabs.TabCount == 0)
            {
                MessageBox.Show("Vous devez ajouter au moins une semaine dans le planning pour pouvoir le générer.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HideAllGenerationParameters();
                HandlePlanningGeneration();
            }
        }

        private void HideAllGenerationParameters()
        {
            Header_Settings.Enabled = false;
            PlanningMonthSelection_Month.Enabled = false;
            PlanningMonthSelection_Year.Enabled = false;
            Footer_NewWeek.Enabled = false;
            Footer_GenerationStart.Enabled = false;
            WeeksSettings_Tabs.Visible = false;
            GeneratingIndicator.Visible = true;
        }

        private void ShowAllGenerationParameters()
        {
            Header_Settings.Enabled = true;
            PlanningMonthSelection_Month.Enabled = true;
            PlanningMonthSelection_Year.Enabled = true;
            Footer_NewWeek.Enabled = true;
            Footer_GenerationStart.Enabled = true;
            WeeksSettings_Tabs.Visible = true;
            GeneratingIndicator.Visible = false;
        }

        private void HandlePlanningGeneration()
        {
            List<Week> weeks = new List<Week>();

            foreach (TabPage tab in WeeksSettings_Tabs.TabPages)
            {
                DateTime weekStart = DateTime.ParseExact(tab.Controls.Find("WeekDates_Start", true)[0].Text, "d", CultureInfo.CurrentCulture);
                DateTime weekEnd = DateTime.ParseExact(tab.Controls.Find("WeekDates_End", true)[0].Text, "d", CultureInfo.CurrentCulture);

                bool mondayDayOff = ((CheckBox)tab.Controls.Find("MondaySettings_IsDayOff", true)[0]).Checked;
                DateTime? mondayStreamStart = !mondayDayOff ? DateTime.ParseExact(tab.Controls.Find("MondaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? mondayHasMultipleGames = !mondayDayOff ? ((CheckBox)tab.Controls.Find("MondaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> mondayGames;

                if (!mondayDayOff && ((ListBox)tab.Controls.Find("MondaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    mondayGames = ((ListBox)tab.Controls.Find("MondaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!mondayDayOff && ((ListBox)tab.Controls.Find("MondaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    mondayGames = new List<string>();
                    mondayGames.Add(((ListBox)tab.Controls.Find("MondaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    mondayGames = new List<string>();
                }

                bool tuesdayDayOff = ((CheckBox)tab.Controls.Find("TuesdaySettings_IsDayOff", true)[0]).Checked;
                DateTime? tuesdayStreamStart = !tuesdayDayOff ? DateTime.ParseExact(tab.Controls.Find("TuesdaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? tuesdayHasMultipleGames = !tuesdayDayOff ? ((CheckBox)tab.Controls.Find("TuesdaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> tuesdayGames;

                if (!tuesdayDayOff && ((ListBox)tab.Controls.Find("TuesdaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    tuesdayGames = ((ListBox)tab.Controls.Find("TuesdaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!tuesdayDayOff && ((ListBox)tab.Controls.Find("TuesdaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    tuesdayGames = new List<string>();
                    tuesdayGames.Add(((ListBox)tab.Controls.Find("TuesdaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    tuesdayGames = new List<string>();
                }

                bool wednesdayDayOff = ((CheckBox)tab.Controls.Find("WednesdaySettings_IsDayOff", true)[0]).Checked;
                DateTime? wednesdayStreamStart = !wednesdayDayOff ? DateTime.ParseExact(tab.Controls.Find("WednesdaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? wednesdayHasMultipleGames = !wednesdayDayOff ? ((CheckBox)tab.Controls.Find("WednesdaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> wednesdayGames;

                if (!wednesdayDayOff && ((ListBox)tab.Controls.Find("WednesdaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    wednesdayGames = ((ListBox)tab.Controls.Find("WednesdaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!wednesdayDayOff && ((ListBox)tab.Controls.Find("WednesdaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    wednesdayGames = new List<string>();
                    wednesdayGames.Add(((ListBox)tab.Controls.Find("WednesdaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    wednesdayGames = new List<string>();
                }

                bool thursdayDayOff = ((CheckBox)tab.Controls.Find("ThursdaySettings_IsDayOff", true)[0]).Checked;
                DateTime? thursdayStreamStart = !thursdayDayOff ? DateTime.ParseExact(tab.Controls.Find("ThursdaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? thursdayHasMultipleGames = !thursdayDayOff ? ((CheckBox)tab.Controls.Find("ThursdaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> thursdayGames;

                if (!thursdayDayOff && ((ListBox)tab.Controls.Find("ThursdaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    thursdayGames = ((ListBox)tab.Controls.Find("ThursdaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!thursdayDayOff && ((ListBox)tab.Controls.Find("ThursdaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    thursdayGames = new List<string>();
                    thursdayGames.Add(((ListBox)tab.Controls.Find("ThursdaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    thursdayGames = new List<string>();
                }

                bool fridayDayOff = ((CheckBox)tab.Controls.Find("FridaySettings_IsDayOff", true)[0]).Checked;
                DateTime? fridayStreamStart = !fridayDayOff ? DateTime.ParseExact(tab.Controls.Find("FridaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? fridayHasMultipleGames = !fridayDayOff ? ((CheckBox)tab.Controls.Find("FridaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> fridayGames;

                if (!fridayDayOff && ((ListBox)tab.Controls.Find("FridaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    fridayGames = ((ListBox)tab.Controls.Find("FridaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!fridayDayOff && ((ListBox)tab.Controls.Find("FridaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    fridayGames = new List<string>();
                    fridayGames.Add(((ListBox)tab.Controls.Find("FridaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    fridayGames = new List<string>();
                }

                bool saturdayDayOff = ((CheckBox)tab.Controls.Find("SaturdaySettings_IsDayOff", true)[0]).Checked;
                DateTime? saturdayStreamStart = !saturdayDayOff ? DateTime.ParseExact(tab.Controls.Find("SaturdaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? saturdayHasMultipleGames = !saturdayDayOff ? ((CheckBox)tab.Controls.Find("SaturdaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> saturdayGames;

                if (!saturdayDayOff && ((ListBox)tab.Controls.Find("SaturdaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    saturdayGames = ((ListBox)tab.Controls.Find("SaturdaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!saturdayDayOff && ((ListBox)tab.Controls.Find("SaturdaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    saturdayGames = new List<string>();
                    saturdayGames.Add(((ListBox)tab.Controls.Find("SaturdaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    saturdayGames = new List<string>();
                }

                bool sundayDayOff = ((CheckBox)tab.Controls.Find("SundaySettings_IsDayOff", true)[0]).Checked;
                DateTime? sundayStreamStart = !sundayDayOff ? DateTime.ParseExact(tab.Controls.Find("SundaySettings_StreamStartHour", true)[0].Text, "t", CultureInfo.CurrentCulture) : null;
                bool? sundayHasMultipleGames = !sundayDayOff ? ((CheckBox)tab.Controls.Find("SundaySettings_HasMultipleGames", true)[0]).Checked : null;
                List<string> sundayGames;

                if (!sundayDayOff && ((ListBox)tab.Controls.Find("SundaySettings_Games", true)[0]).SelectionMode == SelectionMode.MultiExtended)
                {
                    sundayGames = ((ListBox)tab.Controls.Find("SundaySettings_Games", true)[0]).SelectedItems.Cast<string>().ToList();
                }
                else if (!sundayDayOff && ((ListBox)tab.Controls.Find("SundaySettings_Games", true)[0]).SelectionMode == SelectionMode.One)
                {
                    sundayGames = new List<string>();
                    sundayGames.Add(((ListBox)tab.Controls.Find("SundaySettings_Games", true)[0]).SelectedItem.ToString());
                }
                else
                {
                    sundayGames = new List<string>();
                }

                weeks.Add(new Week(
                    weekStart, weekEnd,
                    !mondayDayOff, mondayStreamStart, mondayHasMultipleGames, mondayGames,
                    !tuesdayDayOff, tuesdayStreamStart, tuesdayHasMultipleGames, tuesdayGames,
                    !wednesdayDayOff, wednesdayStreamStart, wednesdayHasMultipleGames, wednesdayGames,
                    !thursdayDayOff, thursdayStreamStart, thursdayHasMultipleGames, thursdayGames,
                    !fridayDayOff, fridayStreamStart, fridayHasMultipleGames, fridayGames,
                    !saturdayDayOff, saturdayStreamStart, saturdayHasMultipleGames, saturdayGames,
                    !sundayDayOff, sundayStreamStart, sundayHasMultipleGames, sundayGames
                ));
            }

            SaveFileDialog saveFileDialog = GeneratedScheduleSaveDialog;
            saveFileDialog.FileName = "Planning " + PlanningMonthSelection_Month.Text + " " + PlanningMonthSelection_Year.Text + ".jpg";
            saveFileDialog.ShowDialog();
            webBrowserScreenSavePath = saveFileDialog.FileName;

            string html = HtmlCode.GenerateHtmlCode("utf-8", PlanningMonthSelection_Month.Text, PlanningMonthSelection_Year.Text, weeks);
            webBrowser = new ChromiumWebBrowser();
            webBrowser.Size = new Size(1920, 1080);
            webBrowser.FrameLoadEnd += WebBrowser_FrameLoadEnd;

            webBrowser.LoadHtml(html, "http://schedule", System.Text.Encoding.UTF8);
        }

        private async void WebBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                var data = await webBrowser.CaptureScreenshotAsync(CefSharp.DevTools.Page.CaptureScreenshotFormat.Jpeg, 100);
                File.WriteAllBytes(webBrowserScreenSavePath, data);
                DialogResult IsFileNeedsToBeOpen = MessageBox.Show("Le planning est disponible dans le fichier suivant :" + Environment.NewLine + webBrowserScreenSavePath, "Planning généré", MessageBoxButtons.YesNo);

                if (IsFileNeedsToBeOpen == DialogResult.Yes)
                {
                    Process fileopener = new Process();
                    fileopener.StartInfo.FileName = "explorer";
                    fileopener.StartInfo.Arguments = "\"" + webBrowserScreenSavePath + "\"";
                    fileopener.Start();
                }

                Invoke((MethodInvoker)delegate ()
                {
                    //Cef.Shutdown();
                    ShowAllGenerationParameters();
                });
            }
        }
    }
}
