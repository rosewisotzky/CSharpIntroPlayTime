﻿using System;
using System.Collections.Generic;

namespace CSharpIntroPlayTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Groceries or Guess A Number?");
            Console.WriteLine("A. Groceries");
            Console.WriteLine("B. Guess A Number");

            // Get text the user types into the console
            string response = Console.ReadLine();

            if (response == "A" || response == "a")
            {
                GroceryList();
            }
            else  // change this to only call GuessingGame() when the user enters option "B"
            {
                GuessingGame();
            }

            // If the user didn't input an "A" or "B" print a message 
            //  telling them they selected an invalid option
        }

        static void GroceryList()
        {
            string input;
            List<string> groceries = new List<string>();

            Console.WriteLine("Enter some groceries. (Enter a blank line when finished)");

            input = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(input))
            {
                groceries.Add(input);

                // Ask for the input again
            }

            Console.WriteLine();
            Console.WriteLine("Your grocery list:");
            foreach (string grocery in groceries)
            {
                // Write the grocery to the console
            }
        }

        static void GuessingGame()
        {
            // Get a random number between 1 and 20
            //  This is the number the user is trying to guess
            int answer = new Random().Next(1, 21);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Guess a number between 1 and 20: ");
                int guess = int.Parse(Console.ReadLine());

                // Add a conditional to determine if the user's guess is higher than the answer
                //  If so, print "Too High!" to the console

                // Add a conditional to determine if the user's guess is lower than the answer
                //  If so, print "Too Low!" to the console

                // When the user guesses correctly, tell them and return from the method
                Console.WriteLine("You got it!");
                return;
            }

            Console.WriteLine("Better luck next time...");
        }
    }
}