using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
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
        static public int typeaccount;
        public Client(string address, int port)
        {
            client = new TcpClient(address, port);
            stream = client.GetStream();
        }
        public void connectClient()
        {
            byte[] data = Encoding.Unicode.GetBytes("Клиент подключён");
            stream.Write(data, 0, data.Length);
        }
        static public void SendRequestToServer(string Request)
        {
            byte[] request = Encoding.Unicode.GetBytes(Request);
            stream.Write(request, 0, request.Length);
        }
        static public DataTable SendAuthorizeServer(string Login, string Password)
        {
                byte[] login = Encoding.Unicode.GetBytes(Login);
                stream.Write(login, 0, login.Length);

                byte[]password= Encoding.Unicode.GetBytes(Password);
                stream.Write(password, 0, password.Length);

                byte[] data = new byte[10000];
                int bytes = 0;

                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                }
                while (stream.DataAvailable);
                DataTable dataTable = GetDataTable(data);
                Array.Clear(data,0,data.Length);
                return dataTable;
        }
        static public DataTable SendRegisterServer(string Login, string Password,int TypeAccount)
        {
                byte[] login = Encoding.Unicode.GetBytes(Login);
                stream.Write(login, 0, login.Length);

                byte[] password = Encoding.Unicode.GetBytes(Password);
                stream.Write(password, 0, password.Length);

                byte[] typeAccount = Encoding.Unicode.GetBytes(TypeAccount.ToString());
                stream.Write(typeAccount, 0, typeAccount.Length);

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

        static public DataTable SendSelectClients()
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
