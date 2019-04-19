using System;

namespace Bank06
{
    public class Transaction
    {
        public int Amount { get; }
        public DateTime Date { get; }
        public int ClosingBalance { get; }
        internal Transaction(int amount, DateTime date, int newBalance)
        {
            Amount = amount;
            Date = date;
            ClosingBalance = newBalance;
        }
    }
}