using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bessonova483___Complex
{
    public partial class FormMESH : Form
    {
        public FormMESH()
        {
            InitializeComponent();
        }
        int X;
        int Y;
        string figure = "Circle";
        int old_x, old_y;
        List<Drawcircle> lst = new List<Drawcircle>();
        float radius;

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMap_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            textBoxX.Text = X.ToString();
            textBoxY.Text = Y.ToString();
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach (Drawcircle fig in lst)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;

                }
                pictureBoxMap.Invalidate();

            }

            old_x = e.X;
            old_y = e.Y;
            if (e.Button == MouseButtons.Right)

            {
                string data = textBoxX.Text + " " + textBoxY.Text + Environment.NewLine;
                list.Items.Add(data);

            }

        }


        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, pictureBoxMap.Width, pictureBoxMap.Height);
            foreach (Drawcircle fig in lst)
                fig.draw(e.Graphics);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Drawcircle fig = Createfigure();
            if (fig == null) return;
            fig.pos_x = pictureBoxMap.Width * 0.5f;
            fig.pos_y = pictureBoxMap.Height * 0.5f;
            listBoxNodes.Items.Add(fig.id);
            lst.Add(fig);


            pictureBoxMap.Invalidate();
        }
        Drawcircle Createfigure()
        {

            return new Circle(10);
        }

        private void FormMESH_Load(object sender, EventArgs e)
        {
            FormMESH_Resize(null, null);
        }

        private void FormMESH_Resize(object sender, EventArgs e)
        {
            int w = ClientRectangle.Width - 16;
            int h = ClientRectangle.Height - pictureBoxMap.Top - 16;

            pictureBoxMap.Width = w;
            pictureBoxMap.Height = h;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < lst.Count)
            {
                lst.RemoveAt(i);
                listBoxNodes.Items.RemoveAt(i);
                i++;
            }
            list.Items.Clear();
            pictureBoxMap.Invalidate();
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            foreach (Drawcircle fig in lst)

                fig.selected = false;
            for (int i = lst.Count - 1; i >= 0; i--)
            {

                Drawcircle fig = lst[i];
                fig.selectTarget = true;
                fig.selected |= fig.test(X, Y);
                if (fig.selected == true)
                {

                    if (fig.selectTarget == true)
                    {
                        fig.Maketarget();
                    }
                }

                textBoxTarID.Text = fig.id.ToString();

            }

            pictureBoxMap.Invalidate();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            string dataexport = "Target id node: " + textBoxTarID.Text + "\n" + "Selected id node: " + textBoxSelID.Text + "\n" + "Radius: " + 10; 
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                        streamWriter.WriteLine(dataexport);
                        streamWriter.Close();
                    }
         }
            
        

        private void pictureBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Drawcircle fig in lst)

                fig.selected = false;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Drawcircle fig = lst[i];
                fig.selected |= fig.test(X, Y);
                if (fig.selected == true)
                {

                    textBoxSelID.Text = fig.id.ToString();
                }
            }
        }

        private void buttonSaveCoord_Click(object sender, EventArgs e)
        {
            string nodedata, Coordinates;
            for (int i = 0; i < listBoxNodes.Items.Count; i++)
            {
                nodedata = listBoxNodes.Items[i].ToString();
                Coordinates = list.Items[i].ToString();
                    string dataexportCoord = "id node: " + nodedata + "\n" + "coordinaties: " + Coordinates + "\n" + "Radius: " + 10;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                        streamWriter.WriteLine(dataexportCoord);
                        streamWriter.Close();
                    }
                }
            }
        

        private void pictureBoxMap_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Drawcircle fig in lst)
                fig.selected = false;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Drawcircle fig = lst[i];
                fig.selected |= fig.test(X, Y);
                if (fig.selected == true)
                {
                    break;
                    
                }

                pictureBoxMap.Invalidate();
            }
        }
    }
}

