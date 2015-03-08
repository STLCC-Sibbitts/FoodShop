using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace FoodShop
{
    class DatabaseUser : DatabaseConnection
    {
        public int loginID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool logType { get; set; }

        public bool ValidRegLogUser()
        {
            bool userValid = false;
            
            using(SqlCommand cmd = new SqlCommand())
            {
                openConnection();
                SqlDataReader conReader;
                conReader = null;
                cmd.CommandText = "Select * from RegLogUser where username=@userName and UserPassword=@UserPassword";
                cmd.Connection = sqlCon;
                cmd.Transaction = sqlTrans;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                try
                {
                    conReader = cmd.ExecuteReader();

                    while(conReader.Read())
                    {
                        loginID = Convert.ToInt32(conReader["LoginID"]);
                        logType = (bool)conReader["LogType"];
                        userValid = true;
                    }
                }
                catch(Exception ex)
                {
                    errorTransaction();
                    throw new ApplicationException("Something happened in the Login module :", ex);
                }
                finally
                {
                    conReader.Close();
                    closeConnection();
                }
            }
            return userValid;
        }
    }
}