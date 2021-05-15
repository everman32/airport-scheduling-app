﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkFlightRequestsForm : Form
    {
        public Form form1;
        public Form form2;
        public Form form3;
        public WorkFlightRequestsForm(DispatcherForm dispatcherForm, WorkPassengersForm workPassengersForm, WorkDestinationsForm workDestinationsForm)
        {
            InitializeComponent();
            form1 = dispatcherForm;
            form2 = workPassengersForm;
            form3 = workDestinationsForm;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        private void WorkFlightRequestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form1.Show();
        }

        private void toolStripButtonView_Click (object sender, EventArgs e)
        {
            Client.SendRequestToServer("Select flightrequests");
            DataTable dataTable = Client.ReceiveSelectFlightRequests();

            this.Size = new System.Drawing.Size(1198, 456);
            panelViewing.Enabled = true;
            panelViewing.Visible = true;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            FlightRequestsGridView.DataSource = dataTable;

            FlightRequestsGridView.AllowUserToAddRows = false;
            FlightRequestsGridView.AllowUserToResizeColumns = false;
            FlightRequestsGridView.AllowUserToResizeRows = false;

            FlightRequestsGridView.RowHeadersVisible = false;
            FlightRequestsGridView.ReadOnly = true;
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(600, 456);
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = true;
            panelAdding.Visible = true;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select passengersNames");
            DataTable dataTable_passenger = Client.ReceiveSelectPassengersNames();
            comboBoxPassenger.DataSource = dataTable_passenger;
            comboBoxPassenger.DisplayMember = "ФИО пассажира";
            comboBoxPassenger.ValueMember = "Id";


            Client.SendRequestToServer("Select destinationsNames");
            DataTable dataTable_destination = Client.ReceiveSelectDestinationsNames();
            comboBoxDestination.DataSource = dataTable_destination;
            comboBoxDestination.DisplayMember = "Name";
            comboBoxDestination.ValueMember = "Id";
        }
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(600, 456);
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = true;
            panelEditing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;


        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(600, 456);
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;
        }

        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Add flightrequest");

            string selected_idpassenger = comboBoxPassenger.SelectedValue.ToString();
            string selected_iddestination = comboBoxDestination.SelectedValue.ToString();
            string selected_highestPrioritytime = comboBoxHighestPriorityTime.Text;
            string selected_mediumPrioritytime = comboBoxMediumPriorityTime.Text;
            string selected_lowestPrioritytime = comboBoxLowestPriorityTime.Text;

            DataTable dataTable = Client.ReceiveAddFlightRequestData(selected_idpassenger, selected_iddestination,
                selected_highestPrioritytime, selected_mediumPrioritytime, selected_lowestPrioritytime);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Заявка на полёт пассажира" + comboBoxPassenger.SelectedText + " в пункт назначения "+
                    comboBoxDestination.SelectedText+" добавлена");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось добавить заявку на полёт, заявка на полёт с такими данными существует");
            }
        }
        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxHighestPriorityTime.Items.Clear();
            comboBoxMediumPriorityTime.Items.Clear();
            comboBoxLowestPriorityTime.Items.Clear();

            labelHighestPriorityTime.Visible = false;
            labelMediumPriorityTime.Visible = false;
            labelLowestPriorityTime.Visible = false;

            comboBoxHighestPriorityTime.Visible = false;
            comboBoxMediumPriorityTime.Visible = false;
            comboBoxLowestPriorityTime.Visible = false;
        }
        private void comboBoxCheckEqual()
        {
            if (comboBoxHighestPriorityTime.SelectedIndex != -1 && comboBoxMediumPriorityTime.SelectedIndex != -1 &&
                comboBoxLowestPriorityTime.SelectedIndex != -1)
            {
                if (comboBoxHighestPriorityTime.SelectedIndex == comboBoxMediumPriorityTime.SelectedIndex ||
                     comboBoxMediumPriorityTime.SelectedIndex == comboBoxLowestPriorityTime.SelectedIndex ||
                     comboBoxHighestPriorityTime.SelectedIndex == comboBoxLowestPriorityTime.SelectedIndex)
                {
                    MessageBox.Show("Времена не должны совпадать");
                    buttonAddFlightRequest.Enabled = false;
                }
            }
        }
        private void comboBoxHighestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxCheckEqual();
        }
        private void comboBoxMediumPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxCheckEqual();
        }
        private void comboBoxLowestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxCheckEqual();
        }
        private bool comboboxCheck_empty()
        {
            if (comboBoxDestination.SelectedIndex != -1 && comboBoxPassenger.SelectedIndex != -1 && comboBoxHighestPriorityTime.SelectedIndex != -1 &&
                comboBoxMediumPriorityTime.SelectedIndex != -1 && comboBoxLowestPriorityTime.SelectedIndex != -1)
            {
                buttonAddFlightRequest.Enabled = true;
                return true;
            }
            else
            {
                buttonAddFlightRequest.Enabled = false;
            }
            return false;
        }
        private void comboBoxPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxHighestPriorityTime.Items.Clear();
            comboBoxMediumPriorityTime.Items.Clear();
            comboBoxLowestPriorityTime.Items.Clear();

            labelHighestPriorityTime.Visible = false;
            labelMediumPriorityTime.Visible = false;
            labelLowestPriorityTime.Visible = false;

            comboBoxHighestPriorityTime.Visible = false;
            comboBoxMediumPriorityTime.Visible = false;
            comboBoxLowestPriorityTime.Visible = false;
        }
        private void buttonGetTime_Click(object sender, EventArgs e)
        {
            comboBoxHighestPriorityTime.Items.Clear();
            comboBoxMediumPriorityTime.Items.Clear();
            comboBoxLowestPriorityTime.Items.Clear();

            labelHighestPriorityTime.Visible = true;
            labelMediumPriorityTime.Visible = true;
            labelLowestPriorityTime.Visible = true;

            comboBoxHighestPriorityTime.Visible = true;
            comboBoxMediumPriorityTime.Visible = true;
            comboBoxLowestPriorityTime.Visible = true;

            string id = comboBoxDestination.SelectedValue.ToString();

                    Client.SendRequestToServer("Select estimatedtimes");
                    DataTable dataTable = Client.ReceiveSelectEstimatedTimes(id);

                    string[] estimatedtime = { dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString(),
                dataTable.Rows[0][2].ToString() };

                    comboBoxHighestPriorityTime.Items.AddRange(estimatedtime);
                    comboBoxMediumPriorityTime.Items.AddRange(estimatedtime);
                    comboBoxLowestPriorityTime.Items.AddRange(estimatedtime);
        }

        private void buttonEditFlightRequest_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Edit flightrequest");

            string selected_idflightrequest = textBoxEditId.Text;
            string selected_highestPrioritytime = comboBoxEditHighestPriorityTime.Text;
            string selected_mediumPrioritytime = comboBoxEditMediumPriorityTime.Text;
            string selected_lowestPrioritytime = comboBoxEditLowestPriorityTime.Text;

            DataTable dataTable = Client.ReceiveEditFlightRequestData(selected_idflightrequest,
                selected_highestPrioritytime, selected_mediumPrioritytime, selected_lowestPrioritytime);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Заявка на полёт пассажира с идент. номером" + textBoxEditId.Text +" отредактирована");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось отредактировать заявку на полёт, заявки на полёт с идент. номером"+ textBoxEditId.Text+" не существует");
            }
        }

        private bool comboboxtextBoxEditCheck_empty()
        {
            if (comboBoxEditHighestPriorityTime.SelectedIndex != -1 && comboBoxEditMediumPriorityTime.SelectedIndex != -1 && comboBoxEditLowestPriorityTime.SelectedIndex != -1&& textBoxEditId.Text!="")
            {
                buttonEditFlightRequest.Enabled = true;
                return true;
            }
            else
            {
                buttonEditFlightRequest.Enabled = false;
            }
            return false;
        }
        private void comboBoxEditCheckEqual()
        {
            if (comboBoxEditHighestPriorityTime.SelectedIndex != -1 && comboBoxEditMediumPriorityTime.SelectedIndex != -1 &&
                comboBoxEditLowestPriorityTime.SelectedIndex != -1)
            {
                if (comboBoxEditHighestPriorityTime.SelectedIndex == comboBoxEditMediumPriorityTime.SelectedIndex ||
                     comboBoxEditMediumPriorityTime.SelectedIndex == comboBoxEditLowestPriorityTime.SelectedIndex ||
                     comboBoxEditHighestPriorityTime.SelectedIndex == comboBoxEditLowestPriorityTime.SelectedIndex)
                {
                    MessageBox.Show("Времена не должны совпадать");
                    buttonEditFlightRequest.Enabled = false;
                }
            }
        }
        private void comboBoxEditHighestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxtextBoxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void comboBoxEditMediumPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxtextBoxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void comboBoxEditLowestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxtextBoxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void textBoxEditId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxEditId_TextChanged(object sender, EventArgs e)
        {
            comboboxtextBoxEditCheck_empty();

            comboBoxEditHighestPriorityTime.Items.Clear();
            comboBoxEditMediumPriorityTime.Items.Clear();
            comboBoxEditLowestPriorityTime.Items.Clear();

            labelEditHighestPriorityTime.Visible = false;
            labelEditMediumPriorityTime.Visible = false;
            labelEditLowestPriorityTime.Visible = false;

            comboBoxEditHighestPriorityTime.Visible = false;
            comboBoxEditMediumPriorityTime.Visible = false;
            comboBoxEditLowestPriorityTime.Visible = false;
        }
        private void buttonEditGetTime_Click(object sender, EventArgs e)
        {
            string id = textBoxEditId.Text;

            Client.SendRequestToServer("Select prioritytimes");
            DataTable dataTable = Client.ReceiveSelectPriorityTimes(id);
            if (dataTable.Rows.Count == 1)
            {
                comboBoxEditHighestPriorityTime.Items.Clear();
                comboBoxEditMediumPriorityTime.Items.Clear();
                comboBoxEditLowestPriorityTime.Items.Clear();

                labelEditHighestPriorityTime.Visible = true;
                labelEditMediumPriorityTime.Visible = true;
                labelEditLowestPriorityTime.Visible = true;

                comboBoxEditHighestPriorityTime.Visible = true;
                comboBoxEditMediumPriorityTime.Visible = true;
                comboBoxEditLowestPriorityTime.Visible = true;

                buttonEditFlightRequest.Visible = true;


                string[] prioritytime = { dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString(),
                dataTable.Rows[0][2].ToString() };

                comboBoxEditHighestPriorityTime.Items.AddRange(prioritytime);
                comboBoxEditMediumPriorityTime.Items.AddRange(prioritytime);
                comboBoxEditLowestPriorityTime.Items.AddRange(prioritytime);
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось получить даты полётов, заявки на полёт с идент. номером " + textBoxEditId.Text + " не существует");
            }
        }

        private void buttonDeleteDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete flightrequest");

            string selected_id = textBoxDeleteId.Text;

            int deleted_count = Client.ReceiveDeleteFlightRequestData(selected_id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление заявки на полёт с Идент. номером " + selected_id + " выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не удалось удалить заявку на полёт, заявки с таким идент. номером не существует");
            }
        }

        private void buttonEditPassenger_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        private void buttonEditDestination_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        private void buttonViewEdit_Click(object sender, EventArgs e)
        {
            labelEditId.Visible = true;
            textBoxEditId.Visible = true;
            buttonEditGetTime.Visible = true;
        }

        private bool textBoxDeleteFlightRequestCheck_empty()
        {
            if (textBoxDeleteId.Text != "")
            {
                buttonDeleteFlightRequest.Enabled = true;
                return true;
            }
            else
            {
                buttonDeleteFlightRequest.Enabled = false;
            }
            return false;
        }
        private void textBoxDeleteId_TextChanged(object sender, EventArgs e)
        {
            textBoxDeleteFlightRequestCheck_empty();
        }

        private void textBoxDeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
