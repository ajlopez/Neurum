namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ThresholdFunction : IValueFunction
    {
        private double threshold;

        public ThresholdFunction(double threshold)
        {
            this.threshold = threshold;
        }

        public double Threshold { get { return this.threshold; } }

        public double Evaluate(double value)
        {
            return value >= this.threshold ? 1.0 : 0.0;
        }
    }
}
