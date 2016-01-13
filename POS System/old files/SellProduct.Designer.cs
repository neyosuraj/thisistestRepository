namespace POS_System
{
    partial class SellProduct
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
            this.Total = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcategoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calproductname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calpaidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calremaningamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Tax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txtremaningamount = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(361, 208);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 70;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(11, 208);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 17);
            this.Total.TabIndex = 69;
            this.Total.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(106, 208);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(142, 20);
            this.txttotal.TabIndex = 68;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 158);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calcustomer
            // 
            this.calcustomer.HeaderText = "Customer Name";
            this.calcustomer.Name = "calcustomer";
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
            // calpaidamount
            // 
            this.calpaidamount.HeaderText = "Paid Amount";
            this.calpaidamount.Name = "calpaidamount";
            // 
            // calremaningamount
            // 
            this.calremaningamount.HeaderText = "Remaning Amount";
            this.calremaningamount.Name = "calremaningamount";
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "total";
            this.caltotal.Name = "caltotal";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(267, 208);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 66;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(566, 68);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(176, 21);
            this.cbocategory.TabIndex = 65;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // cboproductname
            // 
            this.cboproductname.FormattingEnabled = true;
            this.cboproductname.Location = new System.Drawing.Point(104, 95);
            this.cboproductname.Name = "cboproductname";
            this.cboproductname.Size = new System.Drawing.Size(190, 21);
            this.cboproductname.TabIndex = 64;
            this.cboproductname.SelectedIndexChanged += new System.EventHandler(this.cboproductname_SelectedIndexChanged);
            // 
            // txtquanitity
            // 
            this.txtquanitity.Location = new System.Drawing.Point(104, 122);
            this.txtquanitity.Name = "txtquanitity";
            this.txtquanitity.Size = new System.Drawing.Size(190, 20);
            this.txtquanitity.TabIndex = 63;
            this.txtquanitity.TextChanged += new System.EventHandler(this.txtquanitity_TextChanged);
            this.txtquanitity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquanitity_KeyDown);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(566, 126);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(176, 20);
            this.txtdiscount.TabIndex = 62;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(566, 95);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(176, 20);
            this.txtprice.TabIndex = 61;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.Location = new System.Drawing.Point(104, 70);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(190, 20);
            this.txtinvoicedate.TabIndex = 60;
            this.txtinvoicedate.TextChanged += new System.EventHandler(this.txtinvoicedate_TextChanged);
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(566, 40);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(176, 20);
            this.txtcustomername.TabIndex = 59;
            this.txtcustomername.TextChanged += new System.EventHandler(this.txtcustomername_TextChanged);
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Location = new System.Drawing.Point(104, 41);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(190, 20);
            this.txtinvoiceno.TabIndex = 58;
            this.txtinvoiceno.TextChanged += new System.EventHandler(this.txtinvoiceno_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Invoice Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Invoice No";
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(18, 155);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(25, 13);
            this.Tax.TabIndex = 71;
            this.Tax.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Paid Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Remaning Amount";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(49, 443);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 76;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(386, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(486, 446);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(142, 20);
            this.txtgrandtotal.TabIndex = 74;
            this.txtgrandtotal.Text = "0.00";
            // 
            // txttax
            // 
            this.txttax.Location = new System.Drawing.Point(104, 152);
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(190, 20);
            this.txttax.TabIndex = 77;
            this.txttax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttax_KeyDown);
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Location = new System.Drawing.Point(567, 155);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(176, 20);
            this.txtpaidamount.TabIndex = 78;
            this.txtpaidamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpaidamount_KeyDown);
            // 
            // txtremaningamount
            // 
            this.txtremaningamount.Location = new System.Drawing.Point(567, 208);
            this.txtremaningamount.Name = "txtremaningamount";
            this.txtremaningamount.Size = new System.Drawing.Size(175, 20);
            this.txtremaningamount.TabIndex = 79;
            this.txtremaningamount.TextChanged += new System.EventHandler(this.txtremaningamount_TextChanged);
            this.txtremaningamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtremaningamount_KeyDown);
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(569, 180);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 80;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 478);
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
            this.Name = "SellProduct";
            this.Text = "SellProduct";
            this.Load += new System.EventHandler(this.SellProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnremove;
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
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txtremaningamount;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcategoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calproductname;
        private System.Windows.Forms.DataGridViewTextBoxColumn calprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn caldiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calpaidamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn calremaningamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
    }
}