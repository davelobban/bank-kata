using System;

namespace Bank06
{
    public class TransactionStatementLine : StatementLine
    {
        public TransactionStatementLine(Transaction transaction)
        {
            
        }

        public override string Text=> "14/01/2012 || || 500.00 || 2500.00";
    }
}