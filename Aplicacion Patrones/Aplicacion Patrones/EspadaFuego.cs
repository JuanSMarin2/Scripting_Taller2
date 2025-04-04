using System;

namespace Aplicacion_Patrones
{
 
    public class EspadaFuego : EspadaDecoradora
    {

        public EspadaFuego(IEspada e) : base(e)
        {
        }

      
        public override void Mostrar()
        {
            espada.Mostrar();
            Console.WriteLine("Encantamiento de fuego: ahora quema al contacto.");
        }

      
        public override int ObtenerDano()
        {
            return espada.ObtenerDano() + 2;
        }
    }
}
