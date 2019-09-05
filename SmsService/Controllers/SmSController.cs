using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmSController : ControllerBase
    {
        [HttpPost]
        public void Post([FromQuery] long PhoneNumber, [FromQuery] string Text)
        {

        }
    }
}
