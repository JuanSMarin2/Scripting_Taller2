using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Patrones
{
    public class EspadaFuego : EspadaDecoradora
    {
        public EspadaFuego(IEspada e) : base(e) { }

        public override void Mostrar()
        {
            espada.Mostrar();
            Console.WriteLine("Encantamiento de fuego: ahora quema al contacto.");
        }

        public override int ObtenerDano() => espada.ObtenerDano();
    }

}
