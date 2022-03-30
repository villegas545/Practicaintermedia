using System;

namespace Tipos_anonimos_y_dinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new { Name = "Chabelo", Age= 100 };
            Console.WriteLine(people);
            dynamic variable = 12;
            Console.WriteLine(variable);
            variable = "Un Valor";
            Console.WriteLine(variable);
            variable = new { prop1 = "value1", prop2 = "value2", prop3 = "value3" };
            Console.WriteLine(variable);
        }
    }
}
