using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexApp
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------** User Registration **--------");
            User_Registration user  = new User_Registration();  
            if (user.validateFirstName("Abin"))
            {
                Console.WriteLine("\n Valid");
            }
            else
                Console.WriteLine("\n Invalid");
            Console.ReadKey();
        }
    }
}
