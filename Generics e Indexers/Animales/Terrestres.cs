using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_e_Indexers
{
    public class Terrestres:AbstractAnimales
    {
        private string nombre;
        private dynamic peso;
        public Terrestres(string _nombre, dynamic _peso)
        {
            this.nombre = _nombre;
            this.peso = _peso;
        }
        public override string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public override dynamic Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Info()
        {
            return "el " + nombre + " es un animal terrestre y puede caminar";
        }
    }
}
