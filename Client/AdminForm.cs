using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminForm : Form
    {
        public Form form;
        public AdminForm(LoginForm loginForm)
        {
            InitializeComponent();
            form = loginForm;
        }
        public AdminForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            form = registrationForm;
        }

        private void buttonBackLogin_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
    }
}
