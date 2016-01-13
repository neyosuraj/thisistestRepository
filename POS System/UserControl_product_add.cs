using BLLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class UserControl_product_add : UserControl
    {
        public UserControl_product_add()
        {
            InitializeComponent();
        }
        BLLProduct blp = new BLLProduct();
        BLLCategory blcat = new BLLCategory();


        private void UserControl_product_add_Load(object sender, EventArgs e)
        {
            category();
            product();
        }
        public void category()
        {
            DataTable dt = blcat.getallcategory();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cbocategory.DataSource = dt;
                cbocategory.DisplayMember = "category_name";
                cbocategory.ValueMember = "category_id";
            }
        }
        public void product()
        {
            DataTable dt = blp.getallproduct();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["product_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cboproduct.DataSource = dt;
                cboproduct.DisplayMember = "product_name";
                cboproduct.ValueMember = "product_id";
            }
        }

        private void bttnadd_Click(object sender, EventArgs e)
        {
            int parsedvalue;
            BLLProduct blll = new BLLProduct();
            DataTable dt = blll.checkallproducts(txtproduct.Text);
            if (txtproduct.Text=="" ||  txtprice.Text=="") {
                MessageBox.Show("input the required fields...");
            }

            else if (!int.TryParse(txtprice.Text, out parsedvalue))
            {

                lblmsg.Text = ("the input in price is invalid type integers...");
            }

            else if (dt.Rows.Count > 0)
                {

                    MessageBox.Show("product already exists");

                }
                else
                {
                    // values check condition is not finished..
                    int i = blp.addproduct(Convert.ToInt32(cbocategory.SelectedValue.ToString()), txtproduct.Text, Convert.ToDecimal(txtprice.Text));
                    if (i > 0)
                    {
                        MessageBox.Show("Product Has Been Added");
                    gridview1();
                    }
                }
            }  

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int i = blp.deleteproduct(txtproduct.Text);
                if (i > 0)
                {
                    MessageBox.Show("Product has been delete");
                    gridview1();
                }
                else
                {
                    MessageBox.Show("Product is not found please input correct one");
                }
            }
        }

        private void cboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproduct.SelectedIndex != 0)
            {
                DataTable dt = blp.getpricebyproductid(Convert.ToInt32(cboproduct.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtnewprice.Text = dt.Rows[0]["price"].ToString();
                    btnpriceupdate.Focus();
                }
            }
        }

        private void btnpriceupdate_Click(object sender, EventArgs e)
        {
            int parsedvalues;
            if (txtnewprice.Text=="") {
                MessageBox.Show("input the required Fields...");
            }
            else if (!int.TryParse(txtnewprice.Text, out parsedvalues))
            {

                lblmsg.Text = ("the input ijn price is invalid");
            }
            else {

                if (txtnewprice.Text.Length > 0)
                {
                    //int i =Convert.ToInt32( cboproduct.SelectedValue.ToString());

                    int i = blp.updateprice(Convert.ToDecimal(txtnewprice.Text), Convert.ToInt32(cboproduct.SelectedValue.ToString()));
                    if (i > 0)
                    {
                        MessageBox.Show("Price has been update");
                        gridview1();
                    }

                }

            } }

       

        

        private void UserControl_product_add_Load_1(object sender, EventArgs e)
        {
            category();
            product();
            gridview1();


        }
        public void gridview1()
        {
            DataTable dt = blp.getallproduct();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
