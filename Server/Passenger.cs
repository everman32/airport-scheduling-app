using System;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class Passenger
    {
        public static void SendSelectingData(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectPassenger();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForAdditing(NetworkStream stream)
        {
            byte[] Surname = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Surname, 0, Surname.Length);
                builder.Append(Encoding.Unicode.GetString(Surname, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
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

            DataTable dataTable = SQLCommander.InsertPassenger(surname, name, patronymic, phonenumber);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForEditing(NetworkStream stream)
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
            else if (command == "Edit patronymic")
            {
                dataTable = SQLCommander.EditPatronymicPassenger(id, newvalue);
            }
            else if (command == "Edit phonenumber")
            {
                dataTable = SQLCommander.EditPhonenumberPassenger(id, newvalue);
            }
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForDeleting(NetworkStream stream)
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
    }
}
