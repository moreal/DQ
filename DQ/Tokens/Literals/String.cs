namespace DQ.Tokens.Literals
{
    public sealed class String : Literal
    {
        public string Value { get; }

        public String(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && Value == (obj as String).Value;
        }
    }
}
