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
    public partial class UserControl_sell_prodcuts : UserControl
    {
        public UserControl_sell_prodcuts()
        {
            InitializeComponent();
        }
        BLLInvoice blin = new BLLInvoice();
        BLLCategory blcat = new BLLCategory();
        BLLProduct blp = new BLLProduct();

        private void UserControl_sell_prodcuts_Load(object sender, EventArgs e)
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

        int i = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtinvoiceno.Text == "" || cboproductname.Text == "" || txtquanitity.Text == "" || txtcustomername.Text == "" || cbocategory.Text == "" || txtprice.Text == "" || txtdiscount.Text == "")
            {
                MessageBox.Show("inputs are may be empty..");
            }
            else if ((Convert.ToInt32(this.txtquanitity.Text) > 100 | Convert.ToInt32(this.txtquanitity.Text) < 10))
            {
                MessageBox.Show("quantity excedded than 1000 or less than 10");

            }
            else {
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

            } }

        private void btnremove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                decimal total_to_be_remove = Convert.ToDecimal(dr.Cells["caltotal"].Value);
                txtgrandtotal.Text = (Convert.ToDecimal(txtgrandtotal.Text) - Convert.ToDecimal(total_to_be_remove)).ToString();
                dataGridView1.Rows.Remove(dr);
            }
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            txtremaningamount.Text = (Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtpaidamount.Text)).ToString();
            txtremaningamount.Focus();
        }
    }
}
