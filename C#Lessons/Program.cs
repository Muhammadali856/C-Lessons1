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
            bool succes = true;

            while (succes)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    succes = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }


            

            Console.ReadLine();
        }
    }
}
