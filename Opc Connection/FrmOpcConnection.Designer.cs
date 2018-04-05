namespace Opc_Connection
{
    partial class FrmOpcConnection
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btRead = new System.Windows.Forms.Button();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDataChangedRead = new System.Windows.Forms.RichTextBox();
            this.txtVariableRead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btWrite = new System.Windows.Forms.Button();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btReadWrite = new System.Windows.Forms.Button();
            this.rtbDataChangedWrite = new System.Windows.Forms.RichTextBox();
            this.txtVariableWrite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btConnect = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerGui = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerTestConnection = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatus.Text = "Disconnected.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 359);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtVariableRead);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 353);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRead);
            this.groupBox2.Controls.Add(this.rtbRead);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read Method";
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(335, 19);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // rtbRead
            // 
            this.rtbRead.Location = new System.Drawing.Point(6, 19);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.ReadOnly = true;
            this.rtbRead.Size = new System.Drawing.Size(318, 105);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbDataChangedRead);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Changed Method";
            // 
            // rtbDataChangedRead
            // 
            this.rtbDataChangedRead.Location = new System.Drawing.Point(6, 19);
            this.rtbDataChangedRead.Name = "rtbDataChangedRead";
            this.rtbDataChangedRead.ReadOnly = true;
            this.rtbDataChangedRead.Size = new System.Drawing.Size(404, 105);
            this.rtbDataChangedRead.TabIndex = 0;
            this.rtbDataChangedRead.Text = "";
            // 
            // txtVariableRead
            // 
            this.txtVariableRead.ForeColor = System.Drawing.Color.Red;
            this.txtVariableRead.Location = new System.Drawing.Point(67, 42);
            this.txtVariableRead.Name = "txtVariableRead";
            this.txtVariableRead.Size = new System.Drawing.Size(260, 20);
            this.txtVariableRead.TabIndex = 0;
            this.txtVariableRead.Text = "Random.String";
            this.txtVariableRead.TextChanged += new System.EventHandler(this.txtVariableRead_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Variable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btWrite);
            this.panel2.Controls.Add(this.txtWriteValue);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.txtVariableWrite);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(449, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 353);
            this.panel2.TabIndex = 1;
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(316, 81);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(75, 23);
            this.btWrite.TabIndex = 2;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.ForeColor = System.Drawing.Color.Red;
            this.txtWriteValue.Location = new System.Drawing.Point(79, 83);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(221, 20);
            this.txtWriteValue.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "New Value:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btReadWrite);
            this.groupBox3.Controls.Add(this.rtbDataChangedWrite);
            this.groupBox3.Location = new System.Drawing.Point(7, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Changed Method";
            // 
            // btReadWrite
            // 
            this.btReadWrite.Location = new System.Drawing.Point(335, 19);
            this.btReadWrite.Name = "btReadWrite";
            this.btReadWrite.Size = new System.Drawing.Size(75, 23);
            this.btReadWrite.TabIndex = 2;
            this.btReadWrite.Text = "Read";
            this.btReadWrite.UseVisualStyleBackColor = true;
            this.btReadWrite.Click += new System.EventHandler(this.btReadWrite_Click);
            // 
            // rtbDataChangedWrite
            // 
            this.rtbDataChangedWrite.Location = new System.Drawing.Point(6, 19);
            this.rtbDataChangedWrite.Name = "rtbDataChangedWrite";
            this.rtbDataChangedWrite.ReadOnly = true;
            this.rtbDataChangedWrite.Size = new System.Drawing.Size(312, 114);
            this.rtbDataChangedWrite.TabIndex = 0;
            this.rtbDataChangedWrite.Text = "";
            // 
            // txtVariableWrite
            // 
            this.txtVariableWrite.ForeColor = System.Drawing.Color.Red;
            this.txtVariableWrite.Location = new System.Drawing.Point(65, 42);
            this.txtVariableWrite.Name = "txtVariableWrite";
            this.txtVariableWrite.Size = new System.Drawing.Size(260, 20);
            this.txtVariableWrite.TabIndex = 0;
            this.txtVariableWrite.Text = "Bucket Brigade.Boolean";
            this.txtVariableWrite.TextChanged += new System.EventHandler(this.txtVariableWrite_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Variable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 439);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btConnect);
            this.panel3.Controls.Add(this.txtConnectionString);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 68);
            this.panel3.TabIndex = 2;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(796, 32);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(86, 30);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.ForeColor = System.Drawing.Color.Blue;
            this.txtConnectionString.Location = new System.Drawing.Point(120, 38);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(529, 20);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "opcda://localhost/Matrikon.OPC.Simulation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Connection String:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Connection";
            // 
            // timerGui
            // 
            this.timerGui.Enabled = true;
            this.timerGui.Tick += new System.EventHandler(this.timerGui_Tick);
            // 
            // backgroundWorkerTestConnection
            // 
            this.backgroundWorkerTestConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTestConnection_DoWork);
            // 
            // FrmOpcConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOpcConnection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPC Connection.:";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDataChangedRead;
        private System.Windows.Forms.TextBox txtVariableRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.TextBox txtWriteValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtbDataChangedWrite;
        private System.Windows.Forms.TextBox txtVariableWrite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerGui;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTestConnection;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btReadWrite;
    }
}

