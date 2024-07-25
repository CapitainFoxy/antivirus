using System;
using System.IO;

public static class QuarantineManager
{
    private static readonly string quarantinePath = @"C:\Quarantine";

    static QuarantineManager()
    {
        if (!Directory.Exists(quarantinePath))
        {
            Directory.CreateDirectory(quarantinePath);
        }
    }

    public static void AddToQuarantine(string filePath)
    {
        string fileName = Path.GetFileName(filePath);
        string destFile = Path.Combine(quarantinePath, fileName);
        File.Move(filePath, destFile);
        Console.WriteLine($"File moved to quarantine: {fileName}");
    }
}
