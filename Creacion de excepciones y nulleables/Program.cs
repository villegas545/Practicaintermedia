using System;

namespace Creacion_de_excepciones_y_nulleables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? variable = null;
            try
            {
                var response = variable is null ? throw new NullReferenceExceptionClass("Valor nulo"):"valor valido";
                
                Console.WriteLine("Valor valido");

            }
         
            catch (NullReferenceExceptionClass ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

}
