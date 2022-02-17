
namespace Bessonova483___Complex
{
    partial class FormTCP
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
            this.components = new System.ComponentModel.Container();
            this.labelMESH = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonCreateNet = new System.Windows.Forms.Button();
            this.LabelSec = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.listBoxRes = new System.Windows.Forms.ListBox();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.groupBoxNet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNewnamenet = new System.Windows.Forms.TextBox();
            this.textBoxNamenet = new System.Windows.Forms.TextBox();
            this.buttonRenameNet = new System.Windows.Forms.Button();
            this.buttonRemoveNet = new System.Windows.Forms.Button();
            this.buttonListnet = new System.Windows.Forms.Button();
            this.groupBoxnodes = new System.Windows.Forms.GroupBox();
            this.buttonRemovenode = new System.Windows.Forms.Button();
            this.buttonAlterNode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNodedata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewnodedata = new System.Windows.Forms.TextBox();
            this.buttonaddnode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonListnodes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRevoke = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRights = new System.Windows.Forms.TextBox();
            this.buttonShare = new System.Windows.Forms.Button();
            this.buttonListUser = new System.Windows.Forms.Button();
            this.buttonListShare = new System.Windows.Forms.Button();
            this.groupBoxNet.SuspendLayout();
            this.groupBoxnodes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMESH
            // 
            this.labelMESH.AutoSize = true;
            this.labelMESH.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMESH.Location = new System.Drawing.Point(211, 9);
            this.labelMESH.Name = "labelMESH";
            this.labelMESH.Size = new System.Drawing.Size(120, 21);
            this.labelMESH.TabIndex = 21;
            this.labelMESH.Text = "Работа с TCP";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(757, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(158, 39);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(31, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(138, 51);
            this.buttonConnect.TabIndex = 32;
            this.buttonConnect.Text = "Подключить сервер";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(258, 44);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(158, 29);
            this.textBoxAddress.TabIndex = 33;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPort.Location = new System.Drawing.Point(481, 44);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 29);
            this.textBoxPort.TabIndex = 34;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(188, 47);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(64, 21);
            this.labelAddress.TabIndex = 35;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPort.Location = new System.Drawing.Point(420, 47);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(55, 21);
            this.labelPort.TabIndex = 36;
            this.labelPort.Text = "Порт:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(706, 90);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(158, 39);
            this.buttonLogin.TabIndex = 37;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPing
            // 
            this.buttonPing.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPing.Location = new System.Drawing.Point(12, 70);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(158, 39);
            this.buttonPing.TabIndex = 38;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonCreateNet
            // 
            this.buttonCreateNet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNet.Location = new System.Drawing.Point(17, 64);
            this.buttonCreateNet.Name = "buttonCreateNet";
            this.buttonCreateNet.Size = new System.Drawing.Size(158, 39);
            this.buttonCreateNet.TabIndex = 39;
            this.buttonCreateNet.Text = "Создать схему";
            this.buttonCreateNet.UseVisualStyleBackColor = true;
            this.buttonCreateNet.Click += new System.EventHandler(this.buttonCreateNet_Click);
            // 
            // LabelSec
            // 
            this.LabelSec.AutoSize = true;
            this.LabelSec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSec.Location = new System.Drawing.Point(732, 62);
            this.LabelSec.Name = "LabelSec";
            this.LabelSec.Size = new System.Drawing.Size(0, 21);
            this.LabelSec.TabIndex = 42;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(661, 62);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 21);
            this.labelTime.TabIndex = 43;
            this.labelTime.Text = "Время:";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPas.Location = new System.Drawing.Point(420, 99);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(73, 21);
            this.labelPas.TabIndex = 47;
            this.labelPas.Text = "Пароль:";
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.Location = new System.Drawing.Point(188, 99);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(65, 21);
            this.labelLog.TabIndex = 46;
            this.labelLog.Text = "Логин:";
            // 
            // textBoxPas
            // 
            this.textBoxPas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPas.Location = new System.Drawing.Point(499, 96);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(171, 29);
            this.textBoxPas.TabIndex = 45;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLog.Location = new System.Drawing.Point(258, 96);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(158, 29);
            this.textBoxLog.TabIndex = 44;
            // 
            // listBoxRes
            // 
            this.listBoxRes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRes.FormattingEnabled = true;
            this.listBoxRes.ItemHeight = 21;
            this.listBoxRes.Location = new System.Drawing.Point(665, 135);
            this.listBoxRes.Name = "listBoxRes";
            this.listBoxRes.Size = new System.Drawing.Size(250, 214);
            this.listBoxRes.TabIndex = 48;
            // 
            // timerPing
            // 
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // groupBoxNet
            // 
            this.groupBoxNet.Controls.Add(this.buttonRemoveNet);
            this.groupBoxNet.Controls.Add(this.buttonRenameNet);
            this.groupBoxNet.Controls.Add(this.label1);
            this.groupBoxNet.Controls.Add(this.textBoxNamenet);
            this.groupBoxNet.Controls.Add(this.labelName);
            this.groupBoxNet.Controls.Add(this.textBoxNewnamenet);
            this.groupBoxNet.Controls.Add(this.buttonCreateNet);
            this.groupBoxNet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxNet.Location = new System.Drawing.Point(31, 135);
            this.groupBoxNet.Name = "groupBoxNet";
            this.groupBoxNet.Size = new System.Drawing.Size(628, 109);
            this.groupBoxNet.TabIndex = 49;
            this.groupBoxNet.TabStop = false;
            this.groupBoxNet.Text = "Net";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Нов. назв.";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(13, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 21);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Название";
            // 
            // textBoxNewnamenet
            // 
            this.textBoxNewnamenet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewnamenet.Location = new System.Drawing.Point(343, 28);
            this.textBoxNewnamenet.Name = "textBoxNewnamenet";
            this.textBoxNewnamenet.Size = new System.Drawing.Size(128, 29);
            this.textBoxNewnamenet.TabIndex = 51;
            // 
            // textBoxNamenet
            // 
            this.textBoxNamenet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNamenet.Location = new System.Drawing.Point(101, 28);
            this.textBoxNamenet.Name = "textBoxNamenet";
            this.textBoxNamenet.Size = new System.Drawing.Size(138, 29);
            this.textBoxNamenet.TabIndex = 50;
            // 
            // buttonRenameNet
            // 
            this.buttonRenameNet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRenameNet.Location = new System.Drawing.Point(184, 64);
            this.buttonRenameNet.Name = "buttonRenameNet";
            this.buttonRenameNet.Size = new System.Drawing.Size(188, 38);
            this.buttonRenameNet.TabIndex = 54;
            this.buttonRenameNet.Text = "Изменить имя схемы";
            this.buttonRenameNet.UseVisualStyleBackColor = true;
            this.buttonRenameNet.Click += new System.EventHandler(this.buttonRenameNet_Click);
            // 
            // buttonRemoveNet
            // 
            this.buttonRemoveNet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveNet.Location = new System.Drawing.Point(378, 63);
            this.buttonRemoveNet.Name = "buttonRemoveNet";
            this.buttonRemoveNet.Size = new System.Drawing.Size(158, 39);
            this.buttonRemoveNet.TabIndex = 55;
            this.buttonRemoveNet.Text = "Удалить схему";
            this.buttonRemoveNet.UseVisualStyleBackColor = true;
            this.buttonRemoveNet.Click += new System.EventHandler(this.buttonRemoveNet_Click);
            // 
            // buttonListnet
            // 
            this.buttonListnet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListnet.Location = new System.Drawing.Point(706, 355);
            this.buttonListnet.Name = "buttonListnet";
            this.buttonListnet.Size = new System.Drawing.Size(158, 39);
            this.buttonListnet.TabIndex = 56;
            this.buttonListnet.Text = "Список схем";
            this.buttonListnet.UseVisualStyleBackColor = true;
            this.buttonListnet.Click += new System.EventHandler(this.buttonListnet_Click);
            // 
            // groupBoxnodes
            // 
            this.groupBoxnodes.Controls.Add(this.textBoxID);
            this.groupBoxnodes.Controls.Add(this.label4);
            this.groupBoxnodes.Controls.Add(this.buttonRemovenode);
            this.groupBoxnodes.Controls.Add(this.buttonAlterNode);
            this.groupBoxnodes.Controls.Add(this.label2);
            this.groupBoxnodes.Controls.Add(this.textBoxNodedata);
            this.groupBoxnodes.Controls.Add(this.label3);
            this.groupBoxnodes.Controls.Add(this.textBoxNewnodedata);
            this.groupBoxnodes.Controls.Add(this.buttonaddnode);
            this.groupBoxnodes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxnodes.Location = new System.Drawing.Point(31, 250);
            this.groupBoxnodes.Name = "groupBoxnodes";
            this.groupBoxnodes.Size = new System.Drawing.Size(628, 115);
            this.groupBoxnodes.TabIndex = 56;
            this.groupBoxnodes.TabStop = false;
            this.groupBoxnodes.Text = "Nodes";
            // 
            // buttonRemovenode
            // 
            this.buttonRemovenode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemovenode.Location = new System.Drawing.Point(378, 64);
            this.buttonRemovenode.Name = "buttonRemovenode";
            this.buttonRemovenode.Size = new System.Drawing.Size(158, 39);
            this.buttonRemovenode.TabIndex = 55;
            this.buttonRemovenode.Text = "Удалить узел";
            this.buttonRemovenode.UseVisualStyleBackColor = true;
            // 
            // buttonAlterNode
            // 
            this.buttonAlterNode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlterNode.Location = new System.Drawing.Point(184, 65);
            this.buttonAlterNode.Name = "buttonAlterNode";
            this.buttonAlterNode.Size = new System.Drawing.Size(188, 38);
            this.buttonAlterNode.TabIndex = 54;
            this.buttonAlterNode.Text = "Изменить узел";
            this.buttonAlterNode.UseVisualStyleBackColor = true;
            this.buttonAlterNode.Click += new System.EventHandler(this.buttonAlterNode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(293, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Нов.данные";
            // 
            // textBoxNodedata
            // 
            this.textBoxNodedata.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNodedata.Location = new System.Drawing.Point(121, 29);
            this.textBoxNodedata.Name = "textBoxNodedata";
            this.textBoxNodedata.Size = new System.Drawing.Size(166, 29);
            this.textBoxNodedata.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Тек. данные";
            // 
            // textBoxNewnodedata
            // 
            this.textBoxNewnodedata.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewnodedata.Location = new System.Drawing.Point(405, 29);
            this.textBoxNewnodedata.Name = "textBoxNewnodedata";
            this.textBoxNewnodedata.Size = new System.Drawing.Size(121, 29);
            this.textBoxNewnodedata.TabIndex = 51;
            // 
            // buttonaddnode
            // 
            this.buttonaddnode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonaddnode.Location = new System.Drawing.Point(17, 65);
            this.buttonaddnode.Name = "buttonaddnode";
            this.buttonaddnode.Size = new System.Drawing.Size(158, 39);
            this.buttonaddnode.TabIndex = 39;
            this.buttonaddnode.Text = "Добавить узел";
            this.buttonaddnode.UseVisualStyleBackColor = true;
            this.buttonaddnode.Click += new System.EventHandler(this.buttonaddnode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(538, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(573, 24);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(49, 29);
            this.textBoxID.TabIndex = 57;
            // 
            // buttonListnodes
            // 
            this.buttonListnodes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListnodes.Location = new System.Drawing.Point(706, 400);
            this.buttonListnodes.Name = "buttonListnodes";
            this.buttonListnodes.Size = new System.Drawing.Size(158, 39);
            this.buttonListnodes.TabIndex = 57;
            this.buttonListnodes.Text = "Список узлов";
            this.buttonListnodes.UseVisualStyleBackColor = true;
            this.buttonListnodes.Click += new System.EventHandler(this.buttonListnodes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRevoke);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxRights);
            this.groupBox1.Controls.Add(this.buttonShare);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(31, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 109);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Net";
            // 
            // buttonRevoke
            // 
            this.buttonRevoke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRevoke.Location = new System.Drawing.Point(184, 64);
            this.buttonRevoke.Name = "buttonRevoke";
            this.buttonRevoke.Size = new System.Drawing.Size(188, 38);
            this.buttonRevoke.TabIndex = 54;
            this.buttonRevoke.Text = "Отменить";
            this.buttonRevoke.UseVisualStyleBackColor = true;
            this.buttonRevoke.Click += new System.EventHandler(this.buttonRevoke_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(316, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Права доступа";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUser.Location = new System.Drawing.Point(134, 28);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(153, 29);
            this.textBoxUser.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Пользователь";
            // 
            // textBoxRights
            // 
            this.textBoxRights.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRights.Location = new System.Drawing.Point(450, 31);
            this.textBoxRights.Name = "textBoxRights";
            this.textBoxRights.Size = new System.Drawing.Size(128, 29);
            this.textBoxRights.TabIndex = 51;
            // 
            // buttonShare
            // 
            this.buttonShare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShare.Location = new System.Drawing.Point(17, 64);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(158, 39);
            this.buttonShare.TabIndex = 39;
            this.buttonShare.Text = "Поделиться";
            this.buttonShare.UseVisualStyleBackColor = true;
            this.buttonShare.Click += new System.EventHandler(this.buttonShare_Click);
            // 
            // buttonListUser
            // 
            this.buttonListUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListUser.Location = new System.Drawing.Point(686, 445);
            this.buttonListUser.Name = "buttonListUser";
            this.buttonListUser.Size = new System.Drawing.Size(209, 39);
            this.buttonListUser.TabIndex = 58;
            this.buttonListUser.Text = "Список пользователей";
            this.buttonListUser.UseVisualStyleBackColor = true;
            this.buttonListUser.Click += new System.EventHandler(this.buttonListUser_Click);
            // 
            // buttonListShare
            // 
            this.buttonListShare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonListShare.Location = new System.Drawing.Point(676, 490);
            this.buttonListShare.Name = "buttonListShare";
            this.buttonListShare.Size = new System.Drawing.Size(229, 51);
            this.buttonListShare.TabIndex = 59;
            this.buttonListShare.Text = "Список предоставленых в доступ";
            this.buttonListShare.UseVisualStyleBackColor = true;
            this.buttonListShare.Click += new System.EventHandler(this.buttonListShare_Click);
            // 
            // FormTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 540);
            this.Controls.Add(this.buttonListShare);
            this.Controls.Add(this.buttonListUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonListnodes);
            this.Controls.Add(this.groupBoxnodes);
            this.Controls.Add(this.buttonListnet);
            this.Controls.Add(this.groupBoxNet);
            this.Controls.Add(this.listBoxRes);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.LabelSec);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelMESH);
            this.Name = "FormTCP";
            this.Text = "Bessonova 483 - complex";
            this.groupBoxNet.ResumeLayout(false);
            this.groupBoxNet.PerformLayout();
            this.groupBoxnodes.ResumeLayout(false);
            this.groupBoxnodes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMESH;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonCreateNet;
        private System.Windows.Forms.Label LabelSec;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ListBox listBoxRes;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.GroupBox groupBoxNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNamenet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNewnamenet;
        private System.Windows.Forms.Button buttonRemoveNet;
        private System.Windows.Forms.Button buttonRenameNet;
        private System.Windows.Forms.Button buttonListnet;
        private System.Windows.Forms.GroupBox groupBoxnodes;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemovenode;
        private System.Windows.Forms.Button buttonAlterNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNodedata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewnodedata;
        private System.Windows.Forms.Button buttonaddnode;
        private System.Windows.Forms.Button buttonListnodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRevoke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRights;
        private System.Windows.Forms.Button buttonShare;
        private System.Windows.Forms.Button buttonListUser;
        private System.Windows.Forms.Button buttonListShare;
    }
}