using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;              // for Datatable
using System.Configuration;     // for App.Config, should also be added to project reference
using System.Data.SqlClient;    // for Database Connections

namespace FoodShop
{
    // This will be the class for all things related to database
    // All other database related classes will be migrated here....
    class DBServices
    {
        // Click "+" to view the code on regions
        #region Fields
        // Connection name is set to constant (and can only be viewed within class)
        private const string connName = "KeithConnectionString";
        // SQL Statement to create the Employee Table
        private string createEmployeeTableSQL =
            "CREATE TABLE EmployeeTest (EmployeeID int IDENTITY(100,1), " +
                "EmployeeLast varchar(100), " +
                "EmployeeFirst varchar(100), " +
                "PositionID int," +
                "ShiftID int, " +
                "Salary money, " +
                "Primary Key (EmployeeID))";
        // Backing field for connection string

        private String dbConnString;    // TODO: Evaluate encapsulation property
        #endregion

        #region Constructor
        /// <summary>
        /// Retrieve the connection string from App.Config file when a new DBServices object is created,
        /// and throws and exception if it fails. You can check the details of the connection string by
        /// double clicking the App.Config file.
        /// </summary>
        public DBServices()
        {
            try
            {
                this.dbConnString = ConfigurationManager.ConnectionStrings[connName].ConnectionString;
            }
            catch (Exception ce)
            {
                throw new ApplicationException("Unable to get DB Connection String from Config File. " + ce);
            }
        }
        #endregion

        #region Properties
        public String CreateEmployeeTableSQL
        {
            get { return createEmployeeTableSQL; }
        }
        public String DbConnString
        {
            get
            {
                return dbConnString;
            }
            private set // set to private to make it a read-only property
            {
                dbConnString = value;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Test the connection using the database connection string
        /// </summary>
        /// <returns>Connection status</returns>
        public string TestConnection()
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            string retVal = string.Empty;
            try
            {
                sqlCON.Open();
                retVal = "Successfully Connected to DB!";
            }
            catch (Exception ex)
            {
                retVal = ex.Message;
            }
            finally
            {
                sqlCON.Close();
                sqlCON.Dispose();
            }
            return retVal;
        }

        /// <summary>
        /// Helper method to add new employee data to database.
        /// </summary>
        /// <param name="emp">Employee Object</param>
        /// <returns> Status </returns>
        public string SaveData(Employee emp)
        {
            string retVal = String.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "Employees";
                    string insertStatement = "INSERT INTO " + tableName +
                        " VALUES(@LastName, @FirstName, @HireDate, @PositionID, @ShiftID, @Salary, @FullTime, @Hourly, @IsActive)";
                    using (SqlCommand command = new SqlCommand(
                    insertStatement, sqlCon))
                    {
                        //command.Parameters.Add(new SqlParameter("ID", emp.employeeID));
                        command.Parameters.Add(new SqlParameter("LastName", emp.employeeLast));
                        command.Parameters.Add(new SqlParameter("FirstName", emp.employeeFirst));
                        command.Parameters.Add(new SqlParameter("HireDate", emp.hireDate));
                        command.Parameters.Add(new SqlParameter("PositionID", emp.positionID));
                        command.Parameters.Add(new SqlParameter("ShiftID", emp.shiftID));
                        command.Parameters.Add(new SqlParameter("Salary", emp.salary));
                        command.Parameters.Add(new SqlParameter("FullTime", emp.fullTime));
                        command.Parameters.Add(new SqlParameter("Hourly", emp.hourly));
                        command.Parameters.Add(new SqlParameter("IsActive", emp.isActive));
                        command.ExecuteNonQuery();
                    }
                    retVal = "Data Successfully Saved!";
                }
                catch
                {
                    retVal = "Failed to Insert Data.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }

        // TODOs: Overload SaveData Method to accept other objects
        public string saveData(Customer cust)
        {
            string retVal = String.Empty;
            // Put the SQL Connection Here
            return retVal;
        }

        #region Update Data Methods
        public string updateData(Employee emp)
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "Employees";
                    string updateStatement = "UPDATE " + tableName +
                        " SET employeeLast = @LastName, employeeFirst = @FirstName, hireDate = @HireDate," +
                            " positionId = @PositionID, shiftID = @ShiftID, salary = @Salary, fullTime = @FullTime," +
                            " hourly = @Hourly, isActive = @IsActive " +
                        " WHERE employeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(
                    updateStatement, sqlCon))
                    {
                        command.Parameters.AddWithValue("EmployeeID", emp.employeeID);
                        command.Parameters.AddWithValue("LastName", emp.employeeLast);
                        command.Parameters.AddWithValue("FirstName", emp.employeeFirst);
                        command.Parameters.AddWithValue("HireDate", emp.hireDate);
                        command.Parameters.AddWithValue("PositionID", emp.positionID);
                        command.Parameters.AddWithValue("ShiftID", emp.shiftID);
                        command.Parameters.AddWithValue("Salary", emp.salary);
                        command.Parameters.AddWithValue("FullTime", emp.fullTime);
                        command.Parameters.AddWithValue("Hourly", emp.hourly);
                        command.Parameters.AddWithValue("IsActive", emp.isActive);
                        command.ExecuteNonQuery();
                    }
                    retVal = "Data Successfully Updated!";
                }
                catch
                {
                    retVal = "Failed to Update Data.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }
        #endregion



        #endregion
    }
}
