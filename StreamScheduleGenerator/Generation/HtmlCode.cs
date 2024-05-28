namespace StreamScheduleGenerator.Generation
{
    public class HtmlCode
    {
        public static string GenerateHtmlCode(string charset, string scheduleMonth, string scheduleYear, List<Week> weeks)
        {
            string html = "<!DOCTYPE HTML>";

            // Head
            html += "<head>";
            html += "<meta charset='" + charset + "' />";
            html += "<style>" + CssCode.GenerateCssCode() + "</style>";
            html += "</head>";

            // Body
            html += "<body>";
            html += "<div id='content'>";
            html += "<div id='planning_title'>PLANNING - " + scheduleMonth.ToUpper() + " " + scheduleYear + "</div>";
            html += GenerateChannelLinkCode();
            html += "<div id='planning_table'>";
            html += GenerateTableFirstLine();

            foreach (Week week in weeks)
            {
                html += GenerateTableLine(week, scheduleMonth);
            }

            html += "</div>";
            html += "</div>";
            html += "</body>";

            return html;
        }

        private static string GenerateChannelLinkCode()
        {
            string streamPlatformIconFilename = Environment.CurrentDirectory + "\\Images\\";

            switch (Properties.Settings.Default.scheduleStreamPlatformColor)
            {
                case "default":
                    streamPlatformIconFilename += "platform_twitch_default.png";
                    break;
                case "light":
                    streamPlatformIconFilename += "platform_twitch_white.png";
                    break;
                case "dark":
                    streamPlatformIconFilename += "platform_twitch_black.png";
                    break;
            }

            string channelLink = "<div id='channel_link' class='platform_";
            channelLink += Properties.Settings.Default.scheduleStreamPlatform.ToLower() + " " + Properties.Settings.Default.scheduleStreamPlatformColor + "'>";
            channelLink += "<img id='channel_platform' src='" + FileUtilities.FileConverter.FileToBase64(streamPlatformIconFilename) + "' />";
            channelLink += "<div id='channel_link_text'>";

            if (Properties.Settings.Default.scheduleShowFullChannelLink)
            {
                switch (Properties.Settings.Default.scheduleStreamPlatform)
                {
                    case "Twitch":
                        channelLink += "twitch.tv/";
                        break;
                    default:
                        break;
                }
            }

            channelLink += Properties.Settings.Default.scheduleChannelName + "</div>";
            channelLink += "</div>";
            return channelLink;
        }

        private static string GenerateTableFirstLine()
        {
            string tableFirstLine = "<div class='planning_table_line'>";

            tableFirstLine += "<div class='planning_table_col planning_table_col_large'></div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Lundi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Mardi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Mercredi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Jeudi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Vendredi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Samedi</div>";
            tableFirstLine += "<div class='planning_table_col text-center'>Dimanche</div>";

            tableFirstLine += "</div>";
            return tableFirstLine;
        }

        private static string GenerateTableLine(Week week, string scheduleMonth)
        {
            string tableLine = "<div class='planning_table_line'>";

            tableLine += GenerateTableLineFirstCol(week.GetStartDate(), week.GetEndDate(), scheduleMonth);
            tableLine += GenerateTableLineCol(week.GetMonday());
            tableLine += GenerateTableLineCol(week.GetTuesday());
            tableLine += GenerateTableLineCol(week.GetWednesday());
            tableLine += GenerateTableLineCol(week.GetThursday());
            tableLine += GenerateTableLineCol(week.GetFriday());
            tableLine += GenerateTableLineCol(week.GetSaturday());
            tableLine += GenerateTableLineCol(week.GetSunday());

            tableLine += "</div>";
            return tableLine;
        }

        private static string GenerateTableLineFirstCol(DateTime weekStart, DateTime weekEnd, string scheduleMonth)
        {
            string lineFirstCol = "<div class='planning_table_col planning_table_col_large'>";
            lineFirstCol += "Du " + weekStart.Day + " au " + weekEnd.Day + " " + scheduleMonth.ToLower();
            lineFirstCol += "</div>";
            return lineFirstCol;
        }

        private static string GenerateTableLineCol(Day day)
        {
            string lineCol = "";

            if (!day.IsDayOn())
            {
                // Jour OFF
                lineCol += "<div class='planning_table_col text-center stream_off'>OFF</div>";
            }
            else
            {
                // Jour ON
                if (day.IsDayOn() && (day.HasMultipleGames() == null || day.HasMultipleGames() == false))
                {
                    // Jeu unique
                    lineCol += "<div class='planning_table_col text-center stream_on " + Data.CssGameClass.DetermineCssGameClassByName(day.GetGameList()[0]) + "'>";
                    lineCol += ((DateTime)day.GetStreamStart()).ToShortTimeString().Replace(":", "h");
                    lineCol += "</div>";
                }
                else
                {
                    // Multi-gaming
                    lineCol += "<div class='planning_table_col text-center stream_on'>";
                    lineCol += "<div class='planning_table_line'>";

                    foreach (string gameName in day.GetGameList())
                    {
                        lineCol += "<div class='planning_table_col stream_on " + Data.CssGameClass.DetermineCssGameClassByName(gameName) + "'></div>";
                    }

                    lineCol += "</div>";
                    lineCol += "<div class='planning_table_col_inlinebreak'></div>";
                    lineCol += "<p>" + ((DateTime)day.GetStreamStart()).ToShortTimeString().Replace(":", "h") + "</p>";
                    lineCol += "</div>";
                }
            }

            return lineCol;
        }
    }
}
