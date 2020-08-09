
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class LegsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Leg> Get()
        {
            return Leg.MyLeg;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]Leg leg)
        {
            leg.insert();
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