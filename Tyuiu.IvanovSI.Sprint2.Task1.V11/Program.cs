using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint2.Task1.V11.Lib;
namespace Tyuiu.IvanovSI.Sprint2.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #1                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений                                 *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,              *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций              *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),  *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую              *");
            Console.WriteLine("* последовательность(массив): (False, False, True, False, True, False),    *");
            Console.WriteLine("* при a = 145, b = 156, c = 142, d = 117                                   *"); 
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);



            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }



            Console.ReadKey();
        }
    }
}
