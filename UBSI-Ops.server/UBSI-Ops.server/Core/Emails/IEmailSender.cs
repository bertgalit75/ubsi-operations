using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UBSI_Ops.server.Core.Emails
{
    public interface IEmailSender
    {
        Task Send(Email email);
    }
}
