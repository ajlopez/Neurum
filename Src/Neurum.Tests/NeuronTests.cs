namespace Neurum.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NeuronTests
    {
        [TestMethod]
        public void CreatedNeuronHasZeroValue()
        {
            Neuron neuron = new Neuron();

            Assert.AreEqual(0, neuron.Value);
        }
    }
}
