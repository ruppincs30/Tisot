using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class AdminController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost]
        [Route("api/admin/login")]
        public HttpResponseMessage Login([FromBody] Admin admin)
        {
            if (admin.Login())
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Welcome");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "invalid user name or password");
            }

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}