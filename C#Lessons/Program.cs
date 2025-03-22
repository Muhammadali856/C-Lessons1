using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Execise 1
            Console.Write("Ismingizni kiriting: ");
            string name = Console.ReadLine();

            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            */
            /*
            //Exercise 2
            Console.Write("Parol kiriting: ");
            string password1 = Console.ReadLine();
            Console.Write("Qayta kiriting: ");
            string password2 = Console.ReadLine();

            if (!password1.Equals(string.Empty) )
            {
                if (!password2.Equals(string.Empty))
                {
                    if (password1 == password2)
                    {
                        Console.WriteLine("Parollar bir-biriga mos :)");
                    }
                    else
                    {
                        Console.WriteLine("Parollar bir-biriga o'xshash emas");
                    }
                }
                else
                {
                    Console.WriteLine("Iltimos parolni tasdiqlashni kiriting");
                }
            }
            else
            {
                Console.WriteLine("Iltimos parolni kiriting :(");
            }
            */
            Console.ReadLine();
        }
    }
}
