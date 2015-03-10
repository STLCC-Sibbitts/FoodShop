using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

/*******************************************************************
 * 
 * This Class was constructed by following this tutorial:
 * 
 * http://www.codeproject.com/Articles/690207/Csharp-Project-on-Database-for-Beginners
 * 
 *******************************************************************/

namespace FoodShop
{
    public abstract class DatabaseConnection
    {
        public SqlConnection sqlCon;
        public SqlTransaction sqlTrans;

        public DatabaseConnection()
        {
            string strProject = "grass.arvixe.com";
            string dbName = "BreadProjectJr";
            string userID = "IS283_kmne68";
            string userPassword = "zookie321";
            string connection = "data source="
                + strProject
                + ";Persist Security Info=false;database="
                + dbName
                + ";user id="
                + userID
                + ";password="
                + userPassword
                + ";Connection Timeout = 0";
            sqlCon = new SqlConnection(connection);
        }


        public void openConnection()
        {
            sqlCon.Close();
            sqlCon.Open();
            sqlTrans = sqlCon.BeginTransaction();
        }


        public void closeConnection()
        {
            sqlTrans.Commit();
            sqlCon.Close();
        }


        public void errorTransaction()
        {
            sqlTrans.Rollback();
            sqlCon.Close();
        }


        protected void ExecuteSQL(string sSQL)
        {
            SqlCommand cmdDate = new SqlCommand(" SET DATEFORMAT dmy", sqlCon, sqlTrans);
            cmdDate.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand(sSQL, sqlCon, sqlTrans);
            cmd.ExecuteNonQuery();
        }


        protected void OnlyExecuteSQL(string sSQL)
        {
            SqlCommand cmd = new SqlCommand(sSQL, sqlCon);
            cmd.ExecuteNonQuery();
        }


        protected DataSet FillDataSet(DataSet dset, string sSQL, string sTable)
        {
            SqlCommand cmd = new SqlCommand(sSQL, sqlCon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            try
            {
                adapter.Fill(dset, sTable);
            }
            finally
            {
                sqlCon.Close();
            }
            return dset;
        }


        protected DataSet FillData(string sSQL, string sTable)
        {
            SqlCommand cmd = new SqlCommand(sSQL, sqlCon, sqlTrans);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, sTable);
            return ds;
        }


        protected SqlDataReader setDataReader(string sSQL)
        {
            SqlCommand cmd = new SqlCommand(sSQL, sqlCon, sqlTrans);
            cmd.CommandTimeout = 300;
            SqlDataReader returnReader;
            returnReader = cmd.ExecuteReader();
            return returnReader;
        }
    }
}
