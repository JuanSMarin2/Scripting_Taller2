using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Patrones
{
    public abstract class EspadaDecoradora : IEspada
    {
        protected IEspada espada;

        public EspadaDecoradora(IEspada e)
        {
            espada = e;
        }

        public virtual void Mostrar()
        {
            espada.Mostrar();
        }
        public virtual int ObtenerDano()
        {
            return espada.ObtenerDano();
        }
    }

}
