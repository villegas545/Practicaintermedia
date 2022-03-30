using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_e_Indexers
{
    internal static class MapExtention
    {
        public static string GetFirstValue<T>(this Map<T> map) where T : AbstractAnimales
        {
            string Nombre=map[0].Nombre;
            string Peso=map[1].Peso;
            return Nombre + " tiene un peso de " + Peso;
        }
    }
}
