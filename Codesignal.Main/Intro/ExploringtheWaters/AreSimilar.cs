using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesignal.Main.Intro.ExploringtheWaters
{
    internal class AreSimilar
    {
        /*
         * Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.

            Given two arrays a and b, check whether they are similar.

            Example

            For a = [1, 2, 3] and b = [1, 2, 3], the output should be
            solution(a, b) = true.

            The arrays are equal, no need to swap any elements.

            For a = [1, 2, 3] and b = [2, 1, 3], the output should be
            solution(a, b) = true.

            We can obtain b from a by swapping 2 and 1 in b.

            For a = [1, 2, 2] and b = [2, 1, 1], the output should be
            solution(a, b) = false.

            Any swap of any two elements either in a or in b won't make a and b equal.

            Input/Output

            [execution time limit] 0.5 seconds (cs)

            [memory limit] 1 GB

            [input] array.integer a

            Array of integers.

            Guaranteed constraints:
            3 ≤ a.length ≤ 105,
            1 ≤ a[i] ≤ 1000.

            [input] array.integer b

            Array of integers of the same length as a.

            Guaranteed constraints:
            b.length = a.length,
            1 ≤ b[i] ≤ 1000.

            [output] boolean

            true if a and b are similar, false otherwise.
         */

        public static bool Approach1(int[] a, int[] b)
        {
            var a_list = a.ToList();
            var b_list = b.ToList();

            if (a_list.Distinct().ToList().Count != b_list.Distinct().ToList().Count)
                return false;

            List<int> mismatchCount = new List<int>();
            for (int i = 0; i < a_list.Count; i++)
            {
                if (a_list[i] != b_list[i])
                {
                    mismatchCount.Add(i);
                }
                if (mismatchCount.Count > 2)
                    return false;
            }

            return true;
        }

        public static bool Approach2(int[] a, int[] b)
        {
            int diffCount = 0;
            int[] diffPositions = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    diffCount++;
                    if (diffCount > 2)
                    {
                        return false; // More than two differences, not similar
                    }
                    diffPositions[diffCount - 1] = i; // Store the positions of differences
                }
            }

            if (diffCount == 0)
            {
                return true; // No differences, arrays are similar
            }

            // Check if swapping the differing elements makes the arrays similar
            return a[diffPositions[0]] == b[diffPositions[1]] && a[diffPositions[1]] == b[diffPositions[0]];
        }
    }
}
