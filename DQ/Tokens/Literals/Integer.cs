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
    }
}