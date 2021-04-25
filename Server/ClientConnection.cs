using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Server
{
    class ClientConnection
    {
        public TcpClient client;
        static private int status = 0;
        static private string command = "";
        static private string companySearch = "", companyId = "", companyName = "", companyVacancy = "", companySalary = "", companyEmployment = "", companyRequirements = "", companyDescription = "";
        static private string seekerSearch = "", seekerId = "", seekerName = "", seekerVacancy = "", seekerSalary = "", seekerEducation = "", seekerMobileNumber = "", seekerDescription = "";

        public ClientConnection(TcpClient tcpClient)
        {
            client = tcpClient;
        }

        public void connectClient()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64];

                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    /*
                    if (status == 0 && ((builder.ToString() == "SELECT COMPANY") ||
                                        (builder.ToString() == "ADD COMPANY") ||
                                        (builder.ToString() == "DELETE COMPANY") ||
                                        (builder.ToString() == "UPDATE COMPANY") ||
                                        (builder.ToString() == "SELECT SEEKER") ||
                                        (builder.ToString() == "ADD SEEKER") ||
                                        (builder.ToString() == "DELETE SEEKER") ||
                                        (builder.ToString() == "UPDATE SEEKER")))
                    {
                        command = builder.ToString();
                        ++status;
                    }
                    */
                    string message = builder.ToString();
                    Console.WriteLine(builder.ToString());
                    message = "Ваше сообщение доставлено";
                    data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
            */
        }
    }
}
