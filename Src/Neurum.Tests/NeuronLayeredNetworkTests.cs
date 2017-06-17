namespace Neurum.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NeuronLayeredNetworkTests
    {
        [TestMethod]
        public void CreateLayeredNetworkWithThreeLayers()
        {
            NeuronLayeredNetwork network = new NeuronLayeredNetwork(new int[] { 4, 5, 3 });

            Assert.AreEqual(3, network.NLayers);
            Assert.IsNotNull(network.GetLayer(0));
            Assert.AreEqual(4, network.GetLayer(0).Count);
            Assert.IsNotNull(network.GetLayer(1));
            Assert.AreEqual(5, network.GetLayer(1).Count);
            Assert.IsNotNull(network.GetLayer(2));
            Assert.AreEqual(3, network.GetLayer(2).Count);
        }

        [TestMethod]
        public void EvaluateLayeredNetworkWithThreeLayersInputZeroOutputZero()
        {
            NeuronLayeredNetwork network = new NeuronLayeredNetwork(new int[] { 4, 5, 3 });

            var result = network.Evaluate(new double[] { 0.0, 0.0, 0.0, 0.0 });

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
             
            Assert.IsTrue(result.All(x => x == 0));
        }

        [TestMethod]
        public void EvaluateLayeredNetworkWithThreeLayersInputNonZero()
        {
            NeuronLayeredNetwork network = new NeuronLayeredNetwork(new int[] { 4, 5, 10 });

            var result = network.Evaluate(new double[] { 100.0, 100.0, 100.0, 100.0 });

            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count);

            Assert.IsTrue(result.All(x => x == 0));
        }
    }
}
