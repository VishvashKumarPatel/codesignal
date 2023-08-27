using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class Candies
    {
        public static int Approach1(int n, int m)
        {
            return m - m % n;
        }
    }
}
