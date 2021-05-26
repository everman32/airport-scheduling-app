using System;
using System.Text;
using System.Net.Sockets;
using System.Data;
using System.Collections;

namespace Server
{
    class Condorcet
    {
        public static void SendSelectDestinationsNamesCondorcet(NetworkStream stream)
        {
            DataTable dataTable = SQLCommander.SelectDestinationsNamesCondorcet();
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectEstimatedtimesCondorcet(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectEstimatedTimesCondorcet(id);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectPriorityTimesCondorcet(NetworkStream stream)
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

            DataTable dataTable = SQLCommander.SelectPriorityTimesCondorcet(id);
            byte[] data = ClientConnection.GetBinaryFormatData(dataTable);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectPreferencesCondorcet(NetworkStream stream)
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

            byte[] data = ClientConnection.GetBinaryFormatData(dataTablePreferences);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectPairwiseComparison(NetworkStream stream)
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
            int alternative1 = 0;
            for (int j = 0; j < arrayPreferences_columnsCount; j++)
            {
                for (int i = 0; i < arrayPreferences_rowsCount; i++)
                {
                    if (arrayPreferences[i, j] == "0")
                    {
                        alternative1 = i;
                        indexlist_a1.Add(alternative1);
                    }
                }
            }
            ArrayList indexlist_a2 = new ArrayList();
            int alternative2 = 0;
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
            int alternative3 = 0;
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
            for (int i = 0; i < arrayPreferences_columnsCount; i++)
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
                for (int j = 0; j < matrixPairwiseComparison_count; j++)
                {
                    matrixPairwiseComparison[i, j] = Convert.ToInt32(listPairwiseComparison[list_count]);
                    list_count++;
                }
            }
            DataTable dataTablePairwiseComparison = new DataTable();
            for (int i = 0; i < matrixPairwiseComparison_count; i++)
            {
                dataTablePairwiseComparison.Columns.Add("a" + (i + 1).ToString());
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

            byte[] data = ClientConnection.GetBinaryFormatData(dataTablePairwiseComparison);
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        public static void SendSelectbestAlternative(NetworkStream stream)
        {
            try
            {
                byte[] data = new byte[Server.listener.Server.ReceiveBufferSize];
                int bytes = 0;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                }
                while (stream.DataAvailable);

                byte[] confirm = Encoding.Unicode.GetBytes("OK");
                stream.Write(confirm, 0, confirm.Length);
                stream.Flush();

                DataTable dataTable = ClientConnection.GetDataTable(data);

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
                string bestAlternative_buf = "";
                if (count == 3)
                {
                    Console.WriteLine("Наиболее предпочтительные варианты. Парадокс Кондорсе");
                    bestAlternative_buf = "0";
                }
                else
                {
                    for (int i = 0; i < bestAlternative_list.Count; i++)
                    {
                        bestAlternative_buf += bestAlternative_list[i].ToString();
                    }
                }
                byte[] bestAlternative = Encoding.Unicode.GetBytes(bestAlternative_buf.ToString());

                stream.Write(bestAlternative, 0, bestAlternative.Length);
                stream.Flush();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}