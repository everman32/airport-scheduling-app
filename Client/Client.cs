using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

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

                byte[]password= Encoding.Unicode.GetBytes(Password);
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
                Array.Clear(data,0,data.Length);
                return dataTable;
        }
        static public DataTable ReceiveRegisterData(string Login, string Password,int AccessRight)
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
            byte[]data = new byte[10000];
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
        static public DataTable ReceiveAddPassengerData(string Id, string Surname, string Name, string Patronymic, string PhoneNumber)
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

            byte[] surname = Encoding.Unicode.GetBytes(Surname);
            stream.Write(surname, 0, surname.Length);
            stream.Flush();

            confirm = new byte[4];
            bytes = 0;
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
        static public DataTable ReceiveAddDestinationData(string Id, string Name, string Flightduration, string Airplanemodel,string Estimatedtime1,string Estimatedtime2,string Estimatedtime3)
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



    }
}
