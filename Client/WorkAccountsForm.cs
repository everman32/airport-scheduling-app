using System;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkAccountsForm : Form
    {
        public Form form;
        public WorkAccountsForm(AdminForm adminForm)
        {
            InitializeComponent();
            form = adminForm;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        public WorkAccountsForm()
        { }
        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
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
        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Select accounts");
            DataTable dataTable = Client.ReceiveSelectAccounts();

            panelViewing.Enabled = true;
            panelViewing.Visible = true;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            AccountsGridView.DataSource = dataTable;

            AccountsGridView.AllowUserToAddRows = false;
            AccountsGridView.AllowUserToResizeColumns = false;
            AccountsGridView.AllowUserToResizeRows = false;

            AccountsGridView.RowHeadersVisible = false;
            AccountsGridView.ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
            textBoxLogin.Clear();
            textBoxPass.Clear();

            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = true;
            panelAdding.Visible = true;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            comboBoxAccessRight.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
        private void comboBoxAccessRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxPass.Clear();
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
        private bool textBoxComboBoxCheck_empty()
        {
            if (textBoxLogin.Text != "" && textBoxPass.Text != "" && comboBoxAccessRight.SelectedIndex != -1)
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


        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
            textBoxNewvalue.Clear();

            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = true;
            panelEditing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select AssumedAccountsData");
            DataTable dataTable = Client.ReceiveSelectAssumedAccountsData();
            comboBoxEditLogin.DataSource = dataTable;
            comboBoxEditLogin.DisplayMember = "Данные учётной записи";
            comboBoxEditLogin.ValueMember = "Login";

            comboBoxEditLogin.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void textBoxNewvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private bool textBoxcomboBoxEditCheck_empty()
        {
            if (textBoxNewvalue.Text != "" && comboBoxEditLogin.SelectedIndex != -1)
            {
                buttonEditAccount.Enabled = true;
                return true;
            }
            else
            {
                buttonEditAccount.Enabled = false;
            }
            return false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewvalue.Clear();
            textBoxcomboBoxEditCheck_empty();
        }
        private void textBoxNewvalue_TextChanged(object sender, EventArgs e)
        {
            textBoxcomboBoxEditCheck_empty();
        }


        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;

            Client.SendRequestToServer("Select AssumedAccountsData");
            DataTable dataTable = Client.ReceiveSelectAssumedAccountsData();
            comboBoxDelete.DataSource = dataTable;
            comboBoxDelete.DisplayMember = "Данные учётной записи";
            comboBoxDelete.ValueMember = "Login";

            comboBoxDelete.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void comboBoxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeleteCheck_empty();
        }
        private bool comboBoxDeleteCheck_empty()
        {
            if (comboBoxDelete.SelectedIndex != -1)
            {
                buttonDeleteAccount.Enabled = true;
                return true;
            }
            else
            {
                buttonDeleteAccount.Enabled = false;
            }
            return false;
        }



        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Register");

            int accessRight = 0;
            if (comboBoxAccessRight.SelectedIndex == 0)
            {
                accessRight = 1;
            }
            else if (comboBoxAccessRight.SelectedIndex == 1)
            {
                accessRight = 2;
            }
            string login = textBoxLogin.Text;
            string password = textBoxPass.Text;

            DataTable dataTable = Client.ReceiveRegisterData(login, password, accessRight);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Добавление учётной записи " + login + " выполнено");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Учётная запись с таким логином существует"); ;
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }



        private void WorkAccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEditPassenger_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Edit account");


            string login = comboBoxEditLogin.SelectedValue.ToString();
            string newvalue = textBoxNewvalue.Text;

            DataTable dataTable = Client.ReceiveEditAccountData(login, newvalue);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Редактирование учётной записи с логином " + login + " выполнено с использованием нового пароля " + newvalue);
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Учётной записи с таким логином не существует");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
            if (Client.login == comboBoxDelete.SelectedValue.ToString())
            {
                MessageBox.Show("Нельзя удалить учётную запись, с которой выполнен вход в систему");
            }
            else
            {
                Client.SendRequestToServer("Delete account");

                string login = comboBoxDelete.SelectedValue.ToString();

                int deleted_count = Client.ReceiveDeleteAccountData(login);
                if (deleted_count == 1)
                {
                    MessageBox.Show("Удаление учётной записи с логином " + login + " выполнено");
                }
                else if (deleted_count == 0)
                {
                    MessageBox.Show("Учётная запись с таким логином не существует");
                }
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
