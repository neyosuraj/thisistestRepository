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
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
        }
        BLLInvoice blin = new BLLInvoice();
        BLLCategory blcat = new BLLCategory();
        BLLProduct blp = new BLLProduct();
        private void SellProduct_Load(object sender, EventArgs e)
        {
            Category();
            txtinvoicedate.Text = DateTime.Today.ToShortDateString();

            DataTable dt = blin.getsellinvoiceno();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    txtinvoiceno.Text = "100";
                    
                }
                else
                {
                    int getsellinvoiceno = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                    txtinvoiceno.Text = getsellinvoiceno.ToString();
                }
            }
            
        }
        public void Category()
        {
            DataTable dt = blcat.getallcategory();

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["category_name"]="Choose One";
                dt.Rows.InsertAt(dr,0);
                cbocategory.DataSource=dt;
                cbocategory.DisplayMember = "category_name";
                cbocategory.ValueMember = "category_id";
            }
        }
        private void cbocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbocategory.SelectedIndex != 0)
            {
                DataTable dt = blp.getproductid(Convert.ToInt32(cbocategory.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["product_name"] = "Choose One";
                    dt.Rows.InsertAt(dr, 0);
                    cboproductname.DataSource = dt;
                    cboproductname.DisplayMember = "product_name";
                    cboproductname.ValueMember = "product_id";
                }
            }
        }
        private void cboproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboproductname.SelectedIndex != 0)
            {
                DataTable dt = blp.getpricebyproductid(Convert.ToInt32(cboproductname.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtprice.Text = dt.Rows[0]["Price"].ToString();
                    txtquanitity.Focus();
                }
            }

        }

        private void txtquanitity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            
            {
                if (txtquanitity.Text.Length > 0) 
                {
                    txttotal.Text = (Convert.ToDecimal(txtprice.Text) * Convert.ToDecimal(txtquanitity.Text)).ToString();
                    txtdiscount.Focus();
                }
            }
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtquanitity.Text.Length > 0)
                {
                    txttotal.Text = ((Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text)) - (Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text) * (Convert.ToDecimal(txtdiscount.Text) / 100))).ToString();
                    txttax.Focus();
                }
            }
        }

        private void txttax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdiscount.Text.Length > 0)
                {
                    txttotal.Text = (((Convert.ToDecimal(txttotal.Text) * Convert.ToDecimal(txttax.Text)) / 100)+ (Convert.ToDecimal(txttotal.Text))).ToString();
                    txtpaidamount.Focus();
                }
            }
        }

        private void txtpaidamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txttax.Text.Length > 0)
                {
                    btncalculate.Focus();
                }
            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            txtremaningamount.Text=(Convert.ToDecimal(txttotal.Text)-Convert.ToDecimal(txtpaidamount.Text)).ToString();
            txtremaningamount.Focus();
        }

        private void txtremaningamount_KeyDown(object sender, KeyEventArgs e)
        {
            btnadd.Focus();
        }
        int i = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells["calcategoryid"].Value = cbocategory.SelectedIndex.ToString();
            dataGridView1.Rows[i].Cells["calproductid"].Value = cboproductname.SelectedIndex.ToString();
            dataGridView1.Rows[i].Cells["calcustomername"].Value = txtcustomername.Text;
            dataGridView1.Rows[i].Cells["calcategoryname"].Value = cbocategory.Text;
            dataGridView1.Rows[i].Cells["calproductname"].Value = cboproductname.Text;
            dataGridView1.Rows[i].Cells["calprice"].Value = txtprice.Text;
            dataGridView1.Rows[i].Cells["calquantity"].Value = txtquanitity.Text;
            dataGridView1.Rows[i].Cells["caldiscount"].Value = txtdiscount.Text;
            dataGridView1.Rows[i].Cells["calpaidamount"].Value = txtpaidamount.Text;
            dataGridView1.Rows[i].Cells["calremaningamount"].Value = txtremaningamount.Text;
            dataGridView1.Rows[i].Cells["caltotal"].Value = txttotal.Text;
            i++;
            txtgrandtotal.Text = (Convert.ToDecimal(txtgrandtotal.Text) + Convert.ToDecimal(txttotal.Text)).ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                decimal total_to_be_remove = Convert.ToDecimal(dr.Cells["caltotal"].Value);
                txtgrandtotal.Text = (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(total_to_be_remove)).ToString();
                dataGridView1.Rows.Remove(dr);
            }
        }

        private void txtinvoiceno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtinvoicedate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquanitity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtremaningamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
