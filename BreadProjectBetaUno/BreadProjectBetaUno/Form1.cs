using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;  // for App.Config
using System.Data.SqlClient; // for Database Connections

namespace BreadProjectBetaUno
{
    public partial class EmployeeForm : Form
    {
        // Create a new instance of DBServices
        DBServices db = new DBServices();
        public EmployeeForm()
        {
            InitializeComponent();
        }   
        // Test Connection
        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.TestConnection());
        }
        // Create Table
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            // Create a new table and pass the read-only SQL statement from the class
            DBServices newTable = new DBServices();
            MessageBox.Show(db.TryCreateTable(newTable.CreateEmployeeTableSQL));
        }
        // Save Data
        private void btnSaveEmpData_Click(object sender, EventArgs e)
        {
            string lName = tbLastName.Text;
            string fName = tbFirstName.Text;
            int positionId = int.Parse(tbxPositionID.Text);
            int shiftId = int.Parse(tbxShiftId.Text);
            decimal salary = decimal.Parse(tbxSalary.Text);
            // Create a new employee object, and pass the input arguments
            // TODO: Input validation
            var newName = new Employee(lName, fName, positionId, shiftId, salary);
            var name = newName.GetEmployeeName();
            // Add the input to database and show status
            MessageBox.Show(db.AddEmployeeData(name[0].LastName, name[0].FirstName, name[0].PositionId, name[0].ShiftId, name[0].Salary));
        }
        // Delete Table
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(db.TryDeleteTable());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
