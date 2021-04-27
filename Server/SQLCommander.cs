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
            /*
            Console.WriteLine("База данных Airport подключена");*/
        }
        static public string CheckLogin(StringBuilder login, StringBuilder password)
        {
            SqlCommand sqlCommand = new SqlCommand();
            string query;
            query = sqlCommand.CommandText = "SELECT * FROM Account WHERE Login='" + login + "' AND Password='" + password + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                return "1";
            }
            return "0";
        }





    }
}
