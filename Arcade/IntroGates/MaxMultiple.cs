using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class MaxMultiple
    {
        public static int Approach1(int divisor, int bound)
        {
            return bound - bound % divisor;
        }
        public static int Approach2(int divisor, int bound)
        {
            return (bound / divisor) * divisor;
        }
    }
}
