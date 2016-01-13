namespace POS_System
{
    partial class ProductAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboproduct = new System.Windows.Forms.ComboBox();
            this.txtnewprice = new System.Windows.Forms.TextBox();
            this.btnpriceupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // bttnadd
            // 
            this.bttnadd.Location = new System.Drawing.Point(45, 190);
            this.bttnadd.Name = "bttnadd";
            this.bttnadd.Size = new System.Drawing.Size(75, 23);
            this.bttnadd.TabIndex = 4;
            this.bttnadd.Text = "Product Add";
            this.bttnadd.UseVisualStyleBackColor = true;
            this.bttnadd.Click += new System.EventHandler(this.bttnadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(45, 113);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(183, 20);
            this.txtproduct.TabIndex = 2;
            this.txtproduct.TextChanged += new System.EventHandler(this.txtproduct_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(45, 162);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(183, 20);
            this.txtprice.TabIndex = 3;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(45, 66);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(183, 21);
            this.cbocategory.TabIndex = 1;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price Update";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Update";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "New Price";
            // 
            // cboproduct
            // 
            this.cboproduct.FormattingEnabled = true;
            this.cboproduct.Location = new System.Drawing.Point(44, 278);
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(183, 21);
            this.cboproduct.TabIndex = 6;
            this.cboproduct.SelectedIndexChanged += new System.EventHandler(this.cboproduct_SelectedIndexChanged);
            // 
            // txtnewprice
            // 
            this.txtnewprice.Location = new System.Drawing.Point(44, 322);
            this.txtnewprice.Name = "txtnewprice";
            this.txtnewprice.Size = new System.Drawing.Size(183, 20);
            this.txtnewprice.TabIndex = 7;
            this.txtnewprice.TextChanged += new System.EventHandler(this.txtnewprice_TextChanged);
            // 
            // btnpriceupdate
            // 
            this.btnpriceupdate.Location = new System.Drawing.Point(44, 348);
            this.btnpriceupdate.Name = "btnpriceupdate";
            this.btnpriceupdate.Size = new System.Drawing.Size(88, 23);
            this.btnpriceupdate.TabIndex = 8;
            this.btnpriceupdate.Text = "Price Update";
            this.btnpriceupdate.UseVisualStyleBackColor = true;
            this.btnpriceupdate.Click += new System.EventHandler(this.btnpriceupdate_Click);
            // 
            // ProductAdd
            // 
            this.AcceptButton = this.btnpriceupdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 378);
            this.Controls.Add(this.btnpriceupdate);
            this.Controls.Add(this.txtnewprice);
            this.Controls.Add(this.cboproduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAdd";
            this.Text = "ProductUpdate";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboproduct;
        private System.Windows.Forms.TextBox txtnewprice;
        private System.Windows.Forms.Button btnpriceupdate;
        public System.Windows.Forms.TextBox txtproduct;
    }
}