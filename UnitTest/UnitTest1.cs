using System.Collections.Generic;
using NUnit.Framework;
using smit01;


namespace UnitTest
{
    public class Tests
    {
        private City city;
        [SetUp]
        public void Setup()
        {
            city = new City();
        }

        [Test]
        public void Test1()
        {
            Assert.Fail();
            //Assert.Pass();
        }
    }
}