using Randomizer.Classes;
using System.Collections.Generic;

namespace Randomizer
{
    public class MultiplicativeCongruentialGenerator : IRandomGenerator
    {
        public double minValue { get; set; }
        public double maxValue { get; set; }
        public int numberOfValues { get; set; }

        // Estamos recibiendo el mínimo, máximo y cantidad de valores a generar porque, 
        // aunque no sea necesario por el momento puede ser útil más adelante
        /// <summary>
        /// Crea una instancia del Generador Multiplicativo Congruencial
        /// Recibe los valores mínimo y máximo a generar, y la cantidad de valores deseados.
        /// </summary>
        /// <param name="minValue">Valor mínimo a generar</param>
        /// <param name="maxValue">Valor máximo a generar</param>
        /// <param name="numberOfValues">Número de valores a generar</param>
        public MultiplicativeCongruentialGenerator(double minValue, double maxValue, int numberOfValues)
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
            var result = new List<double>();

            for (int i = 0; i < numberOfValues; i++)
            {
                // Generamos un número de la serie, multiplicando la constante multiplicativa y Xi-1, 
                // y calculamos el módulo de la división por el módulo.
                double randomNumber = ((double)multiplier.Value * (lastValue == 0 ? seed : lastValue)) % modulus.Value;

                // Guardamos el valor generado
                lastValue = randomNumber;

                // Agregamos a la colección el valor generado, dividido por el módulo -1 para que sea un valor entre 0 y 1
                //result.Add(randomNumber / (modulus.Value - 1));

                yield return new RandomGridValue((randomNumber / (modulus.Value - 1)));
            };
        }
    }
}
