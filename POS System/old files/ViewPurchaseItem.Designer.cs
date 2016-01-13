namespace POS_System
{
    partial class ViewPurchaseItem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.btncategorysearch = new System.Windows.Forms.Button();
            this.btnproductsearch = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By Product";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(121, 44);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(141, 20);
            this.txtcategory.TabIndex = 3;
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(480, 44);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(161, 20);
            this.txtproduct.TabIndex = 4;
            // 
            // btncategorysearch
            // 
            this.btncategorysearch.Location = new System.Drawing.Point(271, 43);
            this.btncategorysearch.Name = "btncategorysearch";
            this.btncategorysearch.Size = new System.Drawing.Size(88, 23);
            this.btncategorysearch.TabIndex = 5;
            this.btncategorysearch.Text = "Search";
            this.btncategorysearch.UseVisualStyleBackColor = true;
            this.btncategorysearch.Click += new System.EventHandler(this.btncategorysearch_Click);
            // 
            // btnproductsearch
            // 
            this.btnproductsearch.Location = new System.Drawing.Point(648, 44);
            this.btnproductsearch.Name = "btnproductsearch";
            this.btnproductsearch.Size = new System.Drawing.Size(75, 23);
            this.btnproductsearch.TabIndex = 6;
            this.btnproductsearch.Text = "Search";
            this.btnproductsearch.UseVisualStyleBackColor = true;
            this.btnproductsearch.Click += new System.EventHandler(this.btnproductsearch_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(16, 13);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(13, 20);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = ".";
            // 
            // ViewPurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 396);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnproductsearch);
            this.Controls.Add(this.btncategorysearch);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewPurchaseItem";
            this.Text = "ViewPurchaseItem";
            this.Load += new System.EventHandler(this.ViewPurchaseItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Button btncategorysearch;
        private System.Windows.Forms.Button btnproductsearch;
        private System.Windows.Forms.Label lblMsg;
    }
}