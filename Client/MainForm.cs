using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonConnectClient_Click(object sender, EventArgs e)
        {
            int port;
                port = Convert.ToInt32(textBoxPort.Text);
                if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Порт должен быть в диапазоне от 0 до 65535");
                    return;
                }
            try
            {
                Client client = new Client("127.0.0.1", port);
                client.connectClient();

                buttonConnectClient.Enabled = false;
                textBoxPort.Enabled = false;
                ActionChoiseForm loginRegisterPanel = new ActionChoiseForm(this);
                Hide();
                loginRegisterPanel.Show();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к серверу по порту " + port);
            }
        }
        private bool textBoxPortCheck_empty()
        {
                    if (textBoxPort.Text==string.Empty )
                    {
                        buttonConnectClient.Enabled = false;
                        return false;
                    }
            buttonConnectClient.Enabled = true;
            return true;
        }
        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            textBoxPortCheck_empty();
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
