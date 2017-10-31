using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIZZBUZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50000; i++)
            {
                if(i%3==0 && i%5==0)
                    {
                        Console.WriteLine("FIZZBUZZ");
                        Console.Beep(1000, 500);
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                        
                    }
                else if(i%3==0)
                    {
                         Console.WriteLine("FIZZ");
                         Console.Beep(2500, 250);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if(i%5==0)
                {
                    Console.WriteLine("BUZZ");
                    Console.Beep(3000, 100);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.WriteLine(i);
                }
               
            }
            Console.ReadKey();
        }
    }
}
