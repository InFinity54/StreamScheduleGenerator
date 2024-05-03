using StreamScheduleGenerator.Data;

namespace StreamScheduleGenerator.Generation
{
    public class CssCode
    {
        public static string GenerateCssCode()
        {
            return GenerateGlobalCss() + " " + GenerateTableCss() + " " + GenerateCasesCss();
        }

        private static string GenerateGlobalCss()
        {
            string cssGlobal = "";

            foreach (KeyValuePair<string, Dictionary<string, string>> element in CssRules.GetCssGlobalRules())
            {
                cssGlobal += element.Key + " { ";

                foreach (KeyValuePair<string, string> rule in element.Value)
                {
                    cssGlobal += rule.Key + ": " + rule.Value + ";";
                }

                cssGlobal += " } ";
            }

            return cssGlobal;
        }

        private static string GenerateTableCss()
        {
            string cssTable = "";

            foreach (KeyValuePair<string, Dictionary<string, string>> element in CssRules.GetCssTableRules())
            {
                cssTable += element.Key + " { ";

                foreach (KeyValuePair<string, string> rule in element.Value)
                {
                    cssTable += rule.Key + ": " + rule.Value + ";";
                }

                cssTable += " } ";
            }

            return cssTable;
        }

        private static string GenerateCasesCss()
        {
            string cssCases = "";

            foreach (KeyValuePair<string, Dictionary<string, string>> element in CssRules.GetCssCasesRules())
            {
                cssCases += element.Key + " { ";

                foreach (KeyValuePair<string, string> rule in element.Value)
                {
                    cssCases += rule.Key + ": " + rule.Value + ";";
                }

                cssCases += " } ";
            }

            return cssCases;
        }
    }
}
