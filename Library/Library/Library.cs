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

        public void CreateLoanee()
        {
            Console.Clear();
            int result = 0;
            do
            {
                Console.Write("Insert Loanee ID: ");
                
            } while (! int.TryParse(Console.ReadLine(), out result));

            Console.Write("Insert Loanee First name: ");
            string loaneeName = Console.ReadLine();

            Console.Write("Insert Loanee email address: ");
            string loaneeEmail = Console.ReadLine();

            LoanerList.Add(new Loanee(result, loaneeName, loaneeEmail));
            Console.Clear();
        }   

        public string GetLoanee(int id)
        {
            Loanee l = LoanerList.Find(item => item.LoaneeNumber == id);
            return $"Loanee number: {l.LoaneeNumber} | Name: {l.LoaneeName} | Email: {l.LoaneeEmail} | Lended at: {LibraryName}\n ";
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
