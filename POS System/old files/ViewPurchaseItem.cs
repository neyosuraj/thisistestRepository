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
    public partial class ViewPurchaseItem : Form
    {
        public ViewPurchaseItem()
        {
            InitializeComponent();
        }
        BLLPurchase blpur = new BLLPurchase();

        private void ViewPurchaseItem_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            DataTable dt = blpur.getallpurchase();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btncategorysearch_Click(object sender, EventArgs e)
        {
            if (txtcategory.Text.Length > 0)
            {
                DataTable dt = blpur.getpurchasebycategory(Convert.ToInt32(txtcategory.Text));
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    lblMsg.Text = "Cannot Find Category";


                }
            }
            else
            {
                LoadGrid();
                lblMsg.Visible = false;
            }
        }

        private void btnproductsearch_Click(object sender, EventArgs e)
        {
            if (txtproduct.Text.Length > 0)
            {
                DataTable dt = blpur.getpurchasebyproduct(Convert.ToInt32(txtproduct.Text));
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {

                    lblMsg.Text = "Cannot Find Product";


                }
            }
            else
            {
                LoadGrid();
                lblMsg.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

