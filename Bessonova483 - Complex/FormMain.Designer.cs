
namespace Bessonova483___Complex
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGotoMESH = new System.Windows.Forms.Button();
            this.buttonGotoTCP = new System.Windows.Forms.Button();
            this.buttongotoMsg = new System.Windows.Forms.Button();
            this.buttonGotomatrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGotoMESH
            // 
            this.buttonGotoMESH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotoMESH.Location = new System.Drawing.Point(102, 113);
            this.buttonGotoMESH.Name = "buttonGotoMESH";
            this.buttonGotoMESH.Size = new System.Drawing.Size(256, 56);
            this.buttonGotoMESH.TabIndex = 0;
            this.buttonGotoMESH.Text = "Симулятор MESH-сети";
            this.buttonGotoMESH.UseVisualStyleBackColor = true;
            this.buttonGotoMESH.Click += new System.EventHandler(this.buttonGotoMESH_Click);
            // 
            // buttonGotoTCP
            // 
            this.buttonGotoTCP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotoTCP.Location = new System.Drawing.Point(102, 192);
            this.buttonGotoTCP.Name = "buttonGotoTCP";
            this.buttonGotoTCP.Size = new System.Drawing.Size(256, 56);
            this.buttonGotoTCP.TabIndex = 1;
            this.buttonGotoTCP.Text = "Работа с TCP";
            this.buttonGotoTCP.UseVisualStyleBackColor = true;
            this.buttonGotoTCP.Click += new System.EventHandler(this.buttonGotoTCP_Click);
            // 
            // buttongotoMsg
            // 
            this.buttongotoMsg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttongotoMsg.Location = new System.Drawing.Point(102, 265);
            this.buttongotoMsg.Name = "buttongotoMsg";
            this.buttongotoMsg.Size = new System.Drawing.Size(256, 56);
            this.buttongotoMsg.TabIndex = 2;
            this.buttongotoMsg.Text = "Передача данных между узлами";
            this.buttongotoMsg.UseVisualStyleBackColor = true;
            this.buttongotoMsg.Click += new System.EventHandler(this.buttongotoMsg_Click);
            // 
            // buttonGotomatrix
            // 
            this.buttonGotomatrix.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGotomatrix.Location = new System.Drawing.Point(102, 339);
            this.buttonGotomatrix.Name = "buttonGotomatrix";
            this.buttonGotomatrix.Size = new System.Drawing.Size(256, 56);
            this.buttonGotomatrix.TabIndex = 3;
            this.buttonGotomatrix.Text = "Работа с матрицами";
            this.buttonGotomatrix.UseVisualStyleBackColor = true;
            this.buttonGotomatrix.Click += new System.EventHandler(this.buttonGotomatrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Меню";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGotomatrix);
            this.Controls.Add(this.buttongotoMsg);
            this.Controls.Add(this.buttonGotoTCP);
            this.Controls.Add(this.buttonGotoMESH);
            this.Name = "FormMain";
            this.Text = "Bessonova 483 - Complex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGotoMESH;
        private System.Windows.Forms.Button buttonGotoTCP;
        private System.Windows.Forms.Button buttongotoMsg;
        private System.Windows.Forms.Button buttonGotomatrix;
        private System.Windows.Forms.Label label1;
    }
}

