using System;
/*
 * Comentarios en C#
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using output = System.Console;

namespace Sergioteacher.Csharp01_HolaMundo
{
    /// <summary>
    /// <autor>Sergioteacher</autor>
    /// Comentarios codificados en XML
    /// </summary>
    class HolaMundo
    {
        /// <summary>
        /// El método principal
        /// </summary>
        /// <param name="args"> Y los argumentos que gestiona, aquí los parámetros del programa.</param>
        static void Main(string[] args)
        {
            /* Sin incluir el espacio de nombres System */
            //System.Console.WriteLine("¡Hola a todo el mundo!");
            /* Incluyendo el espacio de nombres */
            //Console.WriteLine("¡Hola a todo el mundo!");
            /* usando un alias */
            output.WriteLine("¡Hola a todo el mundo!");
        }
    }
}
