using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WEBUI.Services
{
    public interface IEmailSender
    {
        // smtp => gmail, hotmail vs.
        // api => sendgrid, hizmet aldığınız server...

        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
