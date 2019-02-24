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
                SeaName = "Hisbishu Sea"

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

        }

        static void DisplayMenu()
        {
            bool exitMenu = false;


            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("1)Display Monsters");
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

        static void DisplayHeader(string v)
        {
            throw new NotImplementedException();
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Welsometo my Monster App");
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