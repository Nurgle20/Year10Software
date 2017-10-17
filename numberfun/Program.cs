using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number X:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number Y:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine(num1 + " plus " + num2 +" = " + (num1 + num2));
            Console.WriteLine(num1 + " times " + num2 +" = " + num1 * num2);
            Console.WriteLine(num1 + " minus " + num2 +" = " + (num1 - num2));
            Console.WriteLine(num1 + " divided " + num2  +" = " + num1 / num2);

            Console.ReadKey();
        }
    }
}
