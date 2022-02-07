using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483___Complex
{
    public partial class FormMsg : Form
    {
        public FormMsg()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendtoSer_Click(object sender, EventArgs e)
        {
            switch (comboBoxNodes.SelectedItem)
            {
                case "2": richTextBoxnod1.Text = richTextBoxnod2.Text; break;
                case "3": richTextBoxnod1.Text = richTextBoxnod2.Text = richTextBox3.Text; break;
                case "4": richTextBoxnod1.Text = richTextBoxnod2.Text = richTextBox3.Text = richTextBox4.Text; break;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            richTextBoxnod1.Clear();
            richTextBoxnod2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();

        }

        private void comboBoxNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNodes.SelectedItem)
            {
                case "2": richTextBoxnod1.Visible = richTextBoxnod2.Visible = true; break;
                case "3": richTextBoxnod1.Visible = richTextBoxnod2.Visible = richTextBox3.Visible = true; break;
                case "4": richTextBoxnod1.Visible = richTextBoxnod2.Visible = richTextBox3.Visible = richTextBox4.Visible = true; break;
            }
        }
    }
}
