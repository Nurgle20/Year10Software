using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter a number....");
            int number = int.Parse(Console.ReadLine());

            for(int num = 1; num <= number; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();

            Console.WriteLine("Start");
            Console.ReadLine();

            int number1 = 1;
            while(number1 < 11)
            {
                Console.WriteLine(number1);
                number1++;
            }
            Console.ReadKey();
        }
    }
}
