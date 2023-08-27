using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcade.IntroGates
{
    internal class SeatsinTheater
    {
        public static int Approach1(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }
    }
}
