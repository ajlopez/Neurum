namespace Neurum.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SignumFunctionTests
    {
        [TestMethod]
        public void Evaluate()
        {
            SignumFunction fn = new SignumFunction();

            Assert.AreEqual(1.0, fn.Evaluate(1.0));
            Assert.AreEqual(1.0, fn.Evaluate(1.1));
            Assert.AreEqual(1.0, fn.Evaluate(0.1));
            Assert.AreEqual(1.0, fn.Evaluate(1000));

            Assert.AreEqual(-1.0, fn.Evaluate(-0.1));
            Assert.AreEqual(-1.0, fn.Evaluate(-0.5));

            Assert.AreEqual(0.0, fn.Evaluate(0.0));

            Assert.AreEqual(-1.0, fn.Evaluate(-1.0));
            Assert.AreEqual(-1.0, fn.Evaluate(-1.1));
            Assert.AreEqual(-1.0, fn.Evaluate(-1000));
        }
    }
}
