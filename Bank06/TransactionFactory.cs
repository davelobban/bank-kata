using System;

namespace Bank06
{
    public class TransactionFactory
    {
        public static Transaction Get(int amount, DateTime dateTime, int balancePriorToPosting)
        {
            if (amount > 0)
            {
                return new DepositTransaction(amount, dateTime, balancePriorToPosting);
            }

            return new WithdrawalTransaction(Math.Abs(amount), dateTime, balancePriorToPosting);
        }
    }
}