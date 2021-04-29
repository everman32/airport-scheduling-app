using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client
{
    public partial class LoginForm : Form
    {
        public Form form;
        public LoginForm(LogRegForm loginregForm)
        {
            InitializeComponent();
            form = loginregForm;
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

            DataTable dataTable = Client.SendAuthorizeServer(textBoxLogin.Text, textBoxPass.Text);
            if (dataTable.Rows.Count == 1)
            {
                if (dataTable.Rows[0][2].ToString() == "1")
                {
                    AdminForm adminPanel = new AdminForm(this);
                    Hide();
                    adminPanel.Show();
                    Client.typeaccount = 1;
                }
                else if (dataTable.Rows[0][2].ToString() == "2")
                {
                    AvianavigationSpecialistForm dispatcherForm = new AvianavigationSpecialistForm(this);
                    Hide();
                    dispatcherForm.Show();
                    Client.typeaccount = 2;
                }
                Client.login = textBoxLogin.Text;
                Client.password = textBoxPass.Text;
                MessageBox.Show("Авторизация выполнена. Вы вошли как " + Client.login);
            }
        else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Введены недействительные данные авторизации"); ;
            }
        }
        private bool textBoxCheck_empty()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    if (c.Text == string.Empty)
                    {
                        buttonLogin.Enabled = false;
                        return false;
                    }
            }
            buttonLogin.Enabled = true;
            return true;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
    }
}
