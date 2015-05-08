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
        // private const string connName = "KeithConnectionString";
        private const string connName = "BreadConnectionString";
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
                retVal = "Successfully Connected to BreadProject's Database!";
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

        #region Add New Data Methods
        /// <summary>
        /// Helper method to add new employee data to database.
        /// </summary>
        /// <param name="emp">Employee Object</param>
        /// <returns> Status </returns>
        public string addNewData(Employee emp)
        {
            string retVal = String.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "Employee";
                    string insertStatement = "INSERT INTO " + tableName +
                        " VALUES(@EmployeeLast, @EmployeeFirst, @HireDate, @PositionID, @ShiftID, @Salary, @FullTime, @Hourly, @IsActive)";
                    using (SqlCommand command = new SqlCommand(
                    insertStatement, sqlCon))
                    {
                        //command.Parameters.Add(new SqlParameter("ID", emp.employeeID));
                        command.Parameters.Add(new SqlParameter("EmployeeLast", emp.employeeLast));
                        command.Parameters.Add(new SqlParameter("EmployeeFirst", emp.employeeFirst));
                        command.Parameters.Add(new SqlParameter("HireDate", emp.hireDate));
                        command.Parameters.Add(new SqlParameter("PositionID", emp.positionID));
                        command.Parameters.Add(new SqlParameter("ShiftID", emp.shiftID));
                        command.Parameters.Add(new SqlParameter("Salary", emp.salary));
                        command.Parameters.Add(new SqlParameter("FullTime", emp.fullTime));
                        command.Parameters.Add(new SqlParameter("Hourly", emp.hourly));
                        command.Parameters.Add(new SqlParameter("IsActive", emp.isActive));
                        command.ExecuteNonQuery();
                    }
                    retVal = "New Employee Data Saved!";
                }
                catch
                {
                    retVal = "Failed to Insert New Employee Data.";
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

        #endregion
        public string addNewData(Customer cust)
        {
            string retVal = String.Empty;
            // Put the SQL Connection Here
            return retVal;
        }

        public string addNewData(LineItem li)
        {
            string retVal = String.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "LineItem";
                    string insertStatement = "INSERT INTO " + tableName +
                        " VALUES(@LineItemID, @ProductID, @Quantity, @ProductName, @Price, @ProductDescription, @UpsellID)";
                    using (SqlCommand command = new SqlCommand(
                    insertStatement, sqlCon))
                    {
                        //command.Parameters.Add(new SqlParameter("ID", emp.employeeID));
                        command.Parameters.Add(new SqlParameter("LineItemID", li.LineItemID));
                        command.Parameters.Add(new SqlParameter("ProductID", li.ProductID));
                        command.Parameters.Add(new SqlParameter("Quantity", li.Quantity));
                        command.Parameters.Add(new SqlParameter("ProductName", li.ProductName));
                        command.Parameters.Add(new SqlParameter("Price", li.Price));
                        command.Parameters.Add(new SqlParameter("ProductDescription", li.ProductDescription));
                        command.Parameters.Add(new SqlParameter("UpsellID", li.UpsellID));
                        command.ExecuteNonQuery();
                    }
                    retVal = "New Line Item Data Successfully Saved!";
                }
                catch
                {
                    retVal = "Failed to Insert New Line Item Data.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }

        #region Update Data Methods
        public string updateData(Customer cust)
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "Customer";
                    string updateStatement = "UPDATE " + tableName +
                        " SET CustomerLast = @CustomerLast, CustomerFirst = @CustomerFirst, Gender = @Gender," +
                            " Email = @Email, Telephone = @Telephone, BirthMoDay = @BirthMoDay, FrequentEnrollDate = @FrequentEnrollDate," +
                        " WHERE CustomerID = @CustomerID";
                    using (SqlCommand command = new SqlCommand(
                    updateStatement, sqlCon))
                    {
                        command.Parameters.AddWithValue("CustomerID", cust.customerID);
                        command.Parameters.AddWithValue("CustomerLast", cust.customerLast);
                        command.Parameters.AddWithValue("CustomerFirst", cust.customerFirst);
                        command.Parameters.AddWithValue("Gender", cust.gender);
                        command.Parameters.AddWithValue("Email", cust.eMail);
                        command.Parameters.AddWithValue("Telephone", cust.telephone);
                        command.Parameters.AddWithValue("BirthMoDay", cust.birthMonthDay);
                        command.Parameters.AddWithValue("FrequentEnrollDate", cust.frequentEnrollDate);
                        command.ExecuteNonQuery();
                    }
                    retVal = "Customer Data Successfully Updated!";
                }
                catch
                {
                    retVal = "Failed to Update Customer Data.";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCon.Dispose();
                }
            }
            return retVal;
        }

        public string updateData(Employee emp)
        {
            string retVal = string.Empty;
            using (SqlConnection sqlCon = new SqlConnection(this.DbConnString))
            {
                sqlCon.Open();
                try
                {
                    string tableName = "Employee";
                    string updateStatement = "UPDATE " + tableName +
                        " SET EmployeeLast = @EmployeeLast, EmployeeFirst = @EmployeeFirst, HireDate = @HireDate," +
                            " PositionID = @PositionID, ShiftID = @ShiftID, Salary = @Salary, FullTime = @FullTime," +
                            " Hourly = @Hourly, IsActive = @IsActive " +
                        " WHERE EmployeeID = @EmployeeID";
                    using (SqlCommand command = new SqlCommand(
                    updateStatement, sqlCon))
                    {
                        command.Parameters.AddWithValue("EmployeeID", emp.employeeID);
                        command.Parameters.AddWithValue("EmployeeLast", emp.employeeLast);
                        command.Parameters.AddWithValue("EmployeeFirst", emp.employeeFirst);
                        command.Parameters.AddWithValue("HireDate", emp.hireDate);
                        command.Parameters.AddWithValue("PositionID", emp.positionID);
                        command.Parameters.AddWithValue("ShiftID", emp.shiftID);
                        command.Parameters.AddWithValue("Salary", emp.salary);
                        command.Parameters.AddWithValue("FullTime", emp.fullTime);
                        command.Parameters.AddWithValue("Hourly", emp.hourly);
                        command.Parameters.AddWithValue("IsActive", emp.isActive);
                        command.ExecuteNonQuery();
                    }
                    retVal = "Employee Data Successfully Updated!";
                }
                catch
                {
                    retVal = "Failed to Update Employee Data.";
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

        // Method that takes an SQL query and returns a data table
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

        // Method that executes an sql query
        public string deleteRecord(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();
            string retVal;

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;

            try
            {
                sqlCON.Open();
                sqlCMD.ExecuteNonQuery();
                retVal = "Record Successfully Deleted";
            }
            catch (Exception)
            {
                retVal = "Failed Delete Record This Time";
                //throw;
            }
            finally
            {
                sqlCON.Close();
                sqlCON.Dispose();
                sqlCMD.Dispose();
            }
            return retVal;
        }

        // Method that executes an sql query
        public string executeSQLQuery(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnString);
            SqlCommand sqlCMD = new SqlCommand();
            string retVal;

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;

            try
            {
                sqlCON.Open();
                retVal = Convert.ToString(sqlCMD.ExecuteScalar());
                //retVal = "Record Successfully Deleted";
            }
            catch (Exception)
            {
                retVal = "Failed Delete Record This Time";
                //throw;
            }
            finally
            {
                sqlCON.Close();
                sqlCON.Dispose();
                sqlCMD.Dispose();
            }
            return retVal;
        }


        #endregion
    }
}
