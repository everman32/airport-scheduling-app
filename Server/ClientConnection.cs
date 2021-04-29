using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.IO;

namespace Server
{
    [Serializable]
    class ClientConnection
    {
        public TcpClient client;
        static private string command = "";
        /*
        static private int status = 0;
        static private string companySearch = "", companyId = "", companyName = "", companyVacancy = "", companySalary = "", companyEmployment = "", companyRequirements = "", companyDescription = "";
        static private string seekerSearch = "", seekerId = "", seekerName = "", seekerVacancy = "", seekerSalary = "", seekerEducation = "", seekerMobileNumber = "", seekerDescription = "";
        */
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

                byte[] data= new byte[64];
                StringBuilder builder= new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                string message = builder.ToString();
                Console.WriteLine(message);

                for (; ; )
                {
                    data = new byte[64];
                    builder = new StringBuilder();
                    bytes = 0;

                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    if
                        ((builder.ToString() == "Login") ||
                                        (builder.ToString() == "Register") /*||
                                        (builder.ToString() == "DELETE COMPANY") ||
                                        (builder.ToString() == "UPDATE COMPANY") ||
                                        (builder.ToString() == "SELECT SEEKER") ||
                                        (builder.ToString() == "ADD SEEKER") ||
                                        (builder.ToString() == "DELETE SEEKER") ||
                                        (builder.ToString() == "UPDATE SEEKER")*/)
                    {
                        command = builder.ToString();
                    }
                    if (command == "Login")
                    {
                        ClientConnection.ReceiveAuthorize(stream);  
                    }
                    if (command =="Register")
                    {
                        ClientConnection.ReceiveRegister(stream);
                    }
                    /*
                    message = "Ваше сообщение доставлено";
                    data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    */
                }
            }
            catch
            {
                Console.WriteLine("Клиент отключён");
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
        static byte[] GetBinaryFormatData(DataTable dataTable)
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
        static void ReceiveAuthorize(NetworkStream stream)
        {
            byte[]data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string login = builder.ToString();

            data = new byte[64];
            builder = new StringBuilder();
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string password = builder.ToString();

            DataTable dataTable = SQLCommander.SelectAccount(login, password);
            byte[] auth_data = GetBinaryFormatData(dataTable);
            stream.Write(auth_data, 0, auth_data.Length);
        }

        static void ReceiveRegister(NetworkStream stream)
        {
            byte[] data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string login = builder.ToString();

            data = new byte[64];
            builder = new StringBuilder();
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string password = builder.ToString();

            data = new byte[64];
            builder = new StringBuilder();
            bytes = 0;

            do
            {
                bytes = stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (stream.DataAvailable);
            string typeAccount = builder.ToString();

            DataTable dataTable = SQLCommander.InsertAccount(login, password,typeAccount);
            byte[] reg_data = GetBinaryFormatData(dataTable);
            stream.Write(reg_data, 0, reg_data.Length);
        }





    }
  
}
