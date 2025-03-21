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
            Console.Write("Birinchi raqamni kiriting: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());


            Console.Write("Ikkinchi raqamni kiriting: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            int answer = FirstNumber + SecondNumber;
            int EnteredAnswer = 0;

            while (EnteredAnswer != answer)
            {
                Console.Write("Misolni yech latta: " + FirstNumber + " + " + SecondNumber + " = ");
                EnteredAnswer = Convert.ToInt32(Console.ReadLine());

                if (EnteredAnswer != answer)
                {
                    Console.WriteLine("Daje yaqin ham kelmading boq //🤮");
                }

            }

            Console.WriteLine("Bo'ladi :(");

            Console.ReadLine();
        }
    }
}
