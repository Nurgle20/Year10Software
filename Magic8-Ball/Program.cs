using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            string[] answers = {"Maybe", "Yes", "No", "It is certain",
                                "Unsure, ask again" , "All signs point to yes",
                               "Most likely", "Reply hazy, try again", "Definitely not" };


            Console.WriteLine("Ask no a question that can be answered 'yes' or 'no' . Type 'exit' to leave");

            if(Console.ReadLine() != "exit")
            {
                Random rnd = new Random();

                Console.WriteLine(answers[rnd.Next(9)]);

                Console.WriteLine("");

                playGame();
            }
        }
    }
}
