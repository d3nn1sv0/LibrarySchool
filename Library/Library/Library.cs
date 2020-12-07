using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {

        public string LibraryName { get; }
        public Loanee Loaner { get; private set; }

        public string GetLibrary()
        {
            return $"Welcome to {LibraryName} the date today is: {DateTime.Now.ToShortDateString()}";
        }

        public void CreateLoanee(int loaneeNumber, string loaneeName)
        {
            Loaner = new Loanee(loaneeNumber, loaneeName);
        }   

        public string GetLoanee()
        {
            return $"Loanee number: {Loaner.LoaneeNumber} Name: {Loaner.LoaneeName} Lended at: {LibraryName} ";
        }

        public Library(string name)
        {
            LibraryName = name;
        }
    }
}
