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

        private void buttonBackLogReg_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
    }
}
