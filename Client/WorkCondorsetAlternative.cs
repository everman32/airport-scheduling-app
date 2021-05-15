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
            panelViewingSchedule.Enabled = false;
            panelViewingSchedule.Visible = false;
            panelDeletingSchedule.Enabled = false;
            panelDeletingSchedule.Visible = false;
        }
        private void toolStripButtonSearchAlternative_Click(object sender, EventArgs e)
        {
            panelSearchingAlternative.Enabled = true;
            panelSearchingAlternative.Visible = true;
            panelViewingSchedule.Enabled = false;
            panelViewingSchedule.Visible = false;
            panelDeletingSchedule.Enabled = false;
            panelDeletingSchedule.Visible = false;

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
            panelViewingSchedule.Enabled = true;
            panelViewingSchedule.Visible = true;
            panelDeletingSchedule.Enabled = false;
            panelDeletingSchedule.Visible = false;
        }
        private void toolStripButtonDeleteSchedule_Click(object sender, EventArgs e)
        {
            panelSearchingAlternative.Enabled = false;
            panelSearchingAlternative.Visible = false;
            panelViewingSchedule.Enabled = false;
            panelViewingSchedule.Visible = false;
            panelDeletingSchedule.Enabled = true;
            panelDeletingSchedule.Visible = true;
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
            dataGridPairwiseComparison.Visible = false;
            buttonSearchAlternative.Visible = false;
        }
        private void buttonGetEstimatedPriorityTimes_Click(object sender, EventArgs e)
        {
            labelEstimatedTimes.Visible = true;

            string id = comboBoxDestination.SelectedValue.ToString();


            Client.SendRequestToServer("Select estimatedtimesCondorcet");
            DataTable dataTableEstimatedTimes = Client.ReceiveSelectEstimatedTimesCondorcet(id);

            dataGridEstimatedTimes.DataSource = dataTableEstimatedTimes;

            dataGridEstimatedTimes.AllowUserToAddRows = false;
            dataGridEstimatedTimes.AllowUserToResizeColumns = false;
            dataGridEstimatedTimes.AllowUserToResizeRows = false;

            dataGridEstimatedTimes.RowHeadersVisible = false;
            dataGridEstimatedTimes.ReadOnly = true;

            dataGridEstimatedTimes.Visible = true;

            labelPriorityTimes.Visible = true;


            Client.SendRequestToServer("Select prioritytimesCondorcet");
            DataTable dataTablePriorityTimes = Client.ReceiveSelectPriorityTimesCondorcet(id);

            dataGridPriorityTimes.DataSource = dataTablePriorityTimes;

            dataGridPriorityTimes.AllowUserToAddRows = false;
            dataGridPriorityTimes.AllowUserToResizeColumns = false;
            dataGridPriorityTimes.AllowUserToResizeRows = false;

            dataGridPriorityTimes.RowHeadersVisible = false;
            dataGridPriorityTimes.ReadOnly = true;

            dataGridPriorityTimes.Visible = true;


            labelPreferences.Visible = true;

            Client.SendRequestToServer("Select preferencesCondorcet");
            DataTable dataTablePreferences = Client.ReceiveSelectPreferencesCondorcet(id);

            dataGridPreferences.DataSource = dataTablePreferences;

            dataGridPreferences.AllowUserToAddRows = false;
            dataGridPreferences.AllowUserToResizeColumns = false;
            dataGridPreferences.AllowUserToResizeRows = false;

            dataGridPreferences.RowHeadersVisible = false;
            dataGridPreferences.ReadOnly = true;

            dataGridPreferences.Visible = true;

            buttonPairwiseComparison.Visible = true;
            
        }
        private void buttonPairwiseComparisonMatrix_Click(object sender, EventArgs e)
        {
            string id = comboBoxDestination.SelectedValue.ToString();

            Client.SendRequestToServer("Select pairwiseComparison");
            DataTable dataTablePairwise = Client.ReceiveSelectPairwiseComparison(id);

            labelPairwiseComparison.Visible = true;
            dataGridPairwiseComparison.DataSource = dataTablePairwise;

            dataGridPairwiseComparison.AllowUserToAddRows = false;
            dataGridPairwiseComparison.AllowUserToResizeColumns = false;
            dataGridPairwiseComparison.AllowUserToResizeRows = false;

            dataGridPairwiseComparison.RowHeadersVisible = false;
            dataGridPairwiseComparison.ReadOnly = true;

            dataGridPairwiseComparison.Visible = true;

            buttonSearchAlternative.Visible = true;
        }

        private void buttonSearchAlternative_Click(object sender, EventArgs e)
        {
            int matrixPairwiseComparison_count = dataGridPairwiseComparison.Rows.Count;
            int[,] matrixPairwiseComparison = new int[matrixPairwiseComparison_count, matrixPairwiseComparison_count];

            for (int j = 0; j < matrixPairwiseComparison_count; j++)
            {
                for (int i = 0; i < matrixPairwiseComparison_count; i++)
                {
                    matrixPairwiseComparison[i, j] = Convert.ToInt32(dataGridPairwiseComparison.Rows[i].Cells[j].Value);
                }
            }
            Client.SendRequestToServer("Select bestAlternative");

            int[] bestAlternative_buf = Client.ReceiveSearchBestAlternative(matrixPairwiseComparison, matrixPairwiseComparison_count);

            ArrayList bestAlternative = new ArrayList(bestAlternative_buf);
  

            if (bestAlternative.Count==3)
            {
                MessageBox.Show("Наиболее предпочтительные варианты. Парадокс Кондорсе");
            }
            else
            {
                string str="";

                for(int i=0;i< bestAlternative.Count;i++)
                {
                    str += " а"+ bestAlternative[i].ToString()+";";
                }
                MessageBox.Show("Наиболее предпочтительные варианты. Наилучшими альтернативами являются: " + str);
           }
        }
    }
}
