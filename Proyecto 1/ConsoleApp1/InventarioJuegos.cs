using System.Collections.Generic;

public class InventarioJuegos
{
    private static InventarioJuegos instancia;
    private List<Juego> juegos;

    private InventarioJuegos()
    {
        juegos = new List<Juego>();
    }

    public static InventarioJuegos Instancia
    {
        get
        {
            if (instancia == null)
            {
                instancia = new InventarioJuegos();
            }
            return instancia;
        }
    }

    public void AgregarJuego(Juego juego)
    {
        juegos.Add(juego);
    }

    public List<Juego> ObtenerJuegos()
    {
        return juegos;
    }
}
