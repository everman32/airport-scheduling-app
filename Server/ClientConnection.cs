using System;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.IO;

namespace Server
{
    [Serializable]
    public class ClientConnection
    {
        public TcpClient client;
        static private string command = "";
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
                         (builder.ToString()== "Delete passenger")||
                         (builder.ToString() == "Select destinations")||
                         (builder.ToString() == "Add destination")||
                         (builder.ToString() == "Edit destination")||
                         (builder.ToString() == "Delete destination")||
                         (builder.ToString() == "Select flightrequests")||
                         (builder.ToString() == "Select destinationsNames") ||
                         (builder.ToString() == "Select passengersNames") ||
                         (builder.ToString() == "Select estimatedtimes")||
                         (builder.ToString() == "Add flightrequest")||
                         (builder.ToString() == "Edit flightrequest")||
                         (builder.ToString() == "Select prioritytimes")||
                         (builder.ToString() == "Delete flightrequest")||
                         (builder.ToString() == "Select destinationsNamesCondorcet")||
                         (builder.ToString() == "Select estimatedtimesCondorcet")||
                         (builder.ToString() == "Select prioritytimesCondorcet")||
                         (builder.ToString() == "Select preferencesCondorcet")||
                         (builder.ToString() == "Select pairwiseComparison")||
                         (builder.ToString() == "Select bestAlternative")||
                          (builder.ToString() == "Add schedule")||
                           (builder.ToString() == "Add scheduleWithReserve")||
                            (builder.ToString() == "Select schedule")||
                            (builder.ToString() == "Delete schedule")||
                            (builder.ToString() == "Select accounts")||
                             (builder.ToString() == "Edit account")||
                             (builder.ToString() == "Delete account")||
                             (builder.ToString() == "Build report")




                         )
                    {
                        command = builder.ToString();
                    }
                    if (command == "Login")
                    {
                        Account.ReceiveAuthorizationData(stream);
                    }
                    else if (command == "Register")
                    {
                        Account.ReceiveRegistrationData(stream);
                    }
                    else if (command == "Select passengers")
                    {
                        Passenger.SendSelectingData(stream);
                    }
                    else if (command == "Add passenger")
                    {
                        Passenger.ReceiveDataForAdditing(stream);
                    }
                    else if (command == "Edit passenger")
                    {
                        Passenger.ReceiveDataForEditing(stream);
                    }
                    else if (command == "Delete passenger")
                    {
                        Passenger.ReceiveDataForDeleting(stream);
                    }
                    else if (command == "Select destinations")
                    {
                        Destination.SendSelectingData(stream);
                    }
                    else if (command == "Add destination")
                    {
                        Destination.ReceiveDataForAdditing(stream);
                    }
                    else if (command == "Edit destination")
                    {
                        Destination.ReceiveDataForEditing(stream);
                    }
                    else if (command == "Delete destination")
                    {
                        Destination.ReceiveDataForDeleting(stream);
                    }
                    else if (command == "Select flightrequests")
                    {
                        FlightRequest.SendSelectingData(stream);
                    }
                    else if (command == "Select destinationsNames")
                    {
                        FlightRequest.SendSelectingDestinationsNames(stream);
                    }
                    else if (command == "Select passengersNames")
                    {
                        FlightRequest.SendSelectingPassengersNames(stream);
                    }
                    else if (command == "Select estimatedtimes")
                    {
                        FlightRequest.SendSelectingEstimatedtimes(stream);
                    }
                    else if (command == "Add flightrequest")
                    {
                        FlightRequest.ReceiveDataForAdditing(stream);
                    }
                    else if (command == "Edit flightrequest")
                    {
                        FlightRequest.ReceiveDataForEditing(stream);
                    }
                    else if (command == "Select prioritytimes")
                    {
                        FlightRequest.SendSelectingPriorityTimes(stream);
                    }
                    else if (command == "Delete flightrequest")
                    {
                        FlightRequest.ReceiveDataForDeleting(stream);
                    }
                    else if (command == "Select destinationsNamesCondorcet")
                    {
                        Condorcet.SendSelectDestinationsNamesCondorcet(stream);
                    }
                    else if (command == "Select estimatedtimesCondorcet")
                    {
                        Condorcet.SendSelectEstimatedtimesCondorcet(stream);
                    }
                    else if (command == "Select prioritytimesCondorcet")
                    {
                        Condorcet.SendSelectPriorityTimesCondorcet(stream);
                    }
                    else if (command == "Select preferencesCondorcet")
                    {
                        Condorcet.SendSelectPreferencesCondorcet(stream);
                    }
                    else if (command == "Select pairwiseComparison")
                    {
                        Condorcet.SendSelectPairwiseComparison(stream);
                    }
                    else if (command == "Select bestAlternative")
                    {
                        Condorcet.SendSelectbestAlternative(stream);
                    }
                    else if (command == "Add schedule")
                    {
                        Schedule.ReceiveDataForAdditing(stream);
                    }
                    else if (command == "Add scheduleWithReserve")
                    {
                        Schedule.ReceiveDataForAdditingWithReserve(stream);
                    }
                    else if (command == "Select schedule")
                    {
                        Schedule.SendSelectingData(stream);
                    }
                    else if (command == "Delete schedule")
                    {
                        Schedule.ReceiveDataForDeleting(stream);
                    }
                    else if (command == "Select accounts")
                    {
                        Account.SendSelectingData(stream);
                    }
                    else if (command == "Edit account")
                    {
                        Account.ReceiveDataForEditing(stream);
                    }
                    else if (command == "Delete account")
                    {
                        Account.ReceiveDataForDeleting(stream);
                    }
                    else if (command == "Build report")
                    {
                        Account.ReceiveDataForBuildReport(stream);
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





        public static byte[] GetBinaryFormatData(DataTable dataTable)
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
        public static DataTable GetDataTable(byte[] data)
        {
            DataTable dataTable = null;
            BinaryFormatter bFormat = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                dataTable = (DataTable)bFormat.Deserialize(memoryStream);
            }
            return dataTable;
        }

    }
  
}
