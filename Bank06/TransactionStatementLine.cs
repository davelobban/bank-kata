using System;

namespace Bank06
{
    public class TransactionStatementLine : StatementLine
    {
        private Transaction _transaction;
        public TransactionStatementLine(Transaction transaction)
        {
            _transaction = transaction;
        }

        public override string Text
        {
            get
            {
                if (_transaction.Amount > 0)
                {
                    return
                        $"{_transaction.Date.ToShortDateString()} || {_transaction.Amount}.00 || || {_transaction.ClosingBalance}.00";
                }
                return
                    $"{_transaction.Date.ToShortDateString()} || || {-_transaction.Amount}.00 || {_transaction.ClosingBalance}.00";
            }
        }
    }
}