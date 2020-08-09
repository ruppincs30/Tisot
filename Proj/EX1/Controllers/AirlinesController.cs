using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class AirlinesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Airline> Get()
        {
            return Airline.AirlineList;
        }

      

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
      

        // POST api/<controller>
        public void Post([FromBody]Airline airline)
        {
            airline.insert();
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