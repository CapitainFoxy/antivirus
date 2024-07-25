using System;
using System.IO;

public static class LogViewer
{
    public static void Display()
    {
        string logFilePath = @"C:\Logs\log.txt";
        if (File.Exists(logFilePath))
        {
            string logContent = File.ReadAllText(logFilePath);
            Console.WriteLine("Log File Contents:");
            Console.WriteLine(logContent);
        }
        else
        {
            Console.WriteLine("Log file not found.");
        }
    }
}
