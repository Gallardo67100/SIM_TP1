using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.Distributions
{
    public class UniformDistribution : Distribution
    {
        public UniformDistribution(int seed, int numberOfValues) : base(seed, numberOfValues) { }

        public IEnumerable<RandomGridValue> GenerateUniformAB(double inferiorLimit, double superiorLimit)
        {
            var generator = new NativeRandomGenerator(0.0, 1.0, this.numberOfValues);

            foreach (var item in generator.Generate(this.seed,null, null, null))
            {
                yield return new RandomGridValue(inferiorLimit + item.RandomValue * (superiorLimit - inferiorLimit));
            }
        }
    }
}
