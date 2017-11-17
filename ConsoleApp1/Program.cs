using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Discard Variable (write only) //
            var x = 'a';
            if (x is int) { Console.WriteLine("x is an Integer"); }
            // note that you cannot use "var" only but "var _" // interesting
            if (x is var _) { Console.WriteLine("x is a var\nPress any Key to Quit"); }
            Console.ReadKey(true);
        }
    }
}
