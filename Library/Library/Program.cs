using System;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library("fml lib");
            lib.CreateLoanee(1, "Johnny");
            lib.CreateLoanee(2, "Mads");
            lib.CreateLoanee(3, "Thorsten");

            Console.WriteLine(lib.GetLibrary());

            lib.GetAllLoanees();
        }
    }
}
