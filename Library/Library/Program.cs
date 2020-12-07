using System;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library("fml lib");
            lib.CreateLoanee(1, "Johnny");

            Console.WriteLine(lib.GetLibrary());

            Console.WriteLine(lib.GetLoanee());
        }
    }
}
