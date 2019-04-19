namespace Bank06
{
    internal class StatementLineHeader : StatementLine
    {
        public override string Text { get; }

        public StatementLineHeader(string value)
        {
            Text = value;
        }
    }
}