using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesignal.Main.Intro.ExploringtheWaters
{
    internal class AddBorder
    {
        /*Given a rectangular matrix of characters, add a border of asterisks(*) to it.

        Example

        For

        picture = ["abc",
                   "ded"]
        the output should be

        solution(picture) = ["*****",
                             "*abc*",
                             "*ded*",
                             "*****"]
        Input/Output

        [execution time limit] 0.5 seconds (cs)

        [memory limit] 1 GB

        [input] array.string picture

        A non-empty array of non-empty equal-length strings.

        Guaranteed constraints:
        1 ≤ picture.length ≤ 100,
        1 ≤ picture[i].length ≤ 100.

        [output] array.string

        The same matrix of characters, framed with a border of asterisks of width 1.
        */

        public static string[] Approach1(string[] picture)
        {
            var main_list = picture.ToList();
            var first_list = new List<string>();
            var second_list = new List<string>();

            for (int i = 0; i < main_list.Count; i++)
            {
                if (i == 0 || i == main_list.Count - 1)
                {
                    first_list.Add(new string('*', main_list[i].Length + 2));
                    second_list.Add("*" + main_list[i] + "*");
                }
                else
                {
                    second_list.Add("*" + main_list[i] + "*");
                }
            }

            return first_list.Concat(second_list).Concat(first_list).ToArray();
        }

        public static string[] Approach2(string[] picture)
        {
            var main_list = picture.ToList();
            var result_list = new List<string>();

            var max_string_column = (main_list.Count > 0 ? main_list.Max(x => x.Length) : 0) + 2;
            var max_string_row = main_list.Count + 2;

            var main_index = 0;
            for (int row = 0; row < max_string_row; row++)
            {
                if (row == 0 || row == max_string_row -1)
                    result_list.Add("*".PadLeft(max_string_column,'*'));
                else
                {
                    result_list.Add($"*{main_list[main_index]}*");
                    main_index++;
                }
            }
            return result_list.ToArray();
        }

    }
}
