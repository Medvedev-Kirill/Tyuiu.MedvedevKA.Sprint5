using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MedvedevKA.Sprint5.Task5.V26.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                          *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                                                                     *");
            Console.WriteLine("* Задание #5                                                                                                         *");
            Console.WriteLine("* Вариант #26                                                                                                        *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask5V26.txt в котором есть набор значений.Найти разницу между суммой всех    *");
            Console.WriteLine("* положительных и отрицательных вещественных чисел в файле.Результат округлить до 3 знаков после запятой.            *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений округлить до трёх знаков после запятой.           *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V26.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Разница между суммой положительных и отрицательных чисел = " + res);
            Console.ReadKey();
        }
    }
}
