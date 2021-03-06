﻿namespace Neurum.Tests
{
    using System;
    using System.Collections;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WeightedValueTests
    {
        [TestMethod]
        public void CreatedWeightedValueWithValueZero()
        {
            var value = new WeightedValue(new IValue[] { }, new double[] { });

            Assert.IsNotNull(value.Inputs);
            Assert.AreEqual(0, value.Inputs.Count);

            Assert.IsNotNull(value.Weights);
            Assert.AreEqual(0, value.Weights.Count);

            Assert.AreEqual(0, value.Value);
        }

        [TestMethod]
        public void CreatedWeightedValueWithValueOne()
        {
            var value = new WeightedValue(new IValue[] { new RealValue(1) }, new double[] { 1 });

            Assert.IsNotNull(value.Inputs);
            Assert.AreEqual(1, value.Inputs.Count);

            Assert.IsNotNull(value.Weights);
            Assert.AreEqual(1, value.Weights.Count);

            Assert.AreEqual(1, value.Value);
        }

        [TestMethod]
        public void CreatedWeightedValueWithValueThree()
        {
            var value = new WeightedValue(new IValue[] { new RealValue(1), new RealValue(2) }, new double[] { 1, 1 });

            Assert.IsNotNull(value.Inputs);
            Assert.AreEqual(2, value.Inputs.Count);

            Assert.IsNotNull(value.Weights);
            Assert.AreEqual(2, value.Weights.Count);

            Assert.AreEqual(3, value.Value);
        }

        [TestMethod]
        public void AdjustPositiveWeightsWithPercentage()
        {
            var value = new WeightedValue(new IValue[] { new RealValue(1), new RealValue(2) }, new double[] { 1, 1 });

            value.Adjust(0.1);

            Assert.IsTrue(value.Weights.All(w => w == 1.1));
        }

        [TestMethod]
        public void AdjustNegativeWeightsWithPercentage()
        {
            var value = new WeightedValue(new IValue[] { new RealValue(1), new RealValue(2) }, new double[] { -1, -1 });

            value.Adjust(0.1);

            Assert.IsTrue(value.Weights.All(w => w == -0.9));
        }
    }
}
