using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadProjectBetaUno
{
    /// <summary>
    /// Encapsulate Data for Employee Objects
    /// </summary>
    class Employee
    {
        // Click "+" to view the code on regions
        #region Fields
        public const string tableName = "EmployeeTest"; // transfer to dbservices class
        private int employeeId = 0;
        private string lastName;
        private string firstName;
        private int positionId;
        private int shiftId;
        private decimal salary = 0m;
        #endregion

        #region Constructor
        // Default Constructor
        public Employee()
        {

        }
        // Custom Constructor
        public Employee(string lastName, string firstName, int positionId, int shiftId, decimal salary )
        {
            this.employeeId = 0;            // Default Id for newly created employees
            this.lastName = lastName;       // Can be replaced with "string.empty"
            this.firstName = firstName;     // Can be replaced with "string.empty"
            this.positionId = positionId;
            this.shiftId = shiftId;
            this.salary = salary;
        }
        #endregion

        #region Properties
        public int EmployeeId
        {
            get { return employeeId; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public int PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }
        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region Methods
        public Dictionary<int, Employee> GetEmployeeName()
        {
            // New employee will have the default employee number (0)
            var name = new Dictionary<int, Employee>();
            var newEmployee = new Employee(LastName, FirstName, PositionId, ShiftId, Salary);
            name.Add(EmployeeId, newEmployee);
            return name;
        }

        public override string ToString()
        {
            return string.Format("LastName: {0}, FirstName: {1}",
                LastName, FirstName);
        }
        #endregion
       
    }
}
