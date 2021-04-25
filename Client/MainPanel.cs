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
    public partial class MainPanel : Form
    {
        public MainPanel()
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

            Client client = new Client();
            client.connectClient(port);
            buttonConnectClient.Enabled = false;
            textBoxPort.Enabled = false;
            LoginRegisterPanel loginRegisterPanel= new LoginRegisterPanel();
            loginRegisterPanel.Show();



        }
    }
}
