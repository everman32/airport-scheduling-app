using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminPanel : Form
    {
        public Form form;
        public AdminPanel(LoginPanel loginPanel)
        {
            InitializeComponent();
            form = loginPanel;
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
    }
}
