using System;
using System.IO;

public static class ReportViewer
{
    public static void Display()
    {
        string reportFilePath = @"C:\Reports\report.txt";
        if (File.Exists(reportFilePath))
        {
            string reportContent = File.ReadAllText(reportFilePath);
            Console.WriteLine("Report File Contents:");
            Console.WriteLine(reportContent);
        }
        else
        {
            Console.WriteLine("Report file not found.");
        }
    }
}
