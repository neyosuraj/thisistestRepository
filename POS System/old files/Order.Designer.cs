namespace POS_System
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.msg = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.txtsearchtableno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltable_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calupdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.caldelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txttblno = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnview = new System.Windows.Forms.Button();
            this.cboitem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(241, 396);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(10, 13);
            this.msg.TabIndex = 67;
            this.msg.Text = ".";
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(28, 219);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(75, 23);
            this.btnorder.TabIndex = 66;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // txtsearchtableno
            // 
            this.txtsearchtableno.Location = new System.Drawing.Point(472, 44);
            this.txtsearchtableno.Name = "txtsearchtableno";
            this.txtsearchtableno.Size = new System.Drawing.Size(74, 20);
            this.txtsearchtableno.TabIndex = 65;
            this.txtsearchtableno.TextChanged += new System.EventHandler(this.txtsearchtableno_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Search By Table No";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calitem,
            this.caltable_no,
            this.calquantity,
            this.calcost,
            this.caltotal,
            this.calupdate,
            this.caldelete});
            this.dataGridView1.Location = new System.Drawing.Point(223, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 287);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calitem
            // 
            this.calitem.HeaderText = "Item";
            this.calitem.Name = "calitem";
            this.calitem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // caltable_no
            // 
            this.caltable_no.HeaderText = "Table No";
            this.caltable_no.Name = "caltable_no";
            // 
            // calquantity
            // 
            this.calquantity.HeaderText = "Quantity";
            this.calquantity.Name = "calquantity";
            this.calquantity.Width = 50;
            // 
            // calcost
            // 
            this.calcost.HeaderText = "Cost";
            this.calcost.Name = "calcost";
            this.calcost.Width = 70;
            // 
            // caltotal
            // 
            this.caltotal.HeaderText = "Total";
            this.caltotal.Name = "caltotal";
            this.caltotal.Width = 70;
            // 
            // calupdate
            // 
            this.calupdate.HeaderText = "U";
            this.calupdate.Image = ((System.Drawing.Image)(resources.GetObject("calupdate.Image")));
            this.calupdate.Name = "calupdate";
            this.calupdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calupdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.calupdate.Width = 30;
            // 
            // caldelete
            // 
            this.caldelete.HeaderText = "D";
            this.caldelete.Image = ((System.Drawing.Image)(resources.GetObject("caldelete.Image")));
            this.caldelete.Name = "caldelete";
            this.caldelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.caldelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.caldelete.Width = 30;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(157, 155);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(59, 20);
            this.txtcost.TabIndex = 62;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(69, 155);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(48, 20);
            this.txtquantity.TabIndex = 61;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquantity_KeyDown);
            // 
            // txttblno
            // 
            this.txttblno.Location = new System.Drawing.Point(69, 90);
            this.txttblno.Name = "txttblno";
            this.txttblno.Size = new System.Drawing.Size(48, 20);
            this.txttblno.TabIndex = 59;
            this.txttblno.TextChanged += new System.EventHandler(this.txttblno_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(69, 60);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(147, 20);
            this.txtusername.TabIndex = 58;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Table No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Order Item";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(69, 186);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(147, 20);
            this.txttotal.TabIndex = 105;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(126, 219);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 106;
            this.btnview.Text = "View Bill";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // cboitem
            // 
            this.cboitem.FormattingEnabled = true;
            this.cboitem.Location = new System.Drawing.Point(69, 124);
            this.cboitem.Name = "cboitem";
            this.cboitem.Size = new System.Drawing.Size(147, 21);
            this.cboitem.TabIndex = 107;
            this.cboitem.SelectedIndexChanged += new System.EventHandler(this.cboitem_SelectedIndexChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 380);
            this.Controls.Add(this.cboitem);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.txtsearchtableno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txttblno);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.TextBox txtsearchtableno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txttblno;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridViewTextBoxColumn calitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltable_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
        private System.Windows.Forms.DataGridViewImageColumn calupdate;
        private System.Windows.Forms.DataGridViewImageColumn caldelete;
        private System.Windows.Forms.ComboBox cboitem;
    }
}