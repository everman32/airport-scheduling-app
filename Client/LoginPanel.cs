using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginPanel : Form
    {
        public Form form;
        public LoginPanel(LoginRegisterPanel loginregPanel)
        {
            InitializeComponent();
            form = loginregPanel;

        }

        private void buttonBackLoginRegister_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
    }
}
