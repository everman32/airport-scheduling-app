using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Server
{
    class Server
    {
        static TcpListener listener;
       static public void Run(int port)
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                Console.Clear();
                Console.WriteLine("Сервер запущен и ожидает подключения к порту " + port + "...");

                for (; ; )
                {
                    TcpClient client = listener.AcceptTcpClient();
                    ClientConnection clientobj = new ClientConnection(client);

                    Thread clientThread = new Thread(new ThreadStart(clientobj.connectClient));
                    clientThread.Start();
                        
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка сервера",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }
    }
}
