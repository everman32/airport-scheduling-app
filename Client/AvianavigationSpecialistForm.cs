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
        public AvianavigationSpecialistForm(LoginForm loginForm)
        {
            InitializeComponent();
            form = loginForm;
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonWorkClients_Click(object sender, EventArgs e)
        {
            WorkClientsForm workClientsForm;
            workClientsForm = new WorkClientsForm(this);
            Hide();
            workClientsForm.Show();
        }
    }
}
