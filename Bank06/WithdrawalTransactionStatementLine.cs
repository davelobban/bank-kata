using System;

namespace Bank06
{
    public class WithdrawalTransactionStatementLine : TransactionStatementLine
    {
        private Transaction _transaction;
        public WithdrawalTransactionStatementLine(Transaction transaction)
        {
            _transaction = transaction;
        }

        public override string Text => $"{_transaction.Date.ToShortDateString()} || || {-_transaction.Amount}.00 || {_transaction.ClosingBalance}.00";
    }
}