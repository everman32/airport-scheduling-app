using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public partial class WorkPassengersForm : Form
    {
        public Form form;
        public WorkPassengersForm(DispatcherForm dispatcherForm)
        {
            InitializeComponent();
            form = dispatcherForm;
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        public WorkPassengersForm(AdminForm adminForm)
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
        public WorkPassengersForm()
        {
        }

        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }
        
        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
           char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxPhone_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
           char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
           char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {   
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private bool textBoxCheck_empty()
        {
            if (textBoxSurname.Text != ""&&textBoxName.Text != ""
                && textBoxPatronymic.Text != "" && textBoxPhoneNumber.Text != "")
            {
             buttonAddPassenger.Enabled = true;
             return true;
            }
            else
            {
            buttonAddPassenger.Enabled = false;
            }
             return false;
        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxPhone_Number_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxPatronymic_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }

        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Select passengers");
            DataTable dataTable = Client.ReceiveSelectPassengers();

            panelViewing.Enabled = true;
            panelViewing.Visible = true;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            PassengersGridView.DataSource = dataTable;

            PassengersGridView.AllowUserToAddRows = false;
            PassengersGridView.AllowUserToResizeColumns = false;
            PassengersGridView.AllowUserToResizeRows = false;

            PassengersGridView.RowHeadersVisible = false;
            PassengersGridView.ReadOnly = true;
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

        private void WorkPassengersForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private bool textBoxComboboxCheck_empty()
        {
            if (textBoxEditId.Text != "" && textBoxNewvalue.Text != "" && comboBoxEdit.SelectedIndex!= -1)
            {
                buttonEditPassenger.Enabled = true;
                return true;
            }
            else
            {
                buttonEditPassenger.Enabled = false;
            }
             return false;
        }
        private void textBoxNewvalue_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }
        private void textBoxEditId_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }
        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBoxComboboxCheck_empty();
        }
        private void textBoxEditId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private bool textBoxDeleteCheck_empty()
        {
            if (textBoxDeleteId.Text != "")
            {
                buttonDeletePassenger.Enabled = true;
                return true;
            }
            else
            {
                buttonDeletePassenger.Enabled = false;
            }
            return false;
        }
        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            textBoxDeleteCheck_empty();
        }
        private void textBoxDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonAddPassenger_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Add passenger");

            string selected_surname = textBoxSurname.Text;

            string selected_name = textBoxName.Text;

            string selected_patronymic = textBoxPatronymic.Text;

            string selected_phonenumber = textBoxPhoneNumber.Text;

            DataTable dataTable = Client.ReceiveAddPassengerData(selected_surname, selected_name, selected_patronymic, selected_phonenumber);
            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Пассажир " + selected_surname + " " + selected_name + " " + selected_patronymic + " добавлен");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось добавить пассажира, пассажир с таким ФИО или номером телефона существует");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Edit passenger");

            string command = "";
            if (comboBoxEdit.SelectedIndex == 0)
            {
                command = "Edit surname";
            }
            else if (comboBoxEdit.SelectedIndex == 1)
            {
                command = "Edit name";
            }
            else if (comboBoxEdit.SelectedIndex == 2)
            {
                command = "Edit patronymic";
            }
            else if (comboBoxEdit.SelectedIndex == 3)
            {
                command = "Edit phonenumber";
            }

            string selected_id = textBoxEditId.Text;

            string selected_newvalue = textBoxNewvalue.Text;


            DataTable dataTable = Client.ReceiveEditPassengerData(selected_id, selected_newvalue, command);
            if (dataTable.Rows.Count == 1)
            {
                if (command == "Edit surname")
                {
                    MessageBox.Show("Редактирование фамилии пассажира с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit name")
                {
                    MessageBox.Show("Редактирование имени пассажира с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit patronymic")
                {
                    MessageBox.Show("Редактирование отчества пассажира с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit phonenumber")
                {
                    MessageBox.Show("Редактирование телефонного номера пассажира с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось выполнить редактирование, пассажира с таким идент. номером не существует");
            }
        }
        private void buttonDeletePassenger_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete passenger");

            string selected_id = textBoxDeleteId.Text;

            int deleted_count = Client.ReceiveDeletePassengerData(selected_id);
            if (deleted_count == 1)
            {
                    MessageBox.Show("Удаление пассажира с Идент. номером " + selected_id + " выполнено");  
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не удалось удалить пассажира, пассажира с таким идент. номером не существует");
            }
        }

        private void panelDeleting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripWorkPassengers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void WorkPassengersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void buttonCloseEditPassenger_Click(object sender, EventArgs e)
        {
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
        }
    }
}
