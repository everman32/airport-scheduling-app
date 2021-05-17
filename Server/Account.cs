using System.Text;
using System.Net.Sockets;
using System.Data;
using System;

namespace Server
{
    class Account
    {
        public static void ReceiveAuthorizationData(NetworkStream stream)
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
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveRegistrationData(NetworkStream stream)
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

            byte[] AccessRight = new byte[64];
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

            DataTable dataTable = SQLCommander.InsertAccount(login, password, accessRight);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingData(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectAccount();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForEditing(NetworkStream stream)
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

            DataTable dataTable = new DataTable();
                dataTable = SQLCommander.EditPassword(login, newvalue);

            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForDeleting(NetworkStream stream)
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
            int deleted_count = SQLCommander.DeleteAccount(login);

            byte[] data = BitConverter.GetBytes(deleted_count);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }

        public static void ReceiveDataForBuildReport(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectPassengersForReport(id);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
    }
}
