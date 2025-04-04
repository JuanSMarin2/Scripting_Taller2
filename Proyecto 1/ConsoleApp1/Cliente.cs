using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente : IObservador
    {
        private string nombre;

        public Cliente(string nombre = "Cliente Random")
        {
            this.nombre = nombre;
        }

        public void Actualizar(Juego juego)
        {
            Console.WriteLine($"[Notificación para {nombre}] El juego '{juego.Nombre}' ahora tiene {juego.ObtenerStock()} unidades en stock.");
        }
    }
}
