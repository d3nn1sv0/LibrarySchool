using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {

        public string LibraryName { get; }
        //public Loanee Loaner { get; private set; }
        public List<Loanee> LoanerList { get; }

        public string GetLibrary()
        {
            return $"Welcome to {LibraryName} the date today is: {DateTime.Now.ToShortDateString()}";
        }

        public void CreateLoanee(int loaneeNumber, string loaneeName)
        {
            LoanerList.Add(new Loanee(loaneeNumber, loaneeName));
        }   

        public string GetLoanee(int id)
        {
            Loanee l = LoanerList.Find(item => item.LoaneeNumber == id);
            return $"Loanee number: {l.LoaneeNumber} Name: {l.LoaneeName} Lended at: {LibraryName} ";
        }

        public void GetAllLoanees()
        {
            foreach (Loanee loanee in LoanerList)
            {
                Console.WriteLine(GetLoanee(loanee.LoaneeNumber));
            }
        }

        public Library(string name)
        {
            LibraryName = name;

            LoanerList = new List<Loanee>();
        }
    }
}
