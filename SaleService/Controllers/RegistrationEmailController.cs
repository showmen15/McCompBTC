using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Clients.Email;
using SaleService.Model;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationEmailController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] UserEmail mail)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            httpClient.BaseAddress = new Uri("http://127.0.0.1:4005");

            EmailClient emailClient = new EmailClient(httpClient);
            emailClient.PostAsync("", "", "", "");
        }
    }
}
