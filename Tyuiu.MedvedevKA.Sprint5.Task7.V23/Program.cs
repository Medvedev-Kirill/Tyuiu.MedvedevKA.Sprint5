using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MedvedevKA.Sprint5.Task7.V23.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task7.V23
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                            *");
            Console.WriteLine("* Задание #7                                                                                                         *");
            Console.WriteLine("* Вариант #23                                                                                                        *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V23.txt в котором есть набор символьных данных.                          *");
            Console.WriteLine("* Удалить все русские слова из файла.Полученный результат сохранить в файл OutPutDataFileTask7V23.txt.               *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V23.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
