using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovSI.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {

        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string z;
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

           
            if ((g % 4 == 0 && g % 100 != 0) || (g % 400 == 0))
            {
                daysInMonth[1] = 29; 
            }

            switch (n)
            {
                case 1:
                    m--;
                    if (m == 0)
                    {
                        m = 12;
                        g--;
                    }
                    n = daysInMonth[m - 1];
                    break;
                default:
                    n--;
                    break;
            }

            return z = n + "." + m + "." + g;
        }
    }
}
