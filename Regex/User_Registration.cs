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
        public static string email_Pattern = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public static string mobile_Pattern = "^[0-9]{2}[ ][0-9]{10}$";
        public static string password_PatternR4 = "^(?=.*?[0-9])(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[@#$&*.!?]).{8,}$";
        public static string sampleEmail_Pattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
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

        public static string ValidateEmailID(string Mail)
        {
            if (Regex.IsMatch(Mail, email_Pattern))
                return "E-Mail is Valid";
            else
                return "E-Mail is Invalid";
        }

        public static string ValidateMobileNumber(string Number)
        {
            if (Regex.IsMatch(Number, mobile_Pattern))
                return "Mobile number is valid";
            else
                return "Mobile number is Invalid";
        }

        public static string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, password_PatternR4))
                return "Password is valid";
            else
                return "Password is Invalid";
        }

        public static void SampleEmail()
        {
            string[] sampleEmail ={"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc-100@abc.net","abc111@abc.com","abc+100@gmail.com",
                                   "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc","abc@.com.my","abc123@gmail.a","abc123@.com",
                                   "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@gmail.com.1a",
                                   "abc@gmail.com.aa.au","abc..2002@gmail.com"};
            Console.WriteLine("Validate Sample Email Id");
            Validate(sampleEmail, sampleEmail_Pattern);
        }
        public static void Validate(string[] arr, string pattern)
        {
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, pattern))
                    Console.WriteLine(item + " \t\t " + "Valid Email");
                else
                    Console.WriteLine(item + " \t\t " + "InValid Email");
            }
        }
        public void Registration()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option");
                Console.WriteLine("1 = First Name\n2 = Last Name\n3 = Mail-ID\n4 = Mobile Number\n5 = Password\n6 = Sample_Mail check\n0=Exit");
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
                        Console.WriteLine(ValidateFirstName(lastName));
                        break;
                    case 3:
                        Console.WriteLine("\nEnter E-Mail");
                        string Mail = Console.ReadLine();
                        Console.WriteLine(ValidateEmailID(Mail));
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Mobile number");
                        string Mobile_Num = Console.ReadLine();
                        Console.WriteLine(ValidateMobileNumber(Mobile_Num));
                        break;
                    case 5:
                        Console.WriteLine("\nEnter Password");
                        string password = Console.ReadLine();
                        Console.WriteLine(ValidatePassword(password));
                        break;
                    case 6:
                        SampleEmail();
                        break;
                    default:
                        Console.WriteLine("\nEnter Correct Option!");
                        break;
                }
            }
        }
    }
}
