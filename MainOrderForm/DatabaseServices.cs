using System;
using System.Data;
using System.Data.SqlClient;

namespace MainOrderForm
{
	public class DatabaseServices
	{
		private string connectionString = @"Server=<server name>\<SS Instance name>;Initial Catalog=xxxxxx; User Id=xxxxx; Password=xxxxx;";

		/// <summary>
		/// Verify's the database is available, and throws an exception if it isn't
		/// If the connection was unable to open, the exception message will be contained in the result string.
		/// </summary>
		public DatabaseServices( string connectionString, bool testConnection = true )
		{
			this.ConnectionString = connectionString;
			if ( testConnection )
			{
				var result = this.TestConnection();
				if ( result != "SUCCESS" )
				{
					throw new Exception( result );
				}
			}
		}

		public string ConnectionString
		{
			get
			{
				return this.connectionString;
			}
			set
			{
				this.connectionString = value;
			}
		}
		public string TestConnection()
		{
			var sqlConnection = new SqlConnection( this.ConnectionString );
			string result;

			try
			{
				sqlConnection.Open();
				result = "SUCCESS";
			}
			catch ( Exception ex )
			{
				result = ex.Message;
			}
			finally
			{
				sqlConnection.Close();
				sqlConnection.Dispose();
			}

			return result;
		}
		public DataTable ExecuteSqlReturnTable( string pSqlToExecute )
		{
			var sqlConnection = new SqlConnection( this.ConnectionString );
			var sqlCommand = new SqlCommand();
			var sqlDataAdapter = new SqlDataAdapter();

			var datReturn = new DataTable();

			sqlCommand.Connection = sqlConnection;
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = pSqlToExecute;

			try
			{
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlConnection.Open();
				sqlDataAdapter.Fill( datReturn );
			}
			finally
			{
				//Clean up resources...
				sqlConnection.Close();
				sqlConnection.Dispose();
				sqlCommand.Dispose();
				sqlDataAdapter.Dispose();
			}

			return datReturn;
		}
		public int ExecuteNonQueryReturnRowCount( string pSqlToExecute )
		{
			int rowCount;
			using ( var sqlConnection = new SqlConnection( this.ConnectionString ) )
			{
				var sqlCommand = new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = pSqlToExecute,
					CommandTimeout = 1000
				};

				sqlConnection.Open();
				rowCount = sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();

				//Clean up resources...
				sqlCommand.Dispose();
			}

			return rowCount;
		}
		public string ExecuteNonQueryReturnError( string pSqlToExecute )
		{
			var retValue = string.Empty;
			using ( var sqlConnection = new SqlConnection( this.ConnectionString ) )
			{
				var sqlCommand = new SqlCommand
				{
					Connection = sqlConnection,
					CommandType = CommandType.Text,
					CommandText = pSqlToExecute,
					CommandTimeout = 1000
				};

				sqlConnection.Open();

				try
				{
					sqlCommand.ExecuteNonQuery();
				}
				catch ( Exception ex )
				{
					retValue = ex.Message;
				}
				finally
				{
					sqlCommand.Dispose();
				}
			}
			return retValue;
		}
		public object ExecuteScalar( string pSqlToExecute )
		{
			using ( var sqlConnection = new SqlConnection( this.ConnectionString ) )
			using ( var sqlCommand = new SqlCommand( pSqlToExecute, sqlConnection ) )
			{
				sqlConnection.Open();
				return sqlCommand.ExecuteScalar();
			}
		}

		public DataTable ExecuteSqlReturnTable( SqlCommand sqlCommand )
		{
			var sqlConnection = new SqlConnection( this.ConnectionString );
			var sqlDataAdapter = new SqlDataAdapter();
			var dataTable = new DataTable();

			sqlCommand.Connection = sqlConnection;
			sqlDataAdapter.SelectCommand = sqlCommand;
			sqlConnection.Open();
			sqlDataAdapter.Fill( dataTable );
			sqlConnection.Close();

			//Clean up resources...
			sqlConnection.Dispose();
			sqlCommand.Dispose();
			sqlDataAdapter.Dispose();

			return dataTable;
		}
		public DataSet ExecuteSqlReturnDataSet( SqlCommand pSqlCommandObject, bool fillSchema = false, string tableName = null )
		{
			var sqlConnection = new SqlConnection( this.ConnectionString );
			var sqlDataAdapter = new SqlDataAdapter();
			var dataSet = new DataSet();

			pSqlCommandObject.Connection = sqlConnection;
			sqlDataAdapter.SelectCommand = pSqlCommandObject;

			sqlConnection.Open();
			if ( fillSchema )
			{
				sqlDataAdapter.Fill( dataSet, tableName );
				sqlDataAdapter.FillSchema( dataSet.Tables[tableName], SchemaType.Source );
			}
			else
			{
				sqlDataAdapter.Fill( dataSet );
			}

			sqlConnection.Close();

			//Clean up resources...
			sqlConnection.Dispose();
			pSqlCommandObject.Dispose();
			sqlDataAdapter.Dispose();

			return dataSet;
		}
	}
}