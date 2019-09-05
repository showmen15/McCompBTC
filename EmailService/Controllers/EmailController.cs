using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public void Post([FromQuery] string EmailTo, [FromQuery] string EmailCc, [FromQuery] string Titel, [FromQuery] string Body)
        {

        }
    }
}
