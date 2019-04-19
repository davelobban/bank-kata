using System;

namespace Bank06
{
    public class WithdrawalTransaction: Transaction
    {
        public TransType Type => TransType.Withdrawal;
        internal WithdrawalTransaction(int amount, DateTime date, int newBalance): base(amount, date, newBalance)
        {
        }
    }
}