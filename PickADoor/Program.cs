using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Door");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind door 1 is a cute dog");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind door 2 is a cute cat");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind door 3 is a dead dog");
            }
            else
            {
                Console.WriteLine("try again");
            }

            Console.ReadKey();
        }
    }
}
