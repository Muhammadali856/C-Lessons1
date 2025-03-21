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
            Console.Write("Enter a number: ");
            string textAge = Console.ReadLine();
            int number2 = Convert.ToInt32(textAge);

            
            //Console.Write(number2*2+5);

            Console.Clear();
            Console.Write("The number, which you gave was multiplayed and 5 was added: ");
            Console.WriteLine(number2*2+5);

            Console.ReadLine();
        }
    }
}
