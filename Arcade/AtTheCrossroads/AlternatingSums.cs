using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.AtTheCrossroads
{
    internal class AlternatingSums
    {

        /*
         * Several people are standing in a row and need to be divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.

            You are given an array of positive integers - the weights of the people. Return an array of two integers, where the first element is the total weight of team 1, and the second element is the total weight of team 2 after the division is complete.

            Example

            For a = [50, 60, 60, 45, 70], the output should be
            solution(a) = [180, 105].

            Input/Output

            [execution time limit] 0.5 seconds (cs)

            [memory limit] 1 GB

            [input] array.integer a

            Guaranteed constraints:
            1 ≤ a.length ≤ 105,
            45 ≤ a[i] ≤ 100.

            [output] array.integer
         */

        public static int[] Approach1(int[] a)
        {
            var main_list = a.ToList();
            var first_list = new List<int>();
            var second_list = new List<int>();

            for (int i = 0; i < main_list.Count; i++)
            {
                if (i % 2 == 0)
                    first_list.Add(main_list[i]);
                else
                    second_list.Add(main_list[i]);
            }

            return new int[] { first_list.Sum(), second_list.Sum() };
        }

    }
}
