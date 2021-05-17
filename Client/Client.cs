using System;
using System.Text;
using System.Net.Sockets;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    [Serializable]
    public class Client
    {
        static public TcpClient client;
        static public NetworkStream stream;
        static public string login;
        static public string password;
        static public int accessRight;
        public Client(string address, int port)
        {
            client = new TcpClient(address, port);
            stream = client.GetStream();
        }
        public void connectClient()
        {
            byte[] data = Encoding.Unicode.GetBytes("Клиент подключён");

            stream.Write(data, 0, data.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);
        }
        static public void SendRequestToServer(string Request)
        {
            byte[] request = Encoding.Unicode.GetBytes(Request);
            stream.Write(request, 0, request.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);
        }
        static public DataTable ReceiveAuthorizeData(string Login, string Password)
        {
            byte[] login = Encoding.Unicode.GetBytes(Login);
            stream.Write(login, 0, login.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] password = Encoding.Unicode.GetBytes(Password);
            stream.Write(password, 0, password.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveRegisterData(string Login, string Password, int AccessRight)
        {
            byte[] login = Encoding.Unicode.GetBytes(Login);
            stream.Write(login, 0, login.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] password = Encoding.Unicode.GetBytes(Password);
            stream.Write(password, 0, password.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] accessRight = Encoding.Unicode.GetBytes(AccessRight.ToString());
            stream.Write(accessRight, 0, accessRight.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }

        static public DataTable ReceiveSelectPassengers()
        {
            byte[] data = new byte[100000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveAddPassengerData(string Surname, string Name, string Patronymic, string PhoneNumber)
        {
            byte[] surname = Encoding.Unicode.GetBytes(Surname);
            stream.Write(surname, 0, surname.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] name = Encoding.Unicode.GetBytes(Name);
            stream.Write(name, 0, name.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] patronymic = Encoding.Unicode.GetBytes(Patronymic);
            stream.Write(patronymic, 0, patronymic.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] phonenumber = Encoding.Unicode.GetBytes(PhoneNumber);
            stream.Write(phonenumber, 0, phonenumber.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveEditPassengerData(string Id, string Newvalue, string Command)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] newvalue = Encoding.Unicode.GetBytes(Newvalue);
            stream.Write(newvalue, 0, newvalue.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] command = Encoding.Unicode.GetBytes(Command.ToString());
            stream.Write(command, 0, command.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public int ReceiveDeletePassengerData(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            int deleted_count = BitConverter.ToInt32(data);
            Array.Clear(data, 0, data.Length);
            return deleted_count;
        }


        static public DataTable ReceiveSelectDestinations()
        {
            byte[] data = new byte[100000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveAddDestinationData(string Name, string Flightduration, string Airplanemodel, string Estimatedtime1, string Estimatedtime2, string Estimatedtime3)
        {
            byte[] name = Encoding.Unicode.GetBytes(Name);
            stream.Write(name, 0, name.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] flightduration = Encoding.Unicode.GetBytes(Flightduration);
            stream.Write(flightduration, 0, flightduration.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] airplanemodel = Encoding.Unicode.GetBytes(Airplanemodel);
            stream.Write(airplanemodel, 0, airplanemodel.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] estimatedtime1 = Encoding.Unicode.GetBytes(Estimatedtime1);
            stream.Write(estimatedtime1, 0, estimatedtime1.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] estimatedtime2 = Encoding.Unicode.GetBytes(Estimatedtime2);
            stream.Write(estimatedtime2, 0, estimatedtime2.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] estimatedtime3 = Encoding.Unicode.GetBytes(Estimatedtime3);
            stream.Write(estimatedtime3, 0, estimatedtime3.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveEditDestinationData(string Id, string Newvalue, string Command)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] newvalue = Encoding.Unicode.GetBytes(Newvalue);
            stream.Write(newvalue, 0, newvalue.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] command = Encoding.Unicode.GetBytes(Command.ToString());
            stream.Write(command, 0, command.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public int ReceiveDeleteDestinationData(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            int deleted_count = BitConverter.ToInt32(data);
            Array.Clear(data, 0, data.Length);
            return deleted_count;
        }


        static public DataTable ReceiveSelectFlightRequests()
        {
            byte[] data = new byte[100000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectDestinationsNames()
        {
            byte[] data = new byte[10000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectPassengersNames()
        {
            byte[] data = new byte[10000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectEstimatedTimes(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveAddFlightRequestData(string idPassenger, string idDestination,
                string highestPrioritytime, string mediumPrioritytime, string lowestPrioritytime)
        {
            byte[] idpassenger = Encoding.Unicode.GetBytes(idPassenger);
            stream.Write(idpassenger, 0, idpassenger.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] iddestination = Encoding.Unicode.GetBytes(idDestination);
            stream.Write(iddestination, 0, iddestination.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] highestprioritytime = Encoding.Unicode.GetBytes(highestPrioritytime);
            stream.Write(highestprioritytime, 0, highestprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] mediumprioritytime = Encoding.Unicode.GetBytes(mediumPrioritytime);
            stream.Write(mediumprioritytime, 0, mediumprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] lowestprioritytime = Encoding.Unicode.GetBytes(lowestPrioritytime);
            stream.Write(lowestprioritytime, 0, lowestprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveEditFlightRequestData(string Id, string highestPrioritytime,
            string mediumPrioritytime, string lowestPrioritytime)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] highestprioritytime = Encoding.Unicode.GetBytes(highestPrioritytime);
            stream.Write(highestprioritytime, 0, highestprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] mediumtprioritytime = Encoding.Unicode.GetBytes(mediumPrioritytime);
            stream.Write(mediumtprioritytime, 0, mediumtprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] lowestprioritytime = Encoding.Unicode.GetBytes(lowestPrioritytime);
            stream.Write(lowestprioritytime, 0, lowestprioritytime.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectPriorityTimes(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public int ReceiveDeleteFlightRequestData(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            int deleted_count = BitConverter.ToInt32(data);
            Array.Clear(data, 0, data.Length);
            return deleted_count;
        }


        static public DataTable ReceiveSelectDestinationsNamesCondorcet()
        {
            byte[] data = new byte[10000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectEstimatedTimesCondorcet(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectPriorityTimesCondorcet(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectPreferencesCondorcet(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTablepreferences = GetDataTable(data);
            Array.Clear(data, 0, data.Length);

            return dataTablepreferences;
        }
        static public DataTable ReceiveSelectPairwiseComparison(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTablePairwiseComparison = GetDataTable(data);
            Array.Clear(data, 0, data.Length);

            return dataTablePairwiseComparison;
        }
        static public int[] ReceiveSearchBestAlternative(int[,] matrixPairwiseComparison, int matrixPairwiseComparison_count)
        {
            DataTable dataTablePairwiseComparison = new DataTable();

            for (int i = 0; i < matrixPairwiseComparison_count; i++)
            {
                dataTablePairwiseComparison.Columns.Add();
            }
            for (int i = 0; i < matrixPairwiseComparison_count; i++)
            {
                DataRow row = dataTablePairwiseComparison.NewRow();
                for (int j = 0; j < matrixPairwiseComparison_count; j++)
                {
                    row[j] = matrixPairwiseComparison[i, j];
                }
                dataTablePairwiseComparison.Rows.Add(row);
            }

            byte[] dataTable = GetBinaryFormatData(dataTablePairwiseComparison);
            stream.Write(dataTable, 0, dataTable.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            StringBuilder builder= new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            string bestAlternative_buf = builder.ToString();

            int[] bestAlternative = new int[bestAlternative_buf.Length];
            for (int i = 0; i < bestAlternative.Length; i++)
            {
                bestAlternative[i] = int.Parse(bestAlternative_buf[i].ToString());
            }
            Array.Clear(data, 0, data.Length);
            return bestAlternative;
        }


        static public DataTable ReceiveAddScheduleData(string idDestination, string finalDate)
        {
            byte[] iddestination = Encoding.Unicode.GetBytes(idDestination);
            stream.Write(iddestination, 0, iddestination.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] finaldate = Encoding.Unicode.GetBytes(finalDate);
            stream.Write(finaldate, 0, finaldate.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveAddScheduleWithReserveData(string idDestination, string finalDate,string reserveDate)
        {
            byte[] iddestination = Encoding.Unicode.GetBytes(idDestination);
            stream.Write(iddestination, 0, iddestination.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] finaldate = Encoding.Unicode.GetBytes(finalDate);
            stream.Write(finaldate, 0, finaldate.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] reservedate = Encoding.Unicode.GetBytes(reserveDate);
            stream.Write(reservedate, 0, reservedate.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveSelectSchedule()
        {
            byte[] data = new byte[100000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public int ReceiveDeleteScheduleData(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            int deleted_count = BitConverter.ToInt32(data);
            Array.Clear(data, 0, data.Length);
            return deleted_count;
        }



        static public DataTable ReceiveSelectAccounts()
        {
            byte[] data = new byte[10000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public DataTable ReceiveEditAccountData(string Login, string Newvalue)
        {
            byte[] login = Encoding.Unicode.GetBytes(Login);
            stream.Write(login, 0, login.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] newvalue = Encoding.Unicode.GetBytes(Newvalue);
            stream.Write(newvalue, 0, newvalue.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[10000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static public int ReceiveDeleteAccountData(string Login)
        {
            byte[] login = Encoding.Unicode.GetBytes(Login);
            stream.Write(login, 0, login.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[64];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            int deleted_count = BitConverter.ToInt32(data);
            Array.Clear(data, 0, data.Length);
            return deleted_count;
        }

        public static byte[] GetBinaryFormatData(DataTable dataTable)
        {
            BinaryFormatter bFormat = new BinaryFormatter();
            byte[] outList = null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bFormat.Serialize(memoryStream, dataTable);
                outList = memoryStream.ToArray();
            }
            return outList;
        }


        static public DataTable ReceiveBuildReportData(string Id)
        {
            byte[] id = Encoding.Unicode.GetBytes(Id);
            stream.Write(id, 0, id.Length);
            stream.Flush();

            byte[] confirm = new byte[4];
            int bytes = 0;
            do
            {
                bytes = stream.Read(confirm, 0, confirm.Length);
            }
            while (stream.DataAvailable);

            byte[] data = new byte[100000];
            bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);
            DataTable dataTable = GetDataTable(data);
            Array.Clear(data, 0, data.Length);
            return dataTable;
        }
        static private DataTable GetDataTable(byte[] data)
        {
            DataTable dataTable = null;
            BinaryFormatter bFormat = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                dataTable = (DataTable)bFormat.Deserialize(memoryStream);
            }
            return dataTable;
        }




    }
}
