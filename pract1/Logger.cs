using System;
using System.IO;

public sealed class Logger
{
    private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
    private static readonly object lockObj = new object();
    private string logFilePath;

    private Logger()
    {
        logFilePath = "log.txt";
    }

    public static Logger Instance => instance.Value;

    public void Log(string message)
    {
        lock (lockObj)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                Console.WriteLine(message);
                writer.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
            }
        }
    }
}
