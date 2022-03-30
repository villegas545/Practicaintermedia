using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_excepciones_y_nulleables
{
    internal class NullReferenceExceptionClass:NullReferenceException
    {
        public NullReferenceExceptionClass(string message):base(message)
        {

        }
    }
}
