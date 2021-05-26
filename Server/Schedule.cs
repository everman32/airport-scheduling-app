using System;
using System.Text;
using System.Net.Sockets;
using System.Data;

namespace Server
{
    class Schedule
    {
        public static void SendSelectingData(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectSchedule();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForAdditing(NetworkStream stream)
        {
            byte[] idDestination = new byte[Server.listener.Server.ReceiveBufferSize];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(idDestination, 0, idDestination.Length);
                builder.Append(Encoding.Unicode.GetString(idDestination, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string iddestination = builder.ToString();

            byte[] finalDate = new byte[Server.listener.Server.ReceiveBufferSize];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(finalDate, 0, finalDate.Length);
                builder.Append(Encoding.Unicode.GetString(finalDate, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string finaldate = builder.ToString();

            DataTable dataTable = SQLCommander.InsertSchedule(iddestination, finaldate);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForAdditingWithReserve(NetworkStream stream)
        {
            byte[] idDestination = new byte[Server.listener.Server.ReceiveBufferSize];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = stream.Read(idDestination, 0, idDestination.Length);
                builder.Append(Encoding.Unicode.GetString(idDestination, 0, bytes));
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string iddestination = builder.ToString();

            byte[] finalDate = new byte[Server.listener.Server.ReceiveBufferSize];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(finalDate, 0, finalDate.Length);
                builder.Append(Encoding.Unicode.GetString(finalDate, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string finaldate = builder.ToString();

            byte[] reserveDate = new byte[Server.listener.Server.ReceiveBufferSize];
            builder = new StringBuilder();
            bytes = 0;
            do
            {
                bytes = stream.Read(reserveDate, 0, reserveDate.Length);
                builder.Append(Encoding.Unicode.GetString(reserveDate, 0, bytes));
            }
            while (stream.DataAvailable);

            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

            string reservedate = builder.ToString();

            DataTable dataTable = SQLCommander.InsertScheduleWithReserve(iddestination, finaldate, reservedate);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void ReceiveDataForDeleting(NetworkStream stream)
        {
            byte[] Id = new byte[Server.listener.Server.ReceiveBufferSize];
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
            int deleted_count = SQLCommander.DeleteSchedule(id);

            byte[] data = BitConverter.GetBytes(deleted_count);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectingSchedulesNames(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectSchedulesNames();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
    }
}
