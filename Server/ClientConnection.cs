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

                byte[] confirm = Encoding.Unicode.GetBytes("OK");
                stream.Write(confirm, 0, confirm.Length);
                stream.Flush();
               /* string message = builder.ToString();
                Array.Clear(data, 0, data.Length);
                Console.WriteLine(message);*/

                for (; ; )
                {
                    builder = new StringBuilder();
                    bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                   
                    stream.Write(confirm, 0, confirm.Length);
                    stream.Flush();

                    if
                        ((builder.ToString() == "Login") ||
                         (builder.ToString() == "Register")||
                         (builder.ToString() == "Select passengers")||
                         (builder.ToString() == "Add passenger") ||
                         (builder.ToString() == "Edit passenger")||
                         (builder.ToString()== "Delete passenger")
                                        /*
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
                    else if (command =="Register")
                    {
                        ClientConnection.ReceiveRegisterData(stream);
                    }
                    else if (command == "Select passengers")
                    {
                        ClientConnection.SendSelectPassengers(stream);
                    }
                    else if (command == "Add passenger")
                    {
                        ClientConnection.ReceiveAdditingPassengerData(stream);
                    }
                    else if (command == "Edit passenger")
                    {
                        ClientConnection.ReceiveEditingPassengerData(stream);
                    }
                    else if (command == "Delete passenger")
                    {
                        ClientConnection.ReceiveDeletingPassengerData(stream);
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
                Server.client_count--;
                Console.Clear();
                Console.WriteLine("Сервер запущен и ожидает подключения к порту " + Server.port + "...");
                Console.WriteLine("К серверу подключено " + Server.client_count + " клиентов(а)");
                //Console.WriteLine("Клиент отключён");
            }
           /*
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }*/
          
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
            byte[]Login = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Login, 0, Login.Length);
                builder.Append(Encoding.Unicode.GetString(Login, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string login = builder.ToString();

            byte[] Password = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Password, 0, Password.Length);
                builder.Append(Encoding.Unicode.GetString(Password, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string password = builder.ToString();

            DataTable dataTable = SQLCommander.SelectAccount(login, password);
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void ReceiveRegisterData(NetworkStream stream)
        {
            byte[] Login = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Login, 0, Login.Length);
                builder.Append(Encoding.Unicode.GetString(Login, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string login = builder.ToString();

            byte[]Password = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Password, 0, Password.Length);
                builder.Append(Encoding.Unicode.GetString(Password, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string password = builder.ToString();

            byte[]AccessRight = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(AccessRight, 0, AccessRight.Length);
                builder.Append(Encoding.Unicode.GetString(AccessRight, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string accessRight = builder.ToString();

            DataTable dataTable = SQLCommander.InsertAccount(login, password,accessRight);
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void ReceiveAdditingPassengerData(NetworkStream stream)
        {
            byte[] Id = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Id, 0, Id.Length);
                builder.Append(Encoding.Unicode.GetString(Id, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string id = builder.ToString();

            byte[] Surname = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Surname, 0, Surname.Length);
                builder.Append(Encoding.Unicode.GetString(Surname, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string surname = builder.ToString();

            byte[] Name = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Name, 0, Name.Length);
                builder.Append(Encoding.Unicode.GetString(Name, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string name = builder.ToString();

            byte[] Patronymic = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Patronymic, 0, Patronymic.Length);
                builder.Append(Encoding.Unicode.GetString(Patronymic, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string patronymic = builder.ToString();

            byte[] PhoneNumber = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(PhoneNumber, 0, PhoneNumber.Length);
                builder.Append(Encoding.Unicode.GetString(PhoneNumber, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string phonenumber = builder.ToString();

            DataTable dataTable = SQLCommander.InsertPassenger(id, surname,name,patronymic,phonenumber);
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void ReceiveEditingPassengerData(NetworkStream stream)
        {
            byte[] Id = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Id, 0, Id.Length);
                builder.Append(Encoding.Unicode.GetString(Id, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string id = builder.ToString();

            byte[] Newvalue = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Newvalue, 0, Newvalue.Length);
                builder.Append(Encoding.Unicode.GetString(Newvalue, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string newvalue = builder.ToString();

            byte[] Command = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Command, 0, Command.Length);
                builder.Append(Encoding.Unicode.GetString(Command, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string command = builder.ToString();

            DataTable dataTable = new DataTable();
            if (command == "Edit surname")
            {
                dataTable = SQLCommander.EditSurnamePassenger(id, newvalue);
               
            }
            else if (command == "Edit name")
            {
                
                dataTable = SQLCommander.EditNamePassenger(id, newvalue);
            }
            if (command == "Edit patronymic")
            {
                dataTable = SQLCommander.EditPatronymicPassenger(id, newvalue);
            }
            if (command == "Edit phonenumber")
            {
                dataTable = SQLCommander.EditPhonenumberPassenger(id, newvalue);
            }
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void ReceiveDeletingPassengerData(NetworkStream stream)
        {
            byte[] Id = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Id, 0, Id.Length);
                builder.Append(Encoding.Unicode.GetString(Id, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();
            
            string id = builder.ToString();
            int deleted_count = SQLCommander.DeletePassenger(id);

            byte[] data = BitConverter.GetBytes(deleted_count);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }


        static void SendSelectPassengers(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectPassenger();
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }






    }
  
}
