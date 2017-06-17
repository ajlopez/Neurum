namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Neuron : IValue
    {
        private IValue input;
        private IValueFunction function;
        private double bias;
        private double? cachedValue;

        public Neuron()
            : this(new RealValue())
        {
        }

        public Neuron(IValue input)
            : this(input, new ThresholdFunction(1.0), 0.0)
        {
        }

        public Neuron(IValue input, IValueFunction function, double bias)
        {
            this.input = input;
            this.function = function;
            this.bias = bias;
        }

        public double Value 
        {
            get 
            {
                if (this.cachedValue != null)
                    return this.cachedValue.Value;

                this.cachedValue = this.function.Evaluate(this.input.Value + this.bias);

                return this.cachedValue.Value;
            } 
        }

        public void Clear()
        {
            this.cachedValue = null;
        }
    }
}
