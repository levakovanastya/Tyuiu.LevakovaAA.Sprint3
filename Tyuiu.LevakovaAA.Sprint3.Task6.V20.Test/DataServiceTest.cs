using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint3.Task6.V20.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint3.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(41, res);
        }
    }
}
