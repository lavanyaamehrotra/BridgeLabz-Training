using System.Net;
using System.Net.Mail;

namespace FundooNotesApp.ReminderService.Helpers
{
    public class EmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly string _senderEmail;
        private readonly string _senderPassword;
        private readonly string _senderName;

        public EmailSender(string host, int port, string senderEmail, string senderPassword, string senderName)
        {
            _host = host;
            _port = port;
            _senderEmail = senderEmail;
            _senderPassword = senderPassword;
            _senderName = senderName;
        }

        public void SendReminderEmail(string toEmail, string subject, string noteTitle, string noteDescription)
        {
            using var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword),
                EnableSsl = true
            };

            string body = $"Reminder for your note:\n\nTitle: {noteTitle}\nDescription: {noteDescription}";

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_senderEmail, _senderName),
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };
            mailMessage.To.Add(toEmail);

            client.Send(mailMessage);
        }
    }
}
