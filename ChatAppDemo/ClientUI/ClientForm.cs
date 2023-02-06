using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class ClientForm : Form
    {
        Client client;
        private bool isOnline { get; set; }
        private string clientName { get; set; }
        public ClientForm()
        {
            isOnline= false;
            InitializeComponent();
            usersComboBox.Items.Add("public");
            usersComboBox.SelectedIndex= 0;
            SetUI();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            isOnline= true;
            Login();
            client = new Client() {Name = clientName };
            client.MessageRecieved += Client_MessageRecieved;
            client.ClientDisconnected += Client_ClientDisconnected;
            client.ConnectClient();
            SetUI();
        }

        private void Client_ClientDisconnected()
        {
            isOnline= false;
            client.tcp.Close();
            client.Writer.Close();
            client.Reader.Close();
            SetUI();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string msg = txtMsg.Text;
            txtMsg.Text = string.Empty;
            Display($"[{clientName}]:{msg}");
            string reciver = usersComboBox.SelectedItem.ToString();
            if (usersComboBox.SelectedIndex == 0)
            {
                SendPublicMessage(msg);
            }
            else
            {
                SendPrivateMessage(msg, reciver);
            }
        }

        private void SendPrivateMessage(string msg, string reciver)
        {
            client.send($@"\nPrivate:{reciver}:{msg}:{clientName}");
        }

        private void SendPublicMessage(string msg)
        {
            client.send($@"\nPublic:{clientName}:{msg}");
        }

        private void Client_MessageRecieved(object sender, string e)
        {
            string[] msg = e.Split(':');

            switch (msg[0])
            {
                case @"\newClient":
                    if (msg[1] != clientName)
                    {
                        AddNewUser(msg[1]);
                    }
                    break;
                case @"\nPublic":
                    if (msg[1] != clientName)
                    {
                        Display($"[{msg[1]}]:{msg[2]}");
                    }
                    break;
                case @"\nPrivate":
                    Display($"[Private From:[{msg[3]}]]:{msg[2]}");
                    break;
            }
        }

        private void Display(string msg)
        {
            txtRecievedMsg.Text += $"{Environment.NewLine}{msg}";
        }

        private void AddNewUser(string user)
        {
            usersComboBox.Items.Add($"{user}");
        }

        private void SetUI()
        {
            sendBtn.Enabled = isOnline;
            stopBtn.Enabled = isOnline;
            usersComboBox.Enabled = isOnline;
            startBtn.Enabled = !isOnline;
        }

        private void Login()
        {
            Form1 frm = new Form1();
            frm.UserLogged += Frm_UserLogged;
            frm.ShowDialog();
        }

        private void Frm_UserLogged(object sender, string e)
        {
            clientName = e;
        }
    }
    public class Client
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public TcpClient tcp { get; set; }
        public StreamWriter Writer { get; set; }
        public StreamReader Reader { get; set; }
        public event EventHandler<string> MessageRecieved;
        public event Action ClientDisconnected;


        public Client()
        {
            
        }

        public async void ConnectClient()
        {
            tcp = new TcpClient();
            await tcp.ConnectAsync(IPAddress.Parse("127.0.0.1"), 49500);
            NetworkStream stream = tcp.GetStream();
            Writer = new StreamWriter(stream) { AutoFlush= true };
            Reader = new StreamReader(stream);

            await Writer.WriteLineAsync(Name);
            StartListening();
        }

        public async void send(string msg)
        {
            try
            {
                await Writer.WriteLineAsync(msg);
            }
            catch
            {


            }
        }

        public async void StartListening()
        {
            while (true)
            {
                try
                {
                    string message = await Reader.ReadLineAsync();
                    MessageRecieved(this, message);
                }
                catch
                {
                    ClientDisconnected();
                }
            }
        }
    }
}
