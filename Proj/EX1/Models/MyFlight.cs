using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class MyFlight
    {

        private static List<MyFlight> myFlightlist = new List<MyFlight>();
        string name;
        string email;
        string id;
        string airportOut;
        string airportin;
        string timeOut;
        string timeIn;
        string duration;
        string cost;
        string stop;

        public MyFlight(string id, string airportOut, string airportin, string timeOut, string timeIn, string duration, string cost, string stop, string name, string email)
        {
            Id = id;
            AirportOut = airportOut;
            Airportin = airportin;
            TimeOut = timeOut;
            TimeIn = timeIn;
            Duration = duration;
            Cost = cost;
            Stop = stop;
            Name = name;
            Email = email;
        }

        public MyFlight()
        {
        }

        public static List<MyFlight> MyFlightlist { get => myFlightlist; set => myFlightlist = value; }
        public string Id { get => id; set => id = value; }
        public string AirportOut { get => airportOut; set => airportOut = value; }
        public string Airportin { get => airportin; set => airportin = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Cost { get => cost; set => cost = value; }
        public string Stop { get => stop; set => stop = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertMyFlight(this);
            MyFlightlist.Add(this);
            return 1;
        }


        public DataTable getflight()
        {
            DBservices dbs = new DBservices();
            dbs = dbs.readFlight();
            return dbs.dt;
            ////dbs.update();
            //return 0;
        }
        //public List<MyFlight> get()
        //{
        //    DBservices dbs = new DBservices();
        //    return dbs.getFlight();

        //}
    }
}
