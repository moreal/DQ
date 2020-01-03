namespace DQ.Tokens
{
    public class Symbol : Token
    {
        public string Name { get; }

        public Symbol(string value)
        {
            Name = value;
        }
    }
}
