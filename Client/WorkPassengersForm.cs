using System;
using System.Data;
using System.Windows.Forms;

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
        public WorkPassengersForm()
        { }
            private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
            textBoxSurname.Clear();
            textBoxName.Clear();
            textBoxPatronymic.Clear();
            textBoxPhoneNumber.Clear();

            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = true;
            panelAdding.Visible = true;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool textBoxCheck_empty()
        {
            if (textBoxSurname.Text != "" && textBoxName.Text != ""
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
        private void textBoxPhone_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
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
        private void textBoxPhone_Number_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
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

            Client.SendRequestToServer("Select passengersNames");
            DataTable dataTable = Client.ReceiveSelectPassengersNames();
            comboBoxEdit.DataSource = dataTable;
            comboBoxEdit.DisplayMember = "ФИО пассажира";
            comboBoxEdit.ValueMember = "Id";

            comboBoxEdit.SelectedIndex = -1;
            comboBoxEditCriteria.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool textBoxComboboxCheck_empty()
        {
            if (comboBoxEdit.SelectedIndex != -1 && comboBoxEditCriteria.SelectedIndex != -1 && textBoxNewvalue.Text != "")
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
        private void textBoxNewvalueLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxNewvalueDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxNewvalue_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }
        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNewvalue.Clear();
            textBoxComboboxCheck_empty();
            textBoxNewvalueCheckMask();
        }
        private void comboBoxEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBoxNewvalue.Clear();
            textBoxComboboxCheck_empty();
            textBoxNewvalueCheckMask();
        }

        private void textBoxNewvalueCheckMask()
        {
            this.textBoxNewvalue.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueDigit_KeyPress);
            this.textBoxNewvalue.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetter_KeyPress);

            if (comboBoxEditCriteria.SelectedIndex == 0 || comboBoxEditCriteria.SelectedIndex == 1
                || comboBoxEditCriteria.SelectedIndex == 2)
            {
                this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetter_KeyPress);
            }
            else if (comboBoxEditCriteria.SelectedIndex == 3)
            {
                this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueDigit_KeyPress);
            }
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

            Client.SendRequestToServer("Select passengersNames");
            DataTable dataTable = Client.ReceiveSelectPassengersNames();
            comboBoxDelete.DataSource = dataTable;
            comboBoxDelete.DisplayMember = "ФИО пассажира";
            comboBoxDelete.ValueMember = "Id";

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
                buttonDeletePassenger.Enabled = true;
                return true;
            }
            else
            {
                buttonDeletePassenger.Enabled = false;
            }
            return false;
        }


        private void buttonAddPassenger_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Add passenger");

            string surname = textBoxSurname.Text;
            string name = textBoxName.Text;
            string patronymic = textBoxPatronymic.Text;
            string phonenumber = textBoxPhoneNumber.Text;

            DataTable dataTable = Client.ReceiveAddPassengerData(surname, name, patronymic, phonenumber);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Пассажир " + surname + " " + name + " " + patronymic + " добавлен");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Пассажир с таким ФИО или номером телефона существует");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Edit passenger");

            string command = "";
            if (comboBoxEditCriteria.SelectedIndex == 0)
            {
                command = "Edit surname";
            }
            else if (comboBoxEditCriteria.SelectedIndex == 1)
            {
                command = "Edit name";
            }
            else if (comboBoxEditCriteria.SelectedIndex == 2)
            {
                command = "Edit patronymic";
            }
            else if (comboBoxEditCriteria.SelectedIndex == 3)
            {
                command = "Edit phonenumber";
            }
            string id = comboBoxEdit.SelectedValue.ToString();
            string newvalue = textBoxNewvalue.Text;

            DataTable dataTable = Client.ReceiveEditPassengerData(id, newvalue, command);
            if (dataTable.Rows.Count == 1)
            {
                if (command == "Edit surname")
                {
                    MessageBox.Show("Редактирование фамилии пассажира выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit name")
                {
                    MessageBox.Show("Редактирование имени пассажира выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit patronymic")
                {
                    MessageBox.Show("Редактирование отчества пассажира выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit phonenumber")
                {
                    MessageBox.Show("Редактирование телефонного номера пассажира выполнено с использованием нового значения " + newvalue);
                }
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Пассажир с такими данными существует");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonDeletePassenger_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Delete passenger");

            string id = comboBoxDelete.SelectedValue.ToString();

            int deleted_count = Client.ReceiveDeletePassengerData(id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление пассажира выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не найден пассажир с такими данными");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void WorkPassengersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
