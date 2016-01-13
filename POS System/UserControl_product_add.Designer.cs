namespace POS_System
{
    partial class UserControl_product_add
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
            this.btnpriceupdate = new System.Windows.Forms.Button();
            this.txtnewprice = new System.Windows.Forms.TextBox();
            this.cboproduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpriceupdate
            // 
            this.btnpriceupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpriceupdate.Location = new System.Drawing.Point(32, 360);
            this.btnpriceupdate.Name = "btnpriceupdate";
            this.btnpriceupdate.Size = new System.Drawing.Size(183, 37);
            this.btnpriceupdate.TabIndex = 25;
            this.btnpriceupdate.Text = "Price Update";
            this.btnpriceupdate.UseVisualStyleBackColor = true;
            this.btnpriceupdate.Click += new System.EventHandler(this.btnpriceupdate_Click);
            // 
            // txtnewprice
            // 
            this.txtnewprice.Location = new System.Drawing.Point(32, 334);
            this.txtnewprice.Name = "txtnewprice";
            this.txtnewprice.Size = new System.Drawing.Size(183, 20);
            this.txtnewprice.TabIndex = 24;
            // 
            // cboproduct
            // 
            this.cboproduct.FormattingEnabled = true;
            this.cboproduct.Location = new System.Drawing.Point(32, 290);
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(183, 21);
            this.cboproduct.TabIndex = 23;
            this.cboproduct.SelectedIndexChanged += new System.EventHandler(this.cboproduct_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "New Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Product Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Price Update";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(146, 202);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(70, 36);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete Product";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(33, 78);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(183, 21);
            this.cbocategory.TabIndex = 16;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(33, 174);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(183, 20);
            this.txtprice.TabIndex = 19;
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(33, 125);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(183, 20);
            this.txtproduct.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Price";
            // 
            // bttnadd
            // 
            this.bttnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnadd.Location = new System.Drawing.Point(33, 202);
            this.bttnadd.Name = "bttnadd";
            this.bttnadd.Size = new System.Drawing.Size(107, 36);
            this.bttnadd.TabIndex = 20;
            this.bttnadd.Text = "Product Add";
            this.bttnadd.UseVisualStyleBackColor = true;
            this.bttnadd.Click += new System.EventHandler(this.bttnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(511, 264);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(442, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Products Lists";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(279, 392);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(21, 20);
            this.lblmsg.TabIndex = 32;
            this.lblmsg.Text = "...";
            // 
            // UserControl_product_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpriceupdate);
            this.Controls.Add(this.txtnewprice);
            this.Controls.Add(this.cboproduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_product_add";
            this.Size = new System.Drawing.Size(818, 426);
            this.Load += new System.EventHandler(this.UserControl_product_add_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpriceupdate;
        private System.Windows.Forms.TextBox txtnewprice;
        private System.Windows.Forms.ComboBox cboproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.TextBox txtprice;
        public System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmsg;
    }
}
