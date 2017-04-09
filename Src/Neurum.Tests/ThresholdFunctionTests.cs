namespace Neurum.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ThresholdFunctionTests
    {
        [TestMethod]
        public void HasThreshold()
        {
            ThresholdFunction fn = new ThresholdFunction(1.0);

            Assert.AreEqual(1.0, fn.Threshold);
        }

        [TestMethod]
        public void Evaluate()
        {
            ThresholdFunction fn = new ThresholdFunction(1.0);

            Assert.AreEqual(1.0, fn.Evaluate(1.0));
            Assert.AreEqual(1.0, fn.Evaluate(1.1));
            Assert.AreEqual(1.0, fn.Evaluate(1000));

            Assert.AreEqual(0.0, fn.Evaluate(0.9999));
            Assert.AreEqual(0.0, fn.Evaluate(0.5));
            Assert.AreEqual(0.0, fn.Evaluate(0.0));

            Assert.AreEqual(0.0, fn.Evaluate(-1.0));
            Assert.AreEqual(0.0, fn.Evaluate(-1.1));
            Assert.AreEqual(0.0, fn.Evaluate(-1000));
        }
    }
}
