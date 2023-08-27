using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class CircleofNumbers
    {
        public static int Approach1(int n, int firstNumber)
        {
            return (firstNumber + n / 2) % n;
        }

        public static int Approach2(int n, int firstNumber)
        {
            var range_number = Enumerable.Range(0, n);
            var pre_list = range_number.Take(range_number.Count() / 2).ToList();
            var post_list = range_number.Skip(range_number.Count() / 2).ToList();

            var firstNumberIndex = -1;
            if (pre_list.Contains(firstNumber))
            {
                firstNumberIndex = pre_list.IndexOf(firstNumber);
                return post_list[firstNumberIndex];
            }
            if (post_list.Contains(firstNumber))
            {
                firstNumberIndex = post_list.IndexOf(firstNumber);
                return pre_list[firstNumberIndex];
            }

            return firstNumberIndex;
        }
    }
}
