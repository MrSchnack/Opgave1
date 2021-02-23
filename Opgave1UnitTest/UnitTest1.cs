using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1;
using System;

namespace Opgave1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Beer beer;
        [TestInitialize]
        public void test()
        {
            beer = new Beer();
            beer.Id = 1;
            beer.Name = "Tuborg";
            beer.Price = 14;
            beer.Abv = 4.6;
        }
        [TestMethod]
        public void TestMethod_Name_too_short()
        {


            Assert.ThrowsException<ArgumentException>(() => beer.Name = "nam");



        }
        [TestMethod]
        public void TestMethod_Price_cant_be_0()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = 0);



        }
        [TestMethod]
        public void TestMethod_Abv_cant_be_0()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 0);
        }
        [TestMethod]
        public void TestMethod_Abv_cant_be_minus_1()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);

        }
        [TestMethod]
        public void TestMethod_Abv_cant_be_101()
        {


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 101);

        }
    }
}
