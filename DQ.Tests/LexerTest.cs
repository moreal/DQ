using System;
using System.Linq;
using DQ;
using DQ.Tokens;
using DQ.Tokens.Operators;
using Xunit;
using String = DQ.Tokens.Literals.String;

namespace DQ.Tests
{
    public class LexerTest
    {
        [Fact]
        public void Tokenize()
        {
            var code = ".symbol.'string' = \"string\"";
            var tokens = Lexer.Tokenize(code).ToArray();
            var expected = new Token[]
            {
                new Dot(), new Symbol("symbol"), new Dot(), new String("string"), new Equal(),
                new String("string")
            };
            foreach (var (a, b) in tokens.Zip(expected, ValueTuple.Create))
            {
                Assert.Equal(a, b);
            }
            Assert.Equal(expected, tokens);
        }
    }
}
