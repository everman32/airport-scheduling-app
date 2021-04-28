using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class LogRegForm : Form
    {
        public Form mainPanel;
        public LogRegForm(MainForm main)
        {
            InitializeComponent();
            mainPanel = main;
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            Hide();
            mainPanel.Show();
        }

        private void LoginRegisterPanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuthorizationPanel_Click(object sender, EventArgs e)
        {
            LoginForm loginPanel;
            loginPanel = new LoginForm(this);
            Hide();
            loginPanel.Show();
        }
    }
}
