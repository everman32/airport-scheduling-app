using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Server
{
    static class SQLCommander
    {
        static public SqlConnection sqlConnection;

        static public void ConnectToDatabase()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = Airport; Integrated Security = True;";
            sqlConnection.Open();
            
            Console.WriteLine("База данных Airport подключена");
        }
        static public DataTable SelectAccount(string login, string password)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [Account] WHERE (Login='" + login.Normalize() + "' AND Password='" + password.Normalize() + "')";
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            return dataTable;
        }

        static public DataTable InsertAccount(string login, string password,string typeAccount)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [Account] (Login,Password,TypeAccount) VALUES (@Login,@Password,@TypeAccount)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@Login", login);
            sqlCommand.Parameters.AddWithValue("@Password", password);
            sqlCommand.Parameters.AddWithValue("@TypeAccount", typeAccount);

            DataTable dataTable = new DataTable();

            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectAccount(login, password);
            }
            catch
            {
                return dataTable;
            }
            return dataTable;
        }

        static public DataTable SelectClients()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [Client]";
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }




    }
}
