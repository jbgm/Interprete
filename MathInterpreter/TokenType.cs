using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInterpreter
{
    public enum TokenType
    {
        Number,
        Id,
        Plus,
        Multiplication,
        If,
        ElseIF,
        Else,
        Equal,
        PharentesisStart,
        PharentesisEnd,
        GreaterThan, 
        SmallerThan,
        GreaterThanOrEqualTo,
        SmallerThanOrEqualTo,
        And,
        Or,
        Xor
    }
}
