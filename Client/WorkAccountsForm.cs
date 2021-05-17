using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
        private void toolStripButtonView_Click(object sender, EventArgs e)
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
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = true;
            panelAdding.Visible = true;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = true;
            panelEditing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;
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
        private void comboBoxAccessRight_SelectedIndexChanged(object sender, EventArgs e)
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

        private void buttonRegistration_Click(object sender, EventArgs e)
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
            string selected_login = textBoxLogin.Text;
            string selected_password = textBoxPass.Text;

            DataTable dataTable = Client.ReceiveRegisterData(selected_login, selected_password, accessRight);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Добавление учётной записи " + selected_login+" выполнено");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось добавить учётную запись , учётная запись с таким логином уже существует"); ;
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

        private void WorkAccountsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool textBoxCheck_empty()
        {
            if (textBoxEditLogin.Text != "" && textBoxNewvalue.Text != "")
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
        private void textBoxEditId_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }

        private void textBoxNewvalue_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }

        private void buttonEditPassenger_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Edit account");

            
            string selected_login = textBoxEditLogin.Text;
            string selected_newvalue = textBoxNewvalue.Text;

            DataTable dataTable = Client.ReceiveEditAccountData(selected_login, selected_newvalue);
            if (dataTable.Rows.Count == 1)
            {
                    MessageBox.Show("Редактирование учётной записи с логином " + selected_login + " выполнено с использованием нового пароля " + selected_newvalue);
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось выполнить редактирование, учётной записи с таким логином не существует");
            }
        }

        private void textBoxEditId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
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

        private bool textBoxDeleteCheck_empty()
        {
            if (textBoxDeleteLogin.Text != "")
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
        private void panelAdding_Paint(object sender, PaintEventArgs e)
        {
            textBoxDeleteCheck_empty();
        }

        private void textBoxDeleteLogin_TextChanged(object sender, EventArgs e)
        {
            textBoxDeleteCheck_empty();
        }

        private void textBoxDeleteLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete account");

            string selected_login = textBoxDeleteLogin.Text;

            int deleted_count = Client.ReceiveDeleteAccountData(selected_login);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление учётной записи с логином " + selected_login + " выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не удалось удалить учётную запись, учётная запись с таким логином не существует");
            }
        }
    }
}
