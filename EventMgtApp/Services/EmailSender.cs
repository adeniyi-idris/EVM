//using System.Net.Mail;
//using System.Net;
//using EventMgtApp.Interface;
//using Microsoft.Extensions.Options;
//using MimeKit;

//namespace EventMgtApp.Services
//{
//    public class EmailSender : IEmailSender
//    {
//        private readonly SmtpSettings _smtpSettings;
//        public EmailSender(IOptions<SmtpSettings> smtpSetting)
//        {
//            _smtpSettings = smtpSetting.Value;
//        }
//        public async Task SendEmailAsync(string email, string subject, string message)
//        {
//            var emailMessage = new MimeMessage();

//            emailMessage.From.Add(new MailboxAddress(_smtpSettings.Sender))


//            //var mail = "idrissample@outlook.com";
//            //var pw = "Tomiloluwa30$";
           

//            //var client = new SmtpClient("smtp.office365.com", 587)
//            //{
//            //    EnableSsl = true,
//            //    UseDefaultCredentials = false,
//            //    Credentials = new NetworkCredential(mail, pw)
//            //};

//            //return client.SendMailAsync(
//            //    new MailMessage(from: mail,
//            //                    to: email,
//            //                    subject,
//            //                    message
//            //                    ));
//        }
//    }
//}
