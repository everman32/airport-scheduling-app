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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Login");
          
            string selected_login = textBoxLogin.Text;
            string selected_password = textBoxPass.Text;

            DataTable dataTable = Client.ReceiveAuthorizeData(selected_login, selected_password);
            if (dataTable.Rows.Count == 1)
            {
                if (dataTable.Rows[0][2].ToString() == "1")
                {
                    AdminForm adminPanel = new AdminForm(this);
                    Hide();
                    adminPanel.Show();
                    Client.accessRight = 1;
                }
                else if (dataTable.Rows[0][2].ToString() == "2")
                {
                    AvianavigationSpecialistForm dispatcherForm = new AvianavigationSpecialistForm(this);
                    Hide();
                    dispatcherForm.Show();
                    Client.accessRight = 2;
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
            if (textBoxLogin.Text != "" && textBoxPass.Text != "")
            {
                buttonLogin.Enabled = true;
                return true;
            }
            else
            {
                buttonLogin.Enabled = false;
            }
            return false;
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
           textBoxCheck_empty();
        }
        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
