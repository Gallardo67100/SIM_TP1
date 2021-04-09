using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.Distributions
{
    public class ExponentialDistribution : Distribution
    {
        public ExponentialDistribution(int seed, int numberOfValues) : base(seed, numberOfValues){}

        public IEnumerable<RandomGridValue> GenerateExponential(double lambda)
        {
            var generator = new NativeRandomGenerator(0.0, 1.0, this.numberOfValues);

            foreach (var item in generator.Generate(this.seed, null, null, null))
            {
                yield return new RandomGridValue((-1/lambda) * Math.Log(1 - item.RandomValue));
            }
        }
    }
}
