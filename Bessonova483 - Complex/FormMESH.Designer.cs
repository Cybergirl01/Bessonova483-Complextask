
namespace Bessonova483___Complex
{
    partial class FormMESH
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.listBoxNodes = new System.Windows.Forms.ListBox();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.labelTargetID = new System.Windows.Forms.Label();
            this.textBoxTarID = new System.Windows.Forms.TextBox();
            this.labelSelID = new System.Windows.Forms.Label();
            this.textBoxSelID = new System.Windows.Forms.TextBox();
            this.labelMESH = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSaveCoord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(639, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(158, 39);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(58, 20);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(60, 29);
            this.textBoxX.TabIndex = 2;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(25, 27);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 21);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(124, 28);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(25, 21);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y:";
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(155, 21);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(60, 29);
            this.textBoxY.TabIndex = 4;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Location = new System.Drawing.Point(292, 103);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(496, 335);
            this.pictureBoxMap.TabIndex = 6;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            this.pictureBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);
            this.pictureBoxMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseDown);
            this.pictureBoxMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseMove);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 123);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 39);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(155, 66);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 39);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(9, 66);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 39);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 21;
            this.list.Location = new System.Drawing.Point(12, 228);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(131, 193);
            this.list.TabIndex = 13;
            // 
            // listBoxNodes
            // 
            this.listBoxNodes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxNodes.FormattingEnabled = true;
            this.listBoxNodes.ItemHeight = 21;
            this.listBoxNodes.Location = new System.Drawing.Point(149, 123);
            this.listBoxNodes.Name = "listBoxNodes";
            this.listBoxNodes.Size = new System.Drawing.Size(131, 298);
            this.listBoxNodes.TabIndex = 14;
            // 
            // buttonTarget
            // 
            this.buttonTarget.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTarget.Location = new System.Drawing.Point(292, 58);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(153, 39);
            this.buttonTarget.TabIndex = 15;
            this.buttonTarget.Text = "Назначить Target";
            this.buttonTarget.UseVisualStyleBackColor = true;
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // labelTargetID
            // 
            this.labelTargetID.AutoSize = true;
            this.labelTargetID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTargetID.Location = new System.Drawing.Point(452, 19);
            this.labelTargetID.Name = "labelTargetID";
            this.labelTargetID.Size = new System.Drawing.Size(80, 21);
            this.labelTargetID.TabIndex = 17;
            this.labelTargetID.Text = "TargetID:";
            // 
            // textBoxTarID
            // 
            this.textBoxTarID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTarID.Location = new System.Drawing.Point(534, 16);
            this.textBoxTarID.Name = "textBoxTarID";
            this.textBoxTarID.Size = new System.Drawing.Size(60, 29);
            this.textBoxTarID.TabIndex = 16;
            // 
            // labelSelID
            // 
            this.labelSelID.AutoSize = true;
            this.labelSelID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelID.Location = new System.Drawing.Point(468, 67);
            this.labelSelID.Name = "labelSelID";
            this.labelSelID.Size = new System.Drawing.Size(56, 21);
            this.labelSelID.TabIndex = 19;
            this.labelSelID.Text = "SelID:";
            // 
            // textBoxSelID
            // 
            this.textBoxSelID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelID.Location = new System.Drawing.Point(534, 64);
            this.textBoxSelID.Name = "textBoxSelID";
            this.textBoxSelID.Size = new System.Drawing.Size(60, 29);
            this.textBoxSelID.TabIndex = 18;
            // 
            // labelMESH
            // 
            this.labelMESH.AutoSize = true;
            this.labelMESH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMESH.Location = new System.Drawing.Point(258, 9);
            this.labelMESH.Name = "labelMESH";
            this.labelMESH.Size = new System.Drawing.Size(196, 21);
            this.labelMESH.TabIndex = 20;
            this.labelMESH.Text = "Симулятор MESH-сети";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonSaveCoord
            // 
            this.buttonSaveCoord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveCoord.Location = new System.Drawing.Point(12, 168);
            this.buttonSaveCoord.Name = "buttonSaveCoord";
            this.buttonSaveCoord.Size = new System.Drawing.Size(131, 54);
            this.buttonSaveCoord.TabIndex = 21;
            this.buttonSaveCoord.Text = "Сохранить координаты";
            this.buttonSaveCoord.UseVisualStyleBackColor = true;
            this.buttonSaveCoord.Click += new System.EventHandler(this.buttonSaveCoord_Click);
            // 
            // FormMESH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveCoord);
            this.Controls.Add(this.labelMESH);
            this.Controls.Add(this.labelSelID);
            this.Controls.Add(this.textBoxSelID);
            this.Controls.Add(this.labelTargetID);
            this.Controls.Add(this.textBoxTarID);
            this.Controls.Add(this.buttonTarget);
            this.Controls.Add(this.listBoxNodes);
            this.Controls.Add(this.list);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormMESH";
            this.Text = "Bessonova 483 - Complex";
            this.Load += new System.EventHandler(this.FormMESH_Load);
            this.Resize += new System.EventHandler(this.FormMESH_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.ListBox listBoxNodes;
        private System.Windows.Forms.Button buttonTarget;
        private System.Windows.Forms.Label labelTargetID;
        private System.Windows.Forms.TextBox textBoxTarID;
        private System.Windows.Forms.Label labelSelID;
        private System.Windows.Forms.TextBox textBoxSelID;
        private System.Windows.Forms.Label labelMESH;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSaveCoord;
    }
}