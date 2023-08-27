using Codesignal.Main.Intro.ExploringtheWaters;
using Codesignal.Main.Intro.Level3;

namespace Codesignal.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Level 3

            #region commonCharacterCount_Approach1
            //Level3.CommonCharacterCount.Approach1("aabcc", "adcaa");
            #endregion

            #region isLucky
            
            //Approach 1
            //Level3.isLucky.Approach1(123);
            
            //Approach 2
            //Level3.isLucky.Approach2(123);
            #endregion


            #region SortByHeight
            //Level3.SortByHeight.Approach1(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 } );
            #endregion


            #region ReverseInParentheses
            //Level3.ReverseInParentheses.Approach1("(bar)(bar)");
            //Level3.ReverseInParentheses.Approach1("(bar)");
            //Level3.ReverseInParentheses.Approach1("abc(deg(ghi)(jkl))(mno)pqr");
            var result = ReverseInParentheses.Approach1("abc(deg(ghi)(jkl))(mno)pqr");
            #endregion


            #endregion


            #region Level 4 - ExploringtheWaters

            #region AddBorder
            AddBorder.Approach2(new string[] {"abc",
           "ded"});
            #endregion

            #region AlternatingSums
            AlternatingSums.Approach1(new int[] { 50, 60, 60, 45, 70});
            #endregion

            #region Are Similar

            //AreSimilar.Approach1(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
            AreSimilar.Approach1(new int[] { 1, 2, 2 }, new int[] { 2, 1, 1 });
            //AreSimilar.Approach1(new int[] { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 }, new int[] { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 });

            #endregion

            #endregion

        }

    }
}