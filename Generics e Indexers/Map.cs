using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_e_Indexers
{
    public class Map<T> where T : AbstractAnimales
    {
        private T[] array;
        public Map(int number)
        {
            array = new T[number];
        }
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public T this[string key] 
        {
          get
            {
                foreach(var item in array)
                {
                    if (item.Nombre == key) {       
                        return item; 
                    } 
                }
                throw new Exception();     
            }
        }
    }
}
