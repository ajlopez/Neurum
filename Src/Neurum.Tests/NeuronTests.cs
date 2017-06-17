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

        [TestMethod]
        public void NeuronWithBiasThatTriggersOutput()
        {
            Neuron neuron = new Neuron(new RealValue(0.0), new ThresholdFunction(1.0), 1.0);

            Assert.AreEqual(1, neuron.Value);
        }

        [TestMethod]
        public void NeuronWithBiasThatDoesNotTriggersOutput()
        {
            Neuron neuron = new Neuron(new RealValue(1.0), new ThresholdFunction(1.0), -1.0);

            Assert.AreEqual(0, neuron.Value);
        }

        [TestMethod]
        public void NeuronWithCachedValue()
        {
            var real = new RealValue(1.0);
            Neuron neuron = new Neuron(real);

            Assert.AreEqual(1, neuron.Value);

            real.Value = 0.0;

            Assert.AreEqual(1, neuron.Value);

            neuron.Clear();

            Assert.AreEqual(0, neuron.Value);
        }
    }
}
