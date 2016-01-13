namespace POS_System
{
    partial class UserControl_sell_prodcuts
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
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtremaningamount = new System.Windows.Forms.TextBox();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calremaningamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremove = new System.Windows.Forms.Button();
            this.calcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.cboproductname = new System.Windows.Forms.ComboBox();
            this.txtquanitity = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.calcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpaidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtinvoicedate = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(606, 233);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 111;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtremaningamount
            // 
            this.txtremaningamount.Location = new System.Drawing.Point(604, 261);
            this.txtremaningamount.Name = "txtremaningamount";
            this.txtremaningamount.Size = new System.Drawing.Size(175, 20);
            this.txtremaningamount.TabIndex = 110;
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(604, 208);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(176, 20);
            this.txtpaidamount.TabIndex = 109;
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(141, 205);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(190, 20);
            this.txttax.TabIndex = 108;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(58, 499);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 30);
            this.btnsave.TabIndex = 107;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 106;
            this.label11.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(523, 499);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(142, 20);
            this.txtgrandtotal.TabIndex = 105;
            this.txtgrandtotal.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Remaning Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 103;
            this.label8.Text = "Paid Amount";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(55, 208);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(25, 13);
            this.Tax.TabIndex = 102;
            this.Tax.Text = "Tax";
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "total";
            this.caltotal.Name = "caltotal";
            // 
            // calremaningamount
            // 
            this.calremaningamount.HeaderText = "Remaning Amount";
            this.calremaningamount.Name = "calremaningamount";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(398, 261);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 101;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // calcategoryname
            // 
            this.calcategoryname.HeaderText = "category name";
            this.calcategoryname.Name = "calcategoryname";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(48, 261);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 17);
            this.Total.TabIndex = 100;
            this.Total.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(143, 261);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(142, 20);
            this.txttotal.TabIndex = 99;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(304, 261);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 97;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(603, 121);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(176, 21);
            this.cbocategory.TabIndex = 96;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // cboproductname
            // 
            this.cboproductname.FormattingEnabled = true;
            this.cboproductname.Location = new System.Drawing.Point(141, 148);
            this.cboproductname.Name = "cboproductname";
            this.cboproductname.Size = new System.Drawing.Size(190, 21);
            this.cboproductname.TabIndex = 95;
            this.cboproductname.SelectedIndexChanged += new System.EventHandler(this.cboproductname_SelectedIndexChanged);
            // 
            // txtquanitity
            // 
            this.txtquanitity.Location = new System.Drawing.Point(141, 175);
            this.txtquanitity.Name = "txtquanitity";
            this.txtquanitity.Size = new System.Drawing.Size(190, 20);
            this.txtquanitity.TabIndex = 94;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(603, 179);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(176, 20);
            this.txtdiscount.TabIndex = 93;
            // 
            // calcategoryid
            // 
            this.calcategoryid.HeaderText = "categoryid";
            this.calcategoryid.Name = "calcategoryid";
            this.calcategoryid.Visible = false;
            // 
            // calcustomer
            // 
            this.calcustomer.HeaderText = "Customer Name";
            this.calcustomer.Name = "calcustomer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calcustomer,
            this.calcategoryid,
            this.calproductid,
            this.calcategoryname,
            this.calproductname,
            this.calprice,
            this.calquantity,
            this.caldiscount,
            this.calpaidamount,
            this.calremaningamount,
            this.caltotal});
            this.dataGridView1.Location = new System.Drawing.Point(55, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 158);
            this.dataGridView1.TabIndex = 98;
            // 
            // calproductid
            // 
            this.calproductid.HeaderText = "procudtid";
            this.calproductid.Name = "calproductid";
            this.calproductid.Visible = false;
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
            // calpaidamount
            // 
            this.calpaidamount.HeaderText = "Paid Amount";
            this.calpaidamount.Name = "calpaidamount";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(603, 148);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(176, 20);
            this.txtprice.TabIndex = 92;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(141, 94);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(190, 20);
            this.txtinvoiceno.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Price";
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.Location = new System.Drawing.Point(141, 123);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(190, 20);
            this.txtinvoicedate.TabIndex = 91;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(603, 93);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(176, 20);
            this.txtcustomername.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Invoice No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 24);
            this.label12.TabIndex = 133;
            this.label12.Text = "Sell Products";
            // 
            // UserControl_sell_prodcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtremaningamount);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.txttax);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.cboproductname);
            this.Controls.Add(this.txtquanitity);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtinvoicedate);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_sell_prodcuts";
            this.Size = new System.Drawing.Size(811, 587);
            this.Load += new System.EventHandler(this.UserControl_sell_prodcuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtremaningamount;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn calremaningamount;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryname;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.ComboBox cboproductname;
        private System.Windows.Forms.TextBox txtquanitity;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn caldiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpaidamount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtinvoicedate;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
    }
}
