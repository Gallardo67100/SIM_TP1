using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.Distributions
{
    public abstract class Distribution
    {
        protected int seed;
        protected int numberOfValues;

        public Distribution(int seed, int numberOfValues)
        {
            this.seed = seed;
            this.numberOfValues = numberOfValues;
        }
    }
}
