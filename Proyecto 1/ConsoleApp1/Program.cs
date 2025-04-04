using System;
using ConsoleApp1;

class Programa
{
    static void Main()
    {
        var inventario = InventarioJuegos.Instancia;

        Juego tetris = new Juego("Tetris", 15);
        Juego mario = new Juego("El marios", 10);
        Juego sonic = new Juego("Sonic", 5);

        Cliente cliente1 = new Cliente("Juan Diego");
        Cliente cliente2 = new Cliente("Juan Sebastian");

        tetris.AgregarObservador(cliente1);
        mario.AgregarObservador(cliente2);
        sonic.AgregarObservador(cliente1);
        sonic.AgregarObservador(cliente2);

        inventario.AgregarJuego(tetris);
        inventario.AgregarJuego(mario);
        inventario.AgregarJuego(sonic);

        tetris.Vender(3);
        mario.Vender(5);
        sonic.Vender(2);
    }
}