using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesignal.Main.Intro.Level3
{
    internal class isLucky
    {
        #region Approach1
        public static bool Approach1(int n)
        {
            string s = n.ToString();
            int sum = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                sum += s[i] - s[s.Length - 1 - i];
            }
            return sum == 0;
        }
        #endregion

        #region Approach2
        public static bool Approach2(int n)
        {
            string s = n.ToString();
            List<int> firstHalf = GetListFromNumber(s, 0, s.Length / 2);

            List<int> lastHalf = GetListFromNumber(s, s.Length / 2, s.Length);

            return firstHalf.Sum() == lastHalf.Sum();
        }

        private static List<int> GetListFromNumber(string s, int startPoint, int endPoint)
        {
            List<int> result = new List<int>();
            for (int i = startPoint; i < endPoint; i++)
            {
                result.Add(int.Parse(s[i].ToString()));
            }
            return result;
        }
        #endregion
    }
}
