using System;
using System.IO;

public static class Logger
{
    private static readonly string logFilePath = @"C:\Logs\log.txt";

    public static void Log(string message)
    {
        File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
    }
}
