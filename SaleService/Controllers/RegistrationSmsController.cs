using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Model;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationSmsController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody] UserPhone mail)
        {

        }
    }
}
