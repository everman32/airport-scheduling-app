using System;
using System.Text;
using System.Net.Sockets;
using System.Data;

namespace Server
{
    class Destination
    {
        public static void SendSelectingData(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectDestination();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForAdditing(NetworkStream stream)
        {
            byte[] Name = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(Name, 0, Name.Length);
                builder.Append(Encoding.Unicode.GetString(Name, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string name = builder.ToString();

            byte[] Flightduration = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Flightduration, 0, Flightduration.Length);
                builder.Append(Encoding.Unicode.GetString(Flightduration, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string flightduration = builder.ToString();

            byte[] Airplanemodel = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Airplanemodel, 0, Airplanemodel.Length);
                builder.Append(Encoding.Unicode.GetString(Airplanemodel, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string airplanemodel = builder.ToString();

            byte[] Estimatedtime1 = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Estimatedtime1, 0, Estimatedtime1.Length);
                builder.Append(Encoding.Unicode.GetString(Estimatedtime1, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string estimatedtime1 = builder.ToString();

            byte[] Estimatedtime2 = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Estimatedtime2, 0, Estimatedtime2.Length);
                builder.Append(Encoding.Unicode.GetString(Estimatedtime2, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string estimatedtime2 = builder.ToString();

            byte[] Estimatedtime3 = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(Estimatedtime3, 0, Estimatedtime3.Length);
                builder.Append(Encoding.Unicode.GetString(Estimatedtime3, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string estimatedtime3 = builder.ToString();


            DataTable dataTable = SQLCommander.InsertDestination(name, flightduration, airplanemodel, estimatedtime1, estimatedtime2, estimatedtime3);
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
            if (command == "Edit name")
            {
                dataTable = SQLCommander.EditNameDestination(id, newvalue);
            }
            else if (command == "Edit flightduration")
            {
                dataTable = SQLCommander.EditFlightdurationDestination(id, newvalue);
            }
            else if (command == "Edit airplanemodel")
            {
                dataTable = SQLCommander.EditAirplanemodelDestination(id, newvalue);
            }
            else if (command == "Edit estimatedtime1")
            {
                dataTable = SQLCommander.EditEstimatedtime1Destination(id, newvalue);
            }
            else if (command == "Edit estimatedtime2")
            {
                dataTable = SQLCommander.EditEstimatedtime2Destination(id, newvalue);
            }
            else if (command == "Edit estimatedtime3")
            {
                dataTable = SQLCommander.EditEstimatedtime3Destination(id, newvalue);
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
            int deleted_count = SQLCommander.DeleteDestination(id);

            byte[] data = BitConverter.GetBytes(deleted_count);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
    }
}
