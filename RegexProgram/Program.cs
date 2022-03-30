using System;

namespace RegexProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena que cumpla con lo siguiente: \n Iniciar con 1 letra en Mayusculas, seguido de 3 letras minusculas y finalmente 4 digitos");
            string cadena = Console.ReadLine();
           var mensaje= cadena.IsValid() ? "valida" :"invalida";
           Console.WriteLine("La cadena de texto '" + cadena + "' es " + mensaje);
        }
    }
}
