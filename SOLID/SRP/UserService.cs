using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Common;

namespace SOLID.SRP
{
    public class UserService
    {
        private Database database;
        private SmtpClient smtpClient;

        public void Register(string email, string password)
        {
            if (!email.Contains("@"))
            {
                throw new ValidationException("Email is not a valid email");
            }

            database = new Database();
            var user = new User(email, password);
            database.Save(user);

            smtpClient = new SmtpClient();
            smtpClient.Send(new MailMessage("mysite@nowhere.com", email, "Hello fool !"));
        }
    }
}