using System.Collections.Generic;
using System.Linq;

namespace Randomizer.Helpers
{
    public static class IntervalHandler
    {
        public static Dictionary<string, IEnumerable<double>> DefineIntervals(IEnumerable<double> sample, int numberOfIntervals)
        {
            var result = new Dictionary<string, IEnumerable<double>>();
            var superiorLimits = DefineSuperiorLimits(numberOfIntervals).ToList();

            for (int i = 0; i < superiorLimits.Count(); i++)
            {
                double inferiorLimit = i == 0 ? 0 : superiorLimits[i - 1];
                double superiorLimit = superiorLimits[i];
                IEnumerable<double> groupedValues;

                if (i == superiorLimits.Count - 1)
                {
                    groupedValues = sample.Where(x => x >= inferiorLimit && x <= superiorLimit);
                } else
                {
                    groupedValues = sample.Where(x => x >= inferiorLimit && x < superiorLimit);
                }

                result.Add(inferiorLimit.ToString("0.00") + " - " + superiorLimit.ToString("0.00"),  groupedValues);
            }

            return result;
        }

        private static IEnumerable<double> DefineSuperiorLimits(int numberOfIntervals)
        {
            var superiorLimits = new List<double>();
            double firstLimit = 1.0 / numberOfIntervals;

            for (int i = 1; i <= numberOfIntervals; i++)
            {
                superiorLimits.Add(firstLimit * i);
            }

            return superiorLimits;
        }
    }
}
