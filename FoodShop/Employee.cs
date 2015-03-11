using System;
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
        public bool isActive { get; set; }
        public bool fullTime { get; set; }
        public bool hourly { get; set; }

        // Parameterless constructor
        public Employee()
        {
            // default
        }

        // Constructor
        public Employee (int empID, string lastName, string firstName, int posID, string hired,
            int shift, double pay, bool active, bool fullPart, bool perHour)
        {
            employeeID = empID;
            employeeLast = lastName;
            employeeFirst =firstName;
            hireDate = hired;
            positionID = posID;
            shiftID = shift;
            salary = pay;
            isActive = active;
            fullTime = fullPart;
            hourly = perHour;
        }
    }
}
