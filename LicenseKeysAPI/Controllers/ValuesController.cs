using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LicenseKeysAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Licenses.License>> Get()
        {
            Licenses.License l1 = new Licenses.License(
                new Guid(),
                "Customer",
                DateTime.UtcNow,
                DateTime.UtcNow.AddYears(1)
            );

            Licenses.License l2 = new Licenses.License(
                new Guid(),
                "Customer Very Long  Description Customer Very Long  Description Customer Very Long  Description Customer Very Long  Description ",
                DateTime.UtcNow,
                DateTime.UtcNow.AddYears(1)
            );
            return new Licenses.License[] { l1, l2 };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
