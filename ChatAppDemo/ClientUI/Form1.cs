using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class Form1 : Form
    {
        public event EventHandler<string> UserLogged;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string name = textBox1.Text;
                UserLogged(this, name);
                this.Close();
            }
        }
    }
}
