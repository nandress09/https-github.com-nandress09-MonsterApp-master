using System;
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
                DisplayHeader("This is the invader hub, welcome");
                Console.WriteLine();
                Console.WriteLine("1)Check out my Monsters");
                Console.WriteLine("2)Exit");
                Console.WriteLine("\nEnter Choice");
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
                Console.WriteLine("2)Check out my Spacemonster");
                Console.WriteLine("3)Exit");
                Console.WriteLine("\nEnter Choice");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        DisplaySeamonster();
                        break;
                    case 2:
                        MonsterBattle();
                        break;
                    case 3:
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
            DisplayHeader("My Sea Monster");
            Seamonster mon = InitializeSeaMonster();
            Console.WriteLine("Name: " + mon.Name);
            Console.WriteLine("Age: " + mon.Age);
            Console.WriteLine("Evil or good: " + mon.IsEvil);
            Console.WriteLine("Has Gills: " + mon.HasGills);
            Console.WriteLine("Is monster active: " + mon.IsActive);
            Console.WriteLine("Name of sea: " + mon.SeaName);
            DisplayContinuePrompt();
        }
        
        static void MonsterBattle()
        {
            DisplayHeader("Monster Battle");
            SpaceMonster mon = InitializeSpaceMonster();
            {
                Console.WriteLine("Monster ID: " + mon.ID);
                Console.WriteLine("Name: " + mon.Name);
                Console.WriteLine("Age: " + mon.Age);
                Console.WriteLine("Is monster active: " + mon.IsActive);
                Console.WriteLine("Monster has a ship?: " + mon.HasSpaceship);
                DisplayContinuePrompt();

            };
            switch (mon.MonsterBattleResponse())
            {
                case Monster.MonsterAction.Attack:
                    Console.WriteLine(mon.Name + " attacked you!");
                    break;
                case Monster.MonsterAction.Defend:
                    Console.WriteLine(mon.Name + " is blocking!");
                    break;
                case Monster.MonsterAction.Retreat:
                    Console.WriteLine(mon.Name + " is running away!");
                    break;
                default:
                    break;
            }

            DisplayContinuePrompt();
        }

        static void DisplayHeader(string s)
        {
            Console.Clear();
            Console.WriteLine(s);
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my Monster App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.Write("\nPress any key to continue");
            Console.ReadKey();

        }
    }
}