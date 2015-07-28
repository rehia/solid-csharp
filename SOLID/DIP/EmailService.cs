using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Common;

namespace SOLID.DIP
{
    public class EmailService
    {
        private SmtpClient smtpClient;

        public void ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ValidationException("Email is not a valid email");
            }
        }

        public void SendEmail(string email, string message)
        {
            smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage("mysite@nowhere.com", email, message));
        }
    }
}
