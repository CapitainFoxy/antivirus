using System;

public static class MainMenu
{
    public static void Display()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Antivirus Software");
            Console.WriteLine("1. Start Scan");
            Console.WriteLine("2. Quarantine");
            Console.WriteLine("3. Update Database");
            Console.WriteLine("4. Settings");
            Console.WriteLine("5. Logs");
            Console.WriteLine("6. Reports");
            Console.WriteLine("7. User Management");
            Console.WriteLine("8. Scheduler");
            Console.WriteLine("9. Help");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ScanMenu.Display();
                    break;
                case "2":
                    QuarantineMenu.Display();
                    break;
                case "3":
                    UpdateMenu.Display();
                    break;
                case "4":
                    SettingsMenu.Display();
                    break;
                case "5":
                    LogViewer.Display();
                    break;
                case "6":
                    ReportViewer.Display();
                    break;
                case "7":
                    UserMenu.Display();
                    break;
                case "8":
                    SchedulerMenu.Display();
                    break;
                case "9":
                    HelpMenu.Display();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
