using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSI.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[] horizontalBoundaries = { 3, 5, 9, 12, 3, 5, 9, 12, 3, 12, 7, 13, 7, 13, 7, 13, 6, 12, 6, 12, 3, 13, 7, 10, 12, 13 };
            int[] verticalBoundaries = { 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 12, 12 };

            for (int i = 0; i < horizontalBoundaries.Length; i += 2)
            {
                int x1 = horizontalBoundaries[i];
                int x2 = horizontalBoundaries[i + 1];
                int y1 = verticalBoundaries[i];
                int y2 = verticalBoundaries[i + 1];

                if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
