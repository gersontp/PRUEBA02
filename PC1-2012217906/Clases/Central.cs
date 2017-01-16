using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Central
    {
        public List<Llamada> Llamada = new List<Llamada>();
        public List<Telefono> Telefono = new List<Telefono>();

        


        public void Agregar(Telefono telefono) {
            Telefono.Add(telefono);

        }


        public void Eliminar(Telefono telefono)
        {
            Telefono.Remove(telefono);
        }

        public void IniciarLlamada(string numero)
        {




        }
        public Double FinalizarLlamada(string numero)
        {

            var costo="20";

            return costo;



        }

    }
}
