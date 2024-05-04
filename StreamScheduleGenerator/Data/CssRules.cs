namespace StreamScheduleGenerator.Data
{
    public class CssRules
    {
        public static string imagesFolderPath = (Environment.CurrentDirectory + "\\Images\\").Replace("\\", "/");

        public static Dictionary<string, Dictionary<string, string>> GetCssGlobalRules()
        {
            Dictionary<string, Dictionary<string, string>> globalRules = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> allRules = new Dictionary<string, string>();
            allRules.Add("margin", "0");
            allRules.Add("padding", "0");
            allRules.Add("font-family", "'" + Properties.Settings.Default.scheduleFont + "', sans-serif");
            allRules.Add("user-select", "none");

            Dictionary<string, string> bodyRules = new Dictionary<string, string>();
            bodyRules.Add("background-image", "url('" + FileUtilities.FileConverter.FileToBase64(Properties.Settings.Default.scheduleBackgroundImage) + "')");
            bodyRules.Add("background-attachment", "fixed");
            bodyRules.Add("background-repeat", "no-repeat");
            bodyRules.Add("background-position", "center center");
            bodyRules.Add("background-size", "cover");

            Dictionary<string, string> bgOverlayAndContentRules = new Dictionary<string, string>();
            bgOverlayAndContentRules.Add("position", "fixed");
            bgOverlayAndContentRules.Add("top", "0");
            bgOverlayAndContentRules.Add("left", "0");
            bgOverlayAndContentRules.Add("width", "100vw");
            bgOverlayAndContentRules.Add("height", "100vh");

            globalRules.Add("*", allRules);
            globalRules.Add("body", bodyRules);
            globalRules.Add("#background_overlay, #content", bgOverlayAndContentRules);
            return globalRules;
        }

        public static Dictionary<string, Dictionary<string, string>> GetCssTableRules()
        {
            Dictionary<string, Dictionary<string, string>> tableRules = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> planningTitleRules = new Dictionary<string, string>();
            planningTitleRules.Add("position", "absolute");
            planningTitleRules.Add("top", "40px");
            planningTitleRules.Add("left", "40px");
            planningTitleRules.Add("color", Properties.Settings.Default.scheduleColorTitles);
            planningTitleRules.Add("font-size", "45px");
            planningTitleRules.Add("font-weight", "bold");

            Dictionary<string, string> planningTableRules = new Dictionary<string, string>();
            planningTableRules.Add("position", "absolute");
            planningTableRules.Add("top", "50%");
            planningTableRules.Add("left", "calc(50% - 40vw)");
            planningTableRules.Add("width", "80vw");
            planningTableRules.Add("transform", "translateY(-50%)");

            Dictionary<string, string> planningTableLineRules = new Dictionary<string, string>();
            planningTableLineRules.Add("width", "100%");
            planningTableLineRules.Add("height", "100%");
            planningTableLineRules.Add("display", "flex");

            Dictionary<string, string> planningTableLineBreakRules = new Dictionary<string, string>();
            planningTableLineBreakRules.Add("flex-basis", "100%");
            planningTableLineBreakRules.Add("height", "0");

            Dictionary<string, string> planningTableCol = new Dictionary<string, string>();
            planningTableCol.Add("display", "flex");
            planningTableCol.Add("color", Properties.Settings.Default.scheduleColorTitles);
            planningTableCol.Add("font-size", "25px");
            planningTableCol.Add("font-weight", "bold");
            planningTableCol.Add("align-items", "center");
            planningTableCol.Add("justify-content", "center");

            Dictionary<string, string> planningTableColWithSubLine = new Dictionary<string, string>();
            planningTableColWithSubLine.Add("flex-direction", "column");
            planningTableColWithSubLine.Add("flex-wrap", "wrap");

            Dictionary<string, string> planningTableColForSubLine = new Dictionary<string, string>();
            planningTableColForSubLine.Add("flex", "1");

            Dictionary<string, string> planningTableSublineColParagraph = new Dictionary<string, string>();
            planningTableSublineColParagraph.Add("position", "relative");
            planningTableSublineColParagraph.Add("width", "100%");
            planningTableSublineColParagraph.Add("left", "-100%");
            planningTableSublineColParagraph.Add("bottom", "-40.5%");
            planningTableSublineColParagraph.Add("z-index", "3");

            Dictionary<string, string> planningTableColCenteredText = new Dictionary<string, string>();
            planningTableColCenteredText.Add("text-align", "center");

            Dictionary<string, string> planningTableColNotFirstChild = new Dictionary<string, string>();
            planningTableColNotFirstChild.Add("flex", "1");

            Dictionary<string, string> planningTableColFirstChild = new Dictionary<string, string>();
            planningTableColFirstChild.Add("flex", "2");

            Dictionary<string, string> planningTableColLarge = new Dictionary<string, string>();
            planningTableColLarge.Add("margin-right", "25px");

            Dictionary<string, string> planningTableLineForMultipleStream = new Dictionary<string, string>();
            planningTableLineForMultipleStream.Add("flex", "2");

            tableRules.Add("#planning_title", planningTitleRules);
            tableRules.Add("#planning_table", planningTableRules);
            tableRules.Add(".planning_table_line", planningTableLineRules);
            tableRules.Add(".planning_table_col_inlinebreak", planningTableLineBreakRules);
            tableRules.Add(".planning_table_col", planningTableCol);
            tableRules.Add(".planning_table_col:has(.planning_table_line)", planningTableColWithSubLine);
            tableRules.Add(".planning_table_col:has(.planning_table_line) .planning_table_line .planning_table_col", planningTableColForSubLine);
            tableRules.Add(".planning_table_col:has(.planning_table_line) p", planningTableSublineColParagraph);
            tableRules.Add(".planning_table_col.text-center", planningTableColCenteredText);
            tableRules.Add(".planning_table_col:not(:first-child)", planningTableColNotFirstChild);
            tableRules.Add(".planning_table_col:first-child", planningTableColFirstChild);
            tableRules.Add(".planning_table_col_large", planningTableColLarge);
            tableRules.Add(".stream_double .planning_table_line", planningTableLineForMultipleStream);
            return tableRules;
        }

        public static Dictionary<string, Dictionary<string, string>> GetCssCasesRules()
        {
            Dictionary<string, Dictionary<string, string>> casesRules = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> streamOffRules = new Dictionary<string, string>();
            streamOffRules.Add("color", Properties.Settings.Default.scheduleColorDayOff);
            streamOffRules.Add("border", "1px solid " + Properties.Settings.Default.scheduleColorDayOff);

            Dictionary<string, string> streamOnRules = new Dictionary<string, string>();
            streamOnRules.Add("color", Properties.Settings.Default.scheduleColorDayOn);
            streamOnRules.Add("border", "0px solid transparent");
            streamOnRules.Add("margin", "1px");

            Dictionary<string, string> streamOnLoLRules = new Dictionary<string, string>();
            streamOnLoLRules.Add("padding-top", "125px");
            streamOnLoLRules.Add("background-image", "url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_lol_icon.png") + "'), url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_lol_wallpaper.png") + "')");
            streamOnLoLRules.Add("background-attachment", "fixed, fixed");
            streamOnLoLRules.Add("background-repeat", "no-repeat, no-repeat");
            streamOnLoLRules.Add("background-position", "center center, center center");
            streamOnLoLRules.Add("background-size", "65% auto, cover");

            Dictionary<string, string> streamOnValoRules = new Dictionary<string, string>();
            streamOnValoRules.Add("padding-top", "125px");
            streamOnValoRules.Add("background-image", "url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_valorant_icon.png") + "'), url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_valorant_wallpaper.jpg") + "')");
            streamOnValoRules.Add("background-attachment", "fixed, fixed");
            streamOnValoRules.Add("background-repeat", "no-repeat, no-repeat");
            streamOnValoRules.Add("background-position", "center center, center center");
            streamOnValoRules.Add("background-size", "65% auto, cover");

            Dictionary<string, string> streamOnHuntRules = new Dictionary<string, string>();
            streamOnHuntRules.Add("padding-top", "125px");
            streamOnHuntRules.Add("background-image", "url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_hunt_logo.png") + "'), url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_hunt_wallpaper.jpg") + "')");
            streamOnHuntRules.Add("background-attachment", "fixed, fixed");
            streamOnHuntRules.Add("background-repeat", "no-repeat, no-repeat");
            streamOnHuntRules.Add("background-position", "center center, center center");
            streamOnHuntRules.Add("background-size", "65% auto, cover");

            Dictionary<string, string> streamOnGenshinRules = new Dictionary<string, string>();
            streamOnGenshinRules.Add("padding-top", "125px");
            streamOnGenshinRules.Add("background-image", "url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_genshin_logo.png") + "'), url('" + FileUtilities.FileConverter.FileToBase64(imagesFolderPath + "game_genshin_wallpaper.jpg") + "')");
            streamOnGenshinRules.Add("background-attachment", "fixed, fixed");
            streamOnGenshinRules.Add("background-repeat", "no-repeat, no-repeat");
            streamOnGenshinRules.Add("background-position", "center center, center center");
            streamOnGenshinRules.Add("background-size", "65% auto, cover");
            streamOnGenshinRules.Add("color", Properties.Settings.Default.scheduleColorDayOnContrast);

            casesRules.Add(".stream_off", streamOffRules);
            casesRules.Add(".stream_on", streamOnRules);
            casesRules.Add(".stream_on.stream_lol", streamOnLoLRules);
            casesRules.Add(".stream_on.stream_valo", streamOnValoRules);
            casesRules.Add(".stream_on.stream_hunt", streamOnHuntRules);
            casesRules.Add(".stream_on.stream_genshin", streamOnGenshinRules);
            return casesRules;
        }

        public static Dictionary<string, Dictionary<string, string>> GetCssChannelLinkRules()
        {
            Dictionary<string, Dictionary<string, string>> channelLinkRules = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, string> channelLinkContainerRules = new Dictionary<string, string>();
            channelLinkContainerRules.Add("position", "absolute");
            channelLinkContainerRules.Add("top", "40px");
            channelLinkContainerRules.Add("right", "40px");

            Dictionary<string, string> channelPlatformRules = new Dictionary<string, string>();
            channelPlatformRules.Add("display", "inline-block");
            channelPlatformRules.Add("width", "50px");
            channelPlatformRules.Add("height", "50px");
            channelPlatformRules.Add("vertical-align", "middle");

            Dictionary<string, string> channelLinkTextRules = new Dictionary<string, string>();
            channelLinkTextRules.Add("display", "inline-block");
            channelLinkTextRules.Add("margin-left", "10px");
            channelLinkTextRules.Add("vertical-align", "middle");
            channelLinkTextRules.Add("font-weight", "bold");
            channelLinkTextRules.Add("font-size", "30px");

            channelLinkRules.Add("#channel_link", channelLinkContainerRules);
            channelLinkRules.Add("#channel_platform", channelPlatformRules);
            channelLinkRules.Add("#channel_link_text", channelLinkTextRules);

            if (Properties.Settings.Default.scheduleStreamPlatform == "Twitch")
            {
                Dictionary<string, string> channelPlatformTwitchDefaultRules = new Dictionary<string, string>();
                channelPlatformTwitchDefaultRules.Add("color", "#8205B4");

                Dictionary<string, string> channelPlatformTwitchLightRules = new Dictionary<string, string>();
                channelPlatformTwitchLightRules.Add("color", "#FFFFFF");

                Dictionary<string, string> channelPlatformTwitchDarkRules = new Dictionary<string, string>();
                channelPlatformTwitchDarkRules.Add("color", "#000000");

                channelLinkRules.Add("#channel_link.platform_twitch.default", channelPlatformTwitchDefaultRules);
                channelLinkRules.Add("#channel_link.platform_twitch.light", channelPlatformTwitchLightRules);
                channelLinkRules.Add("#channel_link.platform_twitch.dark", channelPlatformTwitchDarkRules);
            }

            return channelLinkRules;
        }
    }
}
