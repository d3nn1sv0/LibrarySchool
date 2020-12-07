using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
    {

        public string LibraryName { get; }

        public string GetLibrary()
        {
            return $"Welcome to {LibraryName} the date today is: {DateTime.Now.ToShortDateString()}";
        }

        public Library(string name)
        {
            LibraryName = name;
        }
    }
}
