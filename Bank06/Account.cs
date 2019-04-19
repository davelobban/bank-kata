using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bank06
{
    public class Account
    {
        IList<Transaction> _transactions = new List<Transaction>();
        private int _balance;

        public Account(int openingBalance)
        {
            _balance = openingBalance;
        }

        public int GetBalance()
        {
            //return _balance;
            return _transactions.Sum(t => t.Amount);
        }

        public void Deposit(int depositAmount, DateTime dateTime)
        {
            _transactions.Add(new Transaction(depositAmount, dateTime));
        }

        public void Withdraw(int amount, DateTime dateTime)
        {
            _transactions.Add(new Transaction(-amount, dateTime));
        }

        public IList<string> GetStatement()
        {
            var statementLines=new List<string> { "date || credit || debit || balance" };
            return statementLines;
        }

    }

    internal class Transaction
    {
        public int Amount { get; }
        public DateTime Date { get; }

        internal Transaction(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
