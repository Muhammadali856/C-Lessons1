using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string TakenName = Console.ReadLine();
            WelcomeMessager(TakenName);
            Console.ReadLine();
        }

        static void WelcomeMessager(string name)
        {
            Console.WriteLine($"Assalomu aleykum {name}. Tizimga xush kelibsiz :) ");
        }
    }
}
