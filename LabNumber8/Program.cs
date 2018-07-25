﻿using System;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will recognize invalid inputs when the user requests information about students in a class

            string[] students = { "A'Keem Drew", "Terrell White", "Bijaya Acharya", "Christopher Schwarts", "Christopher Singleton", "DeMarko Cross", "Kristen Rieske", "Patrick Turner", "Terrie Thorpe", "Zachary Theodore", "Jesse Ashton", "William Twomey", "William Chapman", "Samantha Mazzola" };

            string[] hometowns = { "Detroit, MI (The Trap to be specific)", "Heaven", "Ohio", "Tokyo", "Las Vegas", "New York", "Antartica", "The Islands", "The Boonies", "here everybody knows your name", "Southfield", "The Green Zone", "The Red Zone", "The Twilight Zone" };

            string[] favoriteFoods = { "Lasagna", "Chicken", "Pig-Feet", "Moose-Knuckles", "Ice Cream", "Brains", "Texas de Brazil", "Lint", "Dust Bunnies", "Pizza", "Steak", "Spaghetti", "Salmon", "Boogers" };

            //***INPUT***

            Console.WriteLine("Welcome to our c# class." + "\n");

            //***PROCESSING***
            bool repeat1 = true;
            while (repeat1)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + students[i]); //Prints students Array
                }

                Console.Write("\n" + "Which student would you like to learn more about? (enter a number 1 - 20): ");
                int userInput = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine($"\nStudent {userInput} is {students[userInput - 1]}. What would you like to know about {students[userInput - 1]}? (enter or \"hometown\" or \"favorite food\")");
                string userSelection = Console.ReadLine().ToLower();


                if (userSelection == "hometown")
                {
                    Console.Write($"\n{students[userInput - 1]} is from {hometowns[userInput - 1]}. Would you like to know more (enter \"yes\" or \"no\")?\n");
                    string continueResponse = Console.ReadLine();

                    if (continueResponse == "yes")
                    {
                        repeat1 = true;
                    }
                    else if (continueResponse == "no")
                    {
                        Console.WriteLine("Thanks!");
                        repeat1 = false;
                    }

                }
                else if (userSelection == "favorite food")
                {
                    Console.WriteLine($"\n{students[userInput - 1]}'s favorite food is: {favoriteFoods[userInput - 1]}. Would you like to know more? (enter \"yes\" or \"no\")\n ");
                    string continueResponse = Console.ReadLine();

                    if (continueResponse == "yes")
                    {
                        repeat1 = true;
                    }
                    else if (continueResponse == "no")
                    {
                        Console.WriteLine("Thanks!");
                        repeat1 = false;
                    }
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again...\n");
                }







            }















        }
    }
}
