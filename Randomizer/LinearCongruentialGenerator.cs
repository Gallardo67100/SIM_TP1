using Randomizer.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Randomizer
{
    public class LinearCongruentialGenerator : IRandomGenerator
    {
        public double minValue { get; set; }
        public double maxValue { get; set; }
        public int numberOfValues { get; set; }

        // Estamos recibiendo el mínimo, máximo y cantidad de valores a generar porque, 
        // aunque no sea necesario por el momento puede ser útil más adelante
        /// <summary>
        /// Crea una instancia del Generador Linear Congruencial
        /// Recibe los valores mínimo y máximo a generar, y la cantidad de valores deseados.
        /// </summary>
        /// <param name="minValue">Valor mínimo a generar</param>
        /// <param name="maxValue">Valor máximo a generar</param>
        /// <param name="numberOfValues">Número de valores a generar</param>
        public LinearCongruentialGenerator(double minValue, double maxValue, int numberOfValues)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.numberOfValues = numberOfValues;
        }

        public IEnumerable<RandomGridValue> Generate(int seed, int? multiplier, int? aditive, int? modulus)
        {
            // Almaceno el último valor en esta variable para poder operar en el siguiente ciclo.
            // Se inicializa con el valor del seed, porque es el valor para X0
            double lastValue = seed;

            for (int i = 0; i < numberOfValues; i++)
            {
                // Generamos un número de la serie, multiplicando la constante multiplicativa y Xi-1, 
                // sumando la constante aditiva, y calculamos el módulo de la división por el módulo.
                double randomNumber = ((double)multiplier.Value * lastValue + aditive.Value) % modulus.Value;

                // Guardamos el valor generado
                lastValue = randomNumber;

                yield return new RandomGridValue((randomNumber / (modulus.Value)).ToString("0.0000"));
            }
        }

        public IEnumerable<double> GenerateUnformated(int seed, int? multiplier, int? aditive, int? modulus)
        {
            // Almaceno el último valor en esta variable para poder operar en el siguiente ciclo.
            // Se inicializa con el valor del seed, porque es el valor para X0
            double lastValue = seed;

            for (int i = 0; i < numberOfValues; i++)
            {
                // Generamos un número de la serie, multiplicando la constante multiplicativa y Xi-1, 
                // y calculamos el módulo de la división por el módulo.
                double randomNumber = ((double)multiplier.Value * lastValue + aditive.Value) % modulus.Value;

                // Guardamos el valor generado
                lastValue = randomNumber;

                yield return randomNumber / (modulus.Value);
            };
        }
    }
}
