using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class ReachNextLevel
    {
        public static bool Approach1(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }

    }
}
