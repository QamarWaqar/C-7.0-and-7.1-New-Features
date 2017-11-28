using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void MyDelegate();
        public static event MyDelegate myEvent;

        static void Main(string[] args)
        {
            int a = default(int); Console.WriteLine("a = " + a + '\n');
            #region Discard Variable
            // Discard Variable (write only) //
            var x = 'a';
            if (x is int) { Console.WriteLine("x is an Integer"); }
            // note that you cannot use "var" only but "var _" // interesting
            if (x is var _) { Console.WriteLine("x is a var\n"); }
            #endregion Discard Variable
            #region Using Discard With Tasks
            Console.WriteLine("Using Discard With Tasks");
            // Creating A Delegate to the Function to be called //
            myEvent += UsingDiscardWithTasks;
            myEvent.Invoke();
            #endregion Using Discard With Tasks
            #region The End
            Console.WriteLine("\nPress Any Key to Quit\n");
            Console.ReadKey(true);
            #endregion The End
        }

        static void UsingDiscardWithTasks(params int[] a)
        {
            //Console.WriteLine("Hello Task");

            // This is awaitable //
            Task.Run(() =>
            {
                for (int i = -7 - 0; i < 0 + 0;)
                {
                    Console.WriteLine("The value of i = " + i);
                    i++;
                    System.Threading.Thread.Sleep(500);
                }
            });
        }
    }
}
