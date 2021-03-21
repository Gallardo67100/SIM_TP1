using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomizer
{
    public class NativeRandomGenerator : IRandomGenerator
    {
        public double minValue { get; set; }
        public double maxValue { get; set; }
        public int numberOfValues { get; set; }

        // Estamos recibiendo el mínimo, máximo y cantidad de valores a generar porque, 
        // aunque no sea necesario por el momento puede ser útil más adelante
        /// <summary>
        /// Crea una instancia del Generador Nativo de C#
        /// Recibe los valores mínimo y máximo a generar, y la cantidad de valores deseados.
        /// </summary>
        /// <param name="minValue">Valor mínimo a generar</param>
        /// <param name="maxValue">Valor máximo a generar</param>
        /// <param name="numberOfValues">Número de valores a generar</param>
        public NativeRandomGenerator(double minValue, double maxValue, int numberOfValues)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.numberOfValues = numberOfValues;
        }

        public IEnumerable<double> Generate(int seed, int? multiplier, int? aditive, int? modulus)
        {
            // Creamos el generador a partir del Seed
            var generator = new Random(seed);
            //var result = new List<double>();

            for (int i = 0; i < numberOfValues; i++)
            {
                // Agregamos el valor generado a la colección.
                //result.Add(generator.NextDouble());

                yield return generator.NextDouble();
            }

            // Se devuelve la colección completa
            //return result;
        }
    }
}
