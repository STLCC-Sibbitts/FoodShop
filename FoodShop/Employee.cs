using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShop
{
    class Employee
    {
        private int employeeID { get; set; }
        private string employeeLast { get; set; }
        private string employeeFirst { get; set; }
        private string hireDate { get; set; }
        private int positionID { get; set; }
        private int shiftID { get; set; }
        private double salary { get; set; }
        private bool isActive { get; set; }
        private bool fullTime { get; set; }
        private bool hourly { get; set; }

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
