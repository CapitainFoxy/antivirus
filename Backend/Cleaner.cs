using System;
using System.IO;

public static class Cleaner
{
    public static void CleanFile(string filePath)
    {
        Console.WriteLine($"Cleaning file: {filePath}");
        
        File.Delete(filePath);
    }
}
