using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using DQ.Tokens;
using DQ.Tokens.Literals;
using DQ.Tokens.Operators;
using String = DQ.Tokens.Literals.String;

namespace DQ
{
    public class Lexer
    {
        public static IEnumerable<Token> Tokenize(string code)
        {
            int startIndex, endIndex;
            for (int i = 0; i < code.Length; ++i)
            {
                switch (code[i])
                {
                    case '.':
                        yield return new Dot();
                        continue;
                    case '\'':
                    case '"':
                        startIndex = i + 1;
                        endIndex = code.IndexOf(code[i], startIndex) - 1;
                        yield return new String(code.Substring(startIndex, endIndex - startIndex + 1));
                        i = endIndex + 1;
                        continue;
                    case '[':
                        yield return new OpenSquareBracket();
                        continue;
                    case ']':
                        yield return new CloseSquareBracket();
                        continue;
                    case '(':
                        yield return new OpenParentheses();
                        continue;
                    case ')':
                        yield return new CloseParentheses();
                        continue;
                    case '+':
                        yield return new Add();
                        continue;
                    case '-':
                        yield return new Subtract();
                        continue;
                    case '/':
                        yield return new Divide();
                        continue;
                    case '*':
                        yield return new Multiply();
                        continue;
                    case '=':
                        yield return new Equal();
                        continue;
                    case '%':
                        yield return new Modular();
                        continue;
                }

                if (" \n\t".Contains(code[i]))
                {
                    continue;;
                }

                startIndex = i;
                while (!" \n\t.'\"+-=*/%".Contains(code[i + 1]))
                {
                    ++i;
                }

                endIndex = i;
                var value = code.Substring(startIndex, endIndex - startIndex + 1);

                if (BigInteger.TryParse(value, out BigInteger result))
                {
                    yield return new Integer(result);
                }
                else
                {
                    yield return new Symbol(value);
                }
            }
        }
    }
}
