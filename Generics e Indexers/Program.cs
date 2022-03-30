using System;

namespace Generics_e_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map<Acuaticos> pez = new Map<Acuaticos>(3);
            pez[0]=new Acuaticos("Payaso","2");
            pez[1]=new Acuaticos("Tilapia","1");
            pez[2] = new Acuaticos("Carpa","3");
            Acuaticos Nemo=pez[0];
            Console.WriteLine(Nemo.Info());
            Console.WriteLine(pez.GetFirstValue());
            try
            {
            Console.WriteLine(pez["Tilawwspia"].Info());
            }
            catch(Exception ex)
            { Console.WriteLine("La key no existe!!!!"); }
        }
    }
}
