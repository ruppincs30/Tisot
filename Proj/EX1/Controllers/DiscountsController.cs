using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.Net.Http;
using System.Web.Http;
using EX1.Models;

namespace EX1.Controllers
{
    public class DiscountsController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<Discount> Get()
        //{
        //    return Discount.DiscountList;
        //}
        public DataTable Get()
        {
            Discount discount = new Discount();
            return discount.getdiscount();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public DataTable Post([FromBody]Discount discount)
        {
            discount.insert();
            return discount.getdiscount();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //DELETE api/<controller>/5
        public DataTable Delete(int id)
        {
            Discount discount = new Discount();
            discount.deleteRow(id);
            return discount.getdiscount();
        }
    }
}