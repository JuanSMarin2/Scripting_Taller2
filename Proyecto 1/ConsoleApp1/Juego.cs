using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Juego : ISujeto
    {
        public string Nombre { get; private set; }
        private int stock;
        private List<IObservador> observadores = new List<IObservador>();

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
                Notificar();
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock para vender {cantidad} unidades de {Nombre}. Stock disponible: {stock}");
            }
        }

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void QuitarObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(this);
            }
        }

        public int ObtenerStock() => stock;
    }
}
