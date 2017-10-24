using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int rand = rnd.Next(1, 1001);

            int guess = -1;
            int count = 0;
            while(guess != rand)
            {
                count++;
                Console.Write("Guess the Number:");
                guess = int.Parse(Console.ReadLine());
                if (guess < rand)
                {
                    Console.WriteLine("To Low");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("To High");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"You Got It, it took {count} tries");
                }
            }
            
            Console.ReadKey();
        }
    }
}
