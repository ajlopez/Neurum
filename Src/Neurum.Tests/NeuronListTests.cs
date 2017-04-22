namespace Neurum.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NeuronListTests
    {
        [TestMethod]
        public void CreatedNeuronList()
        {
            NeuronList list = new NeuronList(42);

            Assert.IsNotNull(list.Neurons);
            Assert.AreEqual(42, list.Neurons.Count);

            for (int k = 0; k < 42; k++)
                Assert.IsNotNull(list.Neurons[k]);
        }

        [TestMethod]
        public void CreateWeightedValue()
        {
            NeuronList list = new NeuronList(42);

            var result = list.CreateWeightedValue();

            Assert.IsNotNull(result);

            Assert.IsNotNull(result.Inputs);
            Assert.AreEqual(42, result.Inputs.Count);

            for (int k = 0; k < 42; k++)
            {
                Assert.AreSame(list.Neurons[k], result.Inputs[k]);
                Assert.IsTrue(result.Weights[k] >= -1.0);
                Assert.IsTrue(result.Weights[k] <= 1.0);
            }
        }
    }
}
