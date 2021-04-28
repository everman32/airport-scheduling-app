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

                    data = new byte[64];
                    StringBuilder builder = new StringBuilder();
        }
        static public void SendRequestToServer(string message)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data,0,data.Length);
        }
        static public DataTable SendAuthToServerReceive(string login, string password)
        {
            byte[] data = Encoding.Unicode.GetBytes(login);
            stream.Write(data, 0, data.Length);

            data = new byte[64];
            data = Encoding.Unicode.GetBytes(password);
            stream.Write(data, 0, data.Length);

            byte []data_auth = new byte[50000];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = stream.Read(data_auth, 0, data_auth.Length);
                builder.Append(Encoding.Unicode.GetString(data_auth, 0, bytes));
            }
            while (stream.DataAvailable);

            DataTable dataTable = GetDataTable(data_auth);
            return dataTable;
        }
        static private DataTable GetDataTable(byte[] dtData)
        {
            DataTable dataTable = null;
            BinaryFormatter bFormat = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(dtData))
            {
                dataTable = (DataTable)bFormat.Deserialize(ms);
            }
            return dataTable;
        }



    }
}
