using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class ExtraNumber
    {
        public static int Approach1(int a, int b, int c)
        {
            if (a == b)
                return c;
            else if (a == c)
                return b;
            else
                return a;
        }
    }
}
