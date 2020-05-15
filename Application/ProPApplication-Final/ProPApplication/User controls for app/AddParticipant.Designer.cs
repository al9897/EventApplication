namespace ProPApplication
{
    partial class AddParticipant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.bttScan = new System.Windows.Forms.Button();
			this.tbNewRFID = new System.Windows.Forms.TextBox();
			this.tbNewPhone = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.tbxNewName = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btUpdate = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tbxRegisteredAccNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.bttSearchCode = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbxRegisteredName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxRegisteredId = new System.Windows.Forms.TextBox();
			this.bttCheckOut = new System.Windows.Forms.Button();
			this.bttLost = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lostRFID = new ProPApplication.LostRFID();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.IndianRed;
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.tbMail);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.bttScan);
			this.panel1.Controls.Add(this.tbNewRFID);
			this.panel1.Controls.Add(this.tbNewPhone);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.tbxNewName);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Location = new System.Drawing.Point(0, 42);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(557, 348);
			this.panel1.TabIndex = 0;
			this.toolTip1.SetToolTip(this.panel1, "Click to scan RFID for new participant");
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(3, 238);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(57, 20);
			this.label15.TabIndex = 27;
			this.label15.Text = "E-mail";
			// 
			// tbMail
			// 
			this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMail.Location = new System.Drawing.Point(153, 235);
			this.tbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(260, 26);
			this.tbMail.TabIndex = 26;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(180, 286);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 39);
			this.button1.TabIndex = 18;
			this.button1.Text = "AddNew";
			this.toolTip1.SetToolTip(this.button1, "Click to add new Participant");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(7, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 20);
			this.label10.TabIndex = 23;
			this.label10.Text = "Ticket Id";
			// 
			// bttScan
			// 
			this.bttScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttScan.ForeColor = System.Drawing.Color.Maroon;
			this.bttScan.Location = new System.Drawing.Point(208, 57);
			this.bttScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttScan.Name = "bttScan";
			this.bttScan.Size = new System.Drawing.Size(123, 28);
			this.bttScan.TabIndex = 15;
			this.bttScan.Text = "Scan";
			this.bttScan.UseVisualStyleBackColor = true;
			this.bttScan.Click += new System.EventHandler(this.bttScan_Click);
			// 
			// tbNewRFID
			// 
			this.tbNewRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNewRFID.Location = new System.Drawing.Point(153, 23);
			this.tbNewRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbNewRFID.Name = "tbNewRFID";
			this.tbNewRFID.Size = new System.Drawing.Size(260, 26);
			this.tbNewRFID.TabIndex = 15;
			this.tbNewRFID.Text = "TicketId";
			// 
			// tbNewPhone
			// 
			this.tbNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNewPhone.Location = new System.Drawing.Point(153, 172);
			this.tbNewPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbNewPhone.Name = "tbNewPhone";
			this.tbNewPhone.Size = new System.Drawing.Size(260, 26);
			this.tbNewPhone.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 178);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 20);
			this.label12.TabIndex = 19;
			this.label12.Text = "Phone";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 118);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 20);
			this.label13.TabIndex = 18;
			this.label13.Text = "Name";
			// 
			// tbxNewName
			// 
			this.tbxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxNewName.Location = new System.Drawing.Point(153, 111);
			this.tbxNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxNewName.Name = "tbxNewName";
			this.tbxNewName.Size = new System.Drawing.Size(260, 26);
			this.tbxNewName.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(7, 87);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(184, 20);
			this.label14.TabIndex = 16;
			this.label14.Text = "Paticipant\'s information";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.IndianRed;
			this.panel2.Controls.Add(this.btUpdate);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.tbxRegisteredAccNo);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.tbPhone);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.bttSearchCode);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.tbxRegisteredName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tbxRegisteredId);
			this.panel2.Location = new System.Drawing.Point(0, 42);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(527, 347);
			this.panel2.TabIndex = 1;
			// 
			// btUpdate
			// 
			this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btUpdate.ForeColor = System.Drawing.Color.Maroon;
			this.btUpdate.Location = new System.Drawing.Point(200, 318);
			this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(169, 27);
			this.btUpdate.TabIndex = 18;
			this.btUpdate.Text = "Update";
			this.toolTip1.SetToolTip(this.btUpdate, "Click to update information");
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Maroon;
			this.button2.Location = new System.Drawing.Point(296, 24);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 38);
			this.button2.TabIndex = 17;
			this.button2.Text = "Search";
			this.toolTip1.SetToolTip(this.button2, "Click to scan and search by RFID");
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(20, 26);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 36);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "Ticket number";
			// 
			// tbxRegisteredAccNo
			// 
			this.tbxRegisteredAccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxRegisteredAccNo.Location = new System.Drawing.Point(163, 232);
			this.tbxRegisteredAccNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxRegisteredAccNo.Name = "tbxRegisteredAccNo";
			this.tbxRegisteredAccNo.Size = new System.Drawing.Size(260, 26);
			this.tbxRegisteredAccNo.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 20);
			this.label7.TabIndex = 11;
			this.label7.Text = "AccountNumber";
			// 
			// tbPhone
			// 
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPhone.Location = new System.Drawing.Point(163, 187);
			this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(260, 26);
			this.tbPhone.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Phone";
			// 
			// bttSearchCode
			// 
			this.bttSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttSearchCode.ForeColor = System.Drawing.Color.Maroon;
			this.bttSearchCode.Location = new System.Drawing.Point(296, 71);
			this.bttSearchCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttSearchCode.Name = "bttSearchCode";
			this.bttSearchCode.Size = new System.Drawing.Size(169, 38);
			this.bttSearchCode.TabIndex = 6;
			this.bttSearchCode.Text = "Scan RFID";
			this.toolTip1.SetToolTip(this.bttSearchCode, "Click to scan and search by RFID");
			this.bttSearchCode.UseVisualStyleBackColor = true;
			this.bttSearchCode.Click += new System.EventHandler(this.bttSearchCode_Click_1);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Name";
			// 
			// tbxRegisteredName
			// 
			this.tbxRegisteredName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxRegisteredName.Location = new System.Drawing.Point(163, 142);
			this.tbxRegisteredName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxRegisteredName.Name = "tbxRegisteredName";
			this.tbxRegisteredName.Size = new System.Drawing.Size(260, 26);
			this.tbxRegisteredName.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Paticipant\'s information";
			// 
			// tbxRegisteredId
			// 
			this.tbxRegisteredId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxRegisteredId.Location = new System.Drawing.Point(20, 71);
			this.tbxRegisteredId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxRegisteredId.Name = "tbxRegisteredId";
			this.tbxRegisteredId.Size = new System.Drawing.Size(260, 36);
			this.tbxRegisteredId.TabIndex = 1;
			this.tbxRegisteredId.Text = "RFID";
			// 
			// bttCheckOut
			// 
			this.bttCheckOut.ForeColor = System.Drawing.Color.Maroon;
			this.bttCheckOut.Location = new System.Drawing.Point(723, 512);
			this.bttCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttCheckOut.Name = "bttCheckOut";
			this.bttCheckOut.Size = new System.Drawing.Size(232, 57);
			this.bttCheckOut.TabIndex = 16;
			this.bttCheckOut.Text = "Check Out";
			this.toolTip1.SetToolTip(this.bttCheckOut, "click to check out");
			this.bttCheckOut.UseVisualStyleBackColor = true;
			this.bttCheckOut.Click += new System.EventHandler(this.bttCheckOut_Click_1);
			// 
			// bttLost
			// 
			this.bttLost.ForeColor = System.Drawing.Color.Maroon;
			this.bttLost.Location = new System.Drawing.Point(135, 495);
			this.bttLost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttLost.Name = "bttLost";
			this.bttLost.Size = new System.Drawing.Size(232, 57);
			this.bttLost.TabIndex = 17;
			this.bttLost.Text = "Lost RFID?";
			this.toolTip1.SetToolTip(this.bttLost, "Click  to get a new RFID");
			this.bttLost.UseVisualStyleBackColor = true;
			this.bttLost.Click += new System.EventHandler(this.bttLost_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.lostRFID);
			this.groupBox2.Controls.Add(this.bttLost);
			this.groupBox2.Controls.Add(this.bttCheckOut);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1160, 606);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Maroon;
			this.button3.Location = new System.Drawing.Point(972, 468);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(169, 49);
			this.button3.TabIndex = 19;
			this.button3.Text = "Scan RFID To Check Out";
			this.toolTip1.SetToolTip(this.button3, "Click to scan and search by RFID");
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(695, 472);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(271, 36);
			this.textBox2.TabIndex = 19;
			this.textBox2.Text = "RFID";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(597, 62);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(520, 400);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Registered Participant";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(20, 62);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(551, 400);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Participant";
			// 
			// lostRFID
			// 
			this.lostRFID.BackColor = System.Drawing.Color.IndianRed;
			this.lostRFID.Location = new System.Drawing.Point(577, 438);
			this.lostRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lostRFID.Name = "lostRFID";
			this.lostRFID.Size = new System.Drawing.Size(13, 12);
			this.lostRFID.TabIndex = 18;
			// 
			// AddParticipant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.Controls.Add(this.groupBox2);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AddParticipant";
			this.Size = new System.Drawing.Size(1160, 606);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttSearchCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRegisteredName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxRegisteredId;
        private System.Windows.Forms.TextBox tbxRegisteredAccNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttCheckOut;
        private System.Windows.Forms.Button bttLost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttScan;
        private System.Windows.Forms.TextBox tbNewRFID;
        private System.Windows.Forms.TextBox tbNewPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.Label label14;
        private LostRFID lostRFID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ToolTip toolTip2;
	}
}
