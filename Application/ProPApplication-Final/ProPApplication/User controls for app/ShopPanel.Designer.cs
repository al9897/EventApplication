namespace ProPApplication
{
    partial class ShopPanel
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
			this.lbShow = new System.Windows.Forms.ListBox();
			this.btnAllShops = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnShowAllEmployee = new System.Windows.Forms.Button();
			this.btnShowEmployee = new System.Windows.Forms.Button();
			this.btnMostProfitShop = new System.Windows.Forms.Button();
			this.cbShopNo = new System.Windows.Forms.ComboBox();
			this.cbEmployee = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lbShow
			// 
			this.lbShow.FormattingEnabled = true;
			this.lbShow.ItemHeight = 16;
			this.lbShow.Location = new System.Drawing.Point(349, 17);
			this.lbShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lbShow.Name = "lbShow";
			this.lbShow.ScrollAlwaysVisible = true;
			this.lbShow.Size = new System.Drawing.Size(789, 388);
			this.lbShow.TabIndex = 0;
			// 
			// btnAllShops
			// 
			this.btnAllShops.BackColor = System.Drawing.Color.IndianRed;
			this.btnAllShops.ForeColor = System.Drawing.Color.Black;
			this.btnAllShops.Location = new System.Drawing.Point(349, 431);
			this.btnAllShops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAllShops.Name = "btnAllShops";
			this.btnAllShops.Size = new System.Drawing.Size(188, 43);
			this.btnAllShops.TabIndex = 1;
			this.btnAllShops.Text = "Check all shops";
			this.btnAllShops.UseVisualStyleBackColor = false;
			this.btnAllShops.Click += new System.EventHandler(this.btnAllShops_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.IndianRed;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(36, 107);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Shop number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(36, 156);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Employee number";
			// 
			// btnShowAllEmployee
			// 
			this.btnShowAllEmployee.BackColor = System.Drawing.Color.IndianRed;
			this.btnShowAllEmployee.ForeColor = System.Drawing.Color.Black;
			this.btnShowAllEmployee.Location = new System.Drawing.Point(95, 213);
			this.btnShowAllEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowAllEmployee.Name = "btnShowAllEmployee";
			this.btnShowAllEmployee.Size = new System.Drawing.Size(141, 37);
			this.btnShowAllEmployee.TabIndex = 6;
			this.btnShowAllEmployee.Text = "Show All Employee";
			this.btnShowAllEmployee.UseVisualStyleBackColor = false;
			this.btnShowAllEmployee.Click += new System.EventHandler(this.btnShowAllEmployee_Click);
			// 
			// btnShowEmployee
			// 
			this.btnShowEmployee.BackColor = System.Drawing.Color.IndianRed;
			this.btnShowEmployee.ForeColor = System.Drawing.Color.Black;
			this.btnShowEmployee.Location = new System.Drawing.Point(95, 278);
			this.btnShowEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowEmployee.Name = "btnShowEmployee";
			this.btnShowEmployee.Size = new System.Drawing.Size(141, 37);
			this.btnShowEmployee.TabIndex = 6;
			this.btnShowEmployee.Text = "Show Employee";
			this.btnShowEmployee.UseVisualStyleBackColor = false;
			this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
			// 
			// btnMostProfitShop
			// 
			this.btnMostProfitShop.BackColor = System.Drawing.Color.IndianRed;
			this.btnMostProfitShop.ForeColor = System.Drawing.Color.Black;
			this.btnMostProfitShop.Location = new System.Drawing.Point(95, 347);
			this.btnMostProfitShop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnMostProfitShop.Name = "btnMostProfitShop";
			this.btnMostProfitShop.Size = new System.Drawing.Size(141, 59);
			this.btnMostProfitShop.TabIndex = 6;
			this.btnMostProfitShop.Text = "Most successful shop";
			this.btnMostProfitShop.UseVisualStyleBackColor = false;
			this.btnMostProfitShop.Click += new System.EventHandler(this.btnMostProfitShop_Click);
			// 
			// cbShopNo
			// 
			this.cbShopNo.FormattingEnabled = true;
			this.cbShopNo.Location = new System.Drawing.Point(173, 103);
			this.cbShopNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbShopNo.Name = "cbShopNo";
			this.cbShopNo.Size = new System.Drawing.Size(160, 24);
			this.cbShopNo.TabIndex = 7;
			// 
			// cbEmployee
			// 
			this.cbEmployee.FormattingEnabled = true;
			this.cbEmployee.Location = new System.Drawing.Point(173, 146);
			this.cbEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbEmployee.Name = "cbEmployee";
			this.cbEmployee.Size = new System.Drawing.Size(160, 24);
			this.cbEmployee.TabIndex = 7;
			// 
			// ShopPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.cbEmployee);
			this.Controls.Add(this.cbShopNo);
			this.Controls.Add(this.btnMostProfitShop);
			this.Controls.Add(this.btnShowEmployee);
			this.Controls.Add(this.btnShowAllEmployee);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAllShops);
			this.Controls.Add(this.lbShow);
			this.ForeColor = System.Drawing.Color.Black;
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "ShopPanel";
			this.Size = new System.Drawing.Size(1157, 603);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.Button btnAllShops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAllEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnMostProfitShop;
        private System.Windows.Forms.ComboBox cbShopNo;
        private System.Windows.Forms.ComboBox cbEmployee;
    }
}
