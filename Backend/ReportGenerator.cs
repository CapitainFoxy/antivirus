using System;
using System.IO;

public static class ReportGenerator
{
    public static void GenerateReport(string reportContent)
    {
        string reportPath = @"C:\Reports\report.txt";
        File.WriteAllText(reportPath, reportContent);
        Console.WriteLine("Report generated.");
    }
}
