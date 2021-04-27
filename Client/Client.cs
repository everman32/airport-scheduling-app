using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    public class Client
    {
        static public TcpClient client = new TcpClient("127.0.0.1", 600);
        static public NetworkStream stream = client.GetStream();
        public void connectClient(int port)
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
        static public string SendAuthToServerReceive(string login, string password)
        {
            byte[] data = Encoding.Unicode.GetBytes(login);
            stream.Write(data, 0, data.Length);

            data = new byte[64];
            data = Encoding.Unicode.GetBytes(password);
            stream.Write(data, 0, data.Length);

            data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);

            string checkLogin = builder.ToString();
            return checkLogin;
        }
    }
}
