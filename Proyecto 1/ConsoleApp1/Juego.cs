using System;
using System.Collections.Generic;
using ConsoleApp1;

public class Juego
{
    public string Nombre { get; private set; }
    private int stock;
    private List<IObservador> observadores;

    public Juego(string nombre, int stockInicial)
    {
        Nombre = nombre;
        stock = stockInicial;
        observadores = new List<IObservador>();
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= stock)
        {
            stock -= cantidad;
            Console.WriteLine("Venta realizada: " + cantidad + " unidades de " + Nombre + ". Stock actual: " + stock);
            Notificar();
        }
        else
        {
            Console.WriteLine("No hay suficiente stock para vender " + cantidad + " unidades de " + Nombre + ". Stock disponible: " + stock);
        }
    }

    public void AgregarObservador(IObservador observador)
    {
        observadores.Add(observador);
    }

    private void Notificar()
    {
        foreach (var observador in observadores)
        {
            observador.Actualizar(this);
        }
    }

    public int ObtenerStock()
    {
        return stock;
    }
}
