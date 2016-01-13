namespace POS_System
{
    partial class UserControl_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_order));
            this.cboitem = new System.Windows.Forms.ComboBox();
            this.btnview = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.btnorder = new System.Windows.Forms.Button();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txttblno = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltable_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.calupdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.caldelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboitem
            // 
            this.cboitem.FormattingEnabled = true;
            this.cboitem.Location = new System.Drawing.Point(121, 180);
            this.cboitem.Name = "cboitem";
            this.cboitem.Size = new System.Drawing.Size(147, 21);
            this.cboitem.TabIndex = 126;
            this.cboitem.SelectedIndexChanged += new System.EventHandler(this.cboitem_SelectedIndexChanged);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(193, 275);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 34);
            this.btnview.TabIndex = 125;
            this.btnview.Text = "View Bill";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(121, 242);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(147, 20);
            this.txttotal.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 123;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(322, 402);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(10, 13);
            this.msg.TabIndex = 122;
            this.msg.Text = ".";
            this.msg.Click += new System.EventHandler(this.msg_Click);
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(117, 275);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(75, 34);
            this.btnorder.TabIndex = 121;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(209, 211);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(59, 20);
            this.txtcost.TabIndex = 117;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(121, 211);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(48, 20);
            this.txtquantity.TabIndex = 116;
            this.txtquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquantity_KeyDown_1);
            // 
            // txttblno
            // 
            this.txttblno.Location = new System.Drawing.Point(121, 146);
            this.txttblno.Name = "txttblno";
            this.txttblno.Size = new System.Drawing.Size(48, 20);
            this.txttblno.TabIndex = 115;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(121, 116);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(147, 20);
            this.txtusername.TabIndex = 114;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 113;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 112;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Table No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 108;
            this.label1.Text = "Order Item";
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
            this.dataGridView1.Location = new System.Drawing.Point(306, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 287);
            this.dataGridView1.TabIndex = 127;
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
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(19, 326);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(21, 20);
            this.lblmsg.TabIndex = 128;
            this.lblmsg.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(175, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 129;
            this.label13.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 130;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 131;
            this.label9.Text = "*";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 132;
            this.label10.Text = "Orders";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "U";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "D";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 30;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 111;
            this.label4.Text = "Item";
            // 
            // UserControl_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboitem);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.btnorder);
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
            this.Name = "UserControl_order";
            this.Size = new System.Drawing.Size(764, 446);
            this.Load += new System.EventHandler(this.UserControl_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cboitem;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txttblno;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn calitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltable_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn calquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn calcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn caltotal;
        private System.Windows.Forms.DataGridViewImageColumn calupdate;
        private System.Windows.Forms.DataGridViewImageColumn caldelete;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
    }
}
