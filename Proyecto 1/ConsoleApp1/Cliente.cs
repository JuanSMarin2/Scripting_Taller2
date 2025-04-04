using System;
using ConsoleApp1;

public class Cliente : IObservador
{
    private string nombre;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
    }

    public void Actualizar(Juego juego)
    {
        Console.WriteLine("Notificación para " + nombre + ": El juego " + juego.Nombre + " tiene " + juego.ObtenerStock() + " unidades en stock.");
    }
}
