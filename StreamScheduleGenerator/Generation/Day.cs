namespace StreamScheduleGenerator.Generation
{
    public class Day
    {
        private bool IsOn;
        private DateTime? StreamStart;
        private bool? IsFeaturingMultipleGames;
        private List<string> StreamGameNames;

        public Day(bool isDayOn, DateTime? start, bool? willFeatureMultipleGames, List<string> games)
        {
            IsOn = isDayOn;
            StreamStart = start;
            IsFeaturingMultipleGames = willFeatureMultipleGames;
            StreamGameNames = games;
        }

        public bool IsDayOn()
        {
            return IsOn;
        }

        public DateTime? GetStreamStart()
        {
            return StreamStart;
        }

        public bool? HasMultipleGames()
        {
            return IsFeaturingMultipleGames;
        }

        public List<string> GetGameList()
        {
            return StreamGameNames;
        }
    }
}
