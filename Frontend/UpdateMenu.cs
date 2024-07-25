using System;

public static class UpdateMenu
{
    public static void Display()
    {
        Console.WriteLine("Updating database...");
        Updater.UpdateDatabase();
        Console.WriteLine("Database update complete.");
    }
}
