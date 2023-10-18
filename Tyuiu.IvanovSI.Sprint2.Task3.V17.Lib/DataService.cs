﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSI.Sprint2.Task3.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 1) / (x - 1), 8);
            }
            else
            {
                if (x == 0)
                {
                    y = (2 + x - 3 * x) / (x - 7);
                }
                else
                {
                    if ((x > -21)&&(x < 2))
                    {
                        y = Math.Pow(1 + (1 / Math.Pow(x, 2)), 4);
                    }
                    else
                    {
                        if (x < -21)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y,3);
        }
    }
}
