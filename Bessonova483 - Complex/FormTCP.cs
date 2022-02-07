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
using System.IO;

namespace Bessonova483___Complex
{
    public partial class FormTCP : Form
    {
        public FormTCP()
        {
            InitializeComponent();
        }
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

                Debug.WriteLine("command " + res);

                if (res == "auth-ok") { MessageBox.Show("Logged.");
                    textBoxResponse.Text = "Logged. Welcome.";
                }
                if (res == "auth-fail") MessageBox.Show("Not logged. There is a problem.");
                if(res == "create-net-ok"){ MessageBox.Show("Created!"); textBoxResponse.Text = "Logged. Welcome.";
                }
                if (res == "create-net-fail") MessageBox.Show("Not logged. There is a problem!");
                if (res == "pong") MessageBox.Show("pong");
                if (res == "net-begin "+ " net " + " net-end") { MessageBox.Show("Here is the list."); textBoxResponse.Text = res.ToString(); }
                if (res == "remove-net-ok") MessageBox.Show("Removed!");
                if (res == "remove-net-fail") MessageBox.Show("Remove failed!");
                if (res == "rename-net-ok") MessageBox.Show("Renamed!");
                if (res == "rename-net-fail") MessageBox.Show("Rename failed!");
                if (res == "list-node-fail") MessageBox.Show("There is a problem or there are no nodes.");
                if (res == "node-begin " + " node " + " node-end")
                {
                    MessageBox.Show("Here is the list of nodes."); textBoxResponse.Text = res.ToString();
                }
                if (res == "add-node-ok")
                {
                    MessageBox.Show("Node added."); textBoxResponse.Text = res.ToString();
                }
                if (res == "add-node-fail") MessageBox.Show("Failed. Either the net doesn't exist or no access to it.");
                if (res == "remove-node-ok") MessageBox.Show("Removed node.");
                if (res == "remove-node-fail") MessageBox.Show("Failed to remove node. Either the net doesn't exist or no access to it.");
                if (res == "alter-node-ok") MessageBox.Show("Altered.");
                if (res == "alter-node-fail") MessageBox.Show("failed to alter. Either the net doesn't exist or no access to it.");

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Send(textBoxCom.Text);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            socket.Connect(textBoxAddress.Text, Convert.ToInt32(textBoxPort.Text));
            //socket.Connect("v1.fxnode.ru", 7510);

            ThreadStart start = new ThreadStart(idle);
            Thread thread = new Thread(start);

            thread.Start();
            // Send("auth myuser mypassword");
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                textBoxCom.Text = File.ReadAllText(o.FileName, Encoding.Default);
                        
                    
             }
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
                string dataexport = "Address: " + textBoxAddress.Text + "\n" + "Port: " + textBoxPort.Text + "\n" + "Requests:  " + textBoxCom.Text;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine(dataexport);
                    streamWriter.Close();
                }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listBoxCom.Items.Add(textBoxCom.Text);
        }
    }
}
