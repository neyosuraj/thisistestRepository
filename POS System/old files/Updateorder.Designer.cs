namespace POS_System
{
    partial class Updateorder
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
            this.btnorder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txttblno = new System.Windows.Forms.TextBox();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(16, 144);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(75, 23);
            this.btnorder.TabIndex = 26;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Table No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cost";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(71, 18);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(147, 20);
            this.txtusername.TabIndex = 21;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txttblno
            // 
            this.txttblno.Location = new System.Drawing.Point(71, 48);
            this.txttblno.Name = "txttblno";
            this.txttblno.Size = new System.Drawing.Size(48, 20);
            this.txttblno.TabIndex = 22;
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(71, 82);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(147, 20);
            this.txtitem.TabIndex = 23;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(71, 113);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(48, 20);
            this.txtquantity.TabIndex = 24;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(159, 113);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(59, 20);
            this.txtcost.TabIndex = 25;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // Updateorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 207);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.txttblno);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Updateorder";
            this.Text = "Updateorder";
            this.Load += new System.EventHandler(this.Updateorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txttblno;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtcost;
    }
}