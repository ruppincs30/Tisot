using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EX1.Models
{
    public class Admin
    {
        string name;
        string password;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public bool Login()
        {
            if (Name == "admin" && Password == "admin")
            {
                return true;
            }
            else
                return false;
        }

      

    }

}