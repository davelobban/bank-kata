using System;

namespace Bank06
{
    public class TransactionFactory
    {
        public static Transaction Get(int amount, DateTime dateTime, int newBalance)
        {
            if (amount > 0)
            {
                return new DepositTransaction(amount, dateTime, newBalance);
            }

            return new WithdrawalTransaction(amount, dateTime, newBalance);
        }
    }
}