using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aps_tcpip
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader SR;
        public StreamWriter SW;
        public string receive;
        public string message;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] local = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in local)
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                    txtIP.Text = ip.ToString();
        }

        private void rbtServer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtServer.Checked == true)
            {
                rbtClient.Checked = false;
                btnConnect.Text = "Start";
            }

            if ((rbtClient.Checked == true || rbtServer.Checked == true) && String.IsNullOrEmpty(txtIP.Text) == false && String.IsNullOrEmpty(txtPort.Text) == false)
            {
                btnConnect.Enabled = true;
                btnSend.Enabled = true;
            }
        }

        private void rbtClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtClient.Checked == true)
            {
                rbtServer.Checked = false;
                btnConnect.Text = "Connect";
            }

            if ((rbtClient.Checked == true || rbtServer.Checked == true) && String.IsNullOrEmpty(txtIP.Text) == false && String.IsNullOrEmpty(txtPort.Text) == false)
            {
                btnConnect.Enabled = true;
                btnSend.Enabled = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (rbtServer.Checked == true)
            {
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtPort.Text));
                listener.Start();
                client = listener.AcceptTcpClient();
                SR = new StreamReader(client.GetStream());
                SW = new StreamWriter(client.GetStream());
                SW.AutoFlush = true;
                bgw1.RunWorkerAsync();
                bgw2.WorkerSupportsCancellation = true;
            }

            if (rbtClient.Checked == true)
            {
                client = new TcpClient();
                IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
                client.Connect(iPEnd);

                try
                {
                    txtChat.AppendText("Connect to Server" + "\r\n");
                    SW = new StreamWriter(client.GetStream());
                    SR = new StreamReader(client.GetStream());
                    SW.AutoFlush = true;
                    bgw1.RunWorkerAsync();
                    bgw2.WorkerSupportsCancellation = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                message = txtMessage.Text;
                bgw2.RunWorkerAsync();
            }
            txtMessage.Text = "";
        }

        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = SR.ReadLine();
                    this.txtChat.Invoke(new MethodInvoker(delegate ()
                    {
                        txtChat.AppendText("Other: " + receive + "\r\n");
                    }));
                    receive = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                SW.WriteLine(message);
                this.txtChat.Invoke(new MethodInvoker(delegate ()
                {
                    txtChat.AppendText("Me: " + message + "\r\n");
                }));
            }
            else
                MessageBox.Show("Sending Failed");

            bgw2.CancelAsync();
        }
    }
}
