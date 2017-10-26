using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                // Menu 
                Console.WriteLine("choose an Option:");
                Console.WriteLine("1. Area of Rectangle");
                Console.WriteLine("2. Area of Triangle");
                Console.WriteLine("3. Area of Circle");
                Console.WriteLine("4. Exit");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Area of Rectangle
                    Console.WriteLine();
                    Console.Write("width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Area: " + (width * length));
                }
                else if (choice == "2")
                {
                    // Area of Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Area: " + (0.5 * width * height));
                }
                else if (choice == "3")
                {
                    // Area of Circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float radius = float.Parse(Console.ReadLine());
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Area: " + (Math.PI * radius * radius));
                }
                else if (choice == "4")
                {
                    Process.Start("U:/ict year 10/visual studio/Year10Software/Loops/bin/Debug/Loops.exe");
                }

                // wait
                Console.WriteLine();
                Console.WriteLine("Press any key to contine...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
