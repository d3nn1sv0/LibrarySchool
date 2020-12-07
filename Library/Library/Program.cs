using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library("fml lib");

            Console.WriteLine(lib.GetLibrary());
        }
    }
}
