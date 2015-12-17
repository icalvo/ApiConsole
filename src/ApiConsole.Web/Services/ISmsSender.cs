using System.Threading.Tasks;

namespace ApiConsole.Web.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
