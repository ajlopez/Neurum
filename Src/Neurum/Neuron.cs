namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Neuron : IValue
    {
        private IValue input;

        public Neuron()
            : this(new RealValue())
        {
        }

        public Neuron(IValue input)
        {
            this.input = input;
        }

        public double Value { get { return this.input.Value >= 1.0 ? 1 : 0; } }
    }
}
