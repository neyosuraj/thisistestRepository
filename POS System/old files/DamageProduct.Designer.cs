namespace POS_System
{
    partial class DamageProduct
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
            this.btnexpire = new System.Windows.Forms.Button();
            this.txtquantityexp = new System.Windows.Forms.TextBox();
            this.cboproductexp = new System.Windows.Forms.ComboBox();
            this.cbocategoryexp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdeprecation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.cboproduct = new System.Windows.Forms.ComboBox();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.btndamage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexpire
            // 
            this.btnexpire.Location = new System.Drawing.Point(120, 300);
            this.btnexpire.Name = "btnexpire";
            this.btnexpire.Size = new System.Drawing.Size(75, 23);
            this.btnexpire.TabIndex = 33;
            this.btnexpire.Text = "Expiry";
            this.btnexpire.UseVisualStyleBackColor = true;
            // 
            // txtquantityexp
            // 
            this.txtquantityexp.Location = new System.Drawing.Point(120, 260);
            this.txtquantityexp.Name = "txtquantityexp";
            this.txtquantityexp.Size = new System.Drawing.Size(120, 20);
            this.txtquantityexp.TabIndex = 32;
            // 
            // cboproductexp
            // 
            this.cboproductexp.FormattingEnabled = true;
            this.cboproductexp.Location = new System.Drawing.Point(120, 229);
            this.cboproductexp.Name = "cboproductexp";
            this.cboproductexp.Size = new System.Drawing.Size(120, 21);
            this.cboproductexp.TabIndex = 31;
            // 
            // cbocategoryexp
            // 
            this.cbocategoryexp.FormattingEnabled = true;
            this.cbocategoryexp.Location = new System.Drawing.Point(120, 199);
            this.cbocategoryexp.Name = "cbocategoryexp";
            this.cbocategoryexp.Size = new System.Drawing.Size(120, 21);
            this.cbocategoryexp.TabIndex = 30;
            this.cbocategoryexp.SelectedIndexChanged += new System.EventHandler(this.cbocategoryexp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Category";
            // 
            // txtdeprecation
            // 
            this.txtdeprecation.Location = new System.Drawing.Point(120, 118);
            this.txtdeprecation.Name = "txtdeprecation";
            this.txtdeprecation.Size = new System.Drawing.Size(120, 20);
            this.txtdeprecation.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Depreciation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 281);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(120, 90);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(120, 20);
            this.txtquantity.TabIndex = 23;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // cboproduct
            // 
            this.cboproduct.FormattingEnabled = true;
            this.cboproduct.Location = new System.Drawing.Point(120, 59);
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(120, 21);
            this.cboproduct.TabIndex = 22;
            this.cboproduct.SelectedIndexChanged += new System.EventHandler(this.cboproduct_SelectedIndexChanged);
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(120, 29);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(120, 21);
            this.cbocategory.TabIndex = 21;
            this.cbocategory.SelectedIndexChanged += new System.EventHandler(this.cbocategory_SelectedIndexChanged);
            // 
            // btndamage
            // 
            this.btndamage.Location = new System.Drawing.Point(120, 150);
            this.btndamage.Name = "btndamage";
            this.btndamage.Size = new System.Drawing.Size(75, 23);
            this.btndamage.TabIndex = 20;
            this.btndamage.Text = "Damage";
            this.btndamage.UseVisualStyleBackColor = true;
            this.btndamage.Click += new System.EventHandler(this.btndamage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Search By Product";
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(457, 30);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(156, 20);
            this.txtproduct.TabIndex = 35;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(630, 29);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(88, 23);
            this.btnsearch.TabIndex = 36;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(293, 58);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(12, 17);
            this.lblmsg.TabIndex = 37;
            this.lblmsg.Text = ".";
            // 
            // DamageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 371);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnexpire);
            this.Controls.Add(this.txtquantityexp);
            this.Controls.Add(this.cboproductexp);
            this.Controls.Add(this.cbocategoryexp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdeprecation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.cboproduct);
            this.Controls.Add(this.cbocategory);
            this.Controls.Add(this.btndamage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DamageProduct";
            this.Text = "DamageProduct";
            this.Load += new System.EventHandler(this.DamageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexpire;
        private System.Windows.Forms.TextBox txtquantityexp;
        private System.Windows.Forms.ComboBox cboproductexp;
        private System.Windows.Forms.ComboBox cbocategoryexp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdeprecation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.ComboBox cboproduct;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.Button btndamage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblmsg;
    }
}