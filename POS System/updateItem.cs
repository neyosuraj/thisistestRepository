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
    public partial class updateItem : Form
    {
        public updateItem()
        {
            InitializeComponent();
        }
        BLLOrder blod = new BLLOrder();

        public void item()
        {
            DataTable dt = blod.getalldatafromitem();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr["item_name"] = "Choose One";
                dt.Rows.InsertAt(dr, 0);
                cboupdateitem.DataSource = dt;
                cboupdateitem.DisplayMember = "item_name";
                cboupdateitem.ValueMember = "item_id";
            }
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void updateItem_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int i = blod.deleteitem(txtdeleteitem.Text);
                if (i > 0)
                {
                    MessageBox.Show("Product has been delete");
                }


                else
                {
                    MessageBox.Show("Product is not found please input correct one");
                }
            }
        }
    }
}
