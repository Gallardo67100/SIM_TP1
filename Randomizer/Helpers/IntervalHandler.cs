using Randomizer.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Randomizer.Helpers
{
    public static class IntervalHandler
    {
        public static Dictionary<string, IEnumerable<double>> DefineIntervals(IEnumerable<RandomGridValue> sample, int numberOfIntervals, double infLimit = 0.0, double supLimit = 1.0)
        {
            var result = new Dictionary<string, IEnumerable<double>>();
            var superiorLimits = DefineSuperiorLimits(numberOfIntervals, infLimit, supLimit).ToList();

            for (int i = 0; i < superiorLimits.Count(); i++)
            {
                double inferiorLimit = i == 0 ? infLimit : superiorLimits[i - 1];
                double superiorLimit = superiorLimits[i];
                IEnumerable<double> groupedValues;

                if (i == superiorLimits.Count - 1)
                {
                    groupedValues = sample.Where(x => x.RandomValue >= inferiorLimit && x.RandomValue <= superiorLimit).Select(x => x.RandomValue);
                } 
                else
                {
                    groupedValues = sample.Where(x => x.RandomValue >= inferiorLimit && x.RandomValue < superiorLimit).Select(x => x.RandomValue);
                }

                result.Add(inferiorLimit.ToString("0.00") + " - " + superiorLimit.ToString("0.00"),  groupedValues);
            }

            return result;
        }

        public static Dictionary<double, int> FormatIntervalsForHistogram(Dictionary<string, IEnumerable<double>> dictionary)
        {
            var result = new Dictionary<double, int>();

            foreach (var item in dictionary)
            {
                double limit;
                if (double.TryParse(item.Key.Split('-')[1], out limit))
                {
                    result.Add(limit, item.Value.Count());
                }
            }

            return result;
        }

        public static IEnumerable<double> GetLimits(int numberOfIntervals, int infLimit = 0, int supLimit = 1)
        {
            var limits = DefineSuperiorLimits(numberOfIntervals).ToList();
            limits.Insert(0, (double)infLimit);
            return limits;
        }

        private static IEnumerable<double> DefineSuperiorLimits(int numberOfIntervals, double infLimit = 0.0, double supLimit = 1.0)
        {
            var superiorLimits = new List<double>();
            double firstLimit = (supLimit - infLimit) / numberOfIntervals;

            for (int i = 1; i <= numberOfIntervals; i++)
            {
                superiorLimits.Add(firstLimit * i + infLimit);
            }

            return superiorLimits;
        }
    }
}
