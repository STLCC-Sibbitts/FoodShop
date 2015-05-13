using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    enum Gender { Male, Female, Undeclared }
    class Customer
    {
        public int customerID { get; set; }
        public string customerLast { get; set; }
        public string customerFirst { get; set; }
        //public string gender { get; set; }
        public Gender gender { get; set; }
        public string eMail { get; set; }
        public string telephone { get; set; }
        public DateTime birthMonthDay { get; set; }
        public DateTime frequentEnrollDate { get; set; }

        // Constructor
        //public Customer(int id, string lastName, string firstName, string sex, string email, string phone, DateTime birthday, DateTime enrollDate)
        public Customer(int id, string lastName, string firstName, Gender sex, string email, string phone, DateTime birthday, DateTime enrollDate)
        {
            customerID = id;
            customerLast = lastName;
            customerFirst = firstName;
            gender = sex;
            eMail = email;
            telephone = phone;
            birthMonthDay = birthday;
            frequentEnrollDate = enrollDate;
        }


    }
}
