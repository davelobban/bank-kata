using System;

namespace Bank06
{
    public class DepositTransaction : Transaction
    {
        public TransType Type => TransType.Deposit;
        internal DepositTransaction(int amount, DateTime date, int newBalance) : base(amount, date, newBalance)
        {
        }
    }
}