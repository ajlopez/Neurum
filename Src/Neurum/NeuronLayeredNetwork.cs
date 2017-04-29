namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NeuronLayeredNetwork
    {
        private IList<IList<IValue>> layers;

        public NeuronLayeredNetwork(IList<int> arities)
        {
        }

        public int NLayers { get { return this.layers.Count; } }

        public IList<IValue> GetLayer(int n)
        {
            return this.layers[n];
        }
    }
}
