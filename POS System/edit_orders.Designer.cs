namespace POS_System
{
    partial class edit_orders
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txttableno = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(115, 157);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(22, 13);
            this.lbltotal.TabIndex = 38;
            this.lbltotal.Text = "0.0";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(112, 184);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 23);
            this.btn_update.TabIndex = 37;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txttableno
            // 
            this.txttableno.Location = new System.Drawing.Point(112, 121);
            this.txttableno.Name = "txttableno";
            this.txttableno.Size = new System.Drawing.Size(146, 20);
            this.txttableno.TabIndex = 33;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(112, 88);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(146, 20);
            this.txtquantity.TabIndex = 34;
            this.txtquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtquantity_KeyDown_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Table No";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(111, 23);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(146, 20);
            this.txtitem.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 31;
            this.label4.Tag = "";
            this.label4.Text = "Item";
            // 
            // txtusers
            // 
            this.txtusers.Location = new System.Drawing.Point(112, 52);
            this.txtusers.Name = "txtusers";
            this.txtusers.Size = new System.Drawing.Size(146, 20);
            this.txtusers.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total";
            // 
            // edit_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txttableno);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusers);
            this.Controls.Add(this.label2);
            this.Name = "edit_orders";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.edit_orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.TextBox txttableno;
        public System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtusers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}