﻿using System;

namespace BlackJack
{
    
    class Program
    {
        static int BankirHit(int rukaB)
        {
            for (int i = 1; i == 1;)
            {
                Random rnd = new Random();

                int karta = rnd.Next(2, 11);
                rukaB += karta;
                Console.WriteLine("Bankir got: " + rukaB + " points\n");

                if (rukaB >= 17)
                {
                    break;
                }
            }
            return rukaB;
        }

        static int GetCard(int ruka)
        {
            int bit = 0;
            int j = 0;
            Random rnd = new Random();

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
                if (ruka > 21)
                {
                    break;
                }
                Console.WriteLine("Press 1 to continue, 2 to stop: \t");
                i = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine("Your hand have: " + ruka + " points");
            return ruka;


            
        }
        static void Main(string[] args)
        { 
            int j = 1000;
            
                
                int ruka = 0;
                int rukaB = 0;
                int bit = 0;
            do
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



                ruka = 0;
                rukaB = 0;
                bit = 0;

                do
                {
                    Console.WriteLine("Enter your bit");
                    bit = int.Parse(Console.ReadLine());
                }
                while (bit > j);

                Random rnd = new Random();





                //You


                ruka = GetCard(ruka);

                if (ruka == 21) // instant win
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("!!! You win !!!");
                    Console.ResetColor();

                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    j = j + bit * 2;
                    continue;
                }

                if (ruka > 21)
                {
                    Console.WriteLine("You lost.");
                    j = j - bit * 2;

                    Console.WriteLine("\nPress enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                //Bankir
                rukaB = BankirHit(rukaB);
                if (rukaB > 21)
                {
                    Console.WriteLine("Bankir lost");
                    j = j + bit * 2;
                    continue;
                }



                //Results

                if (ruka > rukaB & ruka <= 21)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ResetColor();
                    j = j + bit * 2;
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
            while (j > 0);

                if (j > 10000)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congrats! You win the whole game!!!!");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have lost all your money!!! :-(");
                    Console.ReadLine();
                }
        }
    }
}