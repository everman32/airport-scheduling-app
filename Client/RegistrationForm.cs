using System;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class RegistrationForm : Form
    {
        public Form form;
        public RegistrationForm(ActionChoiseForm logRegForm)
        {
            InitializeComponent();
            form = logRegForm;
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Register");

                int accessRight = 2;

            string login = textBoxLogin.Text;
            string password = textBoxPass.Text;
           
            DataTable dataTable = Client.ReceiveRegisterData(login, password, accessRight);
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
                    DispatcherForm dispatcherForm = new DispatcherForm(this);
                    Hide();
                    dispatcherForm.Show();
                    Client.accessRight = 2;
                }
                Client.login = textBoxLogin.Text;
                Client.password = textBoxPass.Text;
                MessageBox.Show("Регистрация выполнена. Вы вошли как диспетчер "+Client.login);
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Учётная запись с такими данными существует"); ;
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonBackLogRegForm_Click(object sender, EventArgs e)
        {
            try
            {
            Hide();
            form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool textBoxCheck_empty()
        {
            if (textBoxLogin.Text != "" && textBoxPass.Text != "")
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
           textBoxCheck_empty();
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

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
