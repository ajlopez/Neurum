namespace Neurum.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RealValueTests
    {
        [TestMethod]
        public void RealValueZero()
        {
            RealValue value = new RealValue();

            Assert.AreEqual(0, value.Value);
        }

        [TestMethod]
        public void RealValueWithValue()
        {
            RealValue value = new RealValue(3.14159);

            Assert.AreEqual(3.14159, value.Value);
        }
    }
}
