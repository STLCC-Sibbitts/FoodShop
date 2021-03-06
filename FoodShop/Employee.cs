﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string employeeLast { get; set; }
        public string employeeFirst { get; set; }
        public string hireDate { get; set; }
        public int positionID { get; set; }
        public int shiftID { get; set; }
        public double salary { get; set; }
        public int fullTime { get; set; }
        public int hourly { get; set; }
        public bool isActive { get; set; }

        // Parameterless constructor
        public Employee()
        {
            // default
        }

        // Constructor
        public Employee (int empID, string lastName, string firstName, string hired, int posID,
            int shift, double pay, int fullPart, int paidPerHour, bool active)
        {
            employeeID = empID;
            employeeLast = lastName;
            employeeFirst =firstName;
            hireDate = hired;
            positionID = posID;
            shiftID = shift;
            salary = pay;
            fullTime = fullPart;
            hourly = paidPerHour;
            isActive = active;
        }
    }
}
