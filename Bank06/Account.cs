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
            var newBalance = balance + depositAmount;
            _transactions.Add(new Transaction(depositAmount, dateTime, newBalance));
        }

        public void Withdraw(int amount, DateTime dateTime)
        {
            var balance = GetBalance();
            var newBalance = balance - amount;
            _transactions.Add(new Transaction(-amount, dateTime, newBalance));
        }

        public IList<StatementLine> GetStatement()
        {
            var statementLines=new List<StatementLine> { new StatementLineHeader( "date || credit || debit || balance") };
            foreach (var transaction in _transactions.OrderByDescending(t=>t.Date))
            {
                statementLines.Add(new TransactionStatementLine(transaction));
            }
            return statementLines;
        }

    }

    //internal class Statement
    //{
    //    internal class Statement(IList<Transaction> transactions )
    //    {
    //    }

    //    internal List<StatementLine> Lines { }
    //}
}
