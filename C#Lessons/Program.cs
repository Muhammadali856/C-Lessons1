using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics.Eventing.Reader;


internal class Program
{
    static void Main(string[] args)
    {
        /*
        //Exercise 1
        Console.Write("Nechta raqam kiritmoqchisiz ?: ");
        int takennumbers = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[takennumbers];

        for (int i = 0; i < takennumbers; i++)
        {
            Console.Write($"{i+1} - raqamni kriting: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Siz kiritgan raqamlar: ");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"{nums[i]}, ");
        }
        */

        //Exercise 2
        int angecount = 3;
        int anglesum = 0;

        for (int i = 0; i < angecount; i++)
        {
            Console.Write($"Enter anlge {i + 1}: ");
            anglesum += Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(anglesum == 180 ? "Valid" : "Invalid");



        Console.ReadLine();
    }
}

