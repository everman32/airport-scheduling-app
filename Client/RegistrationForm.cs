using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class RegistrationForm : Form
    {
        public Form form;
        public RegistrationForm(LogRegForm logRegForm)
        {
            InitializeComponent();
            form = logRegForm;
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Register");

            int accessRight=0;
            if (comboBoxAccessRight.SelectedIndex==0)
            {
                accessRight = 1;
            }
            else if (comboBoxAccessRight.SelectedIndex == 1)
            {
                accessRight = 2;
            }
            string selected_login = textBoxLogin.Text;
            string selected_password = textBoxPass.Text;
           
            DataTable dataTable = Client.ReceiveRegisterData(selected_login, selected_password, accessRight);
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
                MessageBox.Show("Регистрация выполнена. Вы вошли как "+Client.login);
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось зарегистрироваться, пользователь с таким логином уже существует"); ;
            }
        }
        private void buttonBackLogRegForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
        private bool textBoxComboBoxCheck_empty()
        {
            if (textBoxLogin.Text != "" && textBoxPass.Text != ""&& comboBoxAccessRight.SelectedIndex != -1)
            {
               buttonRegistration.Enabled = true;
                return true;
            }
            else
            {
                buttonRegistration.Enabled = false;
            }
            return false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBoxComboBoxCheck_empty();
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
           textBoxComboBoxCheck_empty();
        }
        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            textBoxComboBoxCheck_empty();
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

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
