namespace StreamScheduleGenerator.ColorUtilities
{
    public class ColorConvertor
    {
        public static string ToHex(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";
    }
}
