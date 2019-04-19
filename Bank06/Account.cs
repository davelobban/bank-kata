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

        public IList<StatementLine> GetStatement()
        {
            var statementLines=new List<StatementLine> { new StatementLineHeader( "date || credit || debit || balance") };
            foreach (var transaction in _transactions)
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
