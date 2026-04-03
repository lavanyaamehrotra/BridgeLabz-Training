using System;
using System.IO;
public static class ErrorLogger
{
    private static string filePath = "error_log.txt";
    public static void LogError(string message)
    {
        try
        {
            File.AppendAllText(filePath,DateTime.Now + " : " + message + Environment.NewLine);
        }
        catch
        {
            Console.WriteLine("Logging failed.");
        }
    }
}
