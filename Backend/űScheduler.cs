using System;
using System.Threading.Tasks;

public static class Scheduler
{
    public static async Task ScheduleScan(TimeSpan interval)
    {
        while (true)
        {
            await Task.Delay(interval);
            Console.WriteLine("Scheduled scan started.");
            FileScanner.ScanDirectory(@"C:\Scan");
        }
    }
}
