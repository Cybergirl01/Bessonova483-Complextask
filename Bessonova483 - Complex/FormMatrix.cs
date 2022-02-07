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
    public partial class FormMatrix : Form
    {
        public FormMatrix()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxSizeMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSizeMatrix.Text)
            {
                case "3x3":

                    dataGridViewnode1matrix.RowCount = 3;
                    dataGridViewnode1matrix.ColumnCount = 3;
                  
                    break;
                case "4x4":
                    dataGridViewnode1matrix.RowCount = 4;
                    dataGridViewnode1matrix.ColumnCount = 4;
                
                    break;
                case "5x5":
                    dataGridViewnode1matrix.RowCount = 5;
                    dataGridViewnode1matrix.ColumnCount = 5;
                
                    break;
                case "9x9":
                    dataGridViewnode1matrix.RowCount = 9;
                    dataGridViewnode1matrix.ColumnCount = 9;
           
                    break;
            }
        }

        private void buttonSendtomatrix_Click(object sender, EventArgs e)
        {
            switch (comboBoxSizeMatrix.Text)
            {
                case "3x3":

                    Formmatrixofnode2 fn2 = new Formmatrixofnode2();

                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            fn2.dataGridViewnode2matrix.Columns.Add(" "," ");
                            fn2.dataGridViewnode2matrix.Rows.Add();

                            fn2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fn2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                    Formnode3matrix fn3 = new Formnode3matrix();

                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            fn3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fn3.dataGridViewnode3matrix.Rows.Add();
                            fn3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fn3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */
                    break;
                case "4x4":
                    Formmatrixofnode2 fnod2 = new Formmatrixofnode2();

                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            fnod2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            fnod2.dataGridViewnode2matrix.Rows.Add();

                            fnod2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fnod2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                    Formnode3matrix fnod3 = new Formnode3matrix();

                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            fnod3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fnod3.dataGridViewnode3matrix.Rows.Add();
                            fnod3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fnod3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */
                    break;

                case "5x5":
                    Formmatrixofnode2 fnode2 = new Formmatrixofnode2();

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            fnode2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            fnode2.dataGridViewnode2matrix.Rows.Add();

                            fnode2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fnode2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                    Formnode3matrix fnode3 = new Formnode3matrix();

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            fnode3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fnode3.dataGridViewnode3matrix.Rows.Add();
                            fnode3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fnode3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */

                    break;
                case "9x9":
                    Formmatrixofnode2 node2 = new Formmatrixofnode2();

                    for (int j = 0; j < 9; j++)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            node2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            node2.dataGridViewnode2matrix.Rows.Add();

                            node2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    node2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                    Formnode3matrix node3 = new Formnode3matrix();

                    for (int j = 0; j < 9; j++)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            node3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            node3.dataGridViewnode3matrix.Rows.Add();
                            node3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    node3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */

                    break;
            }

        }

        private void comboBoxNodestoblock_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNodestoblock.Text)
            {
                case "2":
                    buttonSendtomatrix.Visible = false;
                    buttonSendtomatrix.Enabled = false;
                    buttonsendtonode2.Visible = false;
                    buttonsendtonode2.Enabled = false;
                    buttonsendtonode3.Enabled = true;
                    buttonsendtonode3.Visible = true;
                    break;
                case "3":
                    buttonSendtomatrix.Visible = false;
                    buttonSendtomatrix.Enabled = false;
                    buttonsendtonode2.Visible = true;
                    buttonsendtonode2.Enabled = true;
                    buttonsendtonode3.Enabled = false;
                    buttonsendtonode3.Visible = false;

                    break;
                case "Ничего":
                    buttonSendtomatrix.Visible = true;
                    buttonSendtomatrix.Enabled = true;
                    buttonsendtonode2.Visible = false;
                    buttonsendtonode2.Enabled = false;
                    buttonsendtonode3.Enabled = false;
                    buttonsendtonode3.Visible = false;
                    break;

            }
        }

        private void FormMatrix_Load(object sender, EventArgs e)
        {
            buttonsendtonode2.Visible = false;
            buttonsendtonode2.Enabled = false;
            buttonsendtonode3.Enabled = false;
            buttonsendtonode3.Visible = false;
        }

        private void buttonsendtonode2_Click(object sender, EventArgs e)
        {
            switch (comboBoxSizeMatrix.Text)
            {
                case "3x3":

                    Formmatrixofnode2 fn2 = new Formmatrixofnode2();

                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            fn2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            fn2.dataGridViewnode2matrix.Rows.Add();

                            fn2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fn2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                   
                    break;
                case "4x4":
                    Formmatrixofnode2 fnod2 = new Formmatrixofnode2();

                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            fnod2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            fnod2.dataGridViewnode2matrix.Rows.Add();

                            fnod2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fnod2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                    
                    break;

                case "5x5":
                    Formmatrixofnode2 fnode2 = new Formmatrixofnode2();

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            fnode2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            fnode2.dataGridViewnode2matrix.Rows.Add();

                            fnode2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    fnode2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                   

                    break;
                case "9x9":
                    Formmatrixofnode2 node2 = new Formmatrixofnode2();

                    for (int j = 0; j < 9; j++)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            node2.dataGridViewnode2matrix.Columns.Add(" ", " ");
                            node2.dataGridViewnode2matrix.Rows.Add();

                            node2.dataGridViewnode2matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }

                    node2.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде 

                  

                    break;
            }
        }

        private void buttonsendtonode3_Click(object sender, EventArgs e)
        {
            switch (comboBoxSizeMatrix.Text)
            {
                case "3x3":



                    Formnode3matrix fn3 = new Formnode3matrix();

                    for (int j = 0; j < 3; j++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            fn3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fn3.dataGridViewnode3matrix.Rows.Add();
                            fn3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fn3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */
                    break;
                case "4x4":


                    Formnode3matrix fnod3 = new Formnode3matrix();

                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            fnod3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fnod3.dataGridViewnode3matrix.Rows.Add();
                            fnod3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fnod3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */
                    break;

                case "5x5":
              

                    Formnode3matrix fnode3 = new Formnode3matrix();

                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            fnode3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            fnode3.dataGridViewnode3matrix.Rows.Add();
                            fnode3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    fnode3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */

                    break;
                case "9x9":
                   

                    Formnode3matrix node3 = new Formnode3matrix();

                    for (int j = 0; j < 9; j++)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            node3.dataGridViewnode3matrix.Columns.Add(" ", " ");
                            node3.dataGridViewnode3matrix.Rows.Add();
                            node3.dataGridViewnode3matrix.Rows[j].Cells[i].Value = dataGridViewnode1matrix.Rows[j].Cells[i].Value;

                        }
                    }
                    node3.Show();   // После клика по кнопке откроется форма2 с копией данных на датагриде */

                    break;
            }
        }
    }
}
