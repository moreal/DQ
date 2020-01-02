using System.Numerics;

namespace DQ.Tokens.Literals
{
    public sealed class Integer : Literal
    {
        public BigInteger Value { get; }

        public Integer(BigInteger value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && Value == (obj as Integer).Value;
        }
    }
}