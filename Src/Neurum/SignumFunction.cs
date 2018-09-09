namespace Neurum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SignumFunction : IValueFunction
    {
        public double Evaluate(double value)
        {
            return value < 0.0 ? -1.0 : (value > 0.0 ? 1.0 : 0.0);
        }
    }
}
