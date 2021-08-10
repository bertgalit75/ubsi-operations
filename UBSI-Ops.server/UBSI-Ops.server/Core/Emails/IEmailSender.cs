using System.Threading.Tasks;

namespace Ropes.API.Core.Emails
{
    public interface IEmailSender
    {
        Task Send(Email email);
    }
}
