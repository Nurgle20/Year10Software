using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Age");
            int age  = int.Parse(Console.ReadLine());

            if (age <= 13)
            {
                Console.WriteLine("You're a Child");
            }
            else if (age <= 20)
            {
                Console.WriteLine("You're a Teen");
            }
            else
            {
                Console.WriteLine("You're An Adult");
            }
            Console.ReadKey();
        }
    }
}
