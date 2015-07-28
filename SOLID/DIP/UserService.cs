using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Common;

namespace SOLID.DIP
{
    public class UserService
    {
        private Database database;
        private EmailService emailService;

        public void Register(string email, string password)
        {
            emailService = new EmailService();
            emailService.ValidateEmail(email);

            database = new Database();
            var user = new User(email, password);
            database.Save(user);

            SendWelcomeMessage(email);
        }

        private void SendWelcomeMessage(string email)
        {
            emailService.SendEmail(email, "Hello fool !");
        }
    }
}