/**
 * DBServices class graciously provided by Joe Arcelo
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;              // for Datatable
using System.Configuration;     // for App.Config
using System.Data.SqlClient;    // for Database Connections

namespace BreadProjectBetaUno
{
    class DBServices
    {
        // Click "+" to view the code on regions
        #region Fields
        // Connection name is set to constant (and can only be viewed within class)
        private const string connName = "BPJrConnectionString";
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
        /// Helper method to create a new table. A table can be created using an onclick button
        /// event from the Main(Form1.cs). The SQL statement is created within class.
        /// </summary>
        /// <param name="createTableSQLStatement">Read-only property</param>
        /// <returns>Table creation status</returns>
        public string TryCreateTable(string createTableSQLStatement)
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(createTableSQLStatement, sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        retVal = "Table successfully created!";
                    }
                }
                catch (Exception)
                {
                    retVal = "Opps! The table you want to create already exist in DB.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }
        /// <summary>
        /// Helper Method to delete a table from the SQL server. This will be further modified to dynamically
        /// accept any existing table name. 
        /// </summary>
        /// <returns>Table deletion status</returns>
        public string TryDeleteTable()
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = Employee.tableName;
                    using (SqlCommand cmd = new SqlCommand(
                        "DROP TABLE " + tableName + "", sqlCon))
                    {
                        cmd.ExecuteNonQuery();
                        retVal = "Table successfully deleted!";
                    }
                }
                catch (Exception)
                {
                    retVal = "Opps! The table cannot be deleted.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }

        /// <summary>
        /// Helper method to add new employee data to database. New employees are given employee ids
        /// starting at 100, and succeeding addition is incremented by 1.
        /// </summary>
        /// <param name="lName">Last name of new employee</param>
        /// <param name="fname">First name of new employee</param>
        /// <param name="positionId">Position ID of new employee</param>
        /// <param name="shifId">Shift ID of new employee</param>
        /// <param name="salary">Salary of New Employee</param>
        /// <returns></returns>
        public string AddEmployeeData(string lName, string fname, int positionId, int shifId, decimal salary)
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = Employee.tableName;
                    string insertStatement = "INSERT INTO " + tableName + 
                        " VALUES(@LastName, @FirstName, @PositionID, @ShiftID, @Salary )";
                    using (SqlCommand command = new SqlCommand(
                    insertStatement, sqlCon))
                    {
                        command.Parameters.Add(new SqlParameter("LastName", lName));
                        command.Parameters.Add(new SqlParameter("FirstName", fname));
                        command.Parameters.Add(new SqlParameter("PositionID", positionId));
                        command.Parameters.Add(new SqlParameter("ShiftID", shifId));
                        command.Parameters.Add(new SqlParameter("Salary", salary));
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


        /*********Below are unused helper methods ***************/
        public DataTable ExecuteSqlReturnTable(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();
            SqlDataAdapter sqlDA = new SqlDataAdapter();

            DataTable datReturn = new DataTable();

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;

            try
            {
                sqlDA.SelectCommand = sqlCMD;
                sqlCON.Open();
                sqlDA.Fill(datReturn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //Clean up resources...
                sqlCON.Close();
                sqlCON.Dispose();
                sqlCMD.Dispose();
                sqlDA.Dispose();
            }
            return datReturn;
        }
        public int ExecuteNonQueryReturnRowCount(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();
            int retVal;

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;
            sqlCMD.CommandTimeout = 300;

            sqlCON.Open();
            retVal = sqlCMD.ExecuteNonQuery();
            sqlCON.Close();

            //Clean up resources...
            sqlCON.Dispose();
            sqlCMD.Dispose();

            return retVal;
        }
        public String ExecuteNonQueryReturnError(String pSqlToExecute)
        {
            String retValue = string.Empty;
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;
            sqlCMD.CommandTimeout = 300;

            sqlCON.Open();

            try
            {
                sqlCMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                retValue = ex.Message;
            }
            finally
            {
                //Clean up resources...
                sqlCON.Close();
                sqlCON.Dispose();
                sqlCMD.Dispose();
            }
            return retValue;
        }
        public Object ExecuteScalar(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();
            Object retVal;

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;

            sqlCON.Open();

            retVal = sqlCMD.ExecuteScalar();

            //Clean up resources...
            sqlCON.Close();
            sqlCON.Dispose();
            sqlCMD.Dispose();

            return retVal;
        }
        public DataTable ExecuteSqlReturnTable(SqlCommand pSqlCommandObject)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            DataTable datReturn = new DataTable();

            pSqlCommandObject.Connection = sqlCON;
            sqlDA.SelectCommand = pSqlCommandObject;
            sqlCON.Open();
            sqlDA.Fill(datReturn);
            sqlCON.Close();

            //Clean up resources...
            sqlCON.Dispose();
            pSqlCommandObject.Dispose();
            sqlDA.Dispose();

            return datReturn;
        }
        public DataSet ExecuteSqlReturnDataSet(SqlCommand pSqlCommandObject)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            DataSet datReturn = new DataSet();

            pSqlCommandObject.Connection = sqlCON;
            sqlDA.SelectCommand = pSqlCommandObject;
            sqlCON.Open();
            sqlDA.Fill(datReturn);
            sqlCON.Close();

            //Clean up resources...
            sqlCON.Dispose();
            pSqlCommandObject.Dispose();
            sqlDA.Dispose();

            return datReturn;
        }
        #endregion 
    }
}
