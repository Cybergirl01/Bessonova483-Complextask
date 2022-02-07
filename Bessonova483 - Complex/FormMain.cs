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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGotoMESH_Click(object sender, EventArgs e)
        {
            FormMESH Mesh = new FormMESH();
            this.Hide();
            Mesh.ShowDialog();
            this.Show();
        }

        private void buttonGotoTCP_Click(object sender, EventArgs e)
        {
            FormTCP TCP = new FormTCP();
            this.Hide();
            TCP.ShowDialog();
            this.Show();
        }

        private void buttongotoMsg_Click(object sender, EventArgs e)
        {
            FormMsg msg = new FormMsg();
            this.Hide();
            msg.ShowDialog();
            this.Show();
        }

        private void buttonGotomatrix_Click(object sender, EventArgs e)
        {
            FormMatrix matrix = new FormMatrix();
            this.Hide();
            matrix.ShowDialog();
            this.Show();
        }
    }
}
