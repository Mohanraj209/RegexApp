using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexApp
{
	internal class User_Registration
	{
		public static string Pattern = "^([A-Z]*[a-z]*){2,}$";
		public bool validateFirstName(string sample)
		{
			return Regex.IsMatch(sample, Pattern);
		}
	}
}
