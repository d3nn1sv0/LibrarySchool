    using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Loanee
    {
        public readonly int LoaneeNumber;
        public readonly string LoaneeName;

        public Loanee(int number, string name)
        {
            LoaneeNumber = number;
            LoaneeName = name;
        }

    }
}
