namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NeuronLayeredNetwork
    {
        private IList<IValue>[] layers;

        public NeuronLayeredNetwork(IList<int> arities)
        {
            this.layers = new IList<IValue>[arities.Count];

            this.layers[0] = new List<IValue>();

            for (int k = 0; k < arities[0]; k++)
                this.layers[0].Add(new RealValue());

            for (int k = 1; k < arities.Count; k++)
            {
                this.layers[k] = new List<IValue>();

                for (int j = 0; j < arities[k]; j++)
                    this.layers[k].Add(new Neuron(WeightedValue.CreateWeightedValue(this.layers[k - 1])));
            }
        }

        public int NLayers { get { return this.layers.Length; } }

        public IList<IValue> GetLayer(int n)
        {
            return this.layers[n];
        }
    }
}
