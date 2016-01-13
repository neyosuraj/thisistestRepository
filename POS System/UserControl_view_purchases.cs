using BLLS;
using System;
using System.Data;
using System.Windows.Forms;
namespace POS_System
{
    public partial class UserControl_view_purchases : UserControl
    {
        public UserControl_view_purchases()
        {
            InitializeComponent();
        }

        BLLPurchase blpur = new BLLPurchase();
        BLLCategory blcat = new BLLCategory();

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

        private void UserControl_view_purchases_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
