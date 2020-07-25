﻿using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Tal Gætter";
            string appVersion = "1.0.0";
            string appAuthor = "Kasper Rosenkrands";

            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine("{0}: Version {1} af {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("Hvad er dit navn?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hej {0}, lad os spille et spil!", inputName);

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Gæt på et tal mellem 1 og 10");

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    //guess = Int32.Parse(input);

                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Yellow, "Det tal kender jeg ikke, prøv et andet");

                        //Console.ForegroundColor = ConsoleColor.Yellow;

                        //Console.WriteLine("Det tal kender jeg ikke, prøv et andet");

                        //Console.ResetColor();

                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Det var ikke det tal jeg tænkte på, prøv igen");
                        //Console.ForegroundColor = ConsoleColor.Red;

                        //Console.WriteLine("Det var ikke det tal jeg tænkte på, prøv igen");

                        //Console.ResetColor();
                    }
                }

                PrintColorMessage(ConsoleColor.Cyan, "Du gættede rigtigt!");

                //Console.ForegroundColor = ConsoleColor.Cyan;

                //Console.WriteLine("Du gættede rigtigt!");

                //Console.ResetColor();

                Console.WriteLine("Vil du spille en gang mere? [J eller N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "J"){

                    continue;

                } else if(answer == "N") {
                    
                    return;
                
                } else {
                    
                    return;
                
                }
            }
        }

        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}