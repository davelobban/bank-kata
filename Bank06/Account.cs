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
                statementLines.Add(GetLine(transaction));
            }
            return statementLines;
        }
        //TransactionStatementLineFactory
        public static TransactionStatementLine GetLine(Transaction transaction)
        {
            switch (transaction.Type)
            {
                case Transaction.TransType.Deposit:
                    return new DepositTransactionStatementLine(transaction);
                case Transaction.TransType.Withdrawal:
                    return new WithdrawalTransactionStatementLine(transaction);
                default:
                    throw new NotSupportedException("Unknown transaction type");
            }

            
        }
    }
}
