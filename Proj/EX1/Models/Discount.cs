using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;

namespace EX1.Models
{
    public class Discount
    {
        private static List<Discount> discountList = new List<Discount>();

        string code;
        string cityFrom;
        string cityTo;
        string timeOut;
        string timeIn;
        string companyDiscount;

        public Discount(string code, string cityFrom, string cityTo, string timeOut, string timeIn, string companyDiscount)
        {

            Code = code;
            CityFrom = cityFrom;
            CityTo = cityTo;
            TimeOut = timeOut;
            TimeIn = timeIn;
            CompanyDiscount = companyDiscount;
        }

        public Discount()
        {

        }

        public static List<Discount> DiscountList { get => discountList; set => discountList = value; }
        public string Code { get => code; set => code = value; }
        public string CityFrom { get => cityFrom; set => cityFrom = value; }
        public string CityTo { get => cityTo; set => cityTo = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string CompanyDiscount { get => companyDiscount; set => companyDiscount = value; }
       

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertDiscount(this);
            discountList.Add(this);
            return 1;
        }

        public DataTable getdiscount()
        {
            DBservices dbs = new DBservices();
            dbs = dbs.readDiscount();
            return dbs.dt;
            ////dbs.update();
            //return 0;
        }
        public int deleteRow(int id)
        {
            DBservices dbs = new DBservices();
            dbs.deleterow(id);
            return 1;
        }



    }
}