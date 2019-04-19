using System;

namespace Bank06
{
    public class TransactionStatementLineFactory
    {
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