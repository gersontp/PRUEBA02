using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface Telefono
    {

        public readonly string Numero { get; }

        void Fijo (string numero);
        void Celular (string numero);
    }
}
