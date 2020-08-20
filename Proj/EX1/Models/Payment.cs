using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class Payment
    {
        private static List<Payment> myPayments = new List<Payment>();

        string name;
        string email;
        string owner;
        string cvv;
        string cardNumber;
        string expirationDate;
        string amount;

        public Payment(string name, string email, string owner, string cvv, string cardNumber, string expirationDate, string amount)
        {
            Name = name;
            Email = email;
            Owner = owner;
            Cvv = cvv;
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            Amount = amount;
        }

        public static List<Payment> MyPayments { get => myPayments; set => myPayments = value; }


        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public string Amount { get => amount; set => amount = value; }

        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertPayments(this);
            MyPayments.Add(this);
            return 1;
        }
    }
}