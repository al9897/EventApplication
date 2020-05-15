namespace ProPApplication
{
    partial class Drink
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.tbCheckRFID = new System.Windows.Forms.TextBox();
			this.btnCheckRFID = new System.Windows.Forms.Button();
			this.tbAddQuantity = new System.Windows.Forms.TextBox();
			this.lbOrder = new System.Windows.Forms.ListBox();
			this.tabControlDrink = new System.Windows.Forms.TabControl();
			this.tabPageSoftDrink = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabPageAlcohol = new System.Windows.Forms.TabPage();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.chartDrink = new System.Windows.Forms.TabPage();
			this.chartDrink1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tpAlcohol = new System.Windows.Forms.TabPage();
			this.cAlcohol = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbAddQuantity = new System.Windows.Forms.Label();
			this.cbShop = new System.Windows.Forms.ComboBox();
			this.myTimer = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tabControlDrink.SuspendLayout();
			this.tabPageSoftDrink.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPageAlcohol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.chartDrink.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartDrink1)).BeginInit();
			this.tpAlcohol.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cAlcohol)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.ForeColor = System.Drawing.Color.Maroon;
			this.btnCheckOut.Location = new System.Drawing.Point(863, 442);
			this.btnCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(231, 71);
			this.btnCheckOut.TabIndex = 21;
			this.btnCheckOut.Text = "Check Out";
			this.toolTip1.SetToolTip(this.btnCheckOut, "Print receipt");
			this.btnCheckOut.UseVisualStyleBackColor = true;
			this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
			// 
			// tbCheckRFID
			// 
			this.tbCheckRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCheckRFID.Location = new System.Drawing.Point(804, 32);
			this.tbCheckRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCheckRFID.Name = "tbCheckRFID";
			this.tbCheckRFID.Size = new System.Drawing.Size(157, 26);
			this.tbCheckRFID.TabIndex = 20;
			this.tbCheckRFID.Text = "Check RFID";
			// 
			// btnCheckRFID
			// 
			this.btnCheckRFID.ForeColor = System.Drawing.Color.Maroon;
			this.btnCheckRFID.Location = new System.Drawing.Point(967, 32);
			this.btnCheckRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCheckRFID.Name = "btnCheckRFID";
			this.btnCheckRFID.Size = new System.Drawing.Size(99, 26);
			this.btnCheckRFID.TabIndex = 19;
			this.btnCheckRFID.Text = "Enter RFID";
			this.toolTip1.SetToolTip(this.btnCheckRFID, "Customers can check out with their RFID Scan");
			this.btnCheckRFID.UseVisualStyleBackColor = true;
			this.btnCheckRFID.Click += new System.EventHandler(this.btnCheckRFID_Click);
			// 
			// tbAddQuantity
			// 
			this.tbAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAddQuantity.Location = new System.Drawing.Point(147, 26);
			this.tbAddQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbAddQuantity.Name = "tbAddQuantity";
			this.tbAddQuantity.Size = new System.Drawing.Size(445, 26);
			this.tbAddQuantity.TabIndex = 18;
			// 
			// lbOrder
			// 
			this.lbOrder.FormattingEnabled = true;
			this.lbOrder.ItemHeight = 16;
			this.lbOrder.Location = new System.Drawing.Point(804, 96);
			this.lbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lbOrder.Name = "lbOrder";
			this.lbOrder.Size = new System.Drawing.Size(341, 340);
			this.lbOrder.TabIndex = 16;
			this.lbOrder.SelectedIndexChanged += new System.EventHandler(this.lbOrder_SelectedIndexChanged);
			// 
			// tabControlDrink
			// 
			this.tabControlDrink.Controls.Add(this.tabPageSoftDrink);
			this.tabControlDrink.Controls.Add(this.tabPageAlcohol);
			this.tabControlDrink.Controls.Add(this.chartDrink);
			this.tabControlDrink.Controls.Add(this.tpAlcohol);
			this.tabControlDrink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlDrink.Location = new System.Drawing.Point(4, 19);
			this.tabControlDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControlDrink.Name = "tabControlDrink";
			this.tabControlDrink.SelectedIndex = 0;
			this.tabControlDrink.Size = new System.Drawing.Size(768, 455);
			this.tabControlDrink.TabIndex = 17;
			// 
			// tabPageSoftDrink
			// 
			this.tabPageSoftDrink.Controls.Add(this.label4);
			this.tabPageSoftDrink.Controls.Add(this.label5);
			this.tabPageSoftDrink.Controls.Add(this.label6);
			this.tabPageSoftDrink.Controls.Add(this.label3);
			this.tabPageSoftDrink.Controls.Add(this.label2);
			this.tabPageSoftDrink.Controls.Add(this.label1);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox6);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox5);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox4);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox3);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox2);
			this.tabPageSoftDrink.Controls.Add(this.pictureBox1);
			this.tabPageSoftDrink.Location = new System.Drawing.Point(4, 25);
			this.tabPageSoftDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageSoftDrink.Name = "tabPageSoftDrink";
			this.tabPageSoftDrink.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageSoftDrink.Size = new System.Drawing.Size(760, 426);
			this.tabPageSoftDrink.TabIndex = 0;
			this.tabPageSoftDrink.Text = "Soft Drink";
			this.tabPageSoftDrink.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(56, 393);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "?";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(337, 393);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "?";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(615, 393);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(615, 174);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(337, 174);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "?";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(56, 174);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "?";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::ProPApplication.Properties.Resources._7310070003096;
			this.pictureBox6.Location = new System.Drawing.Point(557, 225);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(157, 127);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox6, "pepsi green max : $1");
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::ProPApplication.Properties.Resources.coffee1;
			this.pictureBox5.Location = new System.Drawing.Point(283, 225);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(157, 127);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox5, "coffee : $3");
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::ProPApplication.Properties.Resources.can_pepsi;
			this.pictureBox4.Location = new System.Drawing.Point(5, 225);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(157, 127);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox4, "pepsi : $2");
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ProPApplication.Properties.Resources.FRISDRANK_COCA_COLA_REGULAR_BLIKJE_0_33L__c_897061;
			this.pictureBox3.Location = new System.Drawing.Point(557, 21);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(157, 127);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox3, "cola : $3");
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ProPApplication.Properties.Resources.pepsi_max_ginger;
			this.pictureBox2.Location = new System.Drawing.Point(283, 21);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(157, 127);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox2, "pepsi max : $4");
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProPApplication.Properties.Resources.frisdrank_coca_cola_zero_cherry_blikje_0_33l;
			this.pictureBox1.Location = new System.Drawing.Point(5, 21);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(157, 127);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox1, "cherry cola :$2");
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// tabPageAlcohol
			// 
			this.tabPageAlcohol.BackColor = System.Drawing.Color.White;
			this.tabPageAlcohol.Controls.Add(this.label12);
			this.tabPageAlcohol.Controls.Add(this.label9);
			this.tabPageAlcohol.Controls.Add(this.label11);
			this.tabPageAlcohol.Controls.Add(this.label10);
			this.tabPageAlcohol.Controls.Add(this.label8);
			this.tabPageAlcohol.Controls.Add(this.label7);
			this.tabPageAlcohol.Controls.Add(this.pictureBox12);
			this.tabPageAlcohol.Controls.Add(this.pictureBox11);
			this.tabPageAlcohol.Controls.Add(this.pictureBox10);
			this.tabPageAlcohol.Controls.Add(this.pictureBox9);
			this.tabPageAlcohol.Controls.Add(this.pictureBox8);
			this.tabPageAlcohol.Controls.Add(this.pictureBox7);
			this.tabPageAlcohol.Location = new System.Drawing.Point(4, 25);
			this.tabPageAlcohol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageAlcohol.Name = "tabPageAlcohol";
			this.tabPageAlcohol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageAlcohol.Size = new System.Drawing.Size(760, 426);
			this.tabPageAlcohol.TabIndex = 1;
			this.tabPageAlcohol.Text = "Acoholic Drink";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(615, 393);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(17, 17);
			this.label12.TabIndex = 6;
			this.label12.Text = "?";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(615, 174);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(17, 17);
			this.label9.TabIndex = 6;
			this.label9.Text = "?";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(337, 393);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 17);
			this.label11.TabIndex = 6;
			this.label11.Text = "?";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(56, 393);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(17, 17);
			this.label10.TabIndex = 6;
			this.label10.Text = "?";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(337, 174);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(17, 17);
			this.label8.TabIndex = 6;
			this.label8.Text = "?";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(56, 174);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 17);
			this.label7.TabIndex = 6;
			this.label7.Text = "?";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::ProPApplication.Properties.Resources.old_brigand_black_label_10_year_old_superior_rum_barbados_10730509;
			this.pictureBox12.Location = new System.Drawing.Point(557, 225);
			this.pictureBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(157, 127);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 5;
			this.pictureBox12.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox12, " black label vip : $8");
			this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = global::ProPApplication.Properties.Resources.absorg;
			this.pictureBox11.Location = new System.Drawing.Point(283, 225);
			this.pictureBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(157, 127);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox11.TabIndex = 4;
			this.pictureBox11.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox11, "vodka : $4");
			this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::ProPApplication.Properties.Resources.corona;
			this.pictureBox10.Location = new System.Drawing.Point(5, 225);
			this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(157, 127);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 3;
			this.pictureBox10.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox10, " corona beer: $5");
			this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::ProPApplication.Properties.Resources.jw_black_label_945x1058;
			this.pictureBox9.Location = new System.Drawing.Point(557, 21);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(157, 127);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 2;
			this.pictureBox9.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox9, "black label : $4");
			this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::ProPApplication.Properties.Resources.sierra_tequila_silver_1l_jumbo_slijterij;
			this.pictureBox8.Location = new System.Drawing.Point(283, 21);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(157, 127);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 1;
			this.pictureBox8.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox8, "tequila max :$5");
			this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::ProPApplication.Properties.Resources.We_Tasted_Trader_Joes_Distinqt_Tequila_to_Find_Out_If_Its_Worth_It_720x720_main_image_article_crop;
			this.pictureBox7.Location = new System.Drawing.Point(5, 21);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(157, 127);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 0;
			this.pictureBox7.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox7, "tequila : $5");
			this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
			// 
			// chartDrink
			// 
			this.chartDrink.Controls.Add(this.chartDrink1);
			this.chartDrink.Location = new System.Drawing.Point(4, 25);
			this.chartDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chartDrink.Name = "chartDrink";
			this.chartDrink.Size = new System.Drawing.Size(760, 426);
			this.chartDrink.TabIndex = 2;
			this.chartDrink.Text = "Soft Drink Chart";
			this.chartDrink.UseVisualStyleBackColor = true;
			// 
			// chartDrink1
			// 
			chartArea1.Name = "ChartArea1";
			this.chartDrink1.ChartAreas.Add(chartArea1);
			this.chartDrink1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chartDrink1.Legends.Add(legend1);
			this.chartDrink1.Location = new System.Drawing.Point(0, 0);
			this.chartDrink1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chartDrink1.Name = "chartDrink1";
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.LabelBackColor = System.Drawing.Color.White;
			series1.LabelBorderColor = System.Drawing.Color.White;
			series1.Legend = "Legend1";
			series1.Name = "SoftDrink";
			this.chartDrink1.Series.Add(series1);
			this.chartDrink1.Size = new System.Drawing.Size(760, 426);
			this.chartDrink1.TabIndex = 0;
			this.chartDrink1.Text = "drink";
			title1.Name = "Title1";
			title1.Text = "Soft Drink Chart";
			this.chartDrink1.Titles.Add(title1);
			// 
			// tpAlcohol
			// 
			this.tpAlcohol.Controls.Add(this.cAlcohol);
			this.tpAlcohol.Location = new System.Drawing.Point(4, 25);
			this.tpAlcohol.Margin = new System.Windows.Forms.Padding(4);
			this.tpAlcohol.Name = "tpAlcohol";
			this.tpAlcohol.Size = new System.Drawing.Size(760, 426);
			this.tpAlcohol.TabIndex = 3;
			this.tpAlcohol.Text = "Alcohol Chart";
			this.tpAlcohol.UseVisualStyleBackColor = true;
			// 
			// cAlcohol
			// 
			chartArea2.Name = "ChartArea1";
			this.cAlcohol.ChartAreas.Add(chartArea2);
			this.cAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.cAlcohol.Legends.Add(legend2);
			this.cAlcohol.Location = new System.Drawing.Point(0, 0);
			this.cAlcohol.Margin = new System.Windows.Forms.Padding(4);
			this.cAlcohol.Name = "cAlcohol";
			series2.ChartArea = "ChartArea1";
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "Alcohol";
			this.cAlcohol.Series.Add(series2);
			this.cAlcohol.Size = new System.Drawing.Size(760, 426);
			this.cAlcohol.TabIndex = 0;
			this.cAlcohol.Text = "chart1";
			title2.Name = "Title1";
			title2.Text = "Alcohol";
			this.cAlcohol.Titles.Add(title2);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tabControlDrink);
			this.groupBox1.Location = new System.Drawing.Point(3, 78);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(776, 478);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Drink";
			// 
			// lbAddQuantity
			// 
			this.lbAddQuantity.AutoSize = true;
			this.lbAddQuantity.Location = new System.Drawing.Point(7, 26);
			this.lbAddQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbAddQuantity.Name = "lbAddQuantity";
			this.lbAddQuantity.Size = new System.Drawing.Size(86, 17);
			this.lbAddQuantity.TabIndex = 22;
			this.lbAddQuantity.Text = "AddQuantity";
			this.toolTip1.SetToolTip(this.lbAddQuantity, "Enter the quanity and choose the shop, then click on the picture of the food you " +
        "want to add ");
			// 
			// cbShop
			// 
			this.cbShop.FormattingEnabled = true;
			this.cbShop.Location = new System.Drawing.Point(615, 26);
			this.cbShop.Margin = new System.Windows.Forms.Padding(4);
			this.cbShop.Name = "cbShop";
			this.cbShop.Size = new System.Drawing.Size(96, 24);
			this.cbShop.TabIndex = 9;
			this.cbShop.SelectedIndexChanged += new System.EventHandler(this.cbShop_SelectedIndexChanged);
			// 
			// myTimer
			// 
			this.myTimer.Interval = 10000;
			this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
			// 
			// Drink
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.Controls.Add(this.cbShop);
			this.Controls.Add(this.lbAddQuantity);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCheckOut);
			this.Controls.Add(this.tbCheckRFID);
			this.Controls.Add(this.btnCheckRFID);
			this.Controls.Add(this.tbAddQuantity);
			this.Controls.Add(this.lbOrder);
			this.ForeColor = System.Drawing.Color.Maroon;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Drink";
			this.Size = new System.Drawing.Size(1160, 606);
			this.Load += new System.EventHandler(this.Drink_Load);
			this.tabControlDrink.ResumeLayout(false);
			this.tabPageSoftDrink.ResumeLayout(false);
			this.tabPageSoftDrink.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPageAlcohol.ResumeLayout(false);
			this.tabPageAlcohol.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.chartDrink.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartDrink1)).EndInit();
			this.tpAlcohol.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cAlcohol)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox tbCheckRFID;
        private System.Windows.Forms.Button btnCheckRFID;
        private System.Windows.Forms.TextBox tbAddQuantity;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.TabControl tabControlDrink;
        private System.Windows.Forms.TabPage tabPageSoftDrink;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageAlcohol;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAddQuantity;
        private System.Windows.Forms.ComboBox cbShop;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.TabPage chartDrink;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDrink1;
        private System.Windows.Forms.TabPage tpAlcohol;
        private System.Windows.Forms.DataVisualization.Charting.Chart cAlcohol;
        private System.Windows.Forms.ToolTip toolTip1;
	}
}
