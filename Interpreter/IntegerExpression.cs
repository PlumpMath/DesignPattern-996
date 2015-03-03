using System;
using System.Collections.Generic;
using System.Linq;

namespace Interpreter
{
    public class IntegerExpression : ExpressionBase
    {
        int _value;

        public IntegerExpression(int value)
        {
            _value = value;
        }

        public override int Evaluate()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
