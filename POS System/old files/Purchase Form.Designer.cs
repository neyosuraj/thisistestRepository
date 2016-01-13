namespace POS_System
{
    partial class Purchase_Form
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
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calexpirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpaidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calremainingamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.cboproductname = new System.Windows.Forms.ComboBox();
            this.txtquanitity = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtinvoicedate = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpexpirydate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtremainingamount = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btncalculateamount = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(375, 254);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 14;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(31, 487);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(468, 490);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(142, 20);
            this.txtgrandtotal.TabIndex = 46;
            this.txtgrandtotal.Text = "0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(16, 254);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 17);
            this.Total.TabIndex = 45;
            this.Total.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(99, 254);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(142, 20);
            this.txttotal.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calcategory,
            this.calcategoryid,
            this.calproductid,
            this.calcategoryname,
            this.calproductname,
            this.calprice,
            this.calquantity,
            this.caldiscount,
            this.caltotal,
            this.calexpirydate,
            this.calpaidamount,
            this.calremainingamount});
            this.dataGridView1.Location = new System.Drawing.Point(16, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(839, 158);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calcategory
            // 
            this.calcategory.HeaderText = "Category";
            this.calcategory.Name = "calcategory";
            // 
            // calcategoryid
            // 
            this.calcategoryid.HeaderText = "categoryid";
            this.calcategoryid.Name = "calcategoryid";
            this.calcategoryid.Visible = false;
            // 
            // calproductid
            // 
            this.calproductid.HeaderText = "procudtid";
            this.calproductid.Name = "calproductid";
            this.calproductid.Visible = false;
            // 
            // calcategoryname
            // 
            this.calcategoryname.HeaderText = "category name";
            this.calcategoryname.Name = "calcategoryname";
            // 
            // calproductname
            // 
            this.calproductname.HeaderText = "product name";
            this.calproductname.Name = "calproductname";
            // 
            // calprice
            // 
            this.calprice.HeaderText = "price";
            this.calprice.Name = "calprice";
            // 
            // calquantity
            // 
            this.calquantity.HeaderText = "quantity";
            this.calquantity.Name = "calquantity";
            // 
            // caldiscount
            // 
            this.caldiscount.HeaderText = "discount";
            this.caldiscount.Name = "caldiscount";
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "total";
            this.caltotal.Name = "caltotal";
            // 
            // calexpirydate
            // 
            this.calexpirydate.HeaderText = "Expiry Date";
            this.calexpirydate.Name = "calexpirydate";
            // 
            // calpaidamount
            // 
            this.calpaidamount.HeaderText = "Paid Amount";
            this.calpaidamount.Name = "calpaidamount";
            // 
            // calremainingamount
            // 
            this.calremainingamount.HeaderText = "Remaining Amount";
            this.calremainingamount.Name = "calremainingamount";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(275, 254);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(639, 81);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(200, 21);
            this.cbocategory.TabIndex = 4;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // cboproductname
            // 
            this.cboproductname.FormattingEnabled = true;
            this.cboproductname.Location = new System.Drawing.Point(131, 106);
            this.cboproductname.Name = "cboproductname";
            this.cboproductname.Size = new System.Drawing.Size(161, 21);
            this.cboproductname.TabIndex = 5;
            this.cboproductname.SelectedIndexChanged += new System.EventHandler(this.cboproductname_SelectedIndexChanged);
            // 
            // txtquanitity
            // 
            this.txtquanitity.Location = new System.Drawing.Point(131, 133);
            this.txtquanitity.Name = "txtquanitity";
            this.txtquanitity.Size = new System.Drawing.Size(161, 20);
            this.txtquanitity.TabIndex = 7;
            this.txtquanitity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquanitity_KeyDown);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(639, 139);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(200, 20);
            this.txtdiscount.TabIndex = 8;
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(639, 108);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(200, 20);
            this.txtprice.TabIndex = 6;
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.Location = new System.Drawing.Point(131, 81);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(161, 20);
            this.txtinvoicedate.TabIndex = 3;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(639, 53);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(200, 20);
            this.txtcustomername.TabIndex = 2;
            this.txtcustomername.TextChanged += new System.EventHandler(this.txtcustomername_TextChanged);
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(131, 52);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(161, 20);
            this.txtinvoiceno.TabIndex = 1;
            this.txtinvoiceno.TextChanged += new System.EventHandler(this.txtinvoiceno_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Invoice No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Expiry Date";
            // 
            // dtpexpirydate
            // 
            this.dtpexpirydate.Location = new System.Drawing.Point(131, 160);
            this.dtpexpirydate.Name = "dtpexpirydate";
            this.dtpexpirydate.Size = new System.Drawing.Size(161, 20);
            this.dtpexpirydate.TabIndex = 9;
            this.dtpexpirydate.ValueChanged += new System.EventHandler(this.dtpexpirydate_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(534, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Paid Amount";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(639, 169);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(200, 20);
            this.txtpaidamount.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Remaining Amount";
            // 
            // txtremainingamount
            // 
            this.txtremainingamount.Location = new System.Drawing.Point(131, 195);
            this.txtremainingamount.Name = "txtremainingamount";
            this.txtremainingamount.Size = new System.Drawing.Size(161, 20);
            this.txtremainingamount.TabIndex = 12;
            this.txtremainingamount.Text = "0.0";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btncalculateamount
            // 
            this.btncalculateamount.Location = new System.Drawing.Point(639, 195);
            this.btncalculateamount.Name = "btncalculateamount";
            this.btncalculateamount.Size = new System.Drawing.Size(132, 23);
            this.btncalculateamount.TabIndex = 11;
            this.btncalculateamount.Text = "Calculate Amount";
            this.btncalculateamount.UseVisualStyleBackColor = true;
            this.btncalculateamount.Click += new System.EventHandler(this.btncalculateamount_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.damageProductToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.viewPurchaseToolStripMenuItem,
            this.orderItemToolStripMenuItem,
            this.orderlistsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.softwareInfoToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.productToolStripMenuItem.Text = "File";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.softwareInfoToolStripMenuItem.Text = "Software Info";
            // 
            // damageProductToolStripMenuItem
            // 
            this.damageProductToolStripMenuItem.Name = "damageProductToolStripMenuItem";
            this.damageProductToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.damageProductToolStripMenuItem.Text = "Damage Product";
            this.damageProductToolStripMenuItem.Click += new System.EventHandler(this.damageProductToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem1,
            this.categoryToolStripMenuItem});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.addProductToolStripMenuItem.Text = "Add ";
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.productToolStripMenuItem1.Text = "Product";
            this.productToolStripMenuItem1.Click += new System.EventHandler(this.productToolStripMenuItem1_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // viewPurchaseToolStripMenuItem
            // 
            this.viewPurchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.viewPurchaseToolStripMenuItem.Name = "viewPurchaseToolStripMenuItem";
            this.viewPurchaseToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewPurchaseToolStripMenuItem.Text = "View ";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // orderItemToolStripMenuItem
            // 
            this.orderItemToolStripMenuItem.Name = "orderItemToolStripMenuItem";
            this.orderItemToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.orderItemToolStripMenuItem.Text = "order item";
            this.orderItemToolStripMenuItem.Click += new System.EventHandler(this.orderItemToolStripMenuItem_Click);
            // 
            // orderlistsToolStripMenuItem
            // 
            this.orderlistsToolStripMenuItem.Name = "orderlistsToolStripMenuItem";
            this.orderlistsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.orderlistsToolStripMenuItem.Text = "orderlists";
            this.orderlistsToolStripMenuItem.Click += new System.EventHandler(this.orderlistsToolStripMenuItem_Click);
            // 
            // Purchase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 522);
            this.Controls.Add(this.btncalculateamount);
            this.Controls.Add(this.txtremainingamount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpexpirydate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.cboproductname);
            this.Controls.Add(this.txtquanitity);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtinvoicedate);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purchase_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Purchase_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.ComboBox cboproductname;
        private System.Windows.Forms.TextBox txtquanitity;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtinvoicedate;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpexpirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn caldiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn calexpirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpaidamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calremainingamount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtremainingamount;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btncalculateamount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderlistsToolStripMenuItem;
    }
}