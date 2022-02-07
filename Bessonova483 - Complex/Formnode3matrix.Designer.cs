
namespace Bessonova483___Complex
{
    partial class Formnode3matrix
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
            this.labelnode3 = new System.Windows.Forms.Label();
            this.dataGridViewnode3matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode3matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnode3
            // 
            this.labelnode3.AutoSize = true;
            this.labelnode3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelnode3.Location = new System.Drawing.Point(102, 89);
            this.labelnode3.Name = "labelnode3";
            this.labelnode3.Size = new System.Drawing.Size(60, 21);
            this.labelnode3.TabIndex = 41;
            this.labelnode3.Text = "Узел 3";
            // 
            // dataGridViewnode3matrix
            // 
            this.dataGridViewnode3matrix.AllowUserToAddRows = false;
            this.dataGridViewnode3matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnode3matrix.Location = new System.Drawing.Point(19, 113);
            this.dataGridViewnode3matrix.Name = "dataGridViewnode3matrix";
            this.dataGridViewnode3matrix.Size = new System.Drawing.Size(762, 327);
            this.dataGridViewnode3matrix.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(312, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Работа с матрицами";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(623, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(158, 39);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Formnode3matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnode3);
            this.Controls.Add(this.dataGridViewnode3matrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "Formnode3matrix";
            this.Text = "Bessonova 483 - Complex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode3matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnode3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.DataGridView dataGridViewnode3matrix;
    }
}