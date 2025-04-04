using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Juego
    {
        public string Nombre { get; private set; }
        private int stock;

        public Juego(string nombre, int stockInicial)
        {
            Nombre = nombre;
            stock = stockInicial;
        }

        public void Vender(int cantidad)
        {
            if (stock >= cantidad)
            {
                stock -= cantidad;
                Console.WriteLine($"Venta realizada: {cantidad} unidades de {Nombre}. Stock actual: {stock}");
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock de {Nombre}.");
            }
        }
    }
}
