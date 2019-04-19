using System;

namespace Bank06
{
    public class DepositTransaction : Transaction
    {
        private int _closingBalance;
        public override TransType Type => TransType.Deposit;
        public override int ClosingBalance => _closingBalance;
        internal DepositTransaction(int amount, DateTime date, int balancePriorToPosting) : base(amount, date)
        {
            _closingBalance = balancePriorToPosting + amount;
        }
    }
}