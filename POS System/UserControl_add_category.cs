using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLS;

namespace POS_System
{
    public partial class UserControl_add_category : UserControl
    {
        public UserControl_add_category()
        {
            InitializeComponent();
        }
        BLLCategory blcat = new BLLCategory();
       

        public void category() {

            DataTable dt = blcat.getallcategory();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cbodeletecategory.DataSource = dt;
                cbodeletecategory.DisplayMember = "category_name";
                cbodeletecategory.ValueMember = "category_id";

            }
        }
        private void btncategoryadd_Click(object sender, EventArgs e)
        {
            if (txtaddcategory.Text == "")
            {
                MessageBox.Show("insert reuqired field..");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to Add?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    DataTable dt = blcat.checkcategory(txtaddcategory.Text);
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][1].ToString() == txtaddcategory.Text)
                        {

                            MessageBox.Show("This Category Has Been Already Insert");


                        }

                    }
                    else
                    {
                        int i = blcat.addcategory(txtaddcategory.Text);
                        if (i > 0)
                        {
                            MessageBox.Show("Category Add");
                            gridview();
                        }
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int i = blcat.deletecategory(cbodeletecategory.SelectedValue.ToString());
                if (i > 0)
                {
                    MessageBox.Show("Product has been delete");
                }


                else
                {
                    MessageBox.Show("Product is not found please input correct one");
                }
            }
        }

        private void cbodeletecategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void UserControl_add_category_Load(object sender, EventArgs e)
        {
            category();
            gridview();


        }

        public void gridview()
        {
            DataTable dt = new DataTable();
            dt = blcat.getallcategory();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            txtaddcategory.Text = string.Empty;
            cbodeletecategory.Text = string.Empty;
            
        }
    }
}
