using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class IsInfiniteProcess
    {
        public static bool Approach1(int a, int b)
        {
            if (a > b)
                return true;
            else if (a == b)
                return false;
            else
            {
                if ((b - a) % 2 == 0)
                    return false;
                else
                    return true;
            }
        }
        public static bool Approach2(int a, int b)
        {
            if (a == b)
                return false;
            for (int start = a; start < b; start++)
            {
                a++;
                b--;
                if (a == b)
                    return false;
            }
            return true;

        }
    }
}
