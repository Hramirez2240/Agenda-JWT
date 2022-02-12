using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Crud_JWT.Services
{
    public class EmailService
    {
        public async Task<bool> SendEmail(string message, List<string> to)
        {
            var authentication = new NetworkCredential("hramrez3@gmail.com", "ElGoldoZozoYLolaJiji2240");

            var client = new SmtpClient("smtp.gmail.com")
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = authentication,
                Port = 587,
                EnableSsl = true
            };

            var mailAddress = new MailAddress("hramrez3@gmail.com", "Hector Ramirez");

            var mailMessage = new MailMessage()
            {
                Subject = "Invitation to event!!",
                SubjectEncoding = System.Text.Encoding.UTF8,
                From = mailAddress,

                Body = message,
                BodyEncoding = System.Text.Encoding.UTF8,
            };

            foreach (var destinatary in to)
            {
                mailMessage.To.Add(new MailAddress(destinatary));
            }

            client.Send(mailMessage);

            return true;
        }

        public async static void CreateMessage(List<string> toAddress, string eventName, DateTime eventDate)
        {
            var email = new EmailService();
            string mensaje = $"You have been invited to the event call: {eventName} that will be: {eventDate}";

            await email.SendEmail(mensaje, toAddress);
        }
    }
}
