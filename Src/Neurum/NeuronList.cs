namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NeuronList
    {
        private IList<Neuron> neurons;

        public NeuronList(int nneurons)
        {
            this.neurons = new Neuron[nneurons];

            for (int k = 0; k < nneurons; k++)
                this.neurons[k] = new Neuron();
        }

        public IList<Neuron> Neurons { get { return this.neurons; } }

        public IValue CreateWeightedValue()
        {
            return null;
        }
    }
}
