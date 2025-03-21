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
            Console.Write("Nimani qaytaray ?: ");
            String ChiqarishKerakBolganNarsa = Console.ReadLine();

            Console.Write("Necha marta qaytarib beray ?: ");
            int ChiqishSoni = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= ChiqishSoni; i++)
            {
                Console.WriteLine(i+ ". " + ChiqarishKerakBolganNarsa);
            }

            Console.ReadLine();
        }
    }
}
