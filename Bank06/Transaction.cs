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

        public abstract TransType Type { get; }
        public int Amount => _ledgerPosting.Amount;
        public DateTime Date => _ledgerPosting.Date;
        public abstract int ClosingBalance { get; }
        private readonly LedgerPosting _ledgerPosting;
        internal Transaction(int amount, DateTime date)
        {
            _ledgerPosting = new LedgerPosting(amount, date);
        }
    }
}