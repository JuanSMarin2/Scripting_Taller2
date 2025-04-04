using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class InventarioJuegos
    {
        private static readonly InventarioJuegos instancia = new InventarioJuegos();
        private List<Juego> juegos = new List<Juego>();

        private InventarioJuegos() { }

        public static InventarioJuegos Instancia => instancia;

        public void AgregarJuego(Juego juego)
        {
            juegos.Add(juego);
        }

        public IEnumerable<Juego> ObtenerJuegos()
        {
            return juegos;
        }
    }
}
