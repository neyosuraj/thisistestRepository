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
    public partial class Purchase_Form : Form
    {
        public Purchase_Form()
        {
            InitializeComponent();
        }
        BLLInvoice blin = new BLLInvoice();
        BLLCategory blcat = new BLLCategory();
        BLLProduct blpro = new BLLProduct();
        BLLPurchase blpur = new BLLPurchase();
        BLLStock bls = new BLLStock();

        


       

        private void Purchase_Form_Load(object sender, EventArgs e)
        {
            txtinvoicedate.Text = DateTime.Today.ToShortDateString();
            category();

            DataTable dt = blin.getinvoiceno();
            if(dt.Rows.Count>0)
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
                dt.Rows.InsertAt(dr,0);
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
            if (e.KeyCode == Keys.Enter)
            {
                if (txtquanitity.Text.Length > 0)
                { 
                    txttotal.Text=(Convert.ToDecimal(txtprice.Text)*Convert.ToDecimal(txtquanitity.Text)).ToString();
                    txtdiscount.Focus();
                }
            }
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtdiscount.Text.Length > 0)
                {
                    txttotal.Text = ((Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text)) - (Convert.ToDecimal(txtprice.Text) * Convert.ToInt32(txtquanitity.Text) * (Convert.ToDecimal(txtdiscount.Text) / 100))).ToString();
                    btnadd.Select(); 
                }
            }
        }
        int i = 0;

        private void btnadd_Click(object sender, EventArgs e)
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
            stock();
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
                    DateTime expiry_date=Convert.ToDateTime(dataGridView1.Rows[j].Cells["calexpirydate"].Value.ToString());
                    decimal paid_amount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["calpaidamount"].Value.ToString());
                    decimal remaining_amount = Convert.ToDecimal(dataGridView1.Rows[j].Cells["calremainingamount"].Value.ToString());

                    int k = blpur.createpurhase(category_id, product_id, quantity, Convert.ToInt32(txtinvoiceno.Text), price, discount, total,expiry_date,paid_amount,remaining_amount);


                }
                MessageBox.Show("Data has been save");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtpexpirydate.Format = DateTimePickerFormat.Short;
            dtpexpirydate.Value = DateTime.Today;
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

     
        private void damageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Purchase_Form pf = new Purchase_Form();
            DamageProduct dp = new DamageProduct();
           
            dp.Show();
           
          
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductAdd pa = new ProductAdd();
            pa.ShowDialog(this);
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.ShowDialog(this);
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchaseItem vpi = new ViewPurchaseItem();
            vpi.ShowDialog(this);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageProduct dp = new DamageProduct();
            dp.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.Show();
        }

        private void orderlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderlist od = new orderlist();
            od.Show();
        }

        private void txtinvoiceno_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpexpirydate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }


