using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SOLID.DIP;
using SOLID.Common;

namespace SOLID.Tests.DIP
{
    [TestFixture]
    class UserServiceBehavior
    {
        private UserService service;

	    [SetUp]
	    public void SetUp() {
		    service = new UserService(new EmailService(), new Database());
		    Database.UserIsSaved(false);
		    SmtpClient.MailIsSent(false);
	    }

	    [Test]
	    public void ShouldSaveUserToDatabaseWhenEmailIsValid() {
		
		    service.Register("toto@email.com", "toto");
		    Assert.That(Database.UserIsSaved());
	    }

	    [Test]
	    public void ShouldSendEmailWhenEmailIsValid() {
		
		    service.Register("toto@email.com", "toto");
		    Assert.That(SmtpClient.MailIsSent());
	    }

	    [Test]
	    public void ShouldThrowValidationExceptionWhenEmailIsNotValid() {
		    Assert.Throws<ValidationException>(() => service.Register("totoemail.com", "toto"));
	    }

	    [Test]
	    public void ShouldNotSaveUserWhenEmailIsNotValid() {
		
		    try {
			    service.Register("totoemail.com", "toto");
		    } catch (ValidationException e) {}

		    Assert.False(Database.UserIsSaved());
	    }

	    [Test] 
	    public void ShouldNotSendEmailEmailIsNotValid() {
		
		    try {
			    service.Register("totoemail.com", "toto");
		    } catch (ValidationException e) {}

		    Assert.False(SmtpClient.MailIsSent());
	    }
    }
}
