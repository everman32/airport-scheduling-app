using System;
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
        public WorkFlightRequestsForm(AdminForm adminForm, WorkPassengersForm workPassengersForm, WorkDestinationsForm workDestinationsForm)
        {
            InitializeComponent();
            form1 = adminForm;
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

            comboBoxDestination.SelectedIndex = -1;
            comboBoxPassenger.SelectedIndex = -1;
            comboBoxHighestPriorityTime.SelectedIndex = -1;
            comboBoxMediumPriorityTime.SelectedIndex = -1;
            comboBoxLowestPriorityTime.SelectedIndex = -1;
        }
        private void comboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboboxCheckDestination_empty();
            comboBoxHighestPriorityTime.SelectedIndex = -1 ;
            comboBoxMediumPriorityTime.SelectedIndex = -1;
            comboBoxLowestPriorityTime.SelectedIndex = -1;

            labelHighestPriorityTime.Visible = false;
            labelMediumPriorityTime.Visible = false;
            labelLowestPriorityTime.Visible = false;

            comboBoxHighestPriorityTime.Visible = false;
            comboBoxMediumPriorityTime.Visible = false;
            comboBoxLowestPriorityTime.Visible = false;
        }
        private void comboBoxPassenger_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboBoxHighestPriorityTime.SelectedIndex = -1;
            comboBoxMediumPriorityTime.SelectedIndex = -1;
            comboBoxLowestPriorityTime.SelectedIndex = -1;

            labelHighestPriorityTime.Visible = false;
            labelMediumPriorityTime.Visible = false;
            labelLowestPriorityTime.Visible = false;

            comboBoxHighestPriorityTime.Visible = false;
            comboBoxMediumPriorityTime.Visible = false;
            comboBoxLowestPriorityTime.Visible = false;
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
        private bool comboboxCheckDestination_empty()
        {
            if (comboBoxDestination.SelectedIndex != -1)
            {
                buttonGetTime.Enabled = true;
                return true;
            }
            else
            {
                buttonGetTime.Enabled = false;
            }
            return false;
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
                    MessageBox.Show("Даты не должны совпадать");
                    buttonAddFlightRequest.Enabled = false;
                }
            }
        }
        private void buttonGetTime_Click(object sender, EventArgs e)
        {
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

            comboBoxHighestPriorityTime.Items.Clear();
            comboBoxMediumPriorityTime.Items.Clear();
            comboBoxLowestPriorityTime.Items.Clear();

            comboBoxHighestPriorityTime.Items.AddRange(estimatedtime);
            comboBoxMediumPriorityTime.Items.AddRange(estimatedtime);
            comboBoxLowestPriorityTime.Items.AddRange(estimatedtime);

            comboBoxHighestPriorityTime.SelectedIndex = -1;
            comboBoxMediumPriorityTime.SelectedIndex = -1;
            comboBoxLowestPriorityTime.SelectedIndex = -1;
        }


        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = true;
            panelEditing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select flightrequestsNames");
            DataTable dataTable_flightrequest = Client.ReceiveSelectFlightrequestsNames();
            comboBoxEdit.DataSource = dataTable_flightrequest;
            comboBoxEdit.DisplayMember = "Заявка";
            comboBoxEdit.ValueMember = "Id";

            comboBoxEdit.SelectedIndex = -1;
            comboBoxEditHighestPriorityTime.SelectedIndex = -1;
            comboBoxEditMediumPriorityTime.SelectedIndex = -1;
            comboBoxEditLowestPriorityTime.SelectedIndex = -1;
        }
        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxCheck_empty();
            comboboxCheckFlightRequest_empty();
            comboBoxEditHighestPriorityTime.SelectedIndex = -1;
            comboBoxEditMediumPriorityTime.SelectedIndex = -1;
            comboBoxEditLowestPriorityTime.SelectedIndex = -1;

            labelEditHighestPriorityTime.Visible = false;
            labelEditMediumPriorityTime.Visible = false;
            labelEditLowestPriorityTime.Visible = false;

            comboBoxEditHighestPriorityTime.Visible = false;
            comboBoxEditMediumPriorityTime.Visible = false;
            comboBoxEditLowestPriorityTime.Visible = false;
        }
        private bool comboboxEditCheck_empty()
        {
            if (comboBoxEdit.SelectedIndex!=-1 && comboBoxEditHighestPriorityTime.SelectedIndex != -1 && comboBoxEditMediumPriorityTime.SelectedIndex != -1 && comboBoxEditLowestPriorityTime.SelectedIndex != -1)
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
        private bool comboboxCheckFlightRequest_empty()
        {
            if (comboBoxEdit.SelectedIndex != -1)
            {
                buttonEditGetTime.Enabled = true;
                return true;
            }
            else
            {
                buttonEditGetTime.Enabled = false;
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
                    MessageBox.Show("Даты не должны совпадать");
                    buttonEditFlightRequest.Enabled = false;
                }
            }
        }
        private void comboBoxEditHighestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void comboBoxEditMediumPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void comboBoxEditLowestPriorityTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxEditCheck_empty();
            comboBoxEditCheckEqual();
        }
        private void buttonEditGetTime_Click(object sender, EventArgs e)
        {
            string id = comboBoxEdit.SelectedValue.ToString();

            Client.SendRequestToServer("Select prioritytimes");
            DataTable dataTable = Client.ReceiveSelectPriorityTimes(id);
            if (dataTable.Rows.Count == 1)
            {
                comboBoxEditHighestPriorityTime.Items.Clear();
                comboBoxEditMediumPriorityTime.Items.Clear();
                comboBoxEditLowestPriorityTime.Items.Clear();

                comboBoxEditHighestPriorityTime.SelectedIndex = -1;
                comboBoxEditMediumPriorityTime.SelectedIndex = -1;
                comboBoxEditLowestPriorityTime.SelectedIndex = -1;

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
                MessageBox.Show("Такой заявки не существует");
            }
        }


        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;

            Client.SendRequestToServer("Select flightrequestsNames");
            DataTable dataTable_flightrequest = Client.ReceiveSelectFlightrequestsNames();
            comboBoxDelete.DataSource = dataTable_flightrequest;
            comboBoxDelete.DisplayMember = "Заявка";
            comboBoxDelete.ValueMember = "Id";

            comboBoxDelete.SelectedIndex = -1;
        }
        private bool comboBoxDeleteCheck_empty()
        {
            if (comboBoxDelete.SelectedIndex != -1)
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
        private void comboBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeleteCheck_empty();
        }


        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Add flightrequest");

            string idpassenger = comboBoxPassenger.SelectedValue.ToString();
            string iddestination = comboBoxDestination.SelectedValue.ToString();
            string highestPrioritytime = comboBoxHighestPriorityTime.Text;
            string mediumPrioritytime = comboBoxMediumPriorityTime.Text;
            string lowestPrioritytime = comboBoxLowestPriorityTime.Text;

            DataTable dataTable = Client.ReceiveAddFlightRequestData(idpassenger, iddestination,
                highestPrioritytime, mediumPrioritytime, lowestPrioritytime);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Заявка на полёт добавлена");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Заявка на полёт с такими данными существует");
            }
        }
        private void buttonEditFlightRequest_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Edit flightrequest");

            string id = comboBoxEdit.SelectedValue.ToString();
            string highestPrioritytime = comboBoxEditHighestPriorityTime.Text;
            string mediumPrioritytime = comboBoxEditMediumPriorityTime.Text;
            string lowestPrioritytime = comboBoxEditLowestPriorityTime.Text;

            DataTable dataTable = Client.ReceiveEditFlightRequestData(id,
                highestPrioritytime, mediumPrioritytime, lowestPrioritytime);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Заявка на полёт отредактирована");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Такой заявки не существует");
            }
        }
        private void buttonDeleteDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete flightrequest");

            string id = comboBoxDelete.SelectedValue.ToString();

            int deleted_count = Client.ReceiveDeleteFlightRequestData(id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление заявки на полёт выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Такой заявки не существует");
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
    }
}
