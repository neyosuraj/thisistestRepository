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
    public partial class Viewrestaurant : UserControl
    {
        public Viewrestaurant()
        {
            InitializeComponent();
        }
        BLLOrder blod = new BLLOrder();
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (dtdsearchbydate.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                dt = blod.searchbydate(Convert.ToDateTime(dtdsearchbydate.Text));
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
