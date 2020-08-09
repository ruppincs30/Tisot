using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EX1.Models
{
    public class Airport
    {
        private static List<Airport> airportList = new List<Airport>();
        string code;
        string name;
        string lon;
        string lat;
        string city;
        string country;

        public Airport(string code, string name, string lon, string lat, string city, string country)
        {
            Code = code;
            Name = name;
            Lon = lon;
            Lat = lat;
            City = city;
            Country = country;
        }

        public static List<Airport> AirportList { get => airportList; set => airportList = value; }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Lon { get => lon; set => lon = value; }
        public string Lat { get => lat; set => lat = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertAirport(this); 
            AirportList.Add(this);
            return 1;
        }
    }
}