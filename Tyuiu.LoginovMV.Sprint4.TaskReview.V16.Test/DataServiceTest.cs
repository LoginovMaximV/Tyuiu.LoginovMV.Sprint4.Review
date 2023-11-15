using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint4.TaskReview.V16.Lib;

namespace Tyuiu.LoginovMV.Sprint4.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            string str = "382976421897948";
            int res = ds.Calculate(n, m, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);

        }
    }
}
