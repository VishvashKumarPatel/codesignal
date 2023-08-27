using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class KnapsackLight
    {
        public static int Approach1(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
                return value1 + value2;
            else if (weight1 <= maxW && weight2 <= maxW)
                return Math.Max(value1, value2);
            else if (weight1 <= maxW)
                return value1;
            else if (weight2 <= maxW)
                return value2;
            else
                return 0;
        }
        public static  int Approach2(int value1, int weight1, int value2, int weight2, int maxW)
        {
            var avg1 = value1 / weight1;
            var avg2 = value2 / weight2;

            if (maxW < weight1 && maxW < weight2)
                return 0;
            else if (maxW >= (weight1 + weight2))
                return value1 + value2;
            else
            {
                if (avg1 > avg2)
                    return value1;
                else
                    return value2;
            }
        }
    }
}
