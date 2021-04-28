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
        public RegistrationForm()
        {
            InitializeComponent();
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
                    if (c.Text == string.Empty || comboBox1.SelectedIndex == -1)
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

        }
    }
}
