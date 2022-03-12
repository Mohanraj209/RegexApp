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
            User_Registration User = new User_Registration();
            User.Registration();
            Console.ReadKey();
        }
    }
}
