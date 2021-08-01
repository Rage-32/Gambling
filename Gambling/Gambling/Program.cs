using System;

namespace Gambling
{
    public class GamblingGame
    {

        public static void Main(string[] args)
        {
            var amount = 1000;
            Console.WriteLine("Welcome to Rage's gambling system. This does not save, so when you reload the script you will be reset back to $1,000.");
            Console.WriteLine("Enter amount you want to gamble");
            while (true)
            {
                var random = new Random().Next(1, 100);
                var command = Console.ReadLine();
                int input;
                try
                {
                    input = Convert.ToInt32(command);
                }
                catch
                {
                    Console.WriteLine("Please input a number!");
                    continue;
                }
                
                if (input <= 0)
                {
                    Console.WriteLine("Your amount has to be above 0!");
                    continue;
                }
                if (amount - input < 0)
                {
                    Console.WriteLine("You do not enough money for this");
                    continue;
                }
                if (random > 50)
                {
                    Console.WriteLine($"You win! Your money has been set to ${(amount + input):N0}");
                    amount += input;
                }
                else if (random < 50)
                {
                    Console.WriteLine($"You lose! Your money has been set to ${(amount - input):N0}");
                    amount -= input;
                }
                if (amount != 0) continue;
                Console.WriteLine("You've lost all your money! You've been set to $250");
                amount = 250;
            }
        }
    }
}