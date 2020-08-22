using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class ToursController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Tour> Get()
        {
            return Tour.MyTours;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
        public IEnumerable<Tour> Get(string city)
        {
            Tour tour = new Tour(null,null, null, null, null, null, null);
            return tour.getByCity(city);
        }

        // POST api/<controller>
        public void Post([FromBody] Tour tour)
        {
            tour.insert();
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