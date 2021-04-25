using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Client
{
    public class Client
    {
        TcpClient client;
    public void connectClient(int port)
        {
            client = null;
            try
            {
                client = new TcpClient("127.0.0.1", port);
                NetworkStream stream = client.GetStream();


                    byte[] data = Encoding.Unicode.GetBytes("Клиент подключён");

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
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*finally
            {
                client.Close();
            }*/

        }
    }
}
