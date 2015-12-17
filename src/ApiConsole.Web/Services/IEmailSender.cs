using System.Threading.Tasks;

namespace ApiConsole.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
