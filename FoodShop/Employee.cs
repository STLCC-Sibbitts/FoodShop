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
        private int positionID { get; set; }
        private int shiftID { get; set; }
        private double salary { get; set; }

        // Constructor
        public Employee (int empID, string lastName, string firstName, int posID, int shift, double pay)
        {
            employeeID = empID;
            lastName = employeeLast;
            firstName = employeeFirst;
            positionID = posID;
            shiftID = shift;
            salary = pay;
        }
    }
}
