
namespace Bessonova483___Complex
{
    partial class FormMatrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewnode1matrix = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSizeMatrix = new System.Windows.Forms.ComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonSendtomatrix = new System.Windows.Forms.Button();
            this.buttonsendtonode2 = new System.Windows.Forms.Button();
            this.labelnodeblock = new System.Windows.Forms.Label();
            this.comboBoxNodestoblock = new System.Windows.Forms.ComboBox();
            this.buttonsendtonode3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode1matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(630, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(158, 39);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(319, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Работа с матрицами";
            // 
            // dataGridViewnode1matrix
            // 
            this.dataGridViewnode1matrix.AllowUserToAddRows = false;
            this.dataGridViewnode1matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnode1matrix.Location = new System.Drawing.Point(30, 152);
            this.dataGridViewnode1matrix.Name = "dataGridViewnode1matrix";
            this.dataGridViewnode1matrix.Size = new System.Drawing.Size(719, 239);
            this.dataGridViewnode1matrix.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(103, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Узел 1";
            // 
            // comboBoxSizeMatrix
            // 
            this.comboBoxSizeMatrix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSizeMatrix.FormattingEnabled = true;
            this.comboBoxSizeMatrix.Items.AddRange(new object[] {
            "3x3",
            "4x4",
            "5x5",
            "9x9"});
            this.comboBoxSizeMatrix.Location = new System.Drawing.Point(50, 96);
            this.comboBoxSizeMatrix.Name = "comboBoxSizeMatrix";
            this.comboBoxSizeMatrix.Size = new System.Drawing.Size(153, 29);
            this.comboBoxSizeMatrix.TabIndex = 31;
            this.comboBoxSizeMatrix.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeMatrix_SelectedIndexChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelSize.Location = new System.Drawing.Point(96, 72);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(67, 21);
            this.labelSize.TabIndex = 32;
            this.labelSize.Text = "Размер";
            // 
            // buttonSendtomatrix
            // 
            this.buttonSendtomatrix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendtomatrix.Location = new System.Drawing.Point(30, 399);
            this.buttonSendtomatrix.Name = "buttonSendtomatrix";
            this.buttonSendtomatrix.Size = new System.Drawing.Size(158, 39);
            this.buttonSendtomatrix.TabIndex = 33;
            this.buttonSendtomatrix.Text = "Отправить";
            this.buttonSendtomatrix.UseVisualStyleBackColor = true;
            this.buttonSendtomatrix.Click += new System.EventHandler(this.buttonSendtomatrix_Click);
            // 
            // buttonsendtonode2
            // 
            this.buttonsendtonode2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsendtonode2.Location = new System.Drawing.Point(194, 397);
            this.buttonsendtonode2.Name = "buttonsendtonode2";
            this.buttonsendtonode2.Size = new System.Drawing.Size(225, 39);
            this.buttonsendtonode2.TabIndex = 35;
            this.buttonsendtonode2.Text = "Отправить только узлу 2";
            this.buttonsendtonode2.UseVisualStyleBackColor = true;
            this.buttonsendtonode2.Click += new System.EventHandler(this.buttonsendtonode2_Click);
            // 
            // labelnodeblock
            // 
            this.labelnodeblock.AutoSize = true;
            this.labelnodeblock.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelnodeblock.Location = new System.Drawing.Point(343, 68);
            this.labelnodeblock.Name = "labelnodeblock";
            this.labelnodeblock.Size = new System.Drawing.Size(169, 21);
            this.labelnodeblock.TabIndex = 38;
            this.labelnodeblock.Text = "Узел на блокировку";
            // 
            // comboBoxNodestoblock
            // 
            this.comboBoxNodestoblock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNodestoblock.FormattingEnabled = true;
            this.comboBoxNodestoblock.Items.AddRange(new object[] {
            "2",
            "3",
            "Ничего"});
            this.comboBoxNodestoblock.Location = new System.Drawing.Point(347, 92);
            this.comboBoxNodestoblock.Name = "comboBoxNodestoblock";
            this.comboBoxNodestoblock.Size = new System.Drawing.Size(153, 29);
            this.comboBoxNodestoblock.TabIndex = 37;
            this.comboBoxNodestoblock.SelectedIndexChanged += new System.EventHandler(this.comboBoxNodestoblock_SelectedIndexChanged);
            // 
            // buttonsendtonode3
            // 
            this.buttonsendtonode3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsendtonode3.Location = new System.Drawing.Point(425, 397);
            this.buttonsendtonode3.Name = "buttonsendtonode3";
            this.buttonsendtonode3.Size = new System.Drawing.Size(225, 39);
            this.buttonsendtonode3.TabIndex = 39;
            this.buttonsendtonode3.Text = "Отправить только узлу 3";
            this.buttonsendtonode3.UseVisualStyleBackColor = true;
            this.buttonsendtonode3.Click += new System.EventHandler(this.buttonsendtonode3_Click);
            // 
            // FormMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsendtonode3);
            this.Controls.Add(this.labelnodeblock);
            this.Controls.Add(this.comboBoxNodestoblock);
            this.Controls.Add(this.buttonsendtonode2);
            this.Controls.Add(this.buttonSendtomatrix);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.comboBoxSizeMatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewnode1matrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormMatrix";
            this.Text = "Bessonova 483 - Complex";
            this.Load += new System.EventHandler(this.FormMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode1matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewnode1matrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSizeMatrix;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonSendtomatrix;
        private System.Windows.Forms.Button buttonsendtonode2;
        private System.Windows.Forms.Label labelnodeblock;
        private System.Windows.Forms.ComboBox comboBoxNodestoblock;
        private System.Windows.Forms.Button buttonsendtonode3;
    }
}