using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MedvedevKA.Sprint5.Task6.V1.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task6.V1
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
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                                                   *");
            Console.WriteLine("* Задание #6                                                                                                         *");
            Console.WriteLine("* Вариант #1                                                                                                         *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask6V1.txt в котором есть набор символьных данных.                           *");
            Console.WriteLine("* Найти количество цифр в заданной строке.                                                                           *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V1.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество цифр в заданной строке = " + res);
            Console.ReadKey();
        }
    }
}
