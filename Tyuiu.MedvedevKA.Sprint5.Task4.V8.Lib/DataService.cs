using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevKA.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Pow(x, 2) / Math.Sin(x)) + 3, 3);
            return res;
        }
    }
}

