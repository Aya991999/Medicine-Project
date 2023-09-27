

using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class EmailSender  
    {
        private readonly EmailOptions emailOptions;
        public EmailSender(IOptions<EmailOptions> Options)
        {
            emailOptions = Options.Value;
        }
        public EmailSender( )
        {
           
        }
       

        public string SendMessage(string subject, string messageBody, string fromAddress, string toAddress, string ccAddress, string BccAddress)
        {
            MailMessage message = new MailMessage();
            subject = subject.Replace("\r\n", " ");
            message.Subject = subject;
            message.Body = "<div style='text-align: right;'>"+ messageBody+ "</div>";
            message.IsBodyHtml = true;
            message.From = new MailAddress(fromAddress);
            List<string> _ToAddress = toAddress.Split(';').ToList();
            foreach (var item in _ToAddress)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    message.To.Add(new MailAddress(item));
                }
               
            }
           
            if (ccAddress.Trim().Length > 0)
            {
                foreach (string addr in ccAddress.Split(';'))
                {
                    if (!string.IsNullOrEmpty(addr))
                        message.CC.Add(new MailAddress(addr));
                }
            }
            if (BccAddress.Trim().Length > 0)
            {
                foreach (string addr in BccAddress.Split(';'))
                {
                    if (!string.IsNullOrEmpty(addr))
                        message.Bcc.Add(new MailAddress(addr));
                }
            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.ipi.gov.eg";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential( "", "");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;

            try
            {
                NEVER_EAT_POISON_Disable_CertificateValidation();
                smtp.Send(message);
                // ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
                return "Email Send";
            }
            catch (Exception ex)
            {
                return  ("خطاء خلال تنفيذ العملية الأخيرة برجاء مراجعة الأدمن");
            }
        }


        public string GmailSendMessage(string subject, string messageBody, string fromAddress, string toAddress, string ccAddress)
        {
            try
            {
                const string fromPassword = "123456";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(fromAddress, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = messageBody
                })
                {
                    smtp.Send(message);
                }
                return "";
            }
            catch (Exception ex)
            {
                return "خطاء خلال تنفيذ العملية الأخيرة برجاء مراجعة الأدمن";
            }
        
        }

        static void NEVER_EAT_POISON_Disable_CertificateValidation()
        {
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                )
                {
                    return true;
                };
        }
    }
}
