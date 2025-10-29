using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint3.Task7.V11.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWairArray;
            valueWairArray = new double[len];
            valueWairArray[0] = 20.36;
            valueWairArray[1] = 15.42;
            valueWairArray[2] = 10.99;
            valueWairArray[3] = 7.43;
            valueWairArray[4] = 4.33;
            valueWairArray[5] = 1;
            valueWairArray[6] = 0;
            valueWairArray[7] = -8.87;
            valueWairArray[8] = -13.03;
            valueWairArray[9] = -16.53;
            valueWairArray[10] = -19.60;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWairArray, res);
        }
    }
}
