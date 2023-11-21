using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.MedvedevKA.Sprint5.Task4.V8.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task4.V8
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
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                                                            *");
            Console.WriteLine("* Задание #4                                                                                                         *");
            Console.WriteLine("* Вариант #8                                                                                                         *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V8.txt в котором есть вещественное значение.                             *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.                                                       *");
            Console.WriteLine("* Вычислить значение по формуле и вернуть полученный результат на консоль.                                           *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V8.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}    


    

