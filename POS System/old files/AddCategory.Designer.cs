namespace POS_System
{
    partial class AddCategory
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
            this.txtaddcategory = new System.Windows.Forms.TextBox();
            this.btncategoryadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbodeletecategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // txtaddcategory
            // 
            this.txtaddcategory.Location = new System.Drawing.Point(141, 63);
            this.txtaddcategory.Name = "txtaddcategory";
            this.txtaddcategory.Size = new System.Drawing.Size(143, 20);
            this.txtaddcategory.TabIndex = 1;
            this.txtaddcategory.TextChanged += new System.EventHandler(this.txtaddcategory_TextChanged);
            // 
            // btncategoryadd
            // 
            this.btncategoryadd.Location = new System.Drawing.Point(141, 100);
            this.btncategoryadd.Name = "btncategoryadd";
            this.btncategoryadd.Size = new System.Drawing.Size(116, 23);
            this.btncategoryadd.TabIndex = 2;
            this.btncategoryadd.Text = "Add";
            this.btncategoryadd.UseVisualStyleBackColor = true;
            this.btncategoryadd.Click += new System.EventHandler(this.btncategoryadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delete Category Name";
            // 
            // cbodeletecategory
            // 
            this.cbodeletecategory.FormattingEnabled = true;
            this.cbodeletecategory.Location = new System.Drawing.Point(141, 190);
            this.cbodeletecategory.Name = "cbodeletecategory";
            this.cbodeletecategory.Size = new System.Drawing.Size(143, 21);
            this.cbodeletecategory.TabIndex = 4;
            this.cbodeletecategory.SelectedIndexChanged += new System.EventHandler(this.cbodeletecategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delete Category";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(141, 229);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 277);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbodeletecategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncategoryadd);
            this.Controls.Add(this.txtaddcategory);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddcategory;
        private System.Windows.Forms.Button btncategoryadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbodeletecategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
    }
}