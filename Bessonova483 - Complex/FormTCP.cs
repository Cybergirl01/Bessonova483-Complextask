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
using System.Threading;
using System.Diagnostics;


namespace Bessonova483___Complex
{
    public partial class FormTCP : Form
    {
        public FormTCP()
        {
            InitializeComponent();
        }
        int timesec;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<string> cmd = new List<string>(); 

        void idle()
        {
            string acc = "";

            byte[] buf = new byte[512];
            while (true)
            {
                int len = socket.Receive(buf);

                if(len == 0)
                {
                    break;
                }
                string part = Encoding.ASCII.GetString(buf, 0, len);

                Debug.WriteLine("Receive: " + part);

                acc += part;
                while (true)
                {
                    int pos = acc.IndexOf(Environment.NewLine);
                    if(pos < 0)
                    {
                        break;
                    }
                    string str = acc.Substring(0, pos);
                    acc = acc.Substring(pos + 2);

                    cmd.Add(str);
                }
            }
        }

        void Send(string message)
        {
            string txt = message + Environment.NewLine;
            Debug.WriteLine("send " + txt);
            byte[] buf = Encoding.ASCII.GetBytes(txt);

            socket.Send(buf);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            while (cmd.Count > 0)
            {
                string res = cmd[0];
                cmd.RemoveAt(0);
                string[] mas = res.Split(' ');
                Debug.WriteLine("command: " + res);
                if (res == "auth-ok") MessageBox.Show("All good!");
                if (res == "auth-fail") MessageBox.Show("All bad!");

                if (mas[0] == "net-begin")
                {
                    listBoxRes.Items.Clear();
                }
                if(mas[0] == "net")
                {
                    listBoxRes.Items.Add(mas[1] + " " + mas[2] + " " + mas[3] + " " + mas[4]);
                }
                if (res == "create-net-ok") MessageBox.Show("All good!");
                if (res == "create-net-fail") MessageBox.Show("All bad!");
                if (res == "remove-node-ok") MessageBox.Show("All good!");
                if (res == "remove-node-fail") MessageBox.Show("All bad!");
                if (res == "rename-net-ok") MessageBox.Show("All good!");
                if (res == "rename-net-fail") MessageBox.Show("All bad!");
                if (res == "remove-net-ok") MessageBox.Show("All good!");
                if (res == "remove-net-fail") MessageBox.Show("All bad!");
                if (res == "add-node-ok") MessageBox.Show("All good!");
                if (res == "add-node-fail") MessageBox.Show("All bad!");
                if (res == "list-nodes-fail") MessageBox.Show("All bad!");
                if (mas[0] == "node-begin")
                {
                    listBoxRes.Items.Clear();
                }
                if (mas[0] == "node")
                {
                    listBoxRes.Items.Add(mas[1] + " " + mas[2] + " " + mas[3] + " " + mas[4] +" "+ mas[5]);
                }
                if (res == "alter-node-ok") MessageBox.Show("All good!");
                if (res == "alter-node-fail") MessageBox.Show("All bad!");
                if (mas[0] == "user-begin")
                {
                    listBoxRes.Items.Clear();
                }
                if (mas[0] == "user")
                {
                    listBoxRes.Items.Add(mas[1]);
                }
                if (mas[0] == "share-begin")
                {
                    listBoxRes.Items.Clear();
                }
                if (mas[0] == "share")
                {
                    listBoxRes.Items.Add(mas[1] + " " + mas[2] + " " + mas[3]);
                }
                if (res == "share-ok") MessageBox.Show("All good!");
                if (res == "share-fail") MessageBox.Show("All bad!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            socket.Connect(textBoxAddress.Text, Convert.ToInt32(textBoxPort.Text));
            //socket.Connect("v1.fxnode.ru", 7510);

            ThreadStart start = new ThreadStart(idle);
            Thread thread = new Thread(start);

            thread.Start();
            timer.Start();
            timesec = 15;
            timerPing.Interval = 1500;
            timerPing.Start();
            LabelSec.Text = "15";
            
        }

    private void buttonLogin_Click(object sender, EventArgs e)
        {
            string log = textBoxLog.Text;
            string pas = textBoxPas.Text;
            string message = "auth" + " " + log + " " + pas;
            Send(message);
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            timesec--;
            if (timesec < 0)
            {
                timerPing.Stop();
                return;
            }
            LabelSec.Text = timesec.ToString();

        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            string message = "ping";
            Send(message);
            timesec = 15;
            timerPing.Interval = 1500;
            timerPing.Start();
            LabelSec.Text = "15";
        }

        private void buttonCreateNet_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string message = "create-net" + " " + namenet;
            Send(message);
            textBoxNamenet.Clear();
        }

        private void buttonRenameNet_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string newnamenet = textBoxNewnamenet.Text;
            string message = "rename-net" + " " + namenet + " "+ newnamenet;
            Send(message);
            textBoxNamenet.Clear();
            textBoxNewnamenet.Clear();
        }

        private void buttonRemoveNet_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string message = "remove-net" + " " + namenet;
            Send(message);
            textBoxNamenet.Clear();
        }

        private void buttonListnet_Click(object sender, EventArgs e)
        {
            string message = "list-nets";
            Send(message);
           
        }

        private void buttonListShare_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string message = "list-shares" + " " + namenet;
            Send(message);
            textBoxNamenet.Clear();
            
        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            string message = "list-users";
            Send(message);
        }

        private void buttonaddnode_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string dataNode = textBoxNodedata.Text;
            string message = "add-node" + " " + namenet + " " + dataNode;
            Send(message);
            textBoxNamenet.Clear();
            textBoxNodedata.Clear();
        }

        private void buttonAlterNode_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string newdataNode = textBoxNewnodedata.Text;
            string idnode = textBoxID.Text;
            string message = "alter-node" + " " + namenet + " " + idnode + " " +newdataNode ;
            Send(message);
            textBoxNamenet.Clear();
            textBoxNodedata.Clear();
        }

        private void buttonShare_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string user = textBoxUser.Text;
            string right = textBoxRights.Text;
            string message = "share" + " " + namenet + " " + user + " " + right;
            Send(message);
            textBoxNamenet.Clear();
            textBoxUser.Clear();
            textBoxRights.Clear();
        }

        private void buttonRevoke_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string user = textBoxUser.Text;
            string message = "revoke" + " " + namenet + " " + user;
            Send(message);
            textBoxNamenet.Clear();
            textBoxUser.Clear();
       
        }

        private void buttonListnodes_Click(object sender, EventArgs e)
        {
            string namenet = textBoxNamenet.Text;
            string message = "list-nodes" + " " + namenet;
            Send(message);
            textBoxNamenet.Clear();
        }
    }
}
