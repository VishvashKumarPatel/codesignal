using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class ArithmeticExpression
    {
        public static bool Approach1(int a, int b, int c)
        {
            if (a + b == c)
                return true;
            else if (a - b == c)
                return true;
            else if (a * b == c)
                return true;
            else if (a / b == c)
                return true;
            else
                return false;
        }
        public static bool Approach2(int a, int b, int c)
        {
            if (Result(a, b, Operator.Add) == c)
                return true;
            else if (Result(a, b, Operator.Subtract) == c)
                return true;
            else if (Result(a, b, Operator.Multiply) == c)
                return true;
            else if (Result(a, b, Operator.Divide) == c)
                return true;
            else
                return false;
        }
        enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        private static dynamic Result(int a,int b, Operator @operator)
        {
            
            switch (@operator)
            {
                case Operator.Add:
                    return a + b;
                case Operator.Subtract:
                    return a - b;
                case Operator.Multiply:
                    return a * b;
                case Operator.Divide:
                    return (decimal) a / b;
            }
            return 0;
        }

    }
}
