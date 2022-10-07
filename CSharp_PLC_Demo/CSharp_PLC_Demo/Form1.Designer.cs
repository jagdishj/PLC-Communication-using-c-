
namespace CSharp_PLC_Demo
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxCPUType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxdbx01 = new System.Windows.Forms.CheckBox();
            this.cBoxdbx00 = new System.Windows.Forms.CheckBox();
            this.txtdb1dbw8 = new System.Windows.Forms.TextBox();
            this.txtdb1dbw2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCustomWrite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtSlot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRack);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxCPUType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(229, 193);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 25);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(131, 192);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 26);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(131, 158);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(193, 22);
            this.txtSlot.TabIndex = 4;
            this.txtSlot.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Slot";
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(131, 117);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(193, 22);
            this.txtRack.TabIndex = 3;
            this.txtRack.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rack";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(131, 79);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(193, 22);
            this.txtIPAddress.TabIndex = 2;
            this.txtIPAddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address";
            // 
            // cboxCPUType
            // 
            this.cboxCPUType.FormattingEnabled = true;
            this.cboxCPUType.Location = new System.Drawing.Point(131, 32);
            this.cboxCPUType.Name = "cboxCPUType";
            this.cboxCPUType.Size = new System.Drawing.Size(193, 24);
            this.cboxCPUType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWrite);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Controls.Add(this.txtPV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMAddress);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(33, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read/Write Memory";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(213, 146);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(95, 25);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(115, 145);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 26);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(115, 111);
            this.txtPV.Name = "txtPV";
            this.txtPV.Size = new System.Drawing.Size(193, 22);
            this.txtPV.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "PV";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(115, 75);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(193, 22);
            this.txtSP.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "SP";
            // 
            // txtMAddress
            // 
            this.txtMAddress.Location = new System.Drawing.Point(115, 38);
            this.txtMAddress.Name = "txtMAddress";
            this.txtMAddress.Size = new System.Drawing.Size(193, 22);
            this.txtMAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxdbx01);
            this.groupBox3.Controls.Add(this.cBoxdbx00);
            this.groupBox3.Controls.Add(this.txtdb1dbw8);
            this.groupBox3.Controls.Add(this.txtdb1dbw2);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCustomWrite);
            this.groupBox3.Location = new System.Drawing.Point(420, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 285);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Read/Write Options";
            // 
            // cBoxdbx01
            // 
            this.cBoxdbx01.AutoSize = true;
            this.cBoxdbx01.Location = new System.Drawing.Point(250, 113);
            this.cBoxdbx01.Name = "cBoxdbx01";
            this.cBoxdbx01.Size = new System.Drawing.Size(18, 17);
            this.cBoxdbx01.TabIndex = 24;
            this.cBoxdbx01.UseVisualStyleBackColor = true;
            // 
            // cBoxdbx00
            // 
            this.cBoxdbx00.AutoSize = true;
            this.cBoxdbx00.Location = new System.Drawing.Point(250, 79);
            this.cBoxdbx00.Name = "cBoxdbx00";
            this.cBoxdbx00.Size = new System.Drawing.Size(18, 17);
            this.cBoxdbx00.TabIndex = 23;
            this.cBoxdbx00.UseVisualStyleBackColor = true;
            // 
            // txtdb1dbw8
            // 
            this.txtdb1dbw8.Location = new System.Drawing.Point(202, 192);
            this.txtdb1dbw8.Name = "txtdb1dbw8";
            this.txtdb1dbw8.Size = new System.Drawing.Size(159, 22);
            this.txtdb1dbw8.TabIndex = 20;
            this.txtdb1dbw8.Text = "123456";
            // 
            // txtdb1dbw2
            // 
            this.txtdb1dbw2.Location = new System.Drawing.Point(202, 153);
            this.txtdb1dbw2.Name = "txtdb1dbw2";
            this.txtdb1dbw2.Size = new System.Drawing.Size(159, 22);
            this.txtdb1dbw2.TabIndex = 19;
            this.txtdb1dbw2.Text = "50";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Values";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "DB1.DBD8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "DB1.DBW2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "DB1.DBX0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "DB1.DBX0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address";
            // 
            // btnCustomWrite
            // 
            this.btnCustomWrite.Location = new System.Drawing.Point(149, 247);
            this.btnCustomWrite.Name = "btnCustomWrite";
            this.btnCustomWrite.Size = new System.Drawing.Size(95, 25);
            this.btnCustomWrite.TabIndex = 9;
            this.btnCustomWrite.Text = "Write";
            this.btnCustomWrite.UseVisualStyleBackColor = true;
            this.btnCustomWrite.Click += new System.EventHandler(this.btnCustomWrite_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "PLC Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxCPUType;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCustomWrite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdb1dbw8;
        private System.Windows.Forms.TextBox txtdb1dbw2;
        private System.Windows.Forms.CheckBox cBoxdbx01;
        private System.Windows.Forms.CheckBox cBoxdbx00;
    }
}

