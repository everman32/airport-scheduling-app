using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
        public WorkDestinationsForm()
        {
        }
        private void buttonBackAvianavForm_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
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
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            textBoxCheck_empty();
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

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
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

        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Add destination");

            string selected_name = textBoxName.Text;
            string selected_flightduration = textBoxFlightDuration.Text;
            string selected_airplanemodel = textBoxAirplaneModel.Text;
            string selected_estimatedtime1 = maskedTextBoxEstimatedTime1.Text;
            string selected_estimatedtime2 = maskedTextBoxEstimatedTime2.Text;
            string selected_estimatedtime3 = maskedTextBoxEstimatedTime3.Text;

            DataTable dataTable = Client.ReceiveAddDestinationData(selected_name,selected_flightduration,
                selected_airplanemodel, selected_estimatedtime1, selected_estimatedtime2, selected_estimatedtime3);

            if (dataTable.Rows.Count == 1)
            {

                MessageBox.Show("Пункт назначения " + selected_name + " добавлен");
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось добавить пункт назначения, пункт назначения с такими данными существует");
            }
        }

        private void toolStripWorkDestinations_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripButtonView_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Select destinations");
            DataTable dataTable = Client.ReceiveSelectDestinations();

            this.Size= new System.Drawing.Size(1152, 421);
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
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 421);
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
            this.Size = new System.Drawing.Size(1000, 421);
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
            this.Size = new System.Drawing.Size(1000, 421);
            panelViewing.Enabled = false;
            panelViewing.Visible = false;
            panelAdding.Enabled = false;
            panelAdding.Visible = false;
            panelEditing.Enabled = false;
            panelEditing.Visible = false;
            panelDeleting.Enabled = true;
            panelDeleting.Visible = true;
        }

        private bool textBoxComboboxCheck_empty()
        {
            if (textBoxEditId.Text != "" && comboBoxEdit.SelectedIndex != -1 && (maskedTextBoxNewvalueDate.Text != ""
                ||textBoxNewvalueDigit.Text!=""||textBoxNewvalueLetter.Text!=""|| textBoxNewvalueLetterOrDigit.Text != ""))
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
       

        private void WorkDestinationsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditDestination_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Edit destination");

            string command = "";
            string selected_newvalue="";

            if (comboBoxEdit.SelectedIndex == 0)
            {
                command = "Edit name";
                selected_newvalue = textBoxNewvalueLetter.Text;
            }
            else if (comboBoxEdit.SelectedIndex == 1)
            {
                command = "Edit flightduration";
                selected_newvalue = textBoxNewvalueDigit.Text;
            }
            else if (comboBoxEdit.SelectedIndex == 2)
            {
                command = "Edit airplanemodel";
                selected_newvalue = textBoxNewvalueLetterOrDigit.Text;
            }
            else if (comboBoxEdit.SelectedIndex == 3)
            {
                command = "Edit estimatedtime1";
                selected_newvalue = maskedTextBoxNewvalueDate.Text;
            }
            else if (comboBoxEdit.SelectedIndex == 4)
            {
                command = "Edit estimatedtime2";
                selected_newvalue = maskedTextBoxNewvalueDate.Text;
            }
            else if (comboBoxEdit.SelectedIndex == 5)
            {
                command = "Edit estimatedtime3";
                selected_newvalue = maskedTextBoxNewvalueDate.Text;
            }

            string selected_id = textBoxEditId.Text;

            DataTable dataTable = Client.ReceiveEditDestinationData(selected_id, selected_newvalue, command);
            if (dataTable.Rows.Count == 1)
            {
                if (command == "Edit name")
                {
                    MessageBox.Show("Редактирование пункта назначения с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit flightduration")
                {
                    MessageBox.Show("Редактирование продолжительности полёта с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit airplanemodel")
                {
                    MessageBox.Show("Редактирование модели самолёта с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit estimatedtime1")
                {
                    MessageBox.Show("Редактирование первого предлагаемоего времени с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit estimatedtime2")
                {
                    MessageBox.Show("Редактирование второго предлагаемоего времени с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
                else if (command == "Edit estimatedtime3")
                {
                    MessageBox.Show("Редактирование третьего предлагаемоего времени с Идент. номером " + selected_id + " выполнено с использованием нового значения " + selected_newvalue);
                }
            }
            else if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Не удалось выполнить редактирование, пункта назначения с таким идент. номером не существует");
            }
        }

        private void textBoxEditId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxEditId_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }
        private void comboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
            if (comboBoxEdit.SelectedIndex == 0)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = true;
                textBoxNewvalueDigit.Visible = false;
                textBoxNewvalueLetterOrDigit.Visible = false;
                maskedTextBoxNewvalueDate.Visible=false;
            }
            else if (comboBoxEdit.SelectedIndex == 1)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = false;
                textBoxNewvalueDigit.Visible = true;
                textBoxNewvalueLetterOrDigit.Visible = false;
                maskedTextBoxNewvalueDate.Visible = false;
            }
            else if (comboBoxEdit.SelectedIndex == 2)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = false;
                textBoxNewvalueDigit.Visible = false;
                textBoxNewvalueLetterOrDigit.Visible = true;
                maskedTextBoxNewvalueDate.Visible = false;
            }
            else if (comboBoxEdit.SelectedIndex == 3)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = false;
                textBoxNewvalueDigit.Visible = false;
                textBoxNewvalueLetterOrDigit.Visible = false;
                maskedTextBoxNewvalueDate.Visible = true;
            }
            else if (comboBoxEdit.SelectedIndex == 4)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = false;
                textBoxNewvalueDigit.Visible = false;
                textBoxNewvalueLetterOrDigit.Visible = false;
                maskedTextBoxNewvalueDate.Visible = true;
            }
            else if (comboBoxEdit.SelectedIndex == 5)
            {
                labelEditValue.Visible = true;
                textBoxNewvalueLetter.Visible = false;
                textBoxNewvalueDigit.Visible = false;
                textBoxNewvalueLetterOrDigit.Visible = false;
                maskedTextBoxNewvalueDate.Visible = true;
            }
        }

        private void maskedTextBoxNewvalue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBoxComboboxCheck_empty();
        }

        private void textBoxNewvalueDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxNewvalueDigit_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }

        private void textBoxNewvalueLetter_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }

        private void textBoxNewvalueLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxNewValueLetterOrDigit_TextChanged(object sender, EventArgs e)
        {
            textBoxComboboxCheck_empty();
        }

        private void textBoxNewValueLetterOrDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetterOrDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private bool textBoxDeleteCheck_empty()
        {
            if (textBoxDeleteId.Text != "")
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
        private void textBoxDeleteId_TextChanged(object sender, EventArgs e)
        {
            textBoxDeleteCheck_empty();
        }
        private void textBoxDeleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void buttonDeletePassenger_Click(object sender, EventArgs e)
        {
            Client.SendRequestToServer("Delete destination");

            string selected_id = textBoxDeleteId.Text;

            int deleted_count = Client.ReceiveDeleteDestinationData(selected_id);
            if (deleted_count == 1)
            {
                MessageBox.Show("Удаление пункта назначения с Идент. номером " + selected_id + " выполнено");
            }
            else if (deleted_count == 0)
            {
                MessageBox.Show("Не удалось удалить пункт назначения, пункта назначения с таким идент. номером не существует");
            }
        }

        private void WorkDestinationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

    }
}
