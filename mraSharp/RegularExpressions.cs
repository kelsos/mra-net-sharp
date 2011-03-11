using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mraSharp
{
	class RegularExpressions
	{
		/// <summary>
		/// Takes a string and converts every whitespace to the URL Encoding for space (%20)
		/// </summary>
		/// <param name="toProcess">The string to be processed.</param>
		/// <returns></returns>
		public static string whiteSpaceToUrlEncoding(string toProcess)
		{
			string patternUsed = "\\s+";
			string replacementString = "%20";
			Regex regExp = new Regex(patternUsed);
			return regExp.Replace(toProcess,replacementString);
		}
		/// <summary>
		/// Escapes the apostrophe for an SQL query.
		/// </summary>
		/// <param name="toProcess">The string to process.</param>
		/// <returns></returns>
		public static string escapeApostropheForQuery(string toProcess)
		{
			string patternUsed = "'";
			string replacementString = "''";
			Regex regExp = new Regex(patternUsed);
			return regExp.Replace(toProcess, replacementString);
		}

		/// <summary>
		/// A regular expression that removes the HTML tags from an RSS Description.
		/// </summary>
		/// <param name="toProcess">The string to process.</param>
		/// <returns></returns>
		public static string htmlTagRemover(string toProcess)
		{
			string patternUsed = "<.*>";
			string replacementString = "";
			Regex regExp = new Regex(patternUsed);
			return regExp.Replace(toProcess, replacementString);
		}
	}
}
