using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexApp
{
	public class User_Registration
	{
		public static string firstname_Pattern = "^([A-Z]*[a-z]*){2,}$";
		public static string lastName_Pattern = "^[A-Z]{1}[a-z]{2}$";
		public static string ValidateFirstName(string Name)
		{
			if (Regex.IsMatch(Name, firstname_Pattern))
				return "First Name is Valid";
			else
				return "First Name is Invalid";
		}

		public static string ValidateLastName(string Name)
		{
			if (Regex.IsMatch(Name, lastName_Pattern))
				return "Last Name is Valid";
			else
				return "Last Name is Invalid";
		}

        public void Registration()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option");
                Console.WriteLine("1 = First Name\n2 = Last Name\n0=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        Console.WriteLine("\nEnter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(ValidateFirstName(firstName));
                        break;
                    case 2:
                        Console.WriteLine("\nEnter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(ValidateLastName(lastName));
                        break;
                    default:
                        Console.WriteLine("\nEnter Correct Option!");
                        break;
                }
            }
        }
    }
}
