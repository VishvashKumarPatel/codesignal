using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class LateRide
    {
        public static int Approach1(int n)
        {
            return (n / 60) / 10 + (n / 60) % 10 + (n % 60) / 10 + (n % 60) % 10;
        }
        public static int Approach2(int n)
        {

            var hours = n / 60;

            var minutes = n % 60;

            return hours.ToString().Sum(x => int.Parse(x.ToString())) + minutes.ToString().Sum(x => int.Parse(x.ToString()));
        }
    }
}
