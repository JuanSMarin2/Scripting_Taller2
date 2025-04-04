using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion_Patrones;

class Program
{
    static void Main(string[] args)
    {
        IEspada miEspada = new EspadaDiamante();
        miEspada.Mostrar();
        Console.WriteLine("Daño actual: " + miEspada.ObtenerDano());

        SistemaEncantamientoFacade sistema = new SistemaEncantamientoFacade();
        IEspada espadaEncantada = sistema.Encantar(miEspada);

        Console.WriteLine("\n🛠️ Espada luego del encantamiento:");
        espadaEncantada.Mostrar();
        Console.WriteLine("Daño total: " + espadaEncantada.ObtenerDano());
    }
}
