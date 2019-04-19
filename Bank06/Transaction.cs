using System;

namespace Bank06
{
    public class Transaction
    {
        public int Amount { get; }
        public DateTime Date { get; }

        internal Transaction(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}