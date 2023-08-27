using Arcade.AtTheCrossroads;
using Arcade.IntroGates;

namespace Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IntroGates
            #region AddTwoDigits
            AddTwoDigits.Approach1(28);
            AddTwoDigits.Approach2(28);
            #endregion

            #region LargestNumber
            LargestNumber.Approach1(5);
            #endregion


            #region Candies
            Candies.Approach1(3, 10);
            #endregion

            #region SeatsInTheater
            SeatsinTheater.Approach1(16, 11, 5, 3);
            #endregion

            #region MaxMultiple
            MaxMultiple.Approach1(3, 10);
            MaxMultiple.Approach2(2, 7);
            #endregion

            #region Cirtle Of Numner
            CircleofNumbers.Approach1(18, 6);
            #endregion

            #region LateRide
            //LateRide.Approach2(240);
            LateRide.Approach2(808);
            #endregion
            #region Phone Call
            PhoneCall.Approach2(3, 1, 2, 20);
            #endregion
            #endregion


            #region AtTheCrossroads

            #region Reach Next Level
            ReachNextLevel.Approach1(10, 15, 5);
            #endregion

            #region Knapsack Light
            KnapsackLight.Approach1(10,5,6,4,8);
            #endregion

            #region Extra Number
            ExtraNumber.Approach1(5, 1, 1);
            #endregion

            #region Is Infinite Process?
            IsInfiniteProcess.Approach1(2, 5);
            IsInfiniteProcess.Approach1(6, 3);
            #endregion

            #region Arathmetic Expression
            ArithmeticExpression.Approach2(2,3,5);
            #endregion
            #endregion





        }
    }
}