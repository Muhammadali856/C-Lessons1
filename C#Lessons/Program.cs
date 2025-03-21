using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day of the week: ");
            var justnumber = Console.ReadLine();
            int number = Convert.ToInt32(justnumber);

            switch (number)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tue"); break ;
                case 3: Console.WriteLine("wed"); break;
            }

                Console.ReadLine();
        }
    }
}
