﻿
using System;
////// NAME SONIA MANHAS(C0726358)
/// NAME AMANDEEP KAUR(C0730499)

namespace BankAccount
{
    class Program
    {

    }
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;
        private bool m_frozen = false;
        private BankAccount()
        {
        }
        public BankAccount(String customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;

        }
        public string CustomerName
        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public string DebitAmountExceedsBalanceMessage { get; private set; }
        public string DebitAmountLessThanZeroMessage { get; private set; }

        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount",amount,DebitAmountExceedsBalanceMessage);
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount",amount,DebitAmountLessThanZeroMessage);
            }
            m_balance += amount;
        }
        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance -= amount;
        }



        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is $ {0}", ba.Balance);
        }
    }

}