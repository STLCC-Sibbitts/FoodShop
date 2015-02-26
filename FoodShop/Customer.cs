using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    class Customer
    {
        private int customerID { get; set; }
        private string customerLast { get; set; }
        private string customerFirst { get; set; }
        private string gender { get; set; }
        private string eMail { get; set; }
        private string telephone { get; set; }
        private DateTime birthMonthDay { get; set; }
        private DateTime frequentEnrollDate { get; set; }

        // Constructor
        public Customer(int id, string lastName, string firstName, string sex, string email, string phone, DateTime birthday, DateTime enrollDate)
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
