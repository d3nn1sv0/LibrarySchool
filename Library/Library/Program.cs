using System;

namespace Library
{
    public class Program
    {

        static string menuChoice;
        static Library lib = new Library("fml lib");

        static void Main(string[] args)
        {

            while (menuChoice != "4")
            {
                Console.Clear();
                PrintMenu();
            }

        }


        ///<summary>
        ///Method to create a simple menu to navigate the program
        ///</summary>
        ///<return>return the user input</return>
        static string PrintMenu()
        {

            Console.Write("Select from the menu below:\n\n1. Show library name and current date\n2. Create new Loaner\n3. Print all Loaners\n4. Exit\n\nSelect: ");
            menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(lib.GetLibrary());

                    Console.WriteLine("\nPress enter to return to the main munu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    lib.CreateLoanee();
                    break;
                case "3":
                    Console.Clear();
                    lib.GetAllLoanees();

                    Console.WriteLine("\nPress enter to return to the main munu.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError! Try again!");
                    Console.ResetColor();
                    Console.WriteLine("\nPress [ENTER] ");
                    Console.ReadLine();
                    break;
            }
            return menuChoice;
        }
    }
}
