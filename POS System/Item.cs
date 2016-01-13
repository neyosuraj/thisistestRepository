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
    public partial class item : UserControl
    {
        public item()
        {
            InitializeComponent();
        }
        BLLOrder blod = new BLLOrder();

        public void items()
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
            int parsedvalue;
            if (!int.TryParse(txtitemprice.Text, out parsedvalue))
            {
                lblmsg.Text = ("price inputs are invalid. check again....");

            }
            else
            {
                int i = blod.additem(txtitemname.Text, Convert.ToDecimal(txtitemprice.Text));
                if (i > 0)
                {
                    MessageBox.Show("Product Has Been Added");
                }
            }
        }

        private void item_Load(object sender, EventArgs e)
        {
            items();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int parsedvalue;
            if (!int.TryParse(txtupdateprice.Text, out parsedvalue))
            {
                lblmsg.Text = ("price inputs are invalid. check again....");

            }
            else 
            {
                //int i =Convert.ToInt32( cboproduct.SelectedValue.ToString());

                int i = blod.updateitemprice(cboupdateitem.SelectedValue.ToString(), Convert.ToDecimal(txtupdateprice.Text));
                if (i > 0)
                {
                    MessageBox.Show("Price has been update");
                }

            }
        }
    }
}
