using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Common;

namespace SOLID.SRP
{
    public class EmailService
    {
        public void ValidateEmailFormat(string email)
        {
            if (!email.Contains("@"))
            {
                throw new ValidationException("Email is not a valid email");
            }
        }

        public void SendMessage(string email, string message)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage("mysite@nowhere.com", email, message));
        }
    }
}
