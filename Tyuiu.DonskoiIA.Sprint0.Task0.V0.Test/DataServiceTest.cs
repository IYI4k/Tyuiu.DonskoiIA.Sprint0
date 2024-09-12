using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DonskoiIA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DonskoiIA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Донской Иван";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Донской Иван", res);
        }
    }
}