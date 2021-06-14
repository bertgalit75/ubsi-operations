using System.Threading.Tasks;

namespace UBSI_Ops.server.Core.Emails
{
    public class NullEmailSender : IEmailSender
    {
        public Task Send(Email email)
        {
            return Task.CompletedTask;
        }
    }
}
