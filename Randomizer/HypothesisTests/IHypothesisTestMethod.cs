using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer.HypothesisTests
{
    public interface IHypothesisTestMethod
    {
        public bool Test(IEnumerable<double> sample, int numberOfIntervals, int empiricData);
    }
}
