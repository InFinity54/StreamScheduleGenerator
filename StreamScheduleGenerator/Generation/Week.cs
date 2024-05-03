namespace StreamScheduleGenerator.Generation
{
    public class Week(
        DateTime startDate, DateTime endDate,
        bool isMondayOn, DateTime? mondayStart, bool? mondayFeatureMultipleGames, List<string> mondayGames,
        bool isTuesdayOn, DateTime? tuesdayStart, bool? tuesdayFeatureMultipleGames, List<string> tuesdayGames,
        bool isWednesdayOn, DateTime? wednesdayStart, bool? wednesdayFeatureMultipleGames, List<string> wednesdayGames,
        bool isThursdayOn, DateTime? thursdayStart, bool? thursdayFeatureMultipleGames, List<string> thursdayGames,
        bool isFridayOn, DateTime? fridayStart, bool? fridayFeatureMultipleGames, List<string> fridayGames,
        bool isSaturdayOn, DateTime? saturdayStart, bool? saturdayFeatureMultipleGames, List<string> saturdayGames,
        bool isSundayOn, DateTime? sundayStart, bool? sundayFeatureMultipleGames, List<string> sundayGames
    )
    {
        private readonly DateTime WeekStartDate = startDate;
        private readonly DateTime WeekEndDate = endDate;

        private readonly Day WeekMonday = new Day(isMondayOn, mondayStart, mondayFeatureMultipleGames, mondayGames);
        private readonly Day WeekTuesday = new Day(isTuesdayOn, tuesdayStart, tuesdayFeatureMultipleGames, tuesdayGames);
        private readonly Day WeekWednesday = new Day(isWednesdayOn, wednesdayStart, wednesdayFeatureMultipleGames, wednesdayGames);
        private readonly Day WeekThursday = new Day(isThursdayOn, thursdayStart, thursdayFeatureMultipleGames, thursdayGames);
        private readonly Day WeekFriday = new Day(isFridayOn, fridayStart, fridayFeatureMultipleGames, fridayGames);
        private readonly Day WeekSaturday = new Day(isSaturdayOn, saturdayStart, saturdayFeatureMultipleGames, saturdayGames);
        private readonly Day WeekSunday = new Day(isSundayOn, sundayStart, sundayFeatureMultipleGames, sundayGames);

        public DateTime GetStartDate()
        {
            return WeekStartDate;
        }

        public DateTime GetEndDate()
        {
            return WeekEndDate;
        }

        public Day GetMonday()
        {
            return WeekMonday;
        }

        public Day GetTuesday()
        {
            return WeekTuesday;
        }

        public Day GetWednesday()
        {
            return WeekWednesday;
        }

        public Day GetThursday()
        {
            return WeekThursday;
        }

        public Day GetFriday()
        {
            return WeekFriday;
        }

        public Day GetSaturday()
        {
            return WeekSaturday;
        }

        public Day GetSunday()
        {
            return WeekSunday;
        }
    }
}
