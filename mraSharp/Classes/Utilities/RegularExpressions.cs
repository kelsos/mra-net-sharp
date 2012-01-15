using System.Text.RegularExpressions;

namespace mraNet.Classes.Utilities
{
    public static class RegularExpressions
    {
        /// <summary>
        /// Takes a string and converts every whitespace to the URL Encoding for space (%20)
        /// </summary>
        /// <param name="toProcess">The string to be processed.</param>
        /// <returns></returns>
        public static string WhiteSpaceToUrlEncoding(string toProcess)
        {
            const string patternUsed = "\\s+";
            const string replacementString = "%20";
            var regExp = new Regex(patternUsed);
            return regExp.Replace(toProcess, replacementString);
        }

        /// <summary>
        /// Escapes the apostrophe for an SQL query.
        /// </summary>
        /// <param name="toProcess">The string to process.</param>
        /// <returns></returns>
        public static string EscapeApostropheForQuery(string toProcess)
        {
            const string patternUsed = "'";
            const string replacementString = "''";
            var regExp = new Regex(patternUsed);
            return regExp.Replace(toProcess, replacementString);
        }

        /// <summary>
        /// A regular expression that removes the HTML tags from an RSS Description.
        /// </summary>
        /// <param name="toProcess">The string to process.</param>
        /// <returns></returns>
        public static string HtmlTagRemover(string toProcess)
        {
            const string patternUsed = "<.*>";
            const string replacementString = "";
            var regExp = new Regex(patternUsed);
            return regExp.Replace(toProcess, replacementString);
        }
    }
}