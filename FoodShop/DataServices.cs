/**
 * DataServices class graciously provided by Professor Robert Oberst
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Windows.Forms;

namespace FoodShop
{
    public class DatabaseServices
    {

        private String databaseConString 
            = @"Server=grass.arvixe.com;Initial Catalog=BreadProjectJr; User Id=is283_kmne68; Password=zookie321;";

        public DatabaseServices() 
        {
            //What should happen here?
            //e. g. You could check that the database is available, and throw an exception if it isn't
        }
        public String DbConnectionString 
        {
            get
            {
                return databaseConString;
            }
            set
            {
                databaseConString = value;
            }
        }
       
        public string TestConnection()
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
            string retVal = string.Empty;

            try
            {
                sqlCON.Open();
                retVal = "Successfully Connected!";
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
        public DataTable ExecuteSqlReturnTable(String pSqlToExecute)
        {
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
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
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
            SqlCommand sqlCMD = new SqlCommand();
            int retVal;

            sqlCMD.Connection = sqlCON;
            sqlCMD.CommandType = CommandType.Text;
            sqlCMD.CommandText = pSqlToExecute;

            MessageBox.Show(pSqlToExecute);

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
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
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
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
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
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
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
            SqlConnection sqlCON = new SqlConnection(this.DbConnectionString);
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

         ~DatabaseServices() 
        {
        }
    }
}
