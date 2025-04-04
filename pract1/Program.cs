using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Iniciando aplicación...");

        Logger.Instance.Log("La aplicación ha iniciado.");
        Logger.Instance.Log("Ejecutando una operación importante...");
        Logger.Instance.Log("Operación completada con éxito.");

        Console.WriteLine("Mensajes registrados en el archivo de log.");
    }
}
