using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class Leg
    {
        private static List<Leg> myLeg = new List<Leg>();

        string id;
        string flightid;
        string legnum;
        string flightno;
        string airportOut;
        string airportin;
        string airlinecode;
        string timeOut;
        string timeIn;
        string duration;

        public Leg(string id, string flightid, string legnum, string flightno, string airportOut, string airportin, string airlinecode, string timeOut, string timeIn, string duration)
        {
            Id = id;
            Flightid = flightid;
            Legnum = legnum;
            Flightno = flightno;
            AirportOut = airportOut;
            Airportin = airportin;
            Airlinecode = airlinecode;
            TimeOut = timeOut;
            TimeIn = timeIn;
            Duration = duration;
        }

        public static List<Leg> MyLeg { get => myLeg; set => myLeg = value; }
        public string Id { get => id; set => id = value; }
        public string Flightid { get => flightid; set => flightid = value; }
        public string Legnum { get => legnum; set => legnum = value; }
        public string Flightno { get => flightno; set => flightno = value; }
        public string AirportOut { get => airportOut; set => airportOut = value; }
        public string Airportin { get => airportin; set => airportin = value; }
        public string Airlinecode { get => airlinecode; set => airlinecode = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string Duration { get => duration; set => duration = value; }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertMyLeg(this);
            MyLeg.Add(this);
            return 1;
        }
    }
}