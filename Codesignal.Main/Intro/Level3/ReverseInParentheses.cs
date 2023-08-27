using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codesignal.Main.Intro.Level3
{
    internal class ReverseInParentheses
    {
        public static string Approach1(string inputString)
        {
            int lid = inputString.LastIndexOf('(');
            if (lid == -1)
            {
                return inputString;
            }
            else
            {
                int rid = inputString.IndexOf(')', lid);
                return Approach1(
                            inputString.Substring(0, lid)
                        + new string(inputString.Substring(lid + 1, rid - lid - 1).Reverse().ToArray())
                        + inputString.Substring(rid + 1)
        );
            }
        }
    }
}
