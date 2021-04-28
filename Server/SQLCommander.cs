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
        static public DataTable CheckLogin(string login, string password)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [Account] WHERE (Login='" + login.Normalize() + "' AND Password='" + password.Normalize() + "') ";
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            /*
            if (dtbl.Rows.Count == 1)
            {
                return "1";
            }
            return "0";
            */
            return dataTable;
        }





    }
}
