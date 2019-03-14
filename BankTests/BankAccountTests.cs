using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        public BankAccountTests(string v, double beginningBalance)
        {

        }

        public double DebitBalance { get; private set; }

        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance(double debitAmount)
        {
            double beginningBalance = 11.99;

            double expected = 7.44;
            BankAccountTests account = new BankAccountTests("Mr. Bryan Walton", beginningBalance);
            //Act
            account.Debit_WithValidAmount_UpdatesBalance(debitAmount);

            //Assert
            double actual = account.DebitBalance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
