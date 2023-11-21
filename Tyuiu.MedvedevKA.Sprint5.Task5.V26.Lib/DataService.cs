using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevKA.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double positiveSum = 0;
            double negativeSum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) !=null)
                {
                    double z = Convert.ToDouble(line);
                    if (z < 0)
                        negativeSum += z;
                    else
                        positiveSum += z;
                }
                return Math.Round(positiveSum - negativeSum, 3);
            }
        }
    }
}
