using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ClientSide;

namespace Client
{
    public partial class WorkCondorsetAlternative : Form
    {
        public Form form;
        public WorkCondorsetAlternative(DispatcherForm dispatcherForm)
        {
            InitializeComponent();
            form = dispatcherForm;
            panelSearchingAlternative.Enabled = false;
            panelSearchingAlternative.Visible = false;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        public WorkCondorsetAlternative(AdminForm adminForm)
        {
            InitializeComponent();
            form = adminForm;
            panelSearchingAlternative.Enabled = false;
            panelSearchingAlternative.Visible = false;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }

        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
        private void WorkCondorsetAlternative_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void toolStripButtonSearchAlternative_Click(object sender, EventArgs e)
        {
            panelSearchingAlternative.Enabled = true;
            panelSearchingAlternative.Visible = true;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select destinationsNamesCondorcet");
            DataTable dataTable_destination = Client.ReceiveSelectDestinationsNamesCondorcet();
            comboBoxDestination.DataSource = dataTable_destination;
            comboBoxDestination.DisplayMember = "Name";
            comboBoxDestination.ValueMember = "Id";
        }
        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGetEstimatedPriorityTimes.Visible = true;
            labelPairwiseComparison.Visible = false;
            PairwiseComparisonGridView.Visible = false;
            buttonSearchAlternative.Visible = false;
            buttonReportPassengersFlight.Visible = false;
        }
        private void PairwiseComparisonGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            PairwiseComparisonGridView.RowHeadersWidth = 90;
            foreach (DataGridViewRow row in PairwiseComparisonGridView.Rows)
            {
                row.HeaderCell.Value = "a" + (row.Index + 1).ToString();
            }
        }

        private void toolStripButtonViewSchedule_Click(object sender, EventArgs e)
        {
            panelSearchingAlternative.Enabled = false;
            panelSearchingAlternative.Visible = false;
            panelViewing.Enabled = true;
            panelViewing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select schedule");
            DataTable dataTable = Client.ReceiveSelectSchedule();

            ScheduleGridView.DataSource = dataTable;

            ScheduleGridView.AllowUserToAddRows = false;
            ScheduleGridView.AllowUserToResizeColumns = false;
            ScheduleGridView.AllowUserToResizeRows = false;

            ScheduleGridView.RowHeadersVisible = false;
            ScheduleGridView.ReadOnly = true;
        }


        private void toolStripButtonDeleteSchedule_Click(object sender, EventArgs e)
        {
            panelSearchingAlternative.Enabled = false;
            panelSearchingAlternative.Visible = false;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;

            Client.SendRequestToServer("Select schedulesNames");
            DataTable dataTable_schedule = Client.ReceiveSelectSchedulesNames();
            comboBoxDelete.DataSource = dataTable_schedule;
            comboBoxDelete.DisplayMember = "Расписание";
            comboBoxDelete.ValueMember = "Id";

            comboBoxDelete.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeleteCheck_empty();
        }
        private bool comboBoxDeleteCheck_empty()
        {
            if (comboBoxDelete.SelectedIndex != -1)
            {
                buttonDeleteSchedule.Enabled = true;
                return true;
            }
            else
            {
                buttonDeleteSchedule.Enabled = false;
            }
            return false;
        }

