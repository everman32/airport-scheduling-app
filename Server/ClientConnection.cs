using System;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.IO;
using System.Collections;
using System.Linq;

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
                         (builder.ToString() == "Select bestAlternative")


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
                        ClientConnection.SendSelectDestinationsNamesCondorcet(stream);
                    }
                    else if (command == "Select estimatedtimesCondorcet")
                    {
                        ClientConnection.SendSelectEstimatedtimesCondorcet(stream);
                    }
                    else if (command == "Select prioritytimesCondorcet")
                    {
                        ClientConnection.SendSelectPriorityTimesCondorcet(stream);
                    }
                    else if (command == "Select preferencesCondorcet")
                    {
                        ClientConnection.SendSelectPreferencesCondorcet(stream);
                    }
                    else if (command == "Select pairwiseComparison")
                    {
                        ClientConnection.SendSelectPairwiseComparison(stream);
                    }
                    else if (command == "Select bestAlternative")
                    {
                        ClientConnection.SendSelectbestAlternative(stream);
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
        static private DataTable GetDataTable(byte[] data)
        {
            DataTable dataTable = null;
            BinaryFormatter bFormat = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                dataTable = (DataTable)bFormat.Deserialize(memoryStream);
            }
            return dataTable;
        }

        static void SendSelectDestinationsNamesCondorcet(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectDestinationsNamesCondorcet();
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void SendSelectEstimatedtimesCondorcet(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectEstimatedTimesCondorcet(id);
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void SendSelectPriorityTimesCondorcet(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectPriorityTimesCondorcet(id);
            byte[] data = GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        static void SendSelectPreferencesCondorcet(NetworkStream stream)
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
 
                DataTable dataTableestimated = SQLCommander.SelectEstimatedTimesCondorcet(id);
                DataTable dataTablepriority = SQLCommander.SelectPriorityTimesCondorcet(id);

                string[] arrayEstimatedTimes = new string[dataTableestimated.Columns.Count - 1];
                for (int i = 0, j = 1; j < dataTableestimated.Columns.Count; j++, i++)
                {
                    arrayEstimatedTimes[i] = dataTableestimated.Rows[0][j].ToString();
                }

                string[,] arrayPriorityTimes = new string[dataTablepriority.Columns.Count - 1, dataTablepriority.Rows.Count];
                for (int i = 0, x = 0; i < dataTablepriority.Rows.Count; i++, x++)
                {
                    for (int j = 1, y = 0; j < dataTablepriority.Columns.Count; j++, y++)
                    {
                        arrayPriorityTimes[y, x] = dataTablepriority.Rows[i][j].ToString();
                    }
                }

                int arrayPreferences_rowsCount = dataTablepriority.Columns.Count - 1;
                int arrayPreferences_columnsCount = dataTablepriority.Rows.Count;
                string[,] arrayPreferences = new string[arrayPreferences_rowsCount, arrayPreferences_columnsCount];
                for (int j = 0; j < arrayPreferences_columnsCount; j++)
                {
                    for (int i = 0; i < arrayPreferences_rowsCount; i++)
                    {
                        if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[0])
                        {
                            arrayPreferences[i, j] = "a1";
                        }
                        else if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[1])
                        {
                            arrayPreferences[i, j] = "a2";
                        }
                        if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[2])
                        {
                            arrayPreferences[i, j] = "a3";
                        }
                    }
                }

                DataTable dataTablePreferences = new DataTable();
                for (int i = 0; i < arrayPreferences_columnsCount; i++)
                {
                    dataTablePreferences.Columns.Add(dataTablepriority.Rows[i][0].ToString());
                }
                for (int i = 0; i < arrayPreferences_rowsCount; i++)
                {
                    DataRow row = dataTablePreferences.NewRow();
                    for (int j = 0; j < arrayPreferences_columnsCount; j++)
                    {
                        row[j] = arrayPreferences[i, j];
                    }
                    dataTablePreferences.Rows.Add(row);
                }

                byte[] data = GetBinaryFormatData(dataTablePreferences);
                stream.Write(data, 0, data.Length);
                stream.Flush();
            }
        static void SendSelectPairwiseComparison(NetworkStream stream)
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

            DataTable dataTableestimated = SQLCommander.SelectEstimatedTimesCondorcet(id);
            DataTable dataTablepriority = SQLCommander.SelectPriorityTimesCondorcet(id);

            string[] arrayEstimatedTimes = new string[dataTableestimated.Columns.Count - 1];
            for (int i = 0, j = 1; j < dataTableestimated.Columns.Count; j++, i++)
            {
                arrayEstimatedTimes[i] = dataTableestimated.Rows[0][j].ToString();
            }

            string[,] arrayPriorityTimes = new string[dataTablepriority.Columns.Count - 1, dataTablepriority.Rows.Count];
            for (int i = 0, x = 0; i < dataTablepriority.Rows.Count; i++, x++)
            {
                for (int j = 1, y = 0; j < dataTablepriority.Columns.Count; j++, y++)
                {
                    arrayPriorityTimes[y, x] = dataTablepriority.Rows[i][j].ToString();
                }
            }

            int arrayPreferences_rowsCount = dataTablepriority.Columns.Count - 1;
            int arrayPreferences_columnsCount = dataTablepriority.Rows.Count;
            string[,] arrayPreferences = new string[arrayPreferences_rowsCount, arrayPreferences_columnsCount];
            for (int j = 0; j < arrayPreferences_columnsCount; j++)
            {
                for (int i = 0; i < arrayPreferences_rowsCount; i++)
                {
                    if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[0])
                    {
                        arrayPreferences[i, j] = "0";
                    }
                    else if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[1])
                    {
                        arrayPreferences[i, j] = "1";
                    }
                    if (arrayPriorityTimes[i, j] == arrayEstimatedTimes[2])
                    {
                        arrayPreferences[i, j] = "2";
                    }
                }
            }
           
            ArrayList indexlist_a1 = new ArrayList();
            int alternative1=0;
            for (int j=0;j<arrayPreferences_columnsCount;j++)
            {
                for (int i=0;i<arrayPreferences_rowsCount;i++)
                {
                    if (arrayPreferences[i,j]=="0")
                    {
                        alternative1 = i;
                        indexlist_a1.Add(alternative1);
                    }
                }
            }
            ArrayList indexlist_a2 = new ArrayList();
           int alternative2=0;
           for (int j = 0; j < arrayPreferences_columnsCount; j++)
           {
               for (int i = 0; i < arrayPreferences_rowsCount; i++)
               {
                   if (arrayPreferences[i, j] == "1")
                   {
                       alternative2 = i;
                       indexlist_a2.Add(alternative2);
                   }
               }
            }
           ArrayList indexlist_a3 = new ArrayList();
           int alternative3=0;
           for (int j = 0; j < arrayPreferences_columnsCount; j++)
           {
               for (int i = 0; i < arrayPreferences_rowsCount; i++)
               {
                   if (arrayPreferences[i, j] == "2")
                   {
                       alternative3 = i;
                       indexlist_a3.Add(alternative3);
                   }
               }
           }
           
                       int alternative12 = 0;
                       for (int i=0;i<arrayPreferences_columnsCount;i++)
                       {
                           if (Convert.ToInt32(indexlist_a1[i]) < Convert.ToInt32(indexlist_a2[i]))
                           {
                               alternative12++;
                           }
                       }
                       int alternative13 = 0;
                       for (int i = 0; i < arrayPreferences_columnsCount; i++)
                       {
                           if (Convert.ToInt32(indexlist_a1[i]) < Convert.ToInt32(indexlist_a3[i]))
                           {
                               alternative13++;
                           }
            } 
                       int alternative23 = 0;
                       for (int i = 0; i < arrayPreferences_columnsCount; i++)
                       {
                           if (Convert.ToInt32(indexlist_a2[i]) < Convert.ToInt32(indexlist_a3[i]))
                           {
                               alternative23++;
                           }
                       }
        
                                   int alternative21 = arrayPreferences_columnsCount - alternative12;
                                   int alternative31 = arrayPreferences_columnsCount - alternative13;
                                   int alternative32 = arrayPreferences_columnsCount - alternative23;

                                   ArrayList listPairwiseComparison = new ArrayList();

                                   listPairwiseComparison.Add(0);
                                   listPairwiseComparison.Add(alternative12);
                                   listPairwiseComparison.Add(alternative13);
                                   listPairwiseComparison.Add(alternative21);
                                   listPairwiseComparison.Add(0);
                                   listPairwiseComparison.Add(alternative23);
                                   listPairwiseComparison.Add(alternative31);
                                   listPairwiseComparison.Add(alternative32);
                                   listPairwiseComparison.Add(0);

                                   int matrixPairwiseComparison_count = arrayPreferences_rowsCount;
                                   int[,] matrixPairwiseComparison = new int[matrixPairwiseComparison_count, matrixPairwiseComparison_count];

                                    
                                   int list_count = 0;
                                   for (int i = 0; i < matrixPairwiseComparison_count; i++)
                                   {
                                       for (int j = 0;j< matrixPairwiseComparison_count; j++)
                                       {
                                           matrixPairwiseComparison[i, j] = Convert.ToInt32(listPairwiseComparison[list_count]);
                                           list_count++;
                                       }
                                   }   
                                           DataTable dataTablePairwiseComparison = new DataTable();
                                   for (int i = 0; i < matrixPairwiseComparison_count; i++)
                                   {
                                       dataTablePairwiseComparison.Columns.Add("a" + (i+1).ToString());
                                   }
                                   for (int i = 0; i < matrixPairwiseComparison_count; i++)
                                   {
                                       DataRow row = dataTablePairwiseComparison.NewRow();
                                       for (int j = 0; j < matrixPairwiseComparison_count; j++)
                                       {
                                           row[j] = matrixPairwiseComparison[i, j];
                                       }
                                       dataTablePairwiseComparison.Rows.Add(row);
                                   }

            byte[] data = GetBinaryFormatData(dataTablePairwiseComparison);
            stream.Write(data, 0, data.Length);
            stream.Flush();
            /*
            dataGridMatrixPairwiseComparison.DataSource = dataTablePairwiseComparison;

            dataGridMatrixPairwiseComparison.AllowUserToAddRows = false;
            dataGridMatrixPairwiseComparison.AllowUserToResizeColumns = false;
            dataGridMatrixPairwiseComparison.AllowUserToResizeRows = false;

            dataGridMatrixPairwiseComparison.RowHeadersVisible = false;
            dataGridMatrixPairwiseComparison.ReadOnly = true;

            dataGridMatrixPairwiseComparison.Visible = true;

            int quantity = 0;
            int count = 0;
            for (int i = 0; i < matrixPairwiseComparison_count; i++)
            {
                for (int j = 0; j < matrixPairwiseComparison_count; j++)
                {
                    if (matrixPairwiseComparison[i, j] >= matrixPairwiseComparison[j, i] && i != j)
                    {
                        quantity++;
                    }
                    if (j == matrixPairwiseComparison_count - 1)
                    {
                        if (quantity == matrixPairwiseComparison_count - 1)
                        {
                            MessageBox.Show("Наиболее предпочтительные варианты. Наилучшей альтернативой является: a" + (i+1).ToString());
                            quantity = 0;
                        }
                        else
                        {
                            quantity = 0;
                            count++;
                        }
                    }
                }
            }
            if (count==3)
            {
                MessageBox.Show("Наиболее предпочтительные варианты. Парадокс Кондорсе");
            }
      */

        }
        static void SendSelectbestAlternative(NetworkStream stream)
        {
            byte[] data = new byte[10000];
            int bytes = 0;
            do
            {
                bytes = stream.Read(data, 0, data.Length);
            }
            while (stream.DataAvailable);

            byte[] confirm = Encoding.Unicode.GetBytes("OK");
            stream.Write(confirm, 0, confirm.Length);
            stream.Flush();

                DataTable dataTable = GetDataTable(data);

                int matrixPairwiseComparison_count = dataTable.Rows.Count;
                int[,] matrixPairwiseComparison = new int[matrixPairwiseComparison_count, matrixPairwiseComparison_count];
                for (int i = 0; i < matrixPairwiseComparison_count; i++)
                {
                    for (int j = 0; j < matrixPairwiseComparison_count; j++)
                    {
                        matrixPairwiseComparison[i, j] = Convert.ToInt32(dataTable.Rows[i][j]);
                    }
                }

                ArrayList bestAlternative_list = new ArrayList();

                int quantity = 0;
                int count = 0;

                for (int i = 0; i < matrixPairwiseComparison_count; i++)
                {
                    for (int j = 0; j < matrixPairwiseComparison_count; j++)
                    {
                        if (matrixPairwiseComparison[i, j] >= matrixPairwiseComparison[j, i] && i != j)
                        {
                            quantity++;
                        }
                        if (j == matrixPairwiseComparison_count - 1)
                        {
                            if (quantity == matrixPairwiseComparison_count - 1)
                            {
                                bestAlternative_list.Add(i + 1);
                                quantity = 0;
                            }
                            else
                            {
                                quantity = 0;
                                count++;
                            }
                        }
                    }
                }
                if (count == 3)
                {
                    Console.WriteLine("Наиболее предпочтительные варианты. Парадокс Кондорсе");
                }
                string bestAlternative_buf = "";
                for (int i=0;i< bestAlternative_list.Count;i++)
                {
                    bestAlternative_buf += bestAlternative_list[i].ToString();
                }

                byte[] bestAlternative = Encoding.Unicode.GetBytes(bestAlternative_buf.ToString());

                stream.Write(bestAlternative, 0, bestAlternative.Length);
                stream.Flush();
        }
    }
  
}
