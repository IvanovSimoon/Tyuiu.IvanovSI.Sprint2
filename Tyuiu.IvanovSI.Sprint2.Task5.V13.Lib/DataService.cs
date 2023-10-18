using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovSI.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string z;
            bool isLeapYear = g % 4 == 0 && (g % 100 != 0 || g % 400 == 0);

            // Вычисление следующей даты
            

            switch (m)
            {
                case 2: // Февраль
                    if (n < (isLeapYear ? 29 : 28))
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;

                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    if (n < 30)
                    {
                        n++;
                    }
                    else
                    {
                        m++;
                        n = 1;
                    }
                    break;

                default: // Январь, Март, Май, Июль, Август, Октябрь, Декабрь
                    if (n < 31)
                    {
                        n++;
                    }
                    else if (m < 12)
                    {
                        m++;
                        n = 1;
                    }
                    else
                    {
                        g++;
                        m = 1;
                        n = 1;
                    }
                    break;
                    
            }
            return z = n + "." + m + "." + g;
        }
    }
}        
    