        private void buttonGetEstimatedPriorityTimes_Click(object sender, EventArgs e)
        {
            labelEstimatedTimes.Visible = true;

            string id = comboBoxDestination.SelectedValue.ToString();


            Client.SendRequestToServer("Select estimatedtimesCondorcet");
            DataTable dataTableEstimatedTimes = Client.ReceiveSelectEstimatedTimesCondorcet(id);

            EstimatedTimesGridView.DataSource = dataTableEstimatedTimes;

            EstimatedTimesGridView.AllowUserToAddRows = false;
            EstimatedTimesGridView.AllowUserToResizeColumns = false;
            EstimatedTimesGridView.AllowUserToResizeRows = false;

            EstimatedTimesGridView.RowHeadersVisible = false;
            EstimatedTimesGridView.ReadOnly = true;
            EstimatedTimesGridView.Visible = true;

            labelPriorityTimes.Visible = true;

            foreach (DataGridViewColumn column in EstimatedTimesGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            Client.SendRequestToServer("Select prioritytimesCondorcet");
            DataTable dataTablePriorityTimes = Client.ReceiveSelectPriorityTimesCondorcet(id);

            PriorityTimesGridView.DataSource = dataTablePriorityTimes;

            PriorityTimesGridView.AllowUserToAddRows = false;
            PriorityTimesGridView.AllowUserToResizeColumns = false;
            PriorityTimesGridView.AllowUserToResizeRows = false;

            PriorityTimesGridView.RowHeadersVisible = false;
            PriorityTimesGridView.ReadOnly = true;
            PriorityTimesGridView.Visible = true;

            labelPreferences.Visible = true;

            foreach (DataGridViewColumn column in PriorityTimesGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           

            Client.SendRequestToServer("Select preferencesCondorcet");
            DataTable dataTablePreferences = Client.ReceiveSelectPreferencesCondorcet(id);

            PreferencesGridView.DataSource = dataTablePreferences;

            PreferencesGridView.AllowUserToAddRows = false;
            PreferencesGridView.AllowUserToResizeColumns = false;
            PreferencesGridView.AllowUserToResizeRows = false;

            PreferencesGridView.RowHeadersVisible = false;
            PreferencesGridView.ReadOnly = true;

            PreferencesGridView.Visible = true;

            foreach (DataGridViewColumn column in PreferencesGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           

            Client.SendRequestToServer("Select pairwiseComparison");
            DataTable dataTablePairwise = Client.ReceiveSelectPairwiseComparison(id);

            labelPairwiseComparison.Visible = true;
            PairwiseComparisonGridView.DataSource = dataTablePairwise;

            PairwiseComparisonGridView.AllowUserToAddRows = false;
            PairwiseComparisonGridView.AllowUserToResizeColumns = false;
            PairwiseComparisonGridView.AllowUserToResizeRows = false;
            PairwiseComparisonGridView.AllowUserToDeleteRows = false;

            PairwiseComparisonGridView.ReadOnly = true;
            PairwiseComparisonGridView.Visible = true;

            buttonSearchAlternative.Visible = true;

            foreach (DataGridViewColumn column in PairwiseComparisonGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void buttonSearchAlternative_Click(object sender, EventArgs e)
        {
            int matrixPairwiseComparison_count = PairwiseComparisonGridView.Rows.Count;
            int[,] matrixPairwiseComparison = new int[matrixPairwiseComparison_count, matrixPairwiseComparison_count];
            for (int j = 0; j < matrixPairwiseComparison_count; j++)
            {
                for (int i = 0; i < matrixPairwiseComparison_count; i++)
                {
                    matrixPairwiseComparison[i, j] = Convert.ToInt32(PairwiseComparisonGridView.Rows[i].Cells[j].Value);
                }
            }
            Client.SendRequestToServer("Select bestAlternative");
            int[] bestAlternative_buf = Client.ReceiveSearchBestAlternative(matrixPairwiseComparison, matrixPairwiseComparison_count);
            ArrayList bestAlternative = new ArrayList(bestAlternative_buf);
  
            if (bestAlternative.Count==3)
            {
                MessageBox.Show("Наиболее предпочтительные варианты. Парадокс Кондорсе");
            }
            else if (bestAlternative.Count == 1)
            {
                MessageBox.Show("Наиболее предпочтительные варианты. Наилучшей альтернативой является: а" + bestAlternative[0] + " (" +
                EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[0])].Value + ") ");

                string IdDestination = comboBoxDestination.SelectedValue.ToString();
                string finalDate = EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[0])].Value.ToString();

                Client.SendRequestToServer("Add schedule");
                DataTable dataTable = Client.ReceiveAddScheduleData(IdDestination, finalDate);

                if (dataTable.Rows.Count == 1)
                {
                    string DestinationName = comboBoxDestination.Text;
                    MessageBox.Show("Расписание для пункта назначения " + DestinationName + " составлено. Время отправления: " +
                      finalDate);
                    writetoPdf(DestinationName, finalDate);
                    buttonReportPassengersFlight.Visible = true;
                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Не удалось добавить расписание для пункта назначения, расписание для этого пункта назначения существует");
                }
            }
            else if (bestAlternative.Count == 2)
            {
                MessageBox.Show("Наиболее предпочтительные варианты. Наилучшими альтернативами являются: а" + bestAlternative[0] + " (" +
                    EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[0])].Value + ") " + "а" + bestAlternative[1] + " (" +
                    EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[1])].Value + ") ");

                string IdDestination = comboBoxDestination.SelectedValue.ToString();
                string finalDate = EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[0])].Value.ToString();
                string reserveDate= EstimatedTimesGridView.Rows[0].Cells[Convert.ToInt32(bestAlternative[1])].Value.ToString();

                Client.SendRequestToServer("Add scheduleWithReserve");
                DataTable dataTable = Client.ReceiveAddScheduleWithReserveData(IdDestination, finalDate, reserveDate);

                if (dataTable.Rows.Count == 1)
                {
                    string DestinationName = comboBoxDestination.Text;
                    MessageBox.Show("Расписание для пункта назначения " + DestinationName + " составлено. Время отправления: " +
                      finalDate+" Резервное время (время для дополнительного маршрута): "+ reserveDate);
                    writetoPdf(DestinationName, finalDate, reserveDate);
                    buttonReportPassengersFlight.Visible = true;
                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Не удалось добавить расписание для пункта назначения, расписание для этого пункта назначения существует");
                }
            }
            
        }
        private void buttonGraphDate_Click(object sender, EventArgs e)
        {
            DiagramPassengersCount diagramPassengersCount;
            diagramPassengersCount = new DiagramPassengersCount(this, ScheduleGridView);
            diagramPassengersCount.Show();
        }
        private void buttonDeleteSchedule_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete schedule");

            string id = comboBoxDelete.SelectedValue.ToString();

            int deleted_count = Client.ReceiveDeleteScheduleData(id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление расписания на полёт выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Такого расписания на полёт не существует");
            }
        }


         private void buttonReportPassengersFlight_Click(object sender, EventArgs e)
        {
                Client.SendRequestToServer("Build report");

                string id = comboBoxDestination.SelectedValue.ToString();
                DataTable dataTable = Client.ReceiveBuildReportData(id);

                string name = comboBoxDestination.Text;
                writePassengerstoPdf(id, name, dataTable);
        }
        private void writePassengerstoPdf(string id, string name, DataTable dataTable)
        {
            try
            {
                MessageBox.Show("Сохранение отчёта в формате PDF");
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "Pdf File |*.pdf";
                svg.FileName = "Пассажиры " + name + " №" + id;
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(svg.FileName, FileMode.Create));
                    doc.Open();

                    BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                    PdfPTable table = new PdfPTable(dataTable.Columns.Count);

                    PdfPCell cell = new PdfPCell(new Phrase("Отчёт о пассажирах пункта назначения " + name+"\n\n", font));

                    cell.Colspan = dataTable.Columns.Count;
                    cell.HorizontalAlignment = 1;

                    cell.Border = 0;
                    table.AddCell(cell);

                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        cell = new PdfPCell(new Phrase(new Phrase(dataTable.Columns[j].ColumnName, font)));

                        cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                        table.AddCell(cell);
                    }

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dataTable.Rows[i][j].ToString(), font));
                        }
                    }
                    doc.Add(table);
                    doc.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void writetoPdf(string destinationName, string finalDate)
        {
            try
            {
                MessageBox.Show("Сохранение отчёта в формате PDF");
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "Pdf File |*.pdf";
                svg.FileName = "Расписание на полёт в " + destinationName + " №" + comboBoxDestination.SelectedValue.ToString();
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(svg.FileName, FileMode.Create));
                    doc.Open();

                    BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                    writeEstimatedTimestoPdf(doc, destinationName, finalDate, font);
                    writePriorityTimestoPdf(doc, destinationName, finalDate, font);
                    writePreferencestoPdf(doc, destinationName, finalDate, font);
                    writePairwiseComparisontoPdf(doc, destinationName, finalDate, font);
                    doc.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void writeEstimatedTimestoPdf(Document doc,string destinationName,string finalDate, iTextSharp.text.Font font)
        {
            PdfPTable table = new PdfPTable(EstimatedTimesGridView.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Альтернативой для пункта назначения " + destinationName + " №" + comboBoxDestination.SelectedValue.ToString() + " является " + finalDate+"\n\n", font));

            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Матрица предлагаемых времён", font));

            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            for (int i = 0; i < EstimatedTimesGridView.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(EstimatedTimesGridView.Columns[i].HeaderText, font)));
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }
            for (int i = 0; i < EstimatedTimesGridView.Rows.Count; i++)
            {
                for (int j = 0; j < EstimatedTimesGridView.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(EstimatedTimesGridView.Rows[i].Cells[j].Value.ToString(), font));
                }
            }
            doc.Add(table);
        }
        private void writePriorityTimestoPdf(Document doc, string destinationName, string finalDate, iTextSharp.text.Font font)
    {
        PdfPTable table = new PdfPTable(PriorityTimesGridView.Columns.Count);
        PdfPCell cell = new PdfPCell(new Phrase("\nМатрица приоритетных дат", font));
            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            for (int i = 0; i < PriorityTimesGridView.Columns.Count; i++)
        {
            cell = new PdfPCell(new Phrase(new Phrase(PriorityTimesGridView.Columns[i].HeaderText, font)));
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
            table.AddCell(cell);
        }
        for (int i = 0; i < PriorityTimesGridView.Rows.Count; i++)
        {
            for (int j = 0; j < PriorityTimesGridView.Columns.Count; j++)
            {
                table.AddCell(new Phrase(PriorityTimesGridView.Rows[i].Cells[j].Value.ToString(), font));
            }
        }
        doc.Add(table);
    }
        private void writePreferencestoPdf(Document doc, string destinationName, string finalDate, iTextSharp.text.Font font)
        {
            PdfPTable table = new PdfPTable(PreferencesGridView.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("\nМатрица предпочтений", font));
            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            for (int i = 0; i < PreferencesGridView.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(PreferencesGridView.Columns[i].HeaderText, font)));
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }
            for (int i = 0; i < PreferencesGridView.Rows.Count; i++)
            {
                for (int j = 0; j < PreferencesGridView.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(PreferencesGridView.Rows[i].Cells[j].Value.ToString(), font));
                }
            }
            doc.Add(table);
        }
        private void writePairwiseComparisontoPdf(Document doc, string destinationName, string finalDate, iTextSharp.text.Font font)
        {
            PdfPTable table = new PdfPTable(PairwiseComparisonGridView.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("\nМатрица попарных сравнений", font));
            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            for (int i = 0; i < PairwiseComparisonGridView.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(PairwiseComparisonGridView.Columns[i].HeaderText, font)));
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }
            for (int i = 0; i < PairwiseComparisonGridView.Rows.Count; i++)
            {
                for (int j = 0; j < PairwiseComparisonGridView.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(PairwiseComparisonGridView.Rows[i].Cells[j].Value.ToString(), font));
                }
            }
            doc.Add(table);
        }

        private void writetoPdf(string destinationName, string finalDate,string reserveDate)
        {
            try
            {
                MessageBox.Show("Сохранение отчёта в формате PDF");
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "Pdf File |*.pdf";
                svg.FileName = "Расписание на полёт в " + destinationName + " №" + comboBoxDestination.SelectedValue.ToString();
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, new FileStream(svg.FileName, FileMode.Create));
                    doc.Open();

                    BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                    writeEstimatedTimestoPdf(doc, destinationName, finalDate, reserveDate,font);
                    writePriorityTimestoPdf(doc, destinationName, finalDate, font);
                    writePreferencestoPdf(doc, destinationName, finalDate, font);
                    writePairwiseComparisontoPdf(doc, destinationName, finalDate, font);
                    doc.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void writeEstimatedTimestoPdf(Document doc, string destinationName, string finalDate, string reserveDate, iTextSharp.text.Font font)
        {
            PdfPTable table = new PdfPTable(EstimatedTimesGridView.Columns.Count);
            PdfPCell cell = new PdfPCell(new Phrase("Альтернативой для пункта назначения " + destinationName + " №" + comboBoxDestination.SelectedValue.ToString() + " является " + finalDate + " с резервной датой " + reserveDate +"\n\n", font));

            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Матрица предлагаемых времён", font));

            cell.Colspan = EstimatedTimesGridView.Columns.Count;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);

            for (int i = 0; i < EstimatedTimesGridView.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(new Phrase(EstimatedTimesGridView.Columns[i].HeaderText, font)));
                cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }
            for (int i = 0; i < EstimatedTimesGridView.Rows.Count; i++)
            {
                for (int j = 0; j < EstimatedTimesGridView.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(EstimatedTimesGridView.Rows[i].Cells[j].Value.ToString(), font));
                }
            }
            doc.Add(table);
        }
    }
}





