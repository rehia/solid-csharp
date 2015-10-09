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
        private EmailService emailService;

        public void Register(string email, string password)
        {
            emailService = new EmailService();
            emailService.ValidateEmailFormat(email);

            SaveUserToDatabase(email, password);

            SendWelcomeMessage(email);
        }

        private void SendWelcomeMessage(string email)
        {
            emailService.SendMessage(email, "Hello fool !");
        }

        private void SaveUserToDatabase(string email, string password)
        {
            database = new Database();
            var user = new User(email, password);
            database.Save(user);
        }
    }
}