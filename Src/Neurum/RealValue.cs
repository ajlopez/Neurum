namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RealValue : IValue
    {
        private double value;

        public RealValue()
            : this(0)
        {
        }

        public RealValue(double value)
        {
            this.value = value;
        }

        public double Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
