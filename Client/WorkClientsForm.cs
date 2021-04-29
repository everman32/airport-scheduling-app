using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkClientsForm : Form
    {
        public Form form;
        public WorkClientsForm(AvianavigationSpecialistForm avianavigationSpecialistForm)
        {
            InitializeComponent();
            form = avianavigationSpecialistForm;
        }

        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }

        private void buttonUploadData_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Select clients"); 
            DataTable dataTable = Client.SendSelectClients();

            ClientsGridView.DataSource = dataTable;
        }
    }
}
