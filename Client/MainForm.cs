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
            try
            {
                port = Convert.ToInt32(textBoxPort.Text);
                if (port < 0 || port > 65535)
                {
                    MessageBox.Show("Порт должен быть в диапазоне от 0 до 65535");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Порт должен быть целым положительным числом");
                return;
            }

            Client client = new Client("127.0.0.1",port);
            client.connectClient();
            buttonConnectClient.Enabled = false;
            textBoxPort.Enabled = false;
            LogRegForm loginRegisterPanel= new LogRegForm(this);
            Hide();
            loginRegisterPanel.Show();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {

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
            if 
        }
    }
}
