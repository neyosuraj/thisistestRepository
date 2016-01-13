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
    public partial class ViewStock : UserControl
    {
        public ViewStock()
        {
            InitializeComponent();
        }
        BLLStock blstk = new BLLStock();
        private void ViewStock_Load(object sender, EventArgs e)
        {
            viewstock();
        }
        public void viewstock()
        {
            DataTable dt = new DataTable();
            dt = blstk.getallstock();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtproduct.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                dt = blstk.checkquantityofproduct(txtproduct.Text);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Product Does Not Found");
                }

            }
            else
            {
                MessageBox.Show("Please Enter Text Box");
            }
        }
    }
}
