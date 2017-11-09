using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace babyBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            float money = 10;
            playGame(ref money);
        }
        private static void playGame(ref float money)
        {
            Console.Clear();
            float betAmount = MakeBet(ref money);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWin = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWin, betAmount, ref money);
            Menu(ref money);
        }



            private static void playGame(ref float money)..

            private static float MakeBet(ref float money)
        {
            float betAmount = 0;
            bool validBet = false;
            Console.WriteLine("Enter your bet. you have $" + money);

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > money)
                {
                    Console.WriteLine("Sorry, you do not have enough. Try again.");
                    validBet = false;
                }
                else if (betAmount < 0)
                {
                    Console.WriteLine("Sorry, you cannot bet a negative amount. Try again");
                    validBet = false;
                }
             }
            money ,money - 
        }
        private static int DealCards(Random rnd, string player)...

        private static bool determineWinnner(int player, int dealer)...

        private static void PayOut(bool playerWins, float betAmount, ref float money)...

        private static void Menu(ref float money)
        {
            Console.Write("Would you like anthoer game? y/n: ");
            if(Console.ReadLine() == "y")
            {
                playGame(ref money)
            }
        }

    }
}
