using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminForm : Form
    {
        public Form form;
        public WorkPassengersForm workPassengersForm;
        public WorkDestinationsForm workDestinationsForm;
        public WorkFlightRequestsForm workFlightRequestsForm;
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            form = loginForm;

            workPassengersForm = new WorkPassengersForm(this);
            workDestinationsForm = new WorkDestinationsForm(this);
            workFlightRequestsForm = new WorkFlightRequestsForm(this, workPassengersForm, workDestinationsForm);
        }
        public AdminForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            form = registrationForm;
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonWorkPassengers_Click(object sender, EventArgs e)
        {
            Hide();
            workPassengersForm.Show();
        }

        private void buttonWorkDestinations_Click(object sender, EventArgs e)
        {
            Hide();
            workDestinationsForm.Show();
        }

        private void buttonWorkFlightRequests_Click(object sender, EventArgs e)
        {
            Hide();
            workFlightRequestsForm.Show();
        }

        private void buttonSearchBestAlternative_Click(object sender, EventArgs e)
        {
            WorkCondorsetAlternative workCondorsetAlternative;
            workCondorsetAlternative = new WorkCondorsetAlternative(this);

            Hide();
            workCondorsetAlternative.Show();
        }

        private void buttonWorkAccounts_Click(object sender, EventArgs e)
        {
            WorkAccountsForm workAccountsForm;
            workAccountsForm = new WorkAccountsForm(this);
            workAccountsForm.Show();
        }
    }
}
