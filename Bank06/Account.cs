using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bank06
{
    public class Account
    {
        readonly IList<Transaction> _transactions = new List<Transaction>();

        public int GetBalance()
        {
            return _transactions.LastOrDefault()?.ClosingBalance ?? 0;
        }

        public void Deposit(int depositAmount, DateTime dateTime)
        {
            var balance = GetBalance();
            _transactions.Add(TransactionFactory.Get(depositAmount, dateTime, balance));
        }

        public void Withdraw(int amount, DateTime dateTime)
        {
            var balance = GetBalance();
            _transactions.Add(TransactionFactory.Get(-amount, dateTime, balance));
        }
        public IList<StatementLine> GetStatement()
        {
            var transactions = _transactions;
            return Statement.GetStatement(transactions);
        }
    }
}
