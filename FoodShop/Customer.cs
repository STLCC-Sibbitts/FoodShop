using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    public enum Gender { Male, Female, Undeclared }
    class Customer
    {
        public int customerID { get; set; }
        public string customerLast { get; set; }
        public string customerFirst { get; set; }
        public int gender { get; set; }
        public string eMail { get; set; }
        public string telephone { get; set; }
        public DateTime birthMonthDay { get; set; }
        public DateTime frequentEnrollDate { get; set; }

        // Constructor
        public Customer(int id, string lastName, string firstName, int sex, string email, string phone, DateTime birthday, DateTime enrollDate)
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
