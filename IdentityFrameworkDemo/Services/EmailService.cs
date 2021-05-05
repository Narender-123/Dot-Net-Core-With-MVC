using IdentityFrameworkDemo.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace IdentityFrameworkDemo.Services
{
    public class EmailService
    {
        //This is the actual path of the file we want ot get it from the emailTemplates
        private string templatePath = @"EmailTemplate/{0}.html";
        private readonly SMTPConfigModel _smtpConfig;

        public EmailService(IOptions<SMTPConfigModel> smtpConfig)
        {
            _smtpConfig = smtpConfig.Value;
        }

        //This Method is Send the Mail
        private async Task SendEmail(UserEmailOptionsModel userEmailOptions) 
        {
            //This is the Structure of  MailMesssage
            MailMessage mailMessage = new MailMessage
            {
                Subject = userEmailOptions.Subject,
                Body = userEmailOptions.Body,
                From = new MailAddress(_smtpConfig.SenderAddress, _smtpConfig.SenderDisplayName),
                IsBodyHtml = _smtpConfig.IsBodyHtml
            };

            foreach (var toEmail in userEmailOptions.ToEmails) 
            {
                mailMessage.To.Add(toEmail);
            }

            //We require NetworkCredential for theUserName And Password for SmTp Service
            NetworkCredential networkCredential = new NetworkCredential(_smtpConfig.UserName,_smtpConfig.Password);

            //Now we have to create SMTP Clinet and by using  that clien we had to send the Mail

            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpConfig.Host,
                Port = _smtpConfig.Port,
                EnableSsl = _smtpConfig.EnableSSL,
                UseDefaultCredentials = _smtpConfig.UseDefaltCredentials,
                Credentials = networkCredential
            };
            mailMessage.BodyEncoding = Encoding.Default;
            await smtpClient.SendMailAsync(mailMessage);
        }

        //This Methos Will read the Body from the Htmltemplate which is in the TestEmail.html
        private string GetEmailBody(string templateName)
        {
            var body = File.ReadAllText(string.Format(templatePath, templateName));
            return body;
        }

    }
}
