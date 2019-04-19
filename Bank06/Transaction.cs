using System;

namespace Bank06
{
    public abstract class Transaction
    {
        public enum TransType
        {
            Deposit,
            Withdrawal
        }

        public TransType Type { get; }
        public int Amount => _ledgerPosting.Amount;
        public DateTime Date => _ledgerPosting.Date;
        public int ClosingBalance { get; }
        private readonly LedgerPosting _ledgerPosting;
        internal Transaction(int amount, DateTime date, int newBalance)
        {
            _ledgerPosting = new LedgerPosting(amount, date);
            ClosingBalance = newBalance;
            Type = amount > 0 ? TransType.Deposit : TransType.Withdrawal;
        }
    }
}