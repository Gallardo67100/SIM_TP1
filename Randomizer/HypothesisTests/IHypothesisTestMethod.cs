using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.HypothesisTests
{
    public interface IHypothesisTestMethod
    {
        bool Test(IEnumerable<RandomGridValue> sample, int numberOfIntervals, int empiricData, double significanceValue);
    }
}
