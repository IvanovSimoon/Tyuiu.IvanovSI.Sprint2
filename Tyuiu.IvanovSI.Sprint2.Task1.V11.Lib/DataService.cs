using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSI.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);//false
            res[1] = (a > b) & (c < d);//false
            res[2] = (a + 20 > b) || (c < d);//true
            res[3] = (a > b) && (c < d);//false
            res[4] = !res[0];
            res[5] = (a + 20 > b) ^ (c < d + 50);//false

            return res;
        }
    }
}
