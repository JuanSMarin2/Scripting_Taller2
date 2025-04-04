using System;

class Program
{
    static void Main()
    {
        var inventario = InventarioJuegos.Instancia;

        Juego tetris = new Juego("Tetris", 15);
        Juego mario = new Juego("Super Mario", 10);
        Juego sonic = new Juego("Sonic", 5);

        Cliente cliente1 = new Cliente("Juan Diego");
        Cliente cliente2 = new Cliente("Juan Sebastián");

        // Agregar observadores a los juegos
        tetris.AgregarObservador(cliente1);
        mario.AgregarObservador(cliente2);
        sonic.AgregarObservador(cliente1);
        sonic.AgregarObservador(cliente2);

        // Agregar juegos al inventario
        inventario.AgregarJuego(tetris);
        inventario.AgregarJuego(mario);
        inventario.AgregarJuego(sonic);

        // Simular ventas
        tetris.Vender(3);
        mario.Vender(5);
        sonic.Vender(2);
    }
}
