namespace ProPApplication
{
    partial class LostRFID
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.tbDOB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.tbLost = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(276, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(275, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(276, 94);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(33, 17);
			this.Email.TabIndex = 3;
			this.Email.Text = "Mail";
			// 
			// tbMail
			// 
			this.tbMail.Location = new System.Drawing.Point(419, 70);
			this.tbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbMail.Multiline = true;
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(356, 38);
			this.tbMail.TabIndex = 5;
			this.tbMail.Text = "Input e-mail";
			this.toolTip1.SetToolTip(this.tbMail, "Enter e-mail and click");
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(419, 182);
			this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbLastName.Multiline = true;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(356, 38);
			this.tbLastName.TabIndex = 6;
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(419, 126);
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFirstName.Multiline = true;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(356, 38);
			this.tbFirstName.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(419, 515);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(292, 64);
			this.button1.TabIndex = 8;
			this.button1.Text = "Get new";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(419, 439);
			this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(356, 38);
			this.textBox5.TabIndex = 9;
			this.toolTip1.SetToolTip(this.textBox5, "New RFID");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(276, 463);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "New RFID";
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Maroon;
			this.button2.Location = new System.Drawing.Point(457, 484);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(292, 27);
			this.button2.TabIndex = 11;
			this.button2.Text = "Get new RFID";
			this.toolTip1.SetToolTip(this.button2, "Click here to get a new RFID");
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(419, 239);
			this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPhone.Multiline = true;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(356, 38);
			this.tbPhone.TabIndex = 12;
			// 
			// tbDOB
			// 
			this.tbDOB.Location = new System.Drawing.Point(419, 299);
			this.tbDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDOB.Multiline = true;
			this.tbDOB.Name = "tbDOB";
			this.tbDOB.Size = new System.Drawing.Size(356, 38);
			this.tbDOB.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(276, 262);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 14;
			this.label3.Text = "Phone";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(276, 322);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "DOB";
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.Maroon;
			this.button3.Location = new System.Drawing.Point(781, 70);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 39);
			this.button3.TabIndex = 16;
			this.button3.Text = "Search";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// tbLost
			// 
			this.tbLost.Location = new System.Drawing.Point(419, 373);
			this.tbLost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbLost.Multiline = true;
			this.tbLost.Name = "tbLost";
			this.tbLost.Size = new System.Drawing.Size(356, 38);
			this.tbLost.TabIndex = 17;
			this.toolTip1.SetToolTip(this.tbLost, "RFID has been lost");
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(276, 396);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Lost RFID";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.ForeColor = System.Drawing.Color.Black;
			this.linkLabel1.Location = new System.Drawing.Point(1064, 17);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(47, 20);
			this.linkLabel1.TabIndex = 19;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Back";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// LostRFID
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbLost);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbDOB);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.tbMail);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LostRFID";
			this.Size = new System.Drawing.Size(1160, 606);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbLost;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}
