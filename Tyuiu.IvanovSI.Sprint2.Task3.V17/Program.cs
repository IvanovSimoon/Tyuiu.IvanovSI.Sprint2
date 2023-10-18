using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint2.Task3.V17.Lib;
namespace Tyuiu.IvanovSI.Sprint2.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #3                                                               *");
            Console.WriteLine("* Вариант #17                                                              *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                      *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
