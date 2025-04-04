using System;
using System.IO;

public sealed class Logger
{
    private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
    private readonly string filePath = "log.txt";
    private Logger() { }
    public static Logger Instance { get { return instance.Value; } }
    public void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}

class Program
{
    static void Main()
    {
        Logger logger = Logger.Instance;
        logger.Log("Inicio del registro");
        logger.Log("Otro mensaje de registro");
        Console.WriteLine("Mensajes registrados en log.txt");
    }
}
