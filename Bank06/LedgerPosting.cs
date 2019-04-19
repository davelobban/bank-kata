using System;

namespace Bank06
{
    public class LedgerPosting
    {
        public LedgerPosting(int amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }

        public int Amount { get; }
        public DateTime Date { get; }
    }
}