using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint5.Task2.V26.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[3, 3] { { 2, -3, -3 }, { -8, 8, 0 }, { -6, 1, 0 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
           
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                          *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл                                                 *");
            Console.WriteLine("* Задание #2                                                                                                         *");
            Console.WriteLine("* Вариант #26                                                                                                        *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры.                          *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.                                                  *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.                                               *");
            Console.WriteLine("* 2; -3; -3                                                                                                          *");
            Console.WriteLine("* -8; 8; 0                                                                                                           *");
            Console.WriteLine("* -6; 1; 0                                                                                                          * ");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
