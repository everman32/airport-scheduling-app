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
        static public void SendRequestToServer(string request)
        {
            byte[] data = Encoding.Unicode.GetBytes(request);
            stream.Write(data,0,data.Length);
        }
        static public DataTable SendAuthorizeServer(string login, string password)
        {
            {
                byte[] data = Encoding.Unicode.GetBytes(login);
                stream.Write(data, 0, data.Length);
            }
            {
                byte[] data = Encoding.Unicode.GetBytes(password);
                stream.Write(data, 0, data.Length);
            }
            {
                byte[] data = new byte[10000];
                int bytes = 0;

                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                }
                while (stream.DataAvailable);
                DataTable dataTable = GetDataTable(data);
                return dataTable;
            }
        }
        static public DataTable SendRegisterServer(string login, string password,int typeAccount)
        {
            {
                byte[] data = Encoding.Unicode.GetBytes(login);
                stream.Write(data, 0, data.Length);
            }
            {
                byte[] data = Encoding.Unicode.GetBytes(password);
                stream.Write(data, 0, data.Length);
            }
            {
                byte[] data = Encoding.Unicode.GetBytes(typeAccount.ToString());
                stream.Write(data, 0, data.Length);
            }
            {
                byte[] data = new byte[10000];
                int bytes = 0;

                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                }
                while (stream.DataAvailable);
                DataTable dataTable = GetDataTable(data);
                return dataTable;
            }
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
