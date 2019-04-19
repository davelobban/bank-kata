using System;

namespace Bank06
{
    public class WithdrawalTransaction: Transaction
    {
        private readonly int _closingBalance;
        public override TransType Type => TransType.Withdrawal;

        public override int ClosingBalance => _closingBalance;

        internal WithdrawalTransaction(int amount, DateTime date, int balancePriorToPosting): base(amount, date)
        {
            _closingBalance = balancePriorToPosting - amount;
        }
    }
}