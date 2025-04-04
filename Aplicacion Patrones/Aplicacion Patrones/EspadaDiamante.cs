using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Patrones
{
    public class EspadaDiamante : IEspada
    {
        public int ObtenerDano() => 7;

        public void Mostrar()
        {
            Console.WriteLine("Espada de diamante creada. Daño base: 7.");
        }
    }

}
