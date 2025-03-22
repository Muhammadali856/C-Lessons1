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
            /*
            //First_exercise
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int needed_number = number * i;
                //Console.WriteLine(i + " * " + number + " = " + needed_number);
                Console.WriteLine("{0} * {1} = {2}", i, number, needed_number);
            }
            */

            //Second Exrescise
            for (int i = 0; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} is FizzBuzz", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0}, is Fizz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0}, is Buzz", i);
                }
                else
                {
                    Console.WriteLine("{0}, is the False number", i);
                }
            }
                    Console.ReadLine();
        }
    }
}
