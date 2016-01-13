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
    public partial class UserControl_purchase_form : UserControl
    {
        public UserControl_purchase_form()
        {
            InitializeComponent();
        }
        BLLInvoice blin = new BLLInvoice();
        BLLCategory blcat = new BLLCategory();
        BLLProduct blpro = new BLLProduct();
        BLLPurchase blpur = new BLLPurchase();
        BLLStock bls = new BLLStock();

        private void UserControl_purchase_form_Load(object sender, EventArgs e)
        {
            txtinvoicedate.Text = DateTime.Today.ToShortDateString();
            category();

            DataTable dt = blin.getinvoiceno();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "")
                {
                    txtinvoiceno.Text = "100";
                }
                else
                {
                    int getinvoiceno = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                    txtinvoiceno.Text = getinvoiceno.ToString();
                }
            }

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
        int i = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            int parsedvalue;
            decimal parse;
            if (txtinvoiceno.Text == "" || cboproductname.Text == "" || txtquanitity.Text == "" || txtcustomername.Text == "" || cbocategory.Text == "" || txtprice.Text == "" || txtdiscount.Text == "")
            {
                MessageBox.Show("inputs are may be empty..");
            }
            else if (!int.TryParse(txtinvoiceno.Text, out parsedvalue) || !int.TryParse(txtquanitity.Text, out parsedvalue) || !decimal.TryParse(txtdiscount.Text, out parse)|| !decimal.TryParse(txtpaidamount.Text, out parse))
            {
                lblmsg.Text = ("the inpur are invalid. type integer where required");

            }

            else
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["calcategoryid"].Value = cbocategory.SelectedIndex.ToString();
                dataGridView1.Rows[i].Cells["calproductid"].Value = cboproductname.SelectedIndex.ToString();
                dataGridView1.Rows[i].Cells["calcategory"].Value = cbocategory.Text;
                dataGridView1.Rows[i].Cells["calproductname"].Value = cboproductname.Text;
                dataGridView1.Rows[i].Cells["calprice"].Value = txtprice.Text;
                dataGridView1.Rows[i].Cells["calquantity"].Value = txtquanitity.Text;
                dataGridView1.Rows[i].Cells["caldiscount"].Value = txtdiscount.Text;
                dataGridView1.Rows[i].Cells["caltotal"].Value = txttotal.Text;
                dataGridView1.Rows[i].Cells["calexpirydate"].Value = dtpexpirydate.Text;
                dataGridView1.Rows[i].Cells["calpaidamount"].Value = txtpaidamount.Text;
                dataGridView1.Rows[i].Cells["calremainingamount"].Value = txtremainingamount.Text;
                i++;

                txtgrandtotal.Text = (Convert.ToDecimal(txtgrandtotal.Text) + Convert.ToDecimal(txttotal.Text)).ToString();
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
                DataTable dt = blpro.getpricebyproductid(Convert.ToInt32(cboproductname.SelectedValue.ToString()));
                if (dt.Rows.Count > 0)
                {
                    txtprice.Text = dt.Rows[0]["price"].ToString();
                    txtquanitity.Focus();
                }
            }
        }

        private void txtquanitity_KeyDown(object sender, KeyEventArgs e)
        {
             int parsedvalue;

            // if (!int.TryParse(txtquanitity.Text, out parsedvalue))
            // {
            //     lblmsg.Text = ("the inpur are invalid. type integer where required");

            // }
            //else 
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtquanitity.Text, out parsedvalue))
                {
                    txttotal.Text = (Convert.ToDecimal(txtprice.Text) * Convert.ToDecimal(txtquanitity.Text)).ToString();
                    txtdiscount.Focus();
                }
                else
                {
                    lblmsg.Text = ("Input Fail");
                }
              
            }
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            decimal parsedvalue;

            //if (decimal.TryParse(txtdiscount.Text, out parsedvalue))
            //{
                if (e.KeyCode == Keys.Enter)
                {
                if(decimal.TryParse(txtdiscount.Text, out parsedvalue))
                    txttotal.Text = ((Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text)) - (Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text) * (Convert.ToDecimal(txtdiscount.Text) / 100))).ToString();
                    dtpexpirydate.Select();
                }

           
           else  
            {
                lblmsg.Text = ("the inpur are invalid. type integer where required");
                
            }
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bls.checkquantityofproduct(cboproductname.Text);
            if (dt.Rows.Count > 0)
            {
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    string product_name = (dataGridView1.Rows[a].Cells["calproductname"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView1.Rows[a].Cells["calquantity"].Value.ToString());

                    int b = bls.addquantity(Convert.ToInt32(quantity), product_name);
                }
                purchase_add();
                MessageBox.Show("Quantity Has been Added");
               
            }

            else
            {

                stock();

            }
        }
             public void purchase_add()
               {
            int i = blin.createinvoice(Convert.ToInt32(txtinvoiceno.Text), Convert.ToDateTime(txtinvoicedate.Text));
            if (i > 0)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    int category_id = Convert.ToInt32(dataGridView1.Rows[j].Cells["calcategoryid"].Value.ToString());
                    int product_id = Convert.ToInt32(dataGridView1.Rows[j].Cells["calproductid"].Value.ToString());
                    decimal price = Convert.ToDecimal(dataGridView1.Rows[j].Cells["calprice"].Value.ToString());
                    int quantity = Convert.ToInt32(dataGridView1.Rows[j].Cells["calquantity"].Value.ToString());
                    int discount = Convert.ToInt32(dataGridView1.Rows[j].Cells["caldiscount"].Value.ToString());
                    decimal total = Convert.ToDecimal(dataGridView1.Rows[j].Cells["caltotal"].Value.ToString());
                    DateTime expiry_date = Convert.ToDateTime(dataGridView1.Rows[j].Cells["calexpirydate"].Value.ToString());
                    decimal paid_amount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["calpaidamount"].Value.ToString());
                    decimal remaining_amount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["calremainingamount"].Value.ToString());

                    int k = blpur.createpurhase(category_id, product_id, quantity, Convert.ToInt32(txtinvoiceno.Text), price, discount, total, expiry_date, paid_amount, remaining_amount);


                }
                MessageBox.Show("Data has been save");
            }
        }

        private void btncalculateamount_Click(object sender, EventArgs e)
        {
            txtremainingamount.Text = (Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtpaidamount.Text)).ToString();

        }
        public void stock()
        {

            if (i > 0)
            {
                for (int l = 0; l < dataGridView1.Rows.Count; l++)
                {
                    string category_name = dataGridView1.Rows[l].Cells["calcategory"].Value.ToString();
                    string product_name = dataGridView1.Rows[l].Cells["calproductname"].Value.ToString();
                    int quantity = Convert.ToInt32(dataGridView1.Rows[l].Cells["calquantity"].Value.ToString());
                    decimal price = Convert.ToDecimal(dataGridView1.Rows[l].Cells["calprice"].Value.ToString());

                    DateTime expiry_date = Convert.ToDateTime(dataGridView1.Rows[l].Cells["calexpirydate"].Value.ToString());

                    int k = bls.createstock(category_name, product_name, quantity, price, expiry_date);

                }

            }
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
