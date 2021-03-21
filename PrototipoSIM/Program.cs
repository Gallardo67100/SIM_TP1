using Randomizer;
using Randomizer.HypothesisTests;
using System;
using System.Diagnostics;

namespace PrototipoSIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            // TODO: Interfaz gráfica
            Console.WriteLine("Hello World!");
            IRandomGenerator generator = new LinearCongruentialGenerator(0.0000, 1.0000, 30);
            IHypothesisTestMethod testMethod = new ChiSquareMethod();

            var a = generator.Generate(6, 13, 7, 8);

            var result = testMethod.Test(a, 5, 0);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            if (result)
            {
                Console.WriteLine("No puede negarse la hipótesis");
            }
            else
            {
                Console.WriteLine("Tu hipótesis es una cagada");
            }


            Console.ReadLine();
        }
    }
}
