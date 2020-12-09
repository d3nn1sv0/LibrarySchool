using System;
using Xunit;
using Library;

namespace UnitTest_Lib
{
    public class UnitTest1
    {
        [Fact]
        public void GetLoaneeTest()
        {

            Library.Library testLib = new Library.Library("Test Lib");

            testLib.LoanerList.Add(new Loanee(1, "Johnny", "johnny@lux.dk"));

            string result = testLib.GetLoanee(1);

            Assert.Contains("Johnny", result);
        }
    }
}
