using System;
using System.Data;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkDestinationsForm : Form
    {
        public Form form;
        public WorkDestinationsForm(DispatcherForm dispatcherForm)
        {
            form = dispatcherForm;
            InitializeComponent();
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        public WorkDestinationsForm(AdminForm adminForm)
        {
            form = adminForm;
            InitializeComponent();
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;
        }
        public WorkDestinationsForm()
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
            Client.SendRequestToServer("Select destinations");
            DataTable dataTable = Client.ReceiveSelectDestinations();

            panelViewing.Enabled = true;
            panelViewing.Visible = true;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            DestinationsGridView.DataSource = dataTable;

            DestinationsGridView.AllowUserToAddRows = false;
            DestinationsGridView.AllowUserToResizeColumns = false;
            DestinationsGridView.AllowUserToResizeRows = false;

            DestinationsGridView.RowHeadersVisible = false;
            DestinationsGridView.ReadOnly = true;
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
            textBoxName.Clear();
            textBoxFlightDuration.Clear();
            textBoxAirplaneModel.Clear();
            maskedTextBoxEstimatedTime1.Clear();
            maskedTextBoxEstimatedTime2.Clear();
            maskedTextBoxEstimatedTime3.Clear();

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
            if (textBoxName.Text != "" && textBoxFlightDuration.Text != ""
                && textBoxAirplaneModel.Text != "" && maskedTextBoxEstimatedTime1.MaskCompleted == true
                && maskedTextBoxEstimatedTime2.MaskCompleted == true && maskedTextBoxEstimatedTime3.MaskCompleted == true)
            {
                buttonAddDestination.Enabled = true;
                return true;
            }
            else
            {
                buttonAddDestination.Enabled = false;
            }
            return false;
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxFlightDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxAirplaneModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxFlightDuration_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void textBoxAirplaneModel_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
        }
        private void maskedTextBoxEstimatedTime1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxCheck_empty();
        }
        private void maskedTextBoxEstimatedTime2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxCheck_empty();
        }
        private void maskedTextBoxEstimatedTime3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxCheck_empty();
        }


        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
            maskedTextBoxNewvalueDate.Clear();
            textBoxNewvalue.Clear();
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = true;
            panelEditing.Visible = true;
            panelDeleting.Enabled = false;
            panelDeleting.Visible = false;

            Client.SendRequestToServer("Select destinationsNames");
            DataTable dataTable = Client.ReceiveSelectDestinationsNames();
            comboBoxEdit.DataSource = dataTable;
            comboBoxEdit.DisplayMember = "Name";
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
            if (comboBoxEdit.SelectedIndex != -1 && comboBoxEditCriteria.SelectedIndex != -1 && (maskedTextBoxNewvalueDate.MaskCompleted == true
                || textBoxNewvalue.Text != ""))
            {
                buttonEditDestination.Enabled = true;
                return true;
            }
            else
            {
                buttonEditDestination.Enabled = false;
            }
            return false;
        }
        private void textBoxNewvalueDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxNewvalueLetterOrDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxNewvalueLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void comboBoxEdit_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            maskedTextBoxNewvalueDate.Clear();
            textBoxNewvalue.Clear();
            textBoxComboboxCheck_empty();
            textBoxNewvalueCheckMask();
        }
        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBoxNewvalueDate.Clear();
            textBoxNewvalue.Clear();
            if (comboBoxEditCriteria.SelectedIndex == 0 || comboBoxEditCriteria.SelectedIndex == 1 || comboBoxEditCriteria.SelectedIndex == 2)
            {
                labelEditValue.Visible = true;
                textBoxNewvalue.Visible = true;
                maskedTextBoxNewvalueDate.Visible = false;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 3 || comboBoxEditCriteria.SelectedIndex == 4 || comboBoxEditCriteria.SelectedIndex == 5)
            {
                labelEditValue.Visible = true;
                maskedTextBoxNewvalueDate.Visible = true;
                textBoxNewvalue.Visible = false;
            }
            textBoxComboboxCheck_empty();
            textBoxNewvalueCheckMask();
        }
        private void maskedTextBoxNewvalue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxComboboxCheck_empty();
        }
        private void textBoxNewvalue_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }

        private void textBoxNewvalueCheckMask()
        {
            this.textBoxNewvalue.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueDigit_KeyPress);
            this.textBoxNewvalue.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetter_KeyPress);
            this.textBoxNewvalue.KeyPress -= new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetterOrDigit_KeyPress);
            if (comboBoxEditCriteria.SelectedIndex == 0)
            {
                this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetter_KeyPress);
            }
            else if (comboBoxEditCriteria.SelectedIndex == 1)
            {
                this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueDigit_KeyPress);
            }
            else if (comboBoxEditCriteria.SelectedIndex == 2)
            {
                this.textBoxNewvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewvalueLetterOrDigit_KeyPress);
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

            Client.SendRequestToServer("Select destinationsNames");
            DataTable dataTable = Client.ReceiveSelectDestinationsNames();
            comboBoxDelete.DataSource = dataTable;
            comboBoxDelete.DisplayMember = "Name";
            comboBoxDelete.ValueMember = "Id";

            comboBoxDelete.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDeleteCheck_empty();
        }
        private bool comboBoxDeleteCheck_empty()
        {
            if (comboBoxDelete.SelectedIndex != -1)
            {
                buttonDeleteDestination.Enabled = true;
                return true;
            }
            else
            {
                buttonDeleteDestination.Enabled = false;
            }
            return false;
        }


        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Add destination");

            string name = textBoxName.Text;
            string flightduration = textBoxFlightDuration.Text;
            string airplanemodel = textBoxAirplaneModel.Text;
            string estimatedtime1 = maskedTextBoxEstimatedTime1.Text;
            string estimatedtime2 = maskedTextBoxEstimatedTime2.Text;
            string estimatedtime3 = maskedTextBoxEstimatedTime3.Text;

            DataTable dataTable = Client.ReceiveAddDestinationData(name, flightduration,
                airplanemodel, estimatedtime1, estimatedtime2, estimatedtime3);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Пункт назначения " + name + " добавлен");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Пункт назначения с такими данными существует");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonEditDestination_Click(object sender, EventArgs e)
        {
            try
            {
            Client.SendRequestToServer("Edit destination");

            string command = "";
            string newvalue = "";

            if (comboBoxEditCriteria.SelectedIndex == 0)
            {
                command = "Edit name";
                newvalue = textBoxNewvalue.Text;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 1)
            {
                command = "Edit flightduration";
                newvalue = textBoxNewvalue.Text;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 2)
            {
                command = "Edit airplanemodel";
                newvalue = textBoxNewvalue.Text;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 3)
            {
                command = "Edit estimatedtime1";
                newvalue = maskedTextBoxNewvalueDate.Text;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 4)
            {
                command = "Edit estimatedtime2";
                newvalue = maskedTextBoxNewvalueDate.Text;
            }
            else if (comboBoxEditCriteria.SelectedIndex == 5)
            {
                command = "Edit estimatedtime3";
                newvalue = maskedTextBoxNewvalueDate.Text;
            }
            string id = comboBoxEdit.SelectedValue.ToString();

            DataTable dataTable = Client.ReceiveEditDestinationData(id, newvalue, command);
            if (dataTable.Rows.Count == 1)
            {
                if (command == "Edit name")
                {
                    MessageBox.Show("Редактирование названия выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit flightduration")
                {
                    MessageBox.Show("Редактирование продолжительности полёта выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit airplanemodel")
                {
                    MessageBox.Show("Редактирование модели самолёта выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit estimatedtime1")
                {
                    MessageBox.Show("Редактирование первого предлагаемоего времени выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit estimatedtime2")
                {
                    MessageBox.Show("Редактирование второго предлагаемоего времени выполнено с использованием нового значения " + newvalue);
                }
                else if (command == "Edit estimatedtime3")
                {
                    MessageBox.Show("Редактирование третьего предлагаемоего времени выполнено с использованием нового значения " + newvalue);
                }
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Пункта назначения с такими данными не существует");
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
            Client.SendRequestToServer("Delete destination");

            string id = comboBoxDelete.SelectedValue.ToString();

            int deleted_count = Client.ReceiveDeleteDestinationData(id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление пункта назначения выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Пункта назначения с такими данными не существует");
            }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void WorkDestinationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void buttonFlightDurations_Click(object sender, EventArgs e)
        {
            try
            {
            GraphFlightDuration graphFlightDuration;
            graphFlightDuration = new GraphFlightDuration(this, DestinationsGridView);
            graphFlightDuration.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
