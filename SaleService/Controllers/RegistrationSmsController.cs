﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Clients.Sms;
using SaleService.DbModel;
using SaleService.Model;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationSmsController : ControllerBase
    {
        private readonly DatabaseBTCContext databaseBTCContext;

        public RegistrationSmsController(DatabaseBTCContext context)
        {
            databaseBTCContext = context;
        }

        [HttpPost]
        public void Post([FromBody] UserPhone phone)
        {
            RegisterUsers registerUsers = new RegisterUsers();
            registerUsers.Name = phone.Name;
            registerUsers.Surname = phone.Surname;
            registerUsers.RegisterUsersPhones = new RegisterUsersPhones();
            registerUsers.RegisterUsersPhones.Phone = phone.Phone;

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

            sendSms(registerUsers, validationCodes);
        }

        private void sendSms(RegisterUsers registerUsers, ValidationCodes validationCodes)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            httpClient.BaseAddress = new Uri("http://127.0.0.1:4010");
            SmsClient emailClient = new SmsClient(httpClient);
            emailClient.PostAsync(registerUsers.RegisterUsersPhones.Phone, string.Format("Your register code: {0}", validationCodes.IdCode.ToString()));
        }
    }
}
