
namespace Bessonova483___Complex
{
    partial class Formmatrixofnode2
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
            this.labelnode2 = new System.Windows.Forms.Label();
            this.dataGridViewnode2matrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode2matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnode2
            // 
            this.labelnode2.AutoSize = true;
            this.labelnode2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelnode2.Location = new System.Drawing.Point(102, 87);
            this.labelnode2.Name = "labelnode2";
            this.labelnode2.Size = new System.Drawing.Size(60, 21);
            this.labelnode2.TabIndex = 37;
            this.labelnode2.Text = "Узел 2";
            // 
            // dataGridViewnode2matrix
            // 
            this.dataGridViewnode2matrix.AllowUserToAddRows = false;
            this.dataGridViewnode2matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnode2matrix.Location = new System.Drawing.Point(19, 111);
            this.dataGridViewnode2matrix.Name = "dataGridViewnode2matrix";
            this.dataGridViewnode2matrix.Size = new System.Drawing.Size(762, 327);
            this.dataGridViewnode2matrix.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(312, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Работа с матрицами";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(623, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(158, 39);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Formmatrixofnode2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelnode2);
            this.Controls.Add(this.dataGridViewnode2matrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "Formmatrixofnode2";
            this.Text = "Bessonova 483 - Complex";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnode2matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelnode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.DataGridView dataGridViewnode2matrix;
    }
}