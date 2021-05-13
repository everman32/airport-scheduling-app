using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class AvianavigationSpecialistForm : Form
    {
        public Form form;
        public WorkPassengersForm workPassengersForm;
        public WorkDestinationsForm workDestinationsForm;
        public WorkFlightRequestsForm workFlightRequestsForm;

        public AvianavigationSpecialistForm(LoginForm loginForm)
        {
            InitializeComponent();
            form = loginForm;

            workPassengersForm = new WorkPassengersForm(this);
            workDestinationsForm = new WorkDestinationsForm(this);
            workFlightRequestsForm = new WorkFlightRequestsForm(this, workPassengersForm, workDestinationsForm);
        }
        public AvianavigationSpecialistForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            form = registrationForm;
        }

        private void buttonBackLogReg_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
        private void buttonWorkClients_Click(object sender, EventArgs e)
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

        private void AvianavigationSpecialistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
