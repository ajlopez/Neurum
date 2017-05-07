namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WeightedValue : IValue
    {
        private static Random random = new Random();

        private IList<IValue> inputs;
        private IList<double> weights;

        public WeightedValue(IList<IValue> inputs, IList<double> weights)
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

        public void Adjust(double percentage)
        {
            this.weights = this.weights.Select(w => w + Math.Abs(w) * percentage).ToList();
        }

        public static WeightedValue CreateWeightedValue(IList<IValue> values)
        {
            double[] weights = new double[values.Count];

            for (int k = 0; k < weights.Length; k++)
                weights[k] = (random.NextDouble() * 2) - 1;

            WeightedValue value = new WeightedValue(values, weights);
            return value;
        }
    }
}
