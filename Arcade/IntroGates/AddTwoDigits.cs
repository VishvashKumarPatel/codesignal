using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class AddTwoDigits
    {
        public static int Approach1(int n)
        {
            return n.ToString().Sum(x => int.Parse(x.ToString()));
        }
        public static int Approach2(int n)
        {
            return int.Parse(n.ToString()[0].ToString()) + int.Parse(n.ToString()[1].ToString());
        }
    }
}
