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

        [TestMethod]
        public void NeuronWithValueThatTriggersOutput()
        {
            Neuron neuron = new Neuron(new RealValue(1.0));

            Assert.AreEqual(1, neuron.Value);
        }
    }
}
