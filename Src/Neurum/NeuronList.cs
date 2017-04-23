namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NeuronList
    {
        private static Random random = new Random();

        private IList<Neuron> neurons;

        public NeuronList(int nneurons)
        {
            this.neurons = new Neuron[nneurons];

            for (int k = 0; k < nneurons; k++)
                this.neurons[k] = new Neuron();
        }

        public IList<Neuron> Neurons { get { return this.neurons; } }

        public WeightedValue CreateWeightedValue()
        {
            double[] weights = new double[this.neurons.Count];

            for (int k = 0; k < weights.Length; k++)
                weights[k] = random.NextDouble() * 2 - 1;

            IList<IValue> values = new List<IValue>(this.neurons);
            WeightedValue value = new WeightedValue(values, weights);
            return value;
        }
    }
}
