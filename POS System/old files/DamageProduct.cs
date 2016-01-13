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
    public partial class DamageProduct : Form
    {
        public DamageProduct()
        {
            InitializeComponent();
        }

        BLLCategory blcat = new BLLCategory();
        BLLProduct blpro = new BLLProduct();
        BLLStock blst = new BLLStock();

        private void DamageProduct_Load(object sender, EventArgs e)
        {
            category();
            stockview();
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

        private void cbocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocategory.SelectedIndex != 0)
            {
                DataTable dt = blpro.getproductid(Convert.ToInt32(cbocategory.SelectedValue.ToString()));
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
        }
            
             public void stockview()
        {
            DataTable dt = blst.getallstock();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                
            }
        }

             private void btnsearch_Click(object sender, EventArgs e)
             {
                 if (txtproduct.Text.Length > 0)
                 {
                     DataTable dt = blst.getallstockbyname(txtproduct.Text);
                     if (dt.Rows.Count > 0)
                     {
                         dataGridView1.DataSource = dt;
                     }
                     else
                     {

                         lblmsg.Text = "Cannot Find Product";


                     }
                 }
                 else
                 {
                     stockview();
                     lblmsg.Visible = false;

                 }
             }

        private void cbocategoryexp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocategoryexp.SelectedIndex != 0)
            {
                DataTable dt = blpro.getproductid(Convert.ToInt32(cbocategoryexp.SelectedValue.ToString()));
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
        }

        private void cboproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndamage_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

