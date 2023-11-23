using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MedvedevKA.Sprint5.Task7.V23.Lib;

namespace Tyuiu.MedvedevKA.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.MedvedevKA.Sprint5\Tyuiu.MedvedevKA.Sprint5.Task7.V23\bin\Debug\OutPutFileTask7.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
