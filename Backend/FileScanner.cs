using System;
using System.IO;

public class FileScanner
{
    public static void ScanDirectory(string path)
    {
        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                ScanFile(file);
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }

    public static void ScanFile(string filePath)
    {
        if (SignatureDatabase.IsInfected(filePath))
        {
            Console.WriteLine($"Infected file: {filePath}");
            QuarantineManager.AddToQuarantine(filePath);
        }
    }
}
