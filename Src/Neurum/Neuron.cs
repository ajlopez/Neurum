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

        public Neuron()
            : this(new RealValue())
        {
        }

        public Neuron(IValue input)
            : this(input, new ThresholdFunction(1.0))
        {
        }

        public Neuron(IValue input, IValueFunction function)
        {
            this.input = input;
            this.function = function;
        }

        public double Value { get { return this.function.Evaluate(this.input.Value); } }
    }
}
