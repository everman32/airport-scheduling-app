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

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Login");
            
           string checkLogin=Client.SendAuthToServerReceive(textBoxLogin.Text, textBoxPass.Text);
            if (checkLogin=="1")
            {
                MessageBox.Show("OK");
            }
            else if (checkLogin=="0")
            {
                MessageBox.Show("Введены неправильные данные авторизации"); ;
            }

            

        }
    }
}
