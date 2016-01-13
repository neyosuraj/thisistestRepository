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
    public partial class UserControl_dameged_products : UserControl
    {
        public UserControl_dameged_products()
        {
            InitializeComponent();
        }
        BLLCategory blcat = new BLLCategory();
        BLLProduct blpro = new BLLProduct();
        BLLStock blst = new BLLStock();
        private void UserControl_dameged_products_Load(object sender, EventArgs e)
        {
            stockview();
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
            int parsedvalue;
            if (!int.TryParse(txtproduct.Text, out parsedvalue))
            {
                lblmsg.Text = ("price inputs are invalid. check again....");

            }
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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DamageExpiry ord = new DamageExpiry();
            ord.stock_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ord.lbldamagecategpry.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ord.lbldamageproduct.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ord.txtdamagequantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ord.lblexpirydate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ord.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
