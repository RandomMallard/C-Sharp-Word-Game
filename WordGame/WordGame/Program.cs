using System;
using System.Diagnostics;
using System.ComponentModel;

namespace WordGame
{
    class Process
    {
        static void Main(string[] args)
        {
            int Game = 0;


            Console.WriteLine("Welcome to the word game!");
            Console.WriteLine("This is essentially hangman but I'm not gonna call it that because there is probably a copyright or trademark on it somewhere.");
            Console.WriteLine("Please make a choice to proceed:");
            Console.WriteLine("[0] Quit the game            [1]  Play the game          [2] Another option");
            Console.WriteLine("Please choose here:");
            Game = Convert.ToInt32(Console.ReadLine());


            if (Game == 0)
            {
                Console.WriteLine("Goodbye");
            }
            else if (Game == 2)
            {
                Console.WriteLine("This would have been a rickroll but it didn't work");
            }
        }

    }
}