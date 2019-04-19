using System.Collections.Generic;
using System.Linq;

namespace Bank06
{
    public class Statement
    {
        public static IList<StatementLine> GetStatement(IList<Transaction> transactions)
        {
            var statementLines = new List<StatementLine> {new StatementLineHeader("date || credit || debit || balance")};
            foreach (var transaction in transactions.OrderByDescending(t => t.Date))
            {
                statementLines.Add(TransactionStatementLineFactory.GetLine(transaction));
            }

            return statementLines;
        }
    }
}