using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Final.Utility {
    public class EmailSender : IEmailSender {
        
        public string SendGridSecret { get; set; }
        //don't forget to remove this because they're uncomplete the grid API but be aware not to remove the whole class because it makes an error
        public EmailSender(IConfiguration _config) {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");
        }
        
        public Task SendEmailAsync(string email, string subject, string htmlMessage) {
            //logic to send email using SendGrid API, I will implement the key of the api later ;)

            var client = new SendGridClient(SendGridSecret);

            var from = new EmailAddress("hello@dotnetmastery.com", "Oliek Book");
            var to = new EmailAddress(email);
            var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);

            return client.SendEmailAsync(message);
            //here we should Implement the grid api key but we will not do it now   

        }
    }
}

