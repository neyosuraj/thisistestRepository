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
    public partial class UserControl_view_damage : UserControl
    {
        public UserControl_view_damage()
        {
            InitializeComponent();
        }

        BLLDamage bldmg = new BLLDamage();

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bldmg.getdamageproductbyproductname(txtproduct.Text);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                lblmsg.Text=("Product Does Not Found");
            }
        }

        private void UserControl_view_damage_Load(object sender, EventArgs e)
        {

        }
        public void alldamage()
        {
            DataTable dt = new DataTable();
            dt = bldmg.getalldamageproduct();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }
    }
    }

