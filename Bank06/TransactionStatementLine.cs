using System;

namespace Bank06
{
    public abstract class TransactionStatementLine : StatementLine
    {
        public  abstract override string Text { get; }
    }
}