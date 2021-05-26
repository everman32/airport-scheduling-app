using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class DispatcherForm : Form
    {
        public Form form;
        public WorkPassengersForm workPassengersForm;
        public WorkDestinationsForm workDestinationsForm;
        public WorkFlightRequestsForm workFlightRequestsForm;

        public DispatcherForm(LoginForm loginForm)
        {
            InitializeComponent();
            form = loginForm;

            workPassengersForm = new WorkPassengersForm(this);
            workDestinationsForm = new WorkDestinationsForm(this);
            workFlightRequestsForm = new WorkFlightRequestsForm(this, workPassengersForm, workDestinationsForm);
        }
        public DispatcherForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            form = registrationForm;

            workPassengersForm = new WorkPassengersForm(this);
            workDestinationsForm = new WorkDestinationsForm(this);
            workFlightRequestsForm = new WorkFlightRequestsForm(this, workPassengersForm, workDestinationsForm);
        }

        private void buttonBackLogReg_Click(object sender, EventArgs e)
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
        private void buttonWorkClients_Click(object sender, EventArgs e)
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

        private void AvianavigationSpecialistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
