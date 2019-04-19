using System;

namespace Bank06
{
    public class Transaction
    {
        public enum TransType
        {
            Deposit,
            Withdrawal
        }

        public TransType Type { get; }
        public int Amount { get; }
        public DateTime Date { get; }
        public int ClosingBalance { get; }
        internal Transaction(int amount, DateTime date, int newBalance)
        {
            Amount = amount;
            Date = date;
            ClosingBalance = newBalance;
            Type = amount > 0 ? TransType.Deposit : TransType.Withdrawal;
        }
    }
}