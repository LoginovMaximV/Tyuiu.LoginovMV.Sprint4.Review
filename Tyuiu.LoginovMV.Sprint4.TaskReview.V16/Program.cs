using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint4.TaskReview.V16.Lib;

namespace Tyuiu.LoginovMV.Sprint4.TaskReview.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #16                                                                                                 *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 264795863157. Преобразуйте ее в матрицу 3 на 4                           *");
            Console.WriteLine("* и подсчитайте сумму нечетных чисел.                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int index = 0;
            string str = "382976421897948";
            int[,] array = new int[n, m];
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Произведение нечетных элементов массива: ");
            int res = ds.Calculate(n, m, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
