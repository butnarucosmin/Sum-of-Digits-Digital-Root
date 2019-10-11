using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Sum_of_Digits.Digital_Root;

namespace UnitTest.Sum_of_Digits.Digital_Root
{
    [TestClass]
    public class NumberTest
    {
        private Number num = new Number();

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [TestMethod]
        public void Tests()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(7, num.DigitalRoot(16));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}
