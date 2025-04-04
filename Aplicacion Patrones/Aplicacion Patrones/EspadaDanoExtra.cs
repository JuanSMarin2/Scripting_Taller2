using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Patrones
{
    public class EspadaDanoExtra : EspadaDecoradora
    {
        public EspadaDanoExtra(IEspada e) : base(e) 
        {

        }

        public override void Mostrar()
        {
            espada.Mostrar();
            Console.WriteLine("Encantamiento de fuerza: +2 de daño.");
        }

        public override int ObtenerDano()
        {
            return espada.ObtenerDano() + 4;
        }
    }

}
