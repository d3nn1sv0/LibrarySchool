    using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Loanee : Person
    {
        public readonly int LoaneeNumber;

        public Loanee(int number, string name, string email)
        {
            LoaneeNumber = number;
            LoaneeName = name;
            LoaneeEmail = email;
        }

    }
}
