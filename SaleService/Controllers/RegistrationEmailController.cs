using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Clients.Email;
using SaleService.DbModel;
using SaleService.Model;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationEmailController : ControllerBase
    {
        private readonly DatabaseBTCContext databaseBTCContext;

        public RegistrationEmailController(DatabaseBTCContext context)
        {
            databaseBTCContext = context;
        }

        [HttpPost]
        public void Post([FromBody] UserEmail mail)
        {
            RegisterUsers registerUsers = new RegisterUsers();
            registerUsers.Name = mail.Name;
            registerUsers.Surname = mail.Surname;
            registerUsers.RegisterUsersEmails = new RegisterUsersEmails();
            registerUsers.RegisterUsersEmails.Email = mail.Email;

            databaseBTCContext.RegisterUsers.Add(registerUsers);
            databaseBTCContext.SaveChanges();

            ValidationCodes validationCodes = new ValidationCodes();
            validationCodes.IdUser = registerUsers.IdUser;

            databaseBTCContext.ValidationCodes.Add(validationCodes);
            databaseBTCContext.SaveChanges();

            Wallet wallet = new Wallet();
            wallet.AdressName = string.Format("Wallet adress for: {0}", validationCodes.IdCode);
            wallet.IdCode = validationCodes.IdCode;

            databaseBTCContext.Wallet.Add(wallet);
            databaseBTCContext.SaveChanges();

            sendEmail(registerUsers, validationCodes);
        }

        private void sendEmail(RegisterUsers registerUsers, ValidationCodes validationCodes)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            httpClient.BaseAddress = new Uri("http://127.0.0.1:4005");
            EmailClient emailClient = new EmailClient(httpClient);
            emailClient.PostAsync(registerUsers.RegisterUsersEmails.Email, "", "Your register code", validationCodes.IdCode.ToString());
        }
    }
}
