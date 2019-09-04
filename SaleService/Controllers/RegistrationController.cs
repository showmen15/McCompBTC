using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        //// GET: api/Registration
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Registration/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Registration
        //[HttpPost]
        //public void Post([FromBody] string e_mail)
        //{

        //}

        //// PUT: api/Registration/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpPut("{Email}")]
        [HttpPost]
        public void Put([FromBody] string eMail)
        {

        }

        //[HttpPut("{TelephoneNumber}")]
        [HttpPost]
        public void Put([FromBody] int telephoneNumber)
        {

        }

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
