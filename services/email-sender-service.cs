using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using rice_store.utils;

namespace rice_store.services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string subject, string body);
    }

    public class EmailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;

        public EmailSender()
        {
            _smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tan01204986304@gmail.com", "ymnx wogx rkll fwty"),
                EnableSsl = true,
            };
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            if (!string.IsNullOrWhiteSpace(to) && ValidEmail.IsValidEmail(to))
            {
                var message = new MailMessage
                {
                    From = new MailAddress("tan01204986304@gmail.com", "GoldenRice Store"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true 
                };
                message.To.Add(new MailAddress(to));
                await _smtpClient.SendMailAsync(message);
            }
                
        }
    }


}
