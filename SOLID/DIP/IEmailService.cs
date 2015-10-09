namespace SOLID.DIP
{
    public interface IEmailService
    {
        void ValidateEmail(string email);
        void SendEmail(string email, string message);
    }
}