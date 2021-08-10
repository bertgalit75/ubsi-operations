using System.Threading.Tasks;

namespace Ropes.API.Core.Emails
{
    public class NullEmailSender : IEmailSender
    {
        public Task Send(Email email)
        {
            return Task.CompletedTask;
        }
    }
}
