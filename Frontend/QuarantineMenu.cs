using System;
using System.IO;

public static class QuarantineMenu
{
    public static void Display()
    {
        string[] files = Directory.GetFiles(@"C:\Quarantine");
        Console.WriteLine("Quarantine Contents:");
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
        
        Console.WriteLine("1. Restore file");
        Console.WriteLine("2. Delete file");
        Console.WriteLine("3. Return to Main Menu");
        Console.Write("Choose an option: ");
        switch (Console.ReadLine())
        {
            case "1":
                RestoreFile();
                break;
            case "2":
                DeleteFile();
                break;
            case "3":
                return;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }

    private static void RestoreFile()
    {
        Console.WriteLine("Enter the name of the file to restore:");
        string fileName = Console.ReadLine();
        string quarantinePath = @"C:\Quarantine";
        string filePath = Path.Combine(quarantinePath, fileName);
        if (File.Exists(filePath))
        {
            Console.WriteLine("Enter the destination path to restore the file:");
            string destPath = Console.ReadLine();
            File.Move(filePath, Path.Combine(destPath, fileName));
            Console.WriteLine("File restored.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private static void DeleteFile()
    {
        Console.WriteLine("Enter the name of the file to delete:");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(@"C:\Quarantine", fileName);
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
