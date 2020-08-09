using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class Airline
    {
            private static List<Airline> airlineList = new List<Airline>();
            string code;
            string name;
           

            public Airline(string code, string name)
            {
                Code = code;
                Name = name;
                
            }

        public static List<Airline> AirlineList { get => airlineList; set => airlineList = value; }

        public string Code { get => code; set => code = value; }
            public string Name { get => name; set => name = value; }
        

            public int insert()
            {
                DBservices dbs = new DBservices();
                int numAffected = dbs.insertAirline(this);
                AirlineList.Add(this);
                return 1;
            }
        }
    
}