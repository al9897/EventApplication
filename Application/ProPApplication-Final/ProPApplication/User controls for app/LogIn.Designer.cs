namespace ProPApplication
{
    partial class LogIn
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
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bttLogin = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// tbLogin
			// 
			this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLogin.Location = new System.Drawing.Point(255, 27);
			this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(703, 36);
			this.tbLogin.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.Location = new System.Drawing.Point(255, 96);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(703, 36);
			this.tbPassword.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.IndianRed;
			this.label1.Location = new System.Drawing.Point(64, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.IndianRed;
			this.label2.Location = new System.Drawing.Point(64, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// bttLogin
			// 
			this.bttLogin.BackColor = System.Drawing.Color.IndianRed;
			this.bttLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttLogin.Location = new System.Drawing.Point(474, 136);
			this.bttLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bttLogin.Name = "bttLogin";
			this.bttLogin.Size = new System.Drawing.Size(265, 71);
			this.bttLogin.TabIndex = 5;
			this.bttLogin.Text = "Log In By Account";
			this.toolTip1.SetToolTip(this.bttLogin, "Enter username and password in case RFID card is not working");
			this.bttLogin.UseVisualStyleBackColor = false;
			this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bttLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LogIn";
			this.Size = new System.Drawing.Size(1035, 284);
			this.Load += new System.EventHandler(this.LogIn_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.ToolTip toolTip1;
	}
}
