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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAllShops = new System.Windows.Forms.Button();
            this.tbShopNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.tbEmployeeNo = new System.Windows.Forms.TextBox();
            this.btnShowProfit = new System.Windows.Forms.Button();
            this.btnProfitEachShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(262, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(593, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnAllShops
            // 
            this.btnAllShops.Location = new System.Drawing.Point(262, 349);
            this.btnAllShops.Name = "btnAllShops";
            this.btnAllShops.Size = new System.Drawing.Size(141, 35);
            this.btnAllShops.TabIndex = 1;
            this.btnAllShops.Text = "Check all shops";
            this.btnAllShops.UseVisualStyleBackColor = true;
            // 
            // tbShopNo
            // 
            this.tbShopNo.Location = new System.Drawing.Point(130, 80);
            this.tbShopNo.Name = "tbShopNo";
            this.tbShopNo.Size = new System.Drawing.Size(100, 20);
            this.tbShopNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee number";
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(71, 173);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(106, 30);
            this.btnShowResult.TabIndex = 6;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            // 
            // tbEmployeeNo
            // 
            this.tbEmployeeNo.Location = new System.Drawing.Point(130, 120);
            this.tbEmployeeNo.Name = "tbEmployeeNo";
            this.tbEmployeeNo.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeNo.TabIndex = 2;
            // 
            // btnShowProfit
            // 
            this.btnShowProfit.Location = new System.Drawing.Point(71, 226);
            this.btnShowProfit.Name = "btnShowProfit";
            this.btnShowProfit.Size = new System.Drawing.Size(106, 30);
            this.btnShowProfit.TabIndex = 6;
            this.btnShowProfit.Text = "Show Profit";
            this.btnShowProfit.UseVisualStyleBackColor = true;
            // 
            // btnProfitEachShop
            // 
            this.btnProfitEachShop.Location = new System.Drawing.Point(71, 282);
            this.btnProfitEachShop.Name = "btnProfitEachShop";
            this.btnProfitEachShop.Size = new System.Drawing.Size(106, 48);
            this.btnProfitEachShop.TabIndex = 6;
            this.btnProfitEachShop.Text = "Show profit each shop";
            this.btnProfitEachShop.UseVisualStyleBackColor = true;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProfitEachShop);
            this.Controls.Add(this.btnShowProfit);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmployeeNo);
            this.Controls.Add(this.tbShopNo);
            this.Controls.Add(this.btnAllShops);
            this.Controls.Add(this.listBox1);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(870, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAllShops;
        private System.Windows.Forms.TextBox tbShopNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TextBox tbEmployeeNo;
        private System.Windows.Forms.Button btnShowProfit;
        private System.Windows.Forms.Button btnProfitEachShop;
    }
}
