using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesignal.Main.Intro.Level3
{
    internal class SortByHeight
    {
        public static int[] Approach1(int[] a)
        {
            List<int> output = new List<int>();

            var people_list = a.ToList().Where(x => x > -1).ToList().OrderBy(x => x).ToList();

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == -1)
                {
                    output.Add(a[i]);
                }
                else
                {
                    output.Add(people_list.FirstOrDefault());
                    people_list.RemoveAt(0);
                }
            }
            return output.ToArray();
        }
    }
}
