using System;
using System.Net.Mail;

public static class EmailNotifier
{
    public static void SendEmail(string subject, string body, string toAddress)
    {
        MailMessage mail = new MailMessage("your-email@example.com", toAddress)
        {
            Subject = subject,
            Body = body
        };

        SmtpClient client = new SmtpClient("smtp.example.com")
        {
            Port = 587,
            Credentials = new System.Net.NetworkCredential("username", "password"),
            EnableSsl = true,
        };

        try
        {
            client.Send(mail);
            Console.WriteLine("Email sent.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send email: {ex.Message}");
        }
    }
}
