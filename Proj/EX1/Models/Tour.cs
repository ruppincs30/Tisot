using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class Tour
    {
        private static List<Tour> myTours = new List<Tour>();

        string companyName;
        string email;
        string city;
        string duration;
        string price;
        string description;
        string restaurant;

        public Tour(string companyName, string email, string city, string duration, string price, string description, string restaurant)
        {
            this.companyName = companyName;
            this.email = email;
            this.city = city;
            this.duration = duration;
            this.price = price;
            this.description = description;
            this.restaurant = restaurant;
        }

        public static List<Tour> MyTours { get => myTours; set => myTours = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public string Restaurant { get => restaurant; set => restaurant = value; }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertTours(this);
            MyTours.Add(this);
            return 1;
        }

        public List<Tour> getByCity(string city)
        {
            DBservices dbs = new DBservices();
            return dbs.getToursByCity(city);

        }
    }
}