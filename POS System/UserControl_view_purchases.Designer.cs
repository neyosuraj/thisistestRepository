namespace POS_System
{
    partial class UserControl_view_purchases
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
            this.btnproductsearch = new System.Windows.Forms.Button();
            this.btncategorysearch = new System.Windows.Forms.Button();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnproductsearch
            // 
            this.btnproductsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductsearch.Location = new System.Drawing.Point(751, 66);
            this.btnproductsearch.Name = "btnproductsearch";
            this.btnproductsearch.Size = new System.Drawing.Size(75, 23);
            this.btnproductsearch.TabIndex = 14;
            this.btnproductsearch.Text = "Search";
            this.btnproductsearch.UseVisualStyleBackColor = true;
            this.btnproductsearch.Click += new System.EventHandler(this.btnproductsearch_Click);
            // 
            // btncategorysearch
            // 
            this.btncategorysearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorysearch.Location = new System.Drawing.Point(347, 62);
            this.btncategorysearch.Name = "btncategorysearch";
            this.btncategorysearch.Size = new System.Drawing.Size(88, 23);
            this.btncategorysearch.TabIndex = 13;
            this.btncategorysearch.Text = "Search";
            this.btncategorysearch.UseVisualStyleBackColor = true;
            this.btncategorysearch.Click += new System.EventHandler(this.btncategorysearch_Click);
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(563, 66);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(161, 20);
            this.txtproduct.TabIndex = 12;
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(200, 66);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(141, 20);
            this.txtcategory.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search By Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search By Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 295);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMsg.Location = new System.Drawing.Point(117, 97);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 24);
            this.lblMsg.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(343, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 133;
            this.label10.Text = "View Purchases";
            // 
            // UserControl_view_purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnproductsearch);
            this.Controls.Add(this.btncategorysearch);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl_view_purchases";
            this.Size = new System.Drawing.Size(905, 452);
            this.Load += new System.EventHandler(this.UserControl_view_purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnproductsearch;
        private System.Windows.Forms.Button btncategorysearch;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label10;
    }
}
