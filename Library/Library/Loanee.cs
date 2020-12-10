    using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{

    ///<summary>
    ///This class inherits from Person class
    ///</summary>
    public class Loanee : Person
    {
        public readonly int LoaneeNumber;

        ///<summary>
        ///Constructor for loanee data
        ///</summary>
        public Loanee(int number, string name, string email)
        {
            LoaneeNumber = number;
            LoaneeName = name;
            LoaneeEmail = email;
        }

    }
}
