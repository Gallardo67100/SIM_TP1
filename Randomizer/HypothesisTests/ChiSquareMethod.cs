using Randomizer.Classes;
using Randomizer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomizer.HypothesisTests
{
    public class ChiSquareMethod : IHypothesisTestMethod
    {
        public bool Test(IEnumerable<RandomGridValue> sample, int numberOfIntervals, int empiricData, double significanceValue)
        {
            var intervals = IntervalHandler.DefineIntervals(sample, numberOfIntervals);

            var C = 0.0; // Acumulador para obtener el resultado de Chi-Cuadrado
            var sampleSize = sample.Count(); // Guardamos el tamaño de la muestra para utilizarlo en el calculo de las frecuencias
            var libertyGrade = numberOfIntervals - 1;
            var criticalValue = CriticalValues.GetCriticalValue(libertyGrade, significanceValue);

            foreach(var interval in intervals.Values)
            {
                var expectedFrecuency = (double)sampleSize / numberOfIntervals;
                var observedFrecuency = interval.Count();

                C += (Math.Pow((expectedFrecuency - observedFrecuency), 2) / expectedFrecuency);
            }

            return criticalValue > C;
        }
    }
}
