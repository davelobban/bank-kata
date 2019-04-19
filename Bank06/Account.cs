using System;
using System.Collections;
using System.Collections.Generic;

namespace Bank06
{
    public class Account
    {
        private int _balance;

        public Account(int openingBalance)
        {
            _balance = openingBalance;
        }

        public int GetBalance()
        {
            return _balance;
        }

        public void Deposit(int depositAmount, DateTime dateTime)
        {
            _balance += depositAmount;
        }

        public void Withdraw(int amount, DateTime dateTime)
        {
            _balance -= amount;
        }

        public IList<string> GetStatement()
        {
            return new List<string> { "date || credit || debit || balance" };
        }

    }
}
