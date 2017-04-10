namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WeigthedValue : IValue
    {
        private IList<IValue> inputs;
        private IList<double> weights;

        public WeigthedValue(IList<IValue> inputs, IList<double> weights)
        {
            this.inputs = inputs;
            this.weights = weights;
        }

        public IList<IValue> Inputs { get { return this.inputs; } }

        public IList<double> Weights { get { return this.weights; } }

        public double Value
        {
            get
            {
                double result = 0;

                int ninputs = this.inputs.Count;

                for (int k = 0; k < ninputs; k++)
                    result += this.inputs[k].Value * this.weights[k];

                return result;
            }
        }
    }
}
