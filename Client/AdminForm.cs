using System;
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
            try
            {
            Hide();
            form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
            try
            {
                Hide();
                workPassengersForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonWorkDestinations_Click(object sender, EventArgs e)
        {
            try
            {
            Hide();
            workDestinationsForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonWorkFlightRequests_Click(object sender, EventArgs e)
        {
            try
            {
            Hide();
            workFlightRequestsForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonSearchBestAlternative_Click(object sender, EventArgs e)
        {
            try
            {
            WorkCondorsetAlternative workCondorsetAlternative;
            workCondorsetAlternative = new WorkCondorsetAlternative(this);

            Hide();
            workCondorsetAlternative.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonWorkAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                WorkAccountsForm workAccountsForm;
                workAccountsForm = new WorkAccountsForm(this);
                workAccountsForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
