namespace ProPApplication
{
    partial class Rent
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
			this.rbRfidNo = new System.Windows.Forms.RadioButton();
			this.rbAccountNo = new System.Windows.Forms.RadioButton();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lbxTentInfo = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRentNewTent = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbInvite = new System.Windows.Forms.TextBox();
			this.btnInvite = new System.Windows.Forms.Button();
			this.cbAllTent = new System.Windows.Forms.ComboBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(59, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search Participant";
			// 
			// rbRfidNo
			// 
			this.rbRfidNo.AutoSize = true;
			this.rbRfidNo.ForeColor = System.Drawing.Color.Black;
			this.rbRfidNo.Location = new System.Drawing.Point(41, 82);
			this.rbRfidNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbRfidNo.Name = "rbRfidNo";
			this.rbRfidNo.Size = new System.Drawing.Size(64, 21);
			this.rbRfidNo.TabIndex = 1;
			this.rbRfidNo.TabStop = true;
			this.rbRfidNo.Text = "RFID ";
			this.toolTip1.SetToolTip(this.rbRfidNo, "Search by RFID");
			this.rbRfidNo.UseVisualStyleBackColor = true;
			// 
			// rbAccountNo
			// 
			this.rbAccountNo.AutoSize = true;
			this.rbAccountNo.ForeColor = System.Drawing.Color.Black;
			this.rbAccountNo.Location = new System.Drawing.Point(175, 82);
			this.rbAccountNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbAccountNo.Name = "rbAccountNo";
			this.rbAccountNo.Size = new System.Drawing.Size(134, 21);
			this.rbAccountNo.TabIndex = 2;
			this.rbAccountNo.TabStop = true;
			this.rbAccountNo.Text = "Account Number";
			this.toolTip1.SetToolTip(this.rbAccountNo, "Search by account number");
			this.rbAccountNo.UseVisualStyleBackColor = true;
			// 
			// tbSearch
			// 
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.Location = new System.Drawing.Point(148, 129);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(263, 36);
			this.tbSearch.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(24, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Input";
			this.toolTip1.SetToolTip(this.label2, "Enter account number when account number box above is checked");
			// 
			// btnSearch
			// 
			this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
			this.btnSearch.Location = new System.Drawing.Point(65, 194);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 39);
			this.btnSearch.TabIndex = 5;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lbxTentInfo
			// 
			this.lbxTentInfo.FormattingEnabled = true;
			this.lbxTentInfo.HorizontalScrollbar = true;
			this.lbxTentInfo.ItemHeight = 16;
			this.lbxTentInfo.Location = new System.Drawing.Point(417, 23);
			this.lbxTentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lbxTentInfo.Name = "lbxTentInfo";
			this.lbxTentInfo.Size = new System.Drawing.Size(739, 548);
			this.lbxTentInfo.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(23, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "New";
			this.toolTip1.SetToolTip(this.label3, "Rent availble tent");
			// 
			// btnRentNewTent
			// 
			this.btnRentNewTent.ForeColor = System.Drawing.Color.Maroon;
			this.btnRentNewTent.Location = new System.Drawing.Point(65, 439);
			this.btnRentNewTent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRentNewTent.Name = "btnRentNewTent";
			this.btnRentNewTent.Size = new System.Drawing.Size(175, 39);
			this.btnRentNewTent.TabIndex = 6;
			this.btnRentNewTent.Text = "New";
			this.btnRentNewTent.UseVisualStyleBackColor = true;
			this.btnRentNewTent.Click += new System.EventHandler(this.btnRentNewTent_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(25, 326);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 17);
			this.label7.TabIndex = 8;
			this.label7.Text = "Available Spots";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(25, 367);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Invite people";
			// 
			// tbInvite
			// 
			this.tbInvite.Location = new System.Drawing.Point(148, 367);
			this.tbInvite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbInvite.Multiline = true;
			this.tbInvite.Name = "tbInvite";
			this.tbInvite.Size = new System.Drawing.Size(212, 35);
			this.tbInvite.TabIndex = 10;
			// 
			// btnInvite
			// 
			this.btnInvite.ForeColor = System.Drawing.Color.Maroon;
			this.btnInvite.Location = new System.Drawing.Point(65, 497);
			this.btnInvite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnInvite.Name = "btnInvite";
			this.btnInvite.Size = new System.Drawing.Size(175, 39);
			this.btnInvite.TabIndex = 11;
			this.btnInvite.Text = "Invite People";
			this.btnInvite.UseVisualStyleBackColor = true;
			this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
			// 
			// cbAllTent
			// 
			this.cbAllTent.FormattingEnabled = true;
			this.cbAllTent.Location = new System.Drawing.Point(148, 322);
			this.cbAllTent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbAllTent.Name = "cbAllTent";
			this.cbAllTent.Size = new System.Drawing.Size(212, 24);
			this.cbAllTent.TabIndex = 13;
			// 
			// Rent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.cbAllTent);
			this.Controls.Add(this.btnInvite);
			this.Controls.Add(this.tbInvite);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnRentNewTent);
			this.Controls.Add(this.rbRfidNo);
			this.Controls.Add(this.rbAccountNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbxTentInfo);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.label3);
			this.ForeColor = System.Drawing.Color.Maroon;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Rent";
			this.Size = new System.Drawing.Size(1158, 604);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRfidNo;
        private System.Windows.Forms.RadioButton rbAccountNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lbxTentInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRentNewTent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInvite;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.ComboBox cbAllTent;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
