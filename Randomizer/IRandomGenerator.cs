using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Randomizer
{
    public interface IRandomGenerator
    {
        /// <summary>
        /// Genera una colección de números aleatorios, dependientes de los parámetros pasados
        /// y de los valores mínimo, máximo y cantidad de valores pasados a la clase.
        /// </summary>
        /// <param name="seed">El valor semilla, del cual se parte la generación de números pseudo aleatorios</param>
        /// <param name="multiplier">Constante multiplicativa para los métodos linear congruencial, y multiplicativo congruencial</param>
        /// <param name="aditive">Constante aditiva para el método linear congruencial</param>
        /// <param name="modulus">Módulo para los métodos linear congruencial, y multiplicativo congruencial</param>
        /// <returns></returns>
        IEnumerable<RandomGridValue> Generate(int seed, int? multiplier, int? aditive, int? modulus);
    }
}
