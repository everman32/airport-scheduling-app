using System;
using System.Text;
using System.Data;
using System.Net.Sockets;

namespace Server
{
    class FlightRequest
    {
        public static void SendSelectingData(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectFlightRequests();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingDestinationsNames(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectDestinationsNames();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingPassengersNames(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectPassengersNames();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingFlightRequestsNames(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectFlightRequestsNames();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingEstimatedtimes(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectEstimatedTimes(id);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingPriorityTimes(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectPriorityTimes(id);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }

        public static void ReceiveDataForAdditing(NetworkStream stream)
        {
            byte[] idPassenger = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(idPassenger, 0, idPassenger.Length);
                builder.Append(Encoding.Unicode.GetString(idPassenger, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string idpassenger = builder.ToString();

            byte[] idDestination = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(idDestination, 0, idDestination.Length);
                builder.Append(Encoding.Unicode.GetString(idDestination, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string iddestination = builder.ToString();

            byte[] highestPrioritytime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(highestPrioritytime, 0, highestPrioritytime.Length);
                builder.Append(Encoding.Unicode.GetString(highestPrioritytime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string highestprioritytime = builder.ToString();

            byte[] mediumPrioritytime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(mediumPrioritytime, 0, mediumPrioritytime.Length);
                builder.Append(Encoding.Unicode.GetString(mediumPrioritytime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string mediumprioritytime = builder.ToString();

            byte[] lowestPrioritytime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(lowestPrioritytime, 0, lowestPrioritytime.Length);
                builder.Append(Encoding.Unicode.GetString(lowestPrioritytime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string lowestprioritytime = builder.ToString();

            DataTable dataTable = SQLCommander.InsertFlightRequest(idpassenger, iddestination, highestprioritytime, mediumprioritytime, lowestprioritytime);
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

            byte[] highestPriorityTime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(highestPriorityTime, 0, highestPriorityTime.Length);
                builder.Append(Encoding.Unicode.GetString(highestPriorityTime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string highestprioritytime = builder.ToString();

            byte[] mediumPriorityTime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(mediumPriorityTime, 0, mediumPriorityTime.Length);
                builder.Append(Encoding.Unicode.GetString(mediumPriorityTime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string mediumprioritytime = builder.ToString();

            byte[] lowestPriorityTime = new byte[64];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(lowestPriorityTime, 0, lowestPriorityTime.Length);
                builder.Append(Encoding.Unicode.GetString(lowestPriorityTime, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string lowestprioritytime = builder.ToString();

            DataTable dataTable = new DataTable();
            dataTable = SQLCommander.EditFlightRequest(id, highestprioritytime, mediumprioritytime, lowestprioritytime);

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
            int deleted_count = SQLCommander.DeleteFlightRequest(id);

            byte[] data = BitConverter.GetBytes(deleted_count);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
    }
}
