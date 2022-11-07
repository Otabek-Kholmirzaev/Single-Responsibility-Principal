using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility;

public class EmailService
{
    public static void SendEmail(string email, string subject, string message)
    {
        Console.WriteLine($"Email: {email}\nSubject: {subject}\nMessage: {message}");
    }
}
