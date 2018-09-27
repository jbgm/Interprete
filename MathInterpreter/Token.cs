using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInterpreter
{
    public class Token
    {
        public Token(int index, string content, TokenType type)
        {
            this.Index = index;
            this.Content = content;
            this.Type = type;
        }

        public int Index { get; }
        public string Content { get; }
        public TokenType Type { get; }
    }
}
