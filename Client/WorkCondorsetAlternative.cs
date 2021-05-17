using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Text;
using System.Windows.Forms;

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
            comboBoxDestination.DisplayMember = "Наименование пункта назначения";
            comboBoxDestination.ValueMember = "Идентификационный номер пункта назначения";
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

            //this.Size = new System.Drawing.Size(1198, 456);

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

        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGetEstimatedPriorityTimes.Visible = true;
            labelPairwiseComparison.Visible = false;
            buttonPairwiseComparison.Visible = false;
            PairwiseComparisonGridView.Visible = false;
            buttonSearchAlternative.Visible = false;
            buttonReportPassengersFlight.Visible = false;
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

            Client.SendRequestToServer("Select preferencesCondorcet");
            DataTable dataTablePreferences = Client.ReceiveSelectPreferencesCondorcet(id);

            PreferencesGridView.DataSource = dataTablePreferences;

            PreferencesGridView.AllowUserToAddRows = false;
            PreferencesGridView.AllowUserToResizeColumns = false;
            PreferencesGridView.AllowUserToResizeRows = false;

            PreferencesGridView.RowHeadersVisible = false;
            PreferencesGridView.ReadOnly = true;

            PreferencesGridView.Visible = true;

            buttonPairwiseComparison.Visible = true;
            
        }
        private void buttonPairwiseComparisonMatrix_Click(object sender, EventArgs e)
        {
            string id = comboBoxDestination.SelectedValue.ToString();

            Client.SendRequestToServer("Select pairwiseComparison");
            DataTable dataTablePairwise = Client.ReceiveSelectPairwiseComparison(id);

            labelPairwiseComparison.Visible = true;
            PairwiseComparisonGridView.DataSource = dataTablePairwise;

            PairwiseComparisonGridView.AllowUserToAddRows = false;
            PairwiseComparisonGridView.AllowUserToResizeColumns = false;
            PairwiseComparisonGridView.AllowUserToResizeRows = false;

            PairwiseComparisonGridView.RowHeadersVisible = false;
            PairwiseComparisonGridView.ReadOnly = true;

            PairwiseComparisonGridView.Visible = true;

            buttonSearchAlternative.Visible = true;
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
                    string DestinationName = comboBoxDestination.SelectedText;
                    MessageBox.Show("Расписание для пункта назначения " + DestinationName + " составлено. Время отправления: " +
                      finalDate);
                    buttonReportPassengersFlight.Visible = true;
                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Не удалось добавить расписание для пункта назначения, расписание для этого пункта назначения существует");
                }
            }
            else if (bestAlternative.Count == 2)
            {
                /*
                string str="";
                for(int i=0;i< bestAlternative.Count;i++)
                {
                    str += " а"+ bestAlternative[i].ToString()+";";
                }*/
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
                    string DestinationName = comboBoxDestination.SelectedText;
                    MessageBox.Show("Расписание для пункта назначения " + DestinationName + " составлено. Время отправления: " +
                      finalDate+" Резервное время (время для дополнительного маршрута): "+ reserveDate);
                    buttonReportPassengersFlight.Visible = true;
                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Не удалось добавить расписание для пункта назначения, расписание для этого пункта назначения существует");
                }
            }
            
        }


        private bool textBoxCheck_empty()
        {
            if (textBoxDeleteId.Text != "")
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

        private void textBoxDeleteId_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }

        private void textBoxDeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonDeleteSchedule_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete schedule");

            string selected_id = textBoxDeleteId.Text;

            int deleted_count = Client.ReceiveDeleteScheduleData(selected_id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление расписания на полёт с Идент. номером " + selected_id + " выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не удалось удалить расписание на полёт, расписания с таким идент. номером не существует");
            }
        }

        private void WorkCondorsetAlternative_Load(object sender, EventArgs e)
        {

        }

         void buttonReportPassengersFlight_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Build report");
            string selected_id = comboBoxDestination.SelectedValue.ToString();
            DataTable dataTable = Client.ReceiveBuildReportData(selected_id);

            Report report;
            report = new Report(this);
            report.PassengersFlightGridView.DataSource = dataTable;

            report.PassengersFlightGridView.DataSource = dataTable;

            report.PassengersFlightGridView.AllowUserToAddRows = false;
            report.PassengersFlightGridView.AllowUserToResizeColumns = false;
            report.PassengersFlightGridView.AllowUserToResizeRows = false;

            report.PassengersFlightGridView.RowHeadersVisible = false;
            report.PassengersFlightGridView.ReadOnly = true;

            report.PassengersFlightGridView.Visible = true;
            report.Show();
        }
    }
}
