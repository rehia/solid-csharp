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
        private IDatabase database;
        private IEmailService emailService;

        public UserService() : this(new EmailService(), new Database())
        { }

        public UserService(IEmailService emailService, IDatabase database)
        {
            this.emailService = emailService;
            this.database = database;
        }

        public void Register(string email, string password)
        {
            emailService.ValidateEmail(email);

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