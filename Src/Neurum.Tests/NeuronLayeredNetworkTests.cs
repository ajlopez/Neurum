namespace Neurum.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
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
    }
}
