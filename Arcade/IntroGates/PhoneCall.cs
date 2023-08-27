using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class PhoneCall
    {
        public static int Approach1(int min1, int min2_10, int min11, int s)
        {
            int minutes = 0;
            if (s >= min1)
            {
                minutes++;
                s -= min1;
            }
            while (s >= min2_10 && minutes < 10)
            {
                minutes++;
                s -= min2_10;
            }
            if (s >= min11 && minutes == 10)
            {
                minutes += s / min11;
            }
            return minutes;
        }

        public static int Approach2(int min1, int min2_10, int min11, int s)
        {
            var minutes = 0;

            if (s == 0)
                return minutes;

            if (s == min1)
                return 1;

            var after_min1 = s - min1;

            if (after_min1 < 0)
                return minutes;

            Console.WriteLine($" after_min1 : {after_min1}");


            Console.WriteLine($" (9 * min2_10) : {(9 * min2_10)} , ");

            if ((9 * min2_10) > after_min1)
            {
                Console.WriteLine($" after_min1 : {after_min1} / min2_10 {min2_10}");
                var min2_10_calc = after_min1 / min2_10;
                return 1 + min2_10_calc;
            }

            var from_2_to_10 = (9 * min2_10);
            Console.WriteLine($" from_2_to_10 : {from_2_to_10}");


            var after_2_to_10 = after_min1 - from_2_to_10;
            Console.WriteLine($" after_2_to_10 : {after_2_to_10}");
            if (after_min1 < 0)
                return minutes + 9;

            var from_min11 = after_2_to_10 / min11;

            return 1 + 9 + from_min11;
        }
    }
}
