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
        //TODO: Move this to app.config for security
        //private String databaseConString
        //    = @"Server=grass.arvixe.com;Initial Catalog=BreadProjectJr; User Id=is283_kmne68; Password=zookie321;";


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

        #endregion
    }
}
