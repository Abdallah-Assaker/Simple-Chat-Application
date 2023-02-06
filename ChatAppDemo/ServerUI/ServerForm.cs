using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerUI
{
    public partial class ServerForm : Form
    {
        private TcpListener listner;
        private List<Client> clients;
        private bool isOnline;
        private int Id;
        
        public ServerForm()
        {
            this.Id = 0;
            isOnline = false;
            listner = new TcpListener(IPAddress.Parse("127.0.0.1"), 49500);
            clients = new List<Client>();
            InitializeComponent();
            SetUI();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            listner.Start();
            isOnline = true;
            SetUI();
            StartListeenToClientsAsync();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                ListViewItem item = listView1.SelectedItems[0];
                foreach (Client client in clients)
                {
                    if (client.Name == item.SubItems[0].Text)
                    {
                        clients.Remove(client);
                    }
                }
                listView1.Items.Remove(item);
            }
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            listner.Stop();
            isOnline = false;
            StopClients();
            SetUI();
        }

        private void SetUI()
        {
            abortBtn.Enabled = isOnline;
            removeBtn.Enabled = isOnline;
            startBtn.Enabled = !isOnline;
            if ( isOnline )
            {
                connectionPanel.BackColor = Color.Green;
            }
            else
            {
                connectionPanel.BackColor = Color.Red;
            }
        }

        private async void StartListeenToClientsAsync()
        {
            while (true)
            {
                try 
                {
                    TcpClient tcp= await listner.AcceptTcpClientAsync();
                    Client newClient = new Client(tcp, ++Id);
                    newClient.Name = await newClient.Reader.ReadLineAsync();
                    newClient.MessageRecieved += NewClient_MessageRecieved;
                    AddClientsToListView(newClient);
                    AwareClients(newClient);
                    clients.Add(newClient);
                    newClient.StartListening();
                } 
                catch 
                {
                
                }
            }
        }

        private async void AwareClients(Client newClient)
        {
            UpdatenewUserClients(newClient);
            SendAllClients($@"\newClient:{newClient.Name}");
        }

        private void AddClientsToListView(Client newClient)
        {
            this.Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(newClient.ID.ToString());
                item.SubItems.Add(newClient.Name);
                listView1.Items.Add(item);
            }));
            
        }

        private void UpdatenewUserClients(Client client)
        {
            foreach (Client c in clients)
            {
                client.send($@"\newClient:{c.Name}");
            }
        }

        private void SendPrivateClient(string msg)
        {
            string[] message = msg.Split(':');
            string name = message[1];
            foreach (Client client in clients)
            {
                if (client.Name == name)
                {
                    client.send(msg);
                }
            }
        }

        private void SendAllClients(string msg)
        {
            foreach (Client client in clients)
            {
                client.send(msg);
            }
        }

        

        private void StopClients()
        {
            listner.Stop();
            foreach (Client client in clients)
            {
                client.tcp.Close();
            }
        }

        private void NewClient_MessageRecieved(object sender, string e)
        {
            string[] message = e.Split(':');
            switch (message[0])
            {
                case @"\nPublic":
                    SendAllClients(e);
                    break;
                case @"\nPrivate":
                    SendPrivateClient(e);
                    break;
            }
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

        public Client(TcpClient _client, int _ID)
        {
            tcp = _client;
            NetworkStream stream = tcp.GetStream();
            Writer = new StreamWriter(stream) { AutoFlush = true };
            Reader = new StreamReader(stream);
            ID = _ID;
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


                }       
            }
        }
    }
}
