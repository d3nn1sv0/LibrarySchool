using System;
using Xunit;
using Library;

namespace UnitTest_Lib
{
    public class UnitTest1
    {

        //Simple test to see if its printing the correct data
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
