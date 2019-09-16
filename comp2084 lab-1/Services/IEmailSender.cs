using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp2084_lab_1.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
