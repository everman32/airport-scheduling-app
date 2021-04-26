using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginRegisterPanel : Form
    {
        public Form mainPanel;
        public LoginRegisterPanel(MainPanel main)
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
            LoginPanel loginPanel;
            loginPanel = new LoginPanel(this);
            Hide();
            loginPanel.Show();
        }
    }
}
