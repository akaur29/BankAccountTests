using System;

namespace UnitTestProject1
{
    internal class BankAccount
    {
        private string v;
        private double beginningBalance;

        public BankAccount(string v, double beginningBalance)
        {
            this.v = v;
            this.beginningBalance = beginningBalance;
        }

        internal void Debit(double debitAmount)
        {
            throw new NotImplementedException();
        }
    }
}