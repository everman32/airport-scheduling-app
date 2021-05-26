using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ActionChoiseForm : Form
    {
        public Form mainPanel;
        public ActionChoiseForm(MainForm main)
        {
            InitializeComponent();
            mainPanel = main;
        }

        private void buttonBackMainForm_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                mainPanel.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoginRegisterPanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonAuthorizationPanel_Click(object sender, EventArgs e)
        {
            try
            {
            LoginForm loginPanel;
            loginPanel = new LoginForm(this);
            Hide();
            loginPanel.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonRegForm_Click(object sender, EventArgs e)
        {
            try
            {
            RegistrationForm registrationForm;
            registrationForm = new RegistrationForm(this);
            Hide();
            registrationForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LogRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
