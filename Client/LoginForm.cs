using System;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public Form form;
        public LoginForm(ActionChoiseForm loginregForm)
        {
            InitializeComponent();
            form = loginregForm;
        }

        private void buttonBackLoginRegister_Click(object sender, EventArgs e)
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Client.SendRequestToServer("Login");

                string login = textBoxLogin.Text;
                string password = textBoxPass.Text;

                DataTable dataTable = Client.ReceiveAuthorizeData(login, password);
                if (dataTable.Rows.Count == 1)
                {
                    Client.login = textBoxLogin.Text;
                    Client.password = textBoxPass.Text;

                    if (dataTable.Rows[0][2].ToString() == "1")
                    {
                        AdminForm adminPanel = new AdminForm(this);
                        Hide();
                        adminPanel.Show();
                        Client.accessRight = 1;
                        MessageBox.Show("Авторизация выполнена. Вы вошли как администратор " + Client.login);
                    }
                    else if (dataTable.Rows[0][2].ToString() == "2")
                    {
                        DispatcherForm dispatcherForm = new DispatcherForm(this);
                        Hide();
                        dispatcherForm.Show();
                        Client.accessRight = 2;
                        MessageBox.Show("Авторизация выполнена. Вы вошли как диспетчер " + Client.login);
                    }

                }
                else if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Введены недействительные данные авторизации"); ;
                }
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
