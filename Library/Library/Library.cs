using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Library
    {

        public string LibraryName { get; }
        public List<Loanee> LoanerList { get; }

        /// <summary>
        /// Method that will create a string to show Lib name and current date
        /// </summary>
        /// <return>Returns a string with datetime</return>
        public string GetLibrary()
        {
            return $"Welcome to {LibraryName} the date today is: {DateTime.Now.ToShortDateString()}";
        }

        ///<summary>
        ///Method to create a loanee.
        ///Main menu will direct to this method and ask for user input to create and add to collection
        ///</summary>
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

        ///<summary>
        ///Method that creates the string format for display
        ///</summary>
        ///<return>Returns a string that makes a preset for how loanee data should be printed</return>
        public string GetLoanee(int id)
        {
            Loanee l = LoanerList.Find(item => item.LoaneeNumber == id);
            return $"Loanee number: {l.LoaneeNumber} | Name: {l.LoaneeName} | Email: {l.LoaneeEmail} | Lended at: {LibraryName}\n ";
        }

        ///<summary>
        ///Method that prints the loanee collection to console
        ///</summary>
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
