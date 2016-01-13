namespace POS_System
{
    partial class UserControl_purchase_form
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
            this.txtremainingamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpexpirydate = new System.Windows.Forms.DateTimePicker();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btncalculateamount = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calexpirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpaidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calremainingamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.cboproductname = new System.Windows.Forms.ComboBox();
            this.txtquanitity = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtinvoicedate = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtremainingamount
            // 
            this.txtremainingamount.Location = new System.Drawing.Point(163, 209);
            this.txtremainingamount.Name = "txtremainingamount";
            this.txtremainingamount.Size = new System.Drawing.Size(161, 20);
            this.txtremainingamount.TabIndex = 69;
            this.txtremainingamount.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 88;
            this.label12.Text = "Remaining Amount";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(671, 183);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(180, 20);
            this.txtpaidamount.TabIndex = 67;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(542, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 87;
            this.label11.Text = "Paid Amount";
            // 
            // dtpexpirydate
            // 
            this.dtpexpirydate.Location = new System.Drawing.Point(163, 174);
            this.dtpexpirydate.Name = "dtpexpirydate";
            this.dtpexpirydate.Size = new System.Drawing.Size(161, 20);
            this.dtpexpirydate.TabIndex = 66;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btncalculateamount
            // 
            this.btncalculateamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculateamount.Location = new System.Drawing.Point(671, 209);
            this.btncalculateamount.Name = "btncalculateamount";
            this.btncalculateamount.Size = new System.Drawing.Size(180, 28);
            this.btncalculateamount.TabIndex = 68;
            this.btncalculateamount.Text = "Calculate Amount";
            this.btncalculateamount.UseVisualStyleBackColor = true;
            this.btncalculateamount.Click += new System.EventHandler(this.btncalculateamount_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Expiry Date";
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(410, 259);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(86, 32);
            this.btnremove.TabIndex = 71;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "total";
            this.caltotal.Name = "caltotal";
            // 
            // calquantity
            // 
            this.calquantity.HeaderText = "quantity";
            this.calquantity.Name = "calquantity";
            // 
            // calprice
            // 
            this.calprice.HeaderText = "price";
            this.calprice.Name = "calprice";
            // 
            // calproductname
            // 
            this.calproductname.HeaderText = "product name";
            this.calproductname.Name = "calproductname";
            // 
            // calcategoryname
            // 
            this.calcategoryname.HeaderText = "category name";
            this.calcategoryname.Name = "calcategoryname";
            // 
            // calproductid
            // 
            this.calproductid.HeaderText = "procudtid";
            this.calproductid.Name = "calproductid";
            this.calproductid.Visible = false;
            // 
            // caldiscount
            // 
            this.caldiscount.HeaderText = "discount";
            this.caldiscount.Name = "caldiscount";
            // 
            // calcategoryid
            // 
            this.calcategoryid.HeaderText = "categoryid";
            this.calcategoryid.Name = "calcategoryid";
            this.calcategoryid.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(49, 478);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(81, 27);
            this.btnsave.TabIndex = 72;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(43, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 31);
            this.label8.TabIndex = 85;
            this.label8.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.BackColor = System.Drawing.Color.Black;
            this.txtgrandtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgrandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrandtotal.ForeColor = System.Drawing.Color.Lime;
            this.txtgrandtotal.Location = new System.Drawing.Point(223, 11);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(97, 31);
            this.txtgrandtotal.TabIndex = 84;
            this.txtgrandtotal.Text = "0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(48, 261);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 17);
            this.Total.TabIndex = 83;
            this.Total.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(131, 261);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(142, 20);
            this.txttotal.TabIndex = 82;
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
            this.dataGridView1.Location = new System.Drawing.Point(48, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 158);
            this.dataGridView1.TabIndex = 81;
            // 
            // calcategory
            // 
            this.calcategory.HeaderText = "Category";
            this.calcategory.Name = "calcategory";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Discount";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(300, 259);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 32);
            this.btnadd.TabIndex = 70;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(671, 95);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(180, 21);
            this.cbocategory.TabIndex = 61;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // cboproductname
            // 
            this.cboproductname.FormattingEnabled = true;
            this.cboproductname.Location = new System.Drawing.Point(163, 120);
            this.cboproductname.Name = "cboproductname";
            this.cboproductname.Size = new System.Drawing.Size(161, 21);
            this.cboproductname.TabIndex = 62;
            this.cboproductname.SelectedIndexChanged += new System.EventHandler(this.cboproductname_SelectedIndexChanged);
            // 
            // txtquanitity
            // 
            this.txtquanitity.Location = new System.Drawing.Point(163, 147);
            this.txtquanitity.Name = "txtquanitity";
            this.txtquanitity.Size = new System.Drawing.Size(161, 20);
            this.txtquanitity.TabIndex = 64;
            this.txtquanitity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquanitity_KeyDown);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(671, 153);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(180, 20);
            this.txtdiscount.TabIndex = 65;
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(671, 122);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(180, 20);
            this.txtprice.TabIndex = 63;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.Location = new System.Drawing.Point(163, 95);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(161, 20);
            this.txtinvoicedate.TabIndex = 60;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(671, 67);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(180, 20);
            this.txtcustomername.TabIndex = 59;
            this.txtcustomername.TextChanged += new System.EventHandler(this.txtcustomername_TextChanged);
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(163, 66);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(161, 20);
            this.txtinvoiceno.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Invoice No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Catagory";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(159, 296);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(17, 20);
            this.lblmsg.TabIndex = 89;
            this.lblmsg.Text = "..";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtgrandtotal);
            this.panel1.Location = new System.Drawing.Point(547, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 58);
            this.panel1.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(331, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 91;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(853, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 92;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(852, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 93;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(853, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 17);
            this.label16.TabIndex = 94;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(851, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 95;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(851, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 96;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(326, 210);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 17);
            this.label19.TabIndex = 97;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 98;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(325, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 99;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(326, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 100;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(353, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(140, 24);
            this.label23.TabIndex = 133;
            this.label23.Text = "Purchase Form";
            // 
            // UserControl_purchase_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtremainingamount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpexpirydate);
            this.Controls.Add(this.btncalculateamount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.cboproductname);
            this.Controls.Add(this.txtquanitity);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtinvoicedate);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "UserControl_purchase_form";
            this.Size = new System.Drawing.Size(975, 516);
            this.Load += new System.EventHandler(this.UserControl_purchase_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtremainingamount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpexpirydate;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btncalculateamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.ComboBox cboproductname;
        private System.Windows.Forms.TextBox txtquanitity;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtinvoicedate;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
    }
}
