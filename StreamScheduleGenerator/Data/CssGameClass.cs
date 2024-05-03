namespace StreamScheduleGenerator.Data
{
    public class CssGameClass
    {
        public static string DetermineCssGameClassByName(string gameName)
        {
            switch (gameName)
            {
                case "League of Legends":
                    return "stream_lol";
                case "Genshin Impact":
                    return "stream_genshin";
                case "Hunt : Showdown":
                    return "stream_hunt";
                case "Valorant":
                    return "stream_valo";
                default:
                    return "";
            }
        }
    }
}
