﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
    class Program
    {
       

        static void Main(string[] args)
        {
            // the order of which the program will execute
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayCloseingScreen();

        }

        static Seamonster InitializeSeaMonster()
        {
            return new Seamonster()
            {
                ID = 357,
                Name = "Jerry",
                Age = 475,
                HasGills = true,
                IsActive = true,
                SeaName = "Hisbishu Sea",
                IsEvil = true

            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                ID = 37,
                Name = "Mary",
                Age = 800,
                IsActive = true,
                HasSpaceship = false

            };
        }

        static void DisplayCloseingScreen()
        {
            Console.Clear();
            Console.WriteLine("Press any key to exit the Monster APP!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void DisplayMenu()
        {
            bool exitMenu = false;


            do
            {
                DisplayHeader("Menu");
                Console.WriteLine();
                Console.WriteLine("1)Check out my Monsters");
                Console.WriteLine("2)Exit");
                Console.WriteLine("Enter Choice");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1: DisplayMonsters();
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Pleae enter a valid choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!exitMenu);

        }
        static void DisplayMonsters()
        {
            bool exitMenu = false;
            
            do
            {
                DisplayHeader("Menu");
                Console.WriteLine();
                Console.WriteLine("1)Check out my Seamonster");
                Console.WriteLine("1)Check out my Spacemonster");
                Console.WriteLine("2)Exit");
                Console.WriteLine("Enter Choice");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    default:
                        Console.WriteLine("Pleae enter a valid choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!exitMenu);

        }
        static void DisplaySeamonster()
        {
            Seamonster = new Seamonster();
        }

        static void DisplayHeader(string v)
        {
            Console.Clear();
            Console.WriteLine("This is the invader hub, welcome");
            DisplayContinuePrompt();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Monster App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.Clear();
            Console.Write("Press any key to continue");
            Console.ReadKey();

        }
    }
}