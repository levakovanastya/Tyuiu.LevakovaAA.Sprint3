using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint3.Task3.V30.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint3.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharMaxCount()
        {
            DataService ds = new DataService();
            string str = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';
            double res = ds.GetMaxCharCount(str,  chr);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
