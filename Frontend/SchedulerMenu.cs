using System;
using System.Threading.Tasks;

public static class SchedulerMenu
{
    public static async Task Display()
    {
        Console.WriteLine("Scheduling a scan...");
        Console.WriteLine("Enter interval in hours:");
        if (int.TryParse(Console.ReadLine(), out int hours))
        {
            TimeSpan interval = TimeSpan.FromHours(hours);
            await Scheduler.ScheduleScan(interval);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
