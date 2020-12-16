# IT02_Pidgornyi_Vladislav
Black Jack
using System;
 
namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int j;
 
            for (j = 1000; j > 0;)
            {
                Console.SetCursorPosition(30, 1);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Welcome. Press any key to start");
                Console.ReadLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Gray;
 
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"You have {j} points");
                Console.ResetColor();
                int bit = 0;
                do
                {
                    Console.WriteLine("Enter your bit");
                    bit = int.Parse(Console.ReadLine());
                }
                while (bit > j);
               
                Random rnd = new Random();
 
                int ruka = 0;
                int rukaB = 0;
 
 
 
                //You
 
 
                for (int i = 1; i == 1;)
                {
                    int karta = rnd.Next(2, 11);
 
                    if (karta == 11 & ruka > 11) // obrabotka tuza
                    {
                        ruka += 1;
 
                    }
                    else
                        ruka += karta;
 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your card: " + karta);
                    Console.ResetColor();
 
                    if (ruka > 21) // instant lose
                    {
                        Console.WriteLine("You have more than 21 points. \t");
                        i = 2;
                        break;
                    }
 
                    Console.WriteLine("Press 1 to continue, 2 to stop: \t");
                    i = int.Parse(Console.ReadLine());
                }
 
                Console.WriteLine("Your hand have: " + ruka + " points");
 
 
                if (ruka == 21) // instant win
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!! You win !!!");
                    Console.ResetColor();
 
                    Main(args);
                }
 
                if (ruka > 21)
                {
                    Console.WriteLine("You lost.");
                    Main(args);
                }
 
 
 
                //Bankir
 
                for (int i = 1; i == 1;)
                {
                    int karta = rnd.Next(2, 11);
                    rukaB += karta;
                    Console.WriteLine("Bankir got: " + rukaB + " points\n");
 
                    if (rukaB >= 18)
                    {
                        break;
                    }
                    
 
                }
                if (rukaB > 21)
                {
                    Console.WriteLine("Bankir lost");
                    j = j + bit * 2;
                }
 
 
 
                //Results
 
                if (ruka > rukaB)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ResetColor();
                    j = bit * 2;
                }
                if (ruka == rukaB)
                {
                    Console.WriteLine("No one won");
                }
                if (ruka < rukaB & rukaB <= 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bankir win!");
                    Console.ResetColor();
                    j = j - bit * 2;
                }
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
                Console.Clear();
                
            }
 
            if (j > 10000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congrats! You win the whole game!!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have lost all your money!!! :-(");
                Console.ResetColor();
            }
        }
    }
}
