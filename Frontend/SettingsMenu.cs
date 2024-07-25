using System;
using Newtonsoft.Json;
using System.IO;

public static class SettingsMenu
{
    public static void Display()
    {
        var settings = ConfigManager.LoadConfig<Settings>();
        if (settings == null)
        {
            settings = new Settings
            {
                EnableAutoScan = true,
                ScanIntervalHours = 24
            };
        }

        Console.WriteLine("Current Settings:");
        Console.WriteLine($"1. Enable Auto Scan: {settings.EnableAutoScan}");
        Console.WriteLine($"2. Scan Interval (hours): {settings.ScanIntervalHours}");
        
        Console.WriteLine("1. Change Auto Scan Setting");
        Console.WriteLine("2. Change Scan Interval");
        Console.WriteLine("3. Save and Exit");
        Console.Write("Choose an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                settings.EnableAutoScan = !settings.EnableAutoScan;
                Console.WriteLine($"Auto Scan set to {settings.EnableAutoScan}");
                break;
            case "2":
                Console.WriteLine("Enter new scan interval (hours):");
                if (int.TryParse(Console.ReadLine(), out int interval))
                {
                    settings.ScanIntervalHours = interval;
                    Console.WriteLine($"Scan interval set to {interval} hours");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                break;
            case "3":
                ConfigManager.SaveConfig(settings);
                return;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}
