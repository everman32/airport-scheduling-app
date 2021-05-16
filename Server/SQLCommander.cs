using System;
using System.Data;
using System.Data.SqlClient;

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
            sqlCommand.CommandText = "SELECT * FROM Account WHERE (Login=@login AND Password=@password)";
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
            sqlCommand.CommandText = "INSERT INTO Account (Login,Password,AccessRight) VALUES (@login,@password,@accessRight)";
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


        static public DataTable SelectPassenger()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Id [Идентификационный номер пассажира], Surname+@space+Name+@space+Patronymic [ФИО], PhoneNumber [Телефонный номер] FROM Passenger";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@space", " ");
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectPassenger(string surname, string name, string patronymic, string phone_number)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Passenger WHERE ((Surname=@surname AND Name=@name AND Patronymic=@patronymic) OR PhoneNumber=@phone_number)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@patronymic", patronymic);
            sqlCommand.Parameters.AddWithValue("@phone_number", phone_number);
            
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
        static public DataTable InsertPassenger(string surname, string name, string patronymic, string phone_number)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO Passenger (Surname,Name,Patronymic,PhoneNumber) VALUES (@surname,@name,@patronymic,@phoneNumber)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@patronymic", patronymic);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", phone_number);
          
            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check=SQLCommander.SelectPassenger(surname, name, patronymic, phone_number);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectPassenger(surname, name, patronymic, phone_number);
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


        static public DataTable SelectDestination()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Id [Идентификационный номер пункта назначения], Name [Наименование], FlightDuration [Продолжительность полёта], AirplaneModel [Модель самолёта]," +
                "EstimatedTime1 [Первое предлагаемое время], EstimatedTime2 [Второе предлагаемое время], EstimatedTime3 [Третье предлагаемое время], Status [Статус] FROM Destination";
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestination(string name, string flightduration, string airplanemodel,
            string estimatedtime1, string estimatedtime2, string estimatedtime3)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Name=@name AND FlightDuration=@flightduration AND AirplaneModel=@airplanemodel AND " +
                "EstimatedTime1=@estimatedtime1 AND EstimatedTime2=@estimatedtime2 AND EstimatedTime3=@estimatedtime3)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@flightduration", flightduration);
            sqlCommand.Parameters.AddWithValue("@airplanemodel", airplanemodel);
            sqlCommand.Parameters.AddWithValue("@estimatedtime1", estimatedtime1);
            sqlCommand.Parameters.AddWithValue("@estimatedtime2", estimatedtime2);
            sqlCommand.Parameters.AddWithValue("@estimatedtime3", estimatedtime3);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationName(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND Name=@name)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@name", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationFlightduration(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND FlightDuration=@flightduration)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@flightduration", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationAirplanemodel(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND AirplaneModel=@airplanemodel)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@airplanemodel", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationEstimatedtime1(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND EstimatedTime1=@estimatedtime1)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@estimatedtime1", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationEstimatedtime2(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND EstimatedTime2=@estimatedtime2)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@estimatedtime2", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectDestinationEstimatedtime3(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Destination WHERE (Id=@id AND EstimatedTime3=@estimatedtime3)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@estimatedtime3", newvalue);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        static public DataTable SelectEstimatedTimes(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT EstimatedTime1, EstimatedTime2, EstimatedTime3 FROM Destination dest WHERE (dest.Id=@id)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable InsertDestination(string name,string flightduration,string airplanemodel,
            string estimatedtime1,string estimatedtime2,string estimatedtime3)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO Destination (Name,FlightDuration,AirplaneModel," +
                "EstimatedTime1,EstimatedTime2,EstimatedTime3) VALUES (@name,@flightduration,@airplanemodel," +
                "@estimatedtime1,@estimatedtime2,@estimatedtime3)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@flightduration", flightduration);
            sqlCommand.Parameters.AddWithValue("@airplanemodel", airplanemodel);
            sqlCommand.Parameters.AddWithValue("@estimatedtime1", estimatedtime1);
            sqlCommand.Parameters.AddWithValue("@estimatedtime2", estimatedtime2);
            sqlCommand.Parameters.AddWithValue("@estimatedtime3", estimatedtime3);

            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check = SQLCommander.SelectDestination(name, flightduration,airplanemodel, estimatedtime1, estimatedtime2, estimatedtime3);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectDestination(name, flightduration, airplanemodel, estimatedtime1, estimatedtime2, estimatedtime3);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return dataTable;
                }
            }
            return dataTable;
        }
        static public DataTable EditNameDestination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = "UPDATE Destination SET Name=@name WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@name", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();

            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationName(id, newvalue);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditFlightdurationDestination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Destination SET FlightDuration=@flightduration WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@flightduration", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationFlightduration(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditAirplanemodelDestination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Destination SET AirplaneModel=@airplanemodel WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@airplanemodel", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationAirplanemodel(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditEstimatedtime1Destination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Destination SET EstimatedTime1=@estimatedtime1 WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@estimatedtime1", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationEstimatedtime1(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditEstimatedtime2Destination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Destination SET EstimatedTime2=@estimatedtime2 WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@estimatedtime2", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationEstimatedtime2(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public DataTable EditEstimatedtime3Destination(string id, string newvalue)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE Destination SET EstimatedTime3=@estimatedtime3 WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@estimatedtime3", newvalue);
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectDestinationEstimatedtime3(id, newvalue);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public int DeleteDestination(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM Destination WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            int deleted_count = 0;
            try
            {
                deleted_count = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return deleted_count;
            }
            return deleted_count;
        }


        static public DataTable SelectFlightRequests()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT flightrequest.Id [Идентификационный номер заявки], pass.Surname+@space+pass.Name+@space+pass.Patronymic [ФИО пассажира], " +
                "pass.PhoneNumber [Телефонный номер пассажира], dest.Name [Наименование пункта назначения], flightrequest.HighestPriorityTime [Самое приоритетное время], " +
                "flightrequest.MediumPriorityTime [Время, среднее по приоритету], flightrequest.LowestPriorityTime [Время, низшее по приоритету], flightrequest.Status [Статус] " +
                "FROM FlightRequest flightrequest INNER JOIN Passenger pass ON flightrequest.IdPassenger=pass.Id INNER JOIN Destination dest ON flightrequest.IdDestination=dest.Id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@space", " ");
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectFlightRequest(string idpassenger, string iddestination)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM FlightRequest flightrequest WHERE (flightrequest.IdPassenger=@idpassenger AND flightrequest.IdDestination=@iddestination)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@idpassenger", idpassenger);
            sqlCommand.Parameters.AddWithValue("@iddestination", iddestination);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectFlightRequest(string id, string highestprioritytime,
           string mediumprioritytime, string lowestprioritytime)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM FlightRequest flightrequest WHERE (flightrequest.Id=@id AND flightrequest.HighestPriorityTime=@highestprioritytime AND " +
                "flightrequest.MediumPriorityTime=@mediumprioritytime AND flightrequest.LowestPriorityTime=@lowestprioritytime)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@highestprioritytime", DateTime.ParseExact(highestprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@mediumprioritytime", DateTime.ParseExact(mediumprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@lowestprioritytime", DateTime.ParseExact(lowestprioritytime, "dd.MM.yyyy HH:mm:ss", null));

            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectPriorityTimes(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT HighestPriorityTime, MediumPriorityTime, LowestPriorityTime FROM FlightRequest flightrequest WHERE (flightrequest.Id=@id)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectDestinationsNames()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Id, Name FROM Destination";
            sqlCommand.Connection = sqlConnection;
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectPassengersNames()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Id, Surname+@space+Name+@space+Patronymic [ФИО пассажира] FROM Passenger";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@space", " ");
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable InsertFlightRequest(string idpassenger,string iddestination,string highestprioritytime,
           string mediumprioritytime, string lowestprioritytime)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO FlightRequest (IdPassenger, IdDestination, HighestPriorityTime, MediumPriorityTime, LowestPriorityTime) " +
                "VALUES (@idpassenger, @iddestination, @highestprioritytime, " +
                "@mediumprioritytime, @lowestprioritytime)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@idpassenger", idpassenger);
            sqlCommand.Parameters.AddWithValue("@iddestination", iddestination);
            sqlCommand.Parameters.AddWithValue("@highestprioritytime",DateTime.ParseExact(highestprioritytime,"dd.MM.yyyy HH:mm:ss",null));
            sqlCommand.Parameters.AddWithValue("@mediumprioritytime", DateTime.ParseExact(mediumprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@lowestprioritytime", DateTime.ParseExact(lowestprioritytime, "dd.MM.yyyy HH:mm:ss", null));

            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check = SQLCommander.SelectFlightRequest(idpassenger, iddestination);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectFlightRequest(idpassenger, iddestination);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return dataTable;
                }
            }
            return dataTable;
        }
        static public DataTable EditFlightRequest(string id, string highestprioritytime,
           string mediumprioritytime, string lowestprioritytime)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE FlightRequest SET HighestPriorityTime=@highestprioritytime, " +
                "MediumPriorityTime=@mediumprioritytime, LowestPriorityTime=@lowestprioritytime WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@highestprioritytime", DateTime.ParseExact(highestprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@mediumprioritytime", DateTime.ParseExact(mediumprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@lowestprioritytime", DateTime.ParseExact(lowestprioritytime, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@id", id);

            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.ExecuteNonQuery();
                dataTable = SQLCommander.SelectFlightRequest(id, highestprioritytime, mediumprioritytime, lowestprioritytime);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return dataTable;
            }
            return dataTable;
        }
        static public int DeleteFlightRequest(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM FlightRequest WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            int deleted_count = 0;
            try
            {
                deleted_count = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return deleted_count;
            }
            return deleted_count;
        }


        static public DataTable SelectDestinationsNamesCondorcet()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT DISTINCT dest.Id [Идентификационный номер пункта назначения], dest.Name [Наименование пункта назначения] FROM FlightRequest flightrequest " +
                "INNER JOIN Destination dest ON flightrequest.IdDestination = dest.Id";
            sqlCommand.Connection = sqlConnection;
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectEstimatedTimesCondorcet(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Name [Пункт назначения], EstimatedTime1 [Предлагаемое время 1 (a1)], EstimatedTime2 [Предлагаемое время 2 (a2)], EstimatedTime3[Предлагаемое время 3 (a3)] FROM Destination dest WHERE (dest.Id=@id)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectPriorityTimesCondorcet(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT pass.Surname+@space+pass.Name+@space+pass.Patronymic [ФИО пассажира], flightrequest.HighestPriorityTime [Самое приоритетное время], " +
                "flightrequest.MediumPriorityTime[Время, среднее по приоритету], flightrequest.LowestPriorityTime[Время, низшее по приоритету] FROM FlightRequest flightrequest " +
                "INNER JOIN Passenger pass ON flightrequest.IdPassenger = pass.Id INNER JOIN Destination dest ON flightrequest.IdDestination = dest.Id WHERE flightrequest.IdDestination = @id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@space", " ");
            sqlCommand.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }

        static public DataTable SelectSchedule()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT Id [Идентификационный номер полёта], IdDestination [Идентификационный номер пункта назначения], PassengersCount [Количество пассажиров], " +
                "FinalDate [Дата полёта], ReserveDate [Резервная дата полёта] FROM Schedule";
            sqlCommand.Connection = sqlConnection;
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectSchedule(string iddestination, string finaldate)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Schedule schedule WHERE (schedule.IdDestination=@iddestination AND schedule.FinalDate=@finaldate)";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@iddestination", iddestination);
            sqlCommand.Parameters.AddWithValue("@finaldate", DateTime.ParseExact(finaldate, "dd.MM.yyyy HH:mm:ss", null));
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable SelectScheduleWithReserve(string iddestination, string finaldate, string reservedate)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Schedule schedule WHERE (schedule.IdDestination=@iddestination AND ((schedule.FinalDate=@finaldate " +
                "AND schedule.ReserveDate=@reservedate) OR schedule.FinalDate=@finaldate))";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@iddestination", iddestination);
            sqlCommand.Parameters.AddWithValue("@finaldate", DateTime.ParseExact(finaldate, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand.Parameters.AddWithValue("@reservedate", DateTime.ParseExact(reservedate, "dd.MM.yyyy HH:mm:ss", null));
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataTable;
        }
        static public DataTable InsertSchedule(string iddestination,string finaldate)
        {
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.CommandText = "SELECT * FROM FlightRequest flightrequest WHERE (flightrequest.IdDestination=@iddestination)";
            sqlCommand1.Connection = sqlConnection;
            sqlCommand1.Parameters.AddWithValue("@iddestination", iddestination);
            DataTable dataTablepassengers = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            adapter.Fill(dataTablepassengers);

            int passengersCount = dataTablepassengers.Rows.Count;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.CommandText = "INSERT INTO Schedule (IdDestination, PassengersCount , FinalDate) " +
                "VALUES (@iddestination, @passengerscount, @finaldate)";
            sqlCommand2.Connection = sqlConnection;
            sqlCommand2.Parameters.AddWithValue("@iddestination", iddestination);
            sqlCommand2.Parameters.AddWithValue("@passengerscount", passengersCount);
            sqlCommand2.Parameters.AddWithValue("@finaldate", DateTime.ParseExact(finaldate, "dd.MM.yyyy HH:mm:ss", null));
           
            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check = SQLCommander.SelectSchedule(iddestination, finaldate);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand2.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectSchedule(iddestination, finaldate);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return dataTable;
                }
            }
            return dataTable;
        }
        static public DataTable InsertScheduleWithReserve(string iddestination, string finaldate, string reservedate)
        {
            SqlCommand sqlCommand1 = new SqlCommand();
            sqlCommand1.CommandText = "SELECT * FROM FlightRequest flightrequest WHERE (flightrequest.IdDestination=@iddestination)";
            sqlCommand1.Connection = sqlConnection;
            sqlCommand1.Parameters.AddWithValue("@iddestination", iddestination);
            DataTable dataTablepassengers = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand1);
            adapter.Fill(dataTablepassengers);

            int passengersCount = dataTablepassengers.Rows.Count;
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand2.CommandText = "INSERT INTO Schedule (IdDestination, PassengersCount , FinalDate, ReserveDate) " +
                "VALUES (@iddestination, @passengerscount, @finaldate, @reservedate)";
            sqlCommand2.Connection = sqlConnection;
            sqlCommand2.Parameters.AddWithValue("@iddestination", iddestination);
            sqlCommand2.Parameters.AddWithValue("@passengerscount", passengersCount);
            sqlCommand2.Parameters.AddWithValue("@finaldate", DateTime.ParseExact(finaldate, "dd.MM.yyyy HH:mm:ss", null));
            sqlCommand2.Parameters.AddWithValue("@reservedate", DateTime.ParseExact(reservedate, "dd.MM.yyyy HH:mm:ss", null));

            DataTable dataTable = new DataTable();
            DataTable dataTable_check = new DataTable();
            dataTable_check = SQLCommander.SelectScheduleWithReserve(iddestination, finaldate, reservedate);

            if (dataTable_check.Rows.Count == 0)
            {
                try
                {
                    sqlCommand2.ExecuteNonQuery();
                    dataTable = SQLCommander.SelectScheduleWithReserve(iddestination, finaldate, reservedate);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return dataTable;
                }
            }
            return dataTable;
        }
        static public int DeleteSchedule(string id)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM Schedule WHERE Id=@id";
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            int deleted_count = 0;
            try
            {
                deleted_count = sqlCommand.ExecuteNonQuery();
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