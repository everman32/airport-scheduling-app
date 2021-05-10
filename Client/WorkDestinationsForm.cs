using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkDestinationsForm : Form
    {
        public Form form;
        public WorkDestinationsForm(AvianavigationSpecialistForm avianavigationSpecialistForm)
        {
            form = avianavigationSpecialistForm;
            InitializeComponent();

        }
        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
    }
}
