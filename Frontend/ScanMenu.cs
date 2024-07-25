using System;

public static class ScanMenu
{
    public static void Display()
    {
        Console.WriteLine("Enter directory path to scan:");
        string path = Console.ReadLine();
        FileScanner.ScanDirectory(path);
        Console.WriteLine("Scan completed.");
    }
}
