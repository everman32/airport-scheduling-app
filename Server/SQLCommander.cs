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
            sqlCommand.CommandText = "SELECT * FROM [Account] WHERE (Login=@login AND Password=@password)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@password", password);
 
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            return dataTable;
        }
       static public DataTable InsertAccount(string login, string password,string accessRight)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [Account] (Login,Password,AccessRight) VALUES (@login,@password,@accessRight)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@login", login);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@accessRight", accessRight);
  
            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectAccount(login, password);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable SelectPassenger(string id, string surname, string name, string patronymic, string phone_number)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM [Passenger] WHERE (Id=@id OR (Surname=@surname AND Name=@name AND Patronymic=@patronymic) OR PhoneNumber=@phone_number)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@patronymic", patronymic);
            sqlCommand.Parameters.AddWithValue("@phone_number", phone_number);
            
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectPassenger()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Passenger";
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectPassenger(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Passenger WHERE (Id=@id AND (Surname=@surname OR Name=@name OR Patronymic=@patronymic OR PhoneNumber=@phonenumber))";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@surname", newvalue);
            sqlCommand.Parameters.AddWithValue("@name", newvalue);
            sqlCommand.Parameters.AddWithValue("@patronymic", newvalue);
            sqlCommand.Parameters.AddWithValue("@phonenumber", newvalue);


            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable InsertPassenger(string id,string surname, string name, string patronymic, string phone_number)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [Passenger] (Id,Surname,Name,Patronymic,PhoneNumber) VALUES (@id,@surname,@name,@patronymic,@phoneNumber)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@patronymic", patronymic);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", phone_number);
          
            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check=SQLCommander.SelectPassenger(id, surname, name, patronymic, phone_number);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectPassenger(id, surname, name, patronymic, phone_number);
                }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                    return dataTable;
                }
            }
            return dataTable;
        }
        static public DataTable EditSurnamePassenger(string id,string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
         
            sqlCommand.CommandText = "UPDATE Passenger SET Surname=@surname WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@surname", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectPassenger(id, newvalue);
      
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditNamePassenger(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Passenger SET Name=@name WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@name", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectPassenger(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditPatronymicPassenger(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Passenger SET Patronymic=@patronymic WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@patronymic", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectPassenger(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditPhonenumberPassenger(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Passenger SET PhoneNumber=@phonenumber WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@phonenumber", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectPassenger(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public int DeletePassenger(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM Passenger WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            int deleted_count=0;
            try
            {
                deleted_count=sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return deleted_count;
            }
            return deleted_count;
        }

    }
}
