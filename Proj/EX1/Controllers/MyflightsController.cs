﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class MyflightsController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<MyFlight> Get()
        //{
        //    return MyFlight.MyFlightlist;
        //}

        //[HttpPut]
        //[Route("api/cars/discount")]
        public DataTable Get()
        {
            MyFlight myFlight = new MyFlight();
            return myFlight.getflight();
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        public void Post([FromBody]MyFlight myFlight)
        {
            myFlight.insert();

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