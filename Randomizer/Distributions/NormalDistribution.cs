using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomizer.Distributions
{
    public class NormalDistribution : Distribution
    {
        public NormalDistribution(int seed, int numberOfValues) : base(seed, numberOfValues){}

        public IEnumerable<RandomGridValue> GenerateNormal(double medium, double standarDeviation)
        {
            var generator = new NativeRandomGenerator(0.0, 1.0, this.numberOfValues);
            var randomSample = generator.Generate(this.seed, null, null, null).ToArray();
            var result = new List<RandomGridValue>();

            for (int i = 0; i < randomSample.Length - 1; i = i+2)
            {
                result.Add(new RandomGridValue((Math.Sqrt(-2 * Math.Log(randomSample[i].RandomValue)) * Math.Cos(2 * Math.PI * randomSample[i+1].RandomValue)) * standarDeviation + medium));

                result.Add(new RandomGridValue((Math.Sqrt(-2 * Math.Log(randomSample[i].RandomValue)) * Math.Sin(2 * Math.PI * randomSample[i + 1].RandomValue)) * standarDeviation + medium));
            }

            return result;
        }
    }
}
