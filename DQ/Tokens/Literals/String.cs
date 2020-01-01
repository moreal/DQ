namespace DQ.Tokens.Literals
{
    public sealed class String : Literal
    {
        public string Value { get; }

        public String(string value)
        {
            Value = value;
        }
    }
}
