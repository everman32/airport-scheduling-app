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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxComboBoxCheck_empty();
        }

        private void labelTypeAccount_Click(object sender, EventArgs e)
        {

        }

        private bool textBoxComboBoxCheck_empty()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    if (c.Text == string.Empty || comboBoxTypeAccount.SelectedIndex == -1)
                    {
                        buttonRegistration.Enabled = false;
                        return false;
                    }
            }
            buttonRegistration.Enabled = true;
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBoxComboBoxCheck_empty();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxComboBoxCheck_empty();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Register");

            int typeAccount=0;
            if (comboBoxTypeAccount.SelectedIndex==0)
            {
                typeAccount = 1;
            }
            else if (comboBoxTypeAccount.SelectedIndex == 1)
            {
                typeAccount = 2;
            }
            DataTable dataTable = Client.SendRegisterServer(textBoxLogin.Text, textBoxPass.Text,typeAccount);
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
    }
}
