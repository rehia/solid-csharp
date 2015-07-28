using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Common
{
    public class SmtpClient
    {
        private static bool mailIsSent;

        public static void MailIsSent(bool isSent)
        {
            mailIsSent = isSent;
        }

        public static bool MailIsSent()
        {
            return mailIsSent;
        }

        public void Send(MailMessage mailMessage)
        {
            mailIsSent = true;
        }
    }
}
