namespace ProPApplication
{
    partial class Form1

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbxAdmin = new System.Windows.Forms.PictureBox();
			this.panelShowInfo = new System.Windows.Forms.Panel();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.profile1 = new ProPApplication.User_controls_for_app.Profile();
			this.logIn1 = new ProPApplication.LogIn();
			this.employee = new ProPApplication.employee();
			this.rent = new ProPApplication.Rent();
			this.shopPanel1 = new ProPApplication.ShopPanel();
			this.food = new ProPApplication.Food();
			this.drink = new ProPApplication.Drink();
			this.adminPanel = new ProPApplication.adminPanel();
			this.borrowDevice = new ProPApplication.BorrowDevice();
			this.addParticipant = new ProPApplication.AddParticipant();
			this.shop = new ProPApplication.ShopPanel();
			this.panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).BeginInit();
			this.panelShowInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Controls.Add(this.pictureBox8);
			this.panelMenu.Controls.Add(this.pictureBox7);
			this.panelMenu.Controls.Add(this.pictureBox6);
			this.panelMenu.Controls.Add(this.pictureBox5);
			this.panelMenu.Controls.Add(this.pictureBox4);
			this.panelMenu.Controls.Add(this.pictureBox3);
			this.panelMenu.Controls.Add(this.pictureBox2);
			this.panelMenu.Controls.Add(this.pbxAdmin);
			resources.ApplyResources(this.panelMenu, "panelMenu");
			this.panelMenu.Name = "panelMenu";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProPApplication.Properties.Resources.download1;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::ProPApplication.Properties.Resources.shop_icon;
			resources.ApplyResources(this.pictureBox8, "pictureBox8");
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox8, resources.GetString("pictureBox8.ToolTip"));
			this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::ProPApplication.Properties.Resources.user;
			resources.ApplyResources(this.pictureBox7, "pictureBox7");
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox7, resources.GetString("pictureBox7.ToolTip"));
			this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::ProPApplication.Properties.Resources.team;
			resources.ApplyResources(this.pictureBox6, "pictureBox6");
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox6, resources.GetString("pictureBox6.ToolTip"));
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::ProPApplication.Properties.Resources.coffee;
			resources.ApplyResources(this.pictureBox5, "pictureBox5");
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox5, resources.GetString("pictureBox5.ToolTip"));
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::ProPApplication.Properties.Resources.burger;
			resources.ApplyResources(this.pictureBox4, "pictureBox4");
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ProPApplication.Properties.Resources.rent;
			resources.ApplyResources(this.pictureBox3, "pictureBox3");
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip"));
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ProPApplication.Properties.Resources.devices;
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pbxAdmin
			// 
			this.pbxAdmin.Image = global::ProPApplication.Properties.Resources.analytics1;
			resources.ApplyResources(this.pbxAdmin, "pbxAdmin");
			this.pbxAdmin.Name = "pbxAdmin";
			this.pbxAdmin.TabStop = false;
			this.toolTip1.SetToolTip(this.pbxAdmin, resources.GetString("pbxAdmin.ToolTip"));
			this.pbxAdmin.Click += new System.EventHandler(this.pbxAdmin_Click);
			// 
			// panelShowInfo
			// 
			this.panelShowInfo.BackColor = System.Drawing.Color.DarkOrange;
			this.panelShowInfo.Controls.Add(this.lbWelcome);
			this.panelShowInfo.Controls.Add(this.button1);
			resources.ApplyResources(this.panelShowInfo, "panelShowInfo");
			this.panelShowInfo.Name = "panelShowInfo";
			// 
			// lbWelcome
			// 
			resources.ApplyResources(this.lbWelcome, "lbWelcome");
			this.lbWelcome.ForeColor = System.Drawing.Color.White;
			this.lbWelcome.Name = "lbWelcome";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// profile1
			// 
			this.profile1.BackColor = System.Drawing.Color.IndianRed;
			this.profile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.profile1, "profile1");
			this.profile1.Mainform = null;
			this.profile1.Name = "profile1";
			// 
			// logIn1
			// 
			resources.ApplyResources(this.logIn1, "logIn1");
			this.logIn1.Name = "logIn1";
			this.logIn1.VisibleChanged += new System.EventHandler(this.logIn1_VisibleChanged);
			// 
			// employee
			// 
			this.employee.BackColor = System.Drawing.Color.IndianRed;
			this.employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.employee, "employee");
			this.employee.Name = "employee";
			// 
			// rent
			// 
			this.rent.BackColor = System.Drawing.Color.IndianRed;
			this.rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rent.ForeColor = System.Drawing.Color.Maroon;
			resources.ApplyResources(this.rent, "rent");
			this.rent.Name = "rent";
			// 
			// shopPanel1
			// 
			this.shopPanel1.BackColor = System.Drawing.Color.IndianRed;
			this.shopPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.shopPanel1.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.shopPanel1, "shopPanel1");
			this.shopPanel1.Name = "shopPanel1";
			// 
			// food
			// 
			this.food.BackColor = System.Drawing.Color.IndianRed;
			resources.ApplyResources(this.food, "food");
			this.food.Name = "food";
			// 
			// drink
			// 
			this.drink.BackColor = System.Drawing.Color.IndianRed;
			this.drink.ForeColor = System.Drawing.Color.Maroon;
			resources.ApplyResources(this.drink, "drink");
			this.drink.Name = "drink";
			// 
			// adminPanel
			// 
			this.adminPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.adminPanel.ForeColor = System.Drawing.Color.Maroon;
			resources.ApplyResources(this.adminPanel, "adminPanel");
			this.adminPanel.Name = "adminPanel";
			// 
			// borrowDevice
			// 
			this.borrowDevice.BackColor = System.Drawing.Color.IndianRed;
			resources.ApplyResources(this.borrowDevice, "borrowDevice");
			this.borrowDevice.Name = "borrowDevice";
			// 
			// addParticipant
			// 
			this.addParticipant.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.addParticipant, "addParticipant");
			this.addParticipant.Name = "addParticipant";
			// 
			// shop
			// 
			this.shop.BackColor = System.Drawing.Color.IndianRed;
			this.shop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.shop.ForeColor = System.Drawing.Color.Black;
			resources.ApplyResources(this.shop, "shop");
			this.shop.Name = "shop";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.profile1);
			this.Controls.Add(this.logIn1);
			this.Controls.Add(this.employee);
			this.Controls.Add(this.rent);
			this.Controls.Add(this.shopPanel1);
			this.Controls.Add(this.food);
			this.Controls.Add(this.drink);
			this.Controls.Add(this.adminPanel);
			this.Controls.Add(this.panelShowInfo);
			this.Controls.Add(this.borrowDevice);
			this.Controls.Add(this.panelMenu);
			this.Controls.Add(this.addParticipant);
			this.ForeColor = System.Drawing.Color.Transparent;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.TransparencyKey = System.Drawing.Color.Silver;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxAdmin)).EndInit();
			this.panelShowInfo.ResumeLayout(false);
			this.panelShowInfo.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelShowInfo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbxAdmin;
        private BorrowDevice borrowDevice;
        private AddParticipant addParticipant;
        private Drink drink;
        private Food food;
        private adminPanel adminPanel;
        private employee employee;
        private Rent rent;
        private LogIn logIn1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private ShopPanel shop;
        private ShopPanel shopPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button1;
		private User_controls_for_app.Profile profile1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbWelcome;
	}
}

