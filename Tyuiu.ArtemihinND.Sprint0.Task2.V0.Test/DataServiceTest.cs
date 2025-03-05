using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.ArtemihinND.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ArtemihinND.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Никита";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Никита", res);
        }
    }
}
