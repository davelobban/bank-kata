using System;

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
    }
}
