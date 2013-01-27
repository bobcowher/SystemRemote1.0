using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;


namespace System_Remote_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string host = "192.168.1.14";
        string user = "root";
        string pass = "speak friend and enter";

        public void run(string host, string user, string pass, string command)
        {
            using (var sshClient = new SshClient(host, user, pass))
            {
                sshClient.Connect();
                sshClient.RunCommand(command);
                sshClient.Disconnect();
                sshClient.Dispose();
            }
        }

        void apache_start_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service httpd start");
        }

        void apache_stop_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service httpd stop");
        }

        void apache_restart_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service httpd restart");
        }

        void mysql_start_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service mysqld start");
        }

        void mysql_stop_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service mysqld stop");
        }

        void mysql_restart_button(object sender, EventArgs e)
        {
            run(host, user, pass, "service mysqld restart");
        }
    }
}
