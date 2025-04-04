using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Patrones
{
    public class SistemaEncantamientoFacade
    {
        public IEspada Encantar(IEspada espadaOriginal)
        {
            Console.WriteLine("\n✨ Iniciando proceso de encantamiento...");
            IEspada espadaConDano = new EspadaDanoExtra(espadaOriginal);
            IEspada espadaConFuego = new EspadaFuego(espadaConDano);
            return espadaConFuego;
        }
    }

}
